using AV.Middle.Common.Configure;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AV.Service.WebAPI.Runner
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Log.Instance.Configure("log4net.config");
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();
	}
}