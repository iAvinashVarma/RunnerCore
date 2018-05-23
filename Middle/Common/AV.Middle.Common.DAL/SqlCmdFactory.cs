using AV.Middle.Common.Terminal;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AV.Middle.Common.DAL
{
	public class SqlCmdFactory
	{
		private static readonly TaskCompletionSource<string> conString = new TaskCompletionSource<string>();
		private static readonly TaskCompletionSource<SqlConnectionStringBuilder> connectionStringBuilder = new TaskCompletionSource<SqlConnectionStringBuilder>();
		private static ICommandService commandService;

		public static ICommandService GetFileService(string connectionString, string fileName)
		{
			return GetFileService(
			connectionBuilder: new SqlConnectionStringBuilder
			{
				ConnectionString = connectionString
			},
			fileName: fileName);
		}

		public static ICommandService GetFileService(SqlConnectionStringBuilder connectionBuilder, string fileName)
		{
			if (connectionStringBuilder.TrySetResult(connectionBuilder))
			{
				var arguments = $"-b -S {connectionBuilder.DataSource} -d {connectionBuilder.InitialCatalog}";
				var result = !string.IsNullOrEmpty(connectionBuilder.UserID) && !string.IsNullOrEmpty(connectionBuilder.Password) ? $"{arguments} -U {connectionBuilder.UserID} -P {connectionBuilder.Password} -i {fileName}" : $"{arguments} -E -i {fileName}";
				commandService = new SqlCmd(result);
			}
			else if (connectionStringBuilder.Task.Result != connectionBuilder)
			{
				throw new InvalidOperationException("Invalid Connection string.");
			}
			return commandService;
		}
	}
}
;