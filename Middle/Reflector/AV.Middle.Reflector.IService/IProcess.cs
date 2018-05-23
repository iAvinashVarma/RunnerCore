using System.Collections;

namespace AV.Middle.Reflector.IService
{
	public interface IProcess
	{
		Hashtable Hashtable
		{
			get; set;
		}

		bool Validate();

		void Start();
	}
}