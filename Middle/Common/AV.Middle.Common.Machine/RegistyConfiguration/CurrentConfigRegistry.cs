using Microsoft.Win32;

namespace AV.Middle.Common.Machine.RegistyConfiguration
{
	public class CurrentConfigRegistry : WindowsRegistry
	{
		internal override RegistryKey RegistryKey
		{
			get { return Registry.CurrentConfig; }
		}
	}
}