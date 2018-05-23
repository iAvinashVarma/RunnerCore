using System.Collections;

namespace AV.Middle.Reflector.IService
{
	public interface IPostProcess
	{
		Hashtable Hashtable
		{
			get; set;
		}

		bool PostValidate();

		void PostStart();
	}
}