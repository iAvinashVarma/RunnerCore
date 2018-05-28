using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Company.Model
{
    public class Employee
    {
		private string _name;
		private string _department;
		private double _salary;

		public Employee(string name, string department, double salary)
		{
			_name = name;
			_department = department;
			_salary = salary;
			employees = new List<Employee>();
		}

		private List<Employee> employees;

		public List<Employee> Employees
		{
			get { return employees; }
			set { employees = value; }
		}

		public void Add(Employee employee) => employees.Add(employee);

		public void Remove(Employee employee) => employees.Remove(employee);

		public override string ToString()
		{
			return $"Employee: [ Name: {_name}, Department: {_department}, Salary: {_salary} ]";
		}
	}
}
