using AV.Middle.Common.Model;

namespace AV.Middle.Common.Machine.RegistyConfiguration
{
	public interface IRegistry
	{
		string GetValue(string subKey, string key);

		bool SetValue(string subKey, string key, string value);

		string GetValue(RegistryModel registryModel);

		bool SetValue(RegistryModel registryModel);

		string TryGetValue(RegistryModel registryModel, out bool status);
	}
}