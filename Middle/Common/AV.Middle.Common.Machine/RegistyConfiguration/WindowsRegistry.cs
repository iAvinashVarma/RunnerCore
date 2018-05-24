using AV.Middle.Common.Model;
using Microsoft.Win32;

namespace AV.Middle.Common.Machine.RegistyConfiguration
{
	public abstract class WindowsRegistry : IRegistry
	{
		internal abstract RegistryKey RegistryKey
		{
			get;
		}

		public virtual string GetValue(string subKey, string key)
		{
			return RegistryFactory.GetRegistryValue(RegistryKey, subKey, key, out bool status);
		}

		public virtual string GetValue(RegistryModel registryModel)
		{
			return TryGetValue(registryModel, out bool status);
		}

		public virtual bool SetValue(string subKey, string key, string value)
		{
			return RegistryFactory.SetRegistryValue(RegistryKey, subKey, key, value);
		}

		public virtual bool SetValue(RegistryModel registryModel)
		{
			return SetValue(registryModel.SubKey, registryModel.Key, registryModel.Value);
		}

		public string TryGetValue(RegistryModel registryModel, out bool status)
		{
			return RegistryFactory.GetRegistryValue(RegistryKey, registryModel.SubKey, registryModel.Key, out status);
		}
	}
}