using AV.Middle.Common.Logger.Validator;
using AV.Middle.Common.Machine.RegistyConfiguration;
using AV.Middle.Common.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace AV.Middle.Reflector.RegistryController
{
	public class UpdateRegistry : IProcess
	{
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		private IEnumerable<RegistryModel> registryModels = null;

		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var registry = RegistryFactory.GetRegistry();
			foreach (var reg in registryModels)
			{
				var registryValue = registry.GetValue(reg);
				if(string.IsNullOrEmpty(registryValue))
				{
					logger.Info($"Unable to get \"{reg.SubKey}\\{reg.Key}\".");
					continue;
				}
				logger.Info($"Found \"{reg.SubKey}\\{reg.Key}\": \"{registryValue}\"");
				if (registry.SetValue(reg))
				{
					registryValue = registry.GetValue(reg);
					logger.Info($"Updated \"{reg.SubKey}\\{reg.Key}\": \"{registryValue}\"");
				}
				else
				{
					logger.Warn("Unable to update, make sure the registry is available and you are running the process in admin mode.");
				}
			}
		}

		public bool Validate()
		{
			bool status = false;
			try
			{
				var subKey = EnhanceLog.Set(Hashtable, "SubKeys");
				var key = EnhanceLog.Set(Hashtable, "Key");
				var value = EnhanceLog.Set(Hashtable, "Value", false, string.Empty);
				registryModels = subKey.Split(',').Select(r => new RegistryModel { SubKey = r, Key = key, Value = value });
				status = true;
			}
			catch (Exception ex)
			{
				logger.Error(ex);
			}
			return status;
		}
	}
}