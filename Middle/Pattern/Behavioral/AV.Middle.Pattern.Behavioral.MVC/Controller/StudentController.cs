using AV.Middle.Pattern.Behavioral.MVC.Model;
using AV.Middle.Pattern.Behavioral.MVC.View;
using System;

namespace AV.Middle.Pattern.Behavioral.MVC.Controller
{
	public class StudentController
	{
		private StudentModel _student;
		private StudentView _studentView;

		public StudentController(StudentModel student, StudentView studentView)
		{
			_student = student;
			_studentView = studentView;
		}

		public string GetStudentName()
		{
			return _student.Name;
		}

		public string GetRollNumber()
		{
			return _student.RollNumber;
		}

		public void SetStudentName(string name)
		{
			_student.Name = name;
		}

		public void SetRollNumber(string number)
		{
			_student.RollNumber = number;
		}

		public void UpdateView()
		{
			_studentView.ShowStudentDetails(_student.Name, _student.RollNumber);
		}
	}
}