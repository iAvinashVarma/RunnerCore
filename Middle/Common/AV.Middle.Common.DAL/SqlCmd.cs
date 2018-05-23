using AV.Middle.Common.Model;
using AV.Middle.Common.Terminal;

namespace AV.Middle.Common.DAL
{
	public class SqlCmd : CommandService
	{
		private string Arguments;

		public SqlCmd(string arguments)
		{
			Arguments = arguments;
		}

		public override ExecuteModel ExecuteCommand()
		{
			return base.ExecuteCommand("sqlcmd", Arguments);
		}
	}
}