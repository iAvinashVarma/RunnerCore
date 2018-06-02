using System.Collections;

namespace AV.Middle.Reflector.IService
{
	public class ProcessTemplate : IDecorate
	{
		private IProcess _process;
		private Hashtable _hashtable;
		public ProcessTemplate(IProcess process, Hashtable hashtable)
		{
			_process = process;
			_hashtable = hashtable;
		}

		public virtual void Run()
		{
			if (_hashtable == null) return;
			_process.Hashtable = _hashtable;
			if (_process.Validate())
			{
				_process.Start();
			}
		}
	}
}