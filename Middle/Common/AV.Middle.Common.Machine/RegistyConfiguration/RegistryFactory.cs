using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace AV.Middle.Common.Machine.RegistyConfiguration
{
	public enum RegistryType
	{
		ClassesRoot = 1,
		CurrentUser = 2,
		HKLM = 3,
		Users = 4,
		CurrentConfig = 5
	}

	public class RegistryFactory
	{
		public static IRegistry GetRegistry(RegistryType registryType = RegistryType.HKLM)
		{
			switch (registryType)
			{
				case RegistryType.ClassesRoot:
					return new ClassesRootRegistry();

				case RegistryType.CurrentUser:
					return new CurrentUserRegistry();

				case RegistryType.HKLM:
					return new HKLMRegistry();

				case RegistryType.Users:
					return new UsersRegistry();

				case RegistryType.CurrentConfig:
					return new CurrentConfigRegistry();

				default:
					return new HKLMRegistry();
			}
		}

		internal static string GetRegistryValue(RegistryKey registryKey, string subkey, string key, out bool status)
		{
			var result = string.Empty;
			try
			{
				using (var rKey = registryKey.OpenSubKey(subkey))
				{
					if (rKey != null)
					{
						var obj = rKey.GetValue(key);
						if (obj != null)
						{
							result = obj as String;
						}
					}
				}
			}
			catch (Exception ex)
			{
				status = false;
				Debug.WriteLine(ex);
			}
			status = true;
			return result;
		}

		internal static bool SetRegistryValue(RegistryKey registryKey, string subKey, string key, string value)
		{
			bool status = false;
			try
			{
				using (var rKey = registryKey.OpenSubKey(subKey, true))
				{
					if (rKey != null)
					{
						rKey.SetValue(key, value);
					}
				}
				status = true;
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			return status;
		}
	}
}