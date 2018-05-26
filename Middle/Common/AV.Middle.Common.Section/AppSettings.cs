using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;

namespace AV.Middle.Common.Section
{
	public class AppSettings
	{
		private IConfiguration Configuration { get; set; }

		public List<Add> PreRunnerList
		{
			get
			{
				return GetRunnerSection().PreRunner?.Add;
			}
		}

		public List<Add> RunnerList
		{
			get
			{
				return GetRunnerSection().Runner?.Add;
			}
		}

		public List<Add> PostRunnerList
		{
			get
			{
				return GetRunnerSection().PostRunner?.Add;
			}
		}

		private RunnerSection GetRunnerSection()
		{
			var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(path: "appsettings.json", optional: false, reloadOnChange: true);
			var config = builder.Build();
			var runner = new RunnerSection();
			config.GetSection("runnerSection").Bind(runner);
			return runner;
		}
	}
}