using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace AV.Middle.Common.Reflection
{
	/// <summary>
	/// Represents Assembly Factory.
	/// </summary>
	public class AssemblyFactory
	{
		public static T GetClass<T>(string className, string returnType)
		{
			return (T)Activator.CreateInstance(Type.GetType(Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name.EndsWith(className)).FirstOrDefault().FullName), new object[] { returnType });
		}

		public static T GetReturnClass<T>(string className)
		{
			return (T)Assembly.Load(Assembly.GetExecutingAssembly().FullName).CreateInstance(Assembly.GetExecutingAssembly().GetTypes().Where(t => t.Name.EndsWith(className)).FirstOrDefault().FullName);
		}

		public static T LoadAssembly<T>(string assemblyInfo)
		{
			try
			{
				if (assemblyInfo.IndexOf(',') != -1)
				{
					return LoadAssembly<T>(assemblyInfo.Split(',')[1], assemblyInfo.Split(',')[0]);
				}
				else
				{
					return LoadAssembly<T>(assemblyInfo.Substring(0, assemblyInfo.LastIndexOf('.')), assemblyInfo);
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			return default(T);
		}

		public static T LoadAssembly<T>(string assemblyName, string typeName)
		{
			var currentFolder = $"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}";
			var assembly = Assembly.LoadFrom(Path.Combine(currentFolder, $"{assemblyName}.dll"));
			return GetInstance<T>(assembly, typeName);
		}

		public static T GetInstance<T>(Assembly assembly, string typeName)
		{
			var type = assembly.GetType(typeName, false, true);
			if (null != type.GetInterface(typeof(T).FullName))
			{
				var da = (T)Activator.CreateInstance(type);
				return da;
			}
			return default(T);
		}
	}
}