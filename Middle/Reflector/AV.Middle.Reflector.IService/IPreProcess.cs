using System.Collections;

namespace AV.Middle.Reflector.IService
{
	public interface IPreProcess
	{
		Hashtable Hashtable
		{
			get; set;
		}

		bool PreValidate();

		void PreStart();
	}
}