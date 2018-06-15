using log4net;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.MVC.View
{
    public class StudentView
    {
		private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public void ShowStudentDetails(string name, string rollNumber)
		{
			logger.Info("Student: ");
			logger.Info($"Name: {name}");
			logger.Info($"Roll Number: {rollNumber}");
		}
    }
}
