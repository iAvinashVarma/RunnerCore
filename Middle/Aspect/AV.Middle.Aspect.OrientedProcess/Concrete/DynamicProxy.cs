using AV.Middle.Aspect.OrientedProcess.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AV.Middle.Aspect.OrientedProcess.Concrete
{
	public class DynamicProxy<T> : DispatchProxy
	{
		private T _decorated;
		private Action<string> _logInfo;
		private Action<string> _logError;
		private Func<object, string> _serializeFunction;
		private TaskScheduler _loggingScheduler;

		public DynamicProxy()
		{

		}

		protected override object Invoke(MethodInfo targetMethod, object[] args)
		{
			if (targetMethod != null)
			{
				try
				{
					try
					{
						LogBefore(targetMethod);
					}
					catch (Exception ex)
					{
						//Do not stop method execution if exception
						LogException(ex);
					}

					var result = targetMethod.Invoke(_decorated, args);

					if (result is Task resultTask)
					{
						resultTask.ContinueWith(task =>
						{
							if (task.Exception != null)
							{
								LogException(task.Exception.InnerException ?? task.Exception, targetMethod);
							}
							else
							{
								object taskResult = null;
								if (task.GetType().GetTypeInfo().IsGenericType && task.GetType().GetGenericTypeDefinition() == typeof(Task<>))
								{
									var property = task.GetType().GetTypeInfo().GetProperties().FirstOrDefault(p => p.Name == "Result");
									if (property != null)
									{
										taskResult = property.GetValue(task);
									}
								}

								LogAfter(targetMethod, args, taskResult);
							}
						},
							_loggingScheduler);
					}
					else
					{
						try
						{
							LogAfter(targetMethod);
						}
						catch (Exception ex)
						{
							//Do not stop method execution if exception
							LogException(ex);
						}
					}
					return result;
				}
				catch (Exception ex)
				{
					if (ex is TargetInvocationException)
					{
						LogException(ex.InnerException ?? ex, targetMethod);
						throw ex.InnerException ?? ex;
					}
				}
			}
			throw new ArgumentException(nameof(targetMethod));
		}

		public T Create(T decorated, Action<string> logInfo, Action<string> logError,
			Func<object, string> serializeFunction, TaskScheduler loggingScheduler = null)
		{
			object proxy = Create<T, DynamicProxy<T>>();
			((DynamicProxy<T>)proxy).SetParameters(decorated, logInfo, logError, serializeFunction, loggingScheduler);
			return (T)proxy;
		}

		private void SetParameters(T decorated, Action<string> logInfo, Action<string> logError,
			Func<object, string> serializeFunction, TaskScheduler loggingScheduler)
		{
			_decorated = decorated;
			_logInfo = logInfo;
			_logError = logError;
			_serializeFunction = serializeFunction;
			_loggingScheduler = loggingScheduler ?? TaskScheduler.Default;
		}

		private string GetStringValue(object obj)
		{
			if (obj == null)
			{
				return "null";
			}

			if (obj.GetType().GetTypeInfo().IsPrimitive || obj.GetType().GetTypeInfo().IsEnum || obj is string)
			{
				return obj.ToString();
			}

			try
			{
				return _serializeFunction?.Invoke(obj) ?? obj.ToString();
			}
			catch
			{
				return obj.ToString();
			}
		}

		private void LogException(Exception exception, MethodInfo methodInfo = null)
		{
			try
			{
				var errorMessage = new StringBuilder();
				errorMessage.AppendLine($"Class {_decorated.GetType().FullName}");
				errorMessage.AppendLine($"Method {methodInfo?.Name} threw exception");
				errorMessage.AppendLine(exception.GetDescription());
				_logError?.Invoke(errorMessage.ToString());
			}
			catch (Exception)
			{
				// ignored
				//Method should return original exception
			}
		}

		private void LogAfter(MethodInfo methodInfo) => _logInfo?.Invoke($"After Method {methodInfo.Name} executed.");

		private void LogAfter(MethodInfo methodInfo, object[] args, object result)
		{
			var afterMessage = new StringBuilder();
			afterMessage.AppendLine($"After Class {_decorated.GetType().FullName}");
			afterMessage.AppendLine($"Method {methodInfo.Name} executed");
			afterMessage.AppendLine("Output:");
			afterMessage.AppendLine(GetStringValue(result));
			var parameters = methodInfo.GetParameters();
			if (parameters.Any())
			{
				afterMessage.AppendLine("Parameters:");
				for (var i = 0; i < parameters.Length; i++)
				{
					var parameter = parameters[i];
					var arg = args[i];
					afterMessage.AppendLine($"{parameter.Name}:{GetStringValue(arg)}");
				}
			}

			_logInfo?.Invoke(afterMessage.ToString());
		}

		private void LogBefore(MethodInfo methodInfo) => _logInfo?.Invoke($"Before Method {methodInfo.Name} executing.");

		private void LogBefore(MethodInfo methodInfo, object[] args)
		{
			var beforeMessage = new StringBuilder();
			beforeMessage.AppendLine($"Class {_decorated.GetType().FullName}");
			beforeMessage.AppendLine($"Method {methodInfo.Name} executing");
			var parameters = methodInfo.GetParameters();
			if (parameters.Any())
			{
				beforeMessage.AppendLine("Parameters:");
				for (var i = 0; i < parameters.Length; i++)
				{
					var parameter = parameters[i];
					var arg = args[i];
					beforeMessage.AppendLine($"{parameter.Name}:{GetStringValue(arg)}");
				}
			}
			_logInfo?.Invoke(beforeMessage.ToString());
		}
	}
}
