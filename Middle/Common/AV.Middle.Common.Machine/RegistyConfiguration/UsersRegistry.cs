using Microsoft.Win32;

namespace AV.Middle.Common.Machine.RegistyConfiguration
{
	public class UsersRegistry : WindowsRegistry
	{
		internal override RegistryKey RegistryKey
		{
			get { return Registry.Users; }
		}
	}
}