using System.Collections;

namespace AV.Middle.Reflector.IService
{
	public class ProcessTemplate
	{
		private IProcess _process;
		public ProcessTemplate(IProcess process)
		{
			_process = process;
		}

		public virtual void Run(Hashtable hashtable)
		{
			if (hashtable == null) return;
			_process.Hashtable = hashtable;
			if (_process.Validate())
			{
				_process.Start();
			}
		}
	}
}