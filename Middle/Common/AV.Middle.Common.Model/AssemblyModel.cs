using System;

namespace AV.Middle.Common.Model
{
	public class AssemblyModel
	{
		private string title;

		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		private string description;

		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		private string company;

		public string Company
		{
			get { return company; }
			set { company = value; }
		}

		private string product;

		public string Product
		{
			get { return product; }
			set { product = value; }
		}

		private string copyright;

		public string Copyright
		{
			get { return copyright; }
			set { copyright = value; }
		}

		private string assemblyVersion;

		public string AssemblyVersion
		{
			get { return assemblyVersion; }
			set { assemblyVersion = value; }
		}

		private string fileVersion;

		public string FileVersion
		{
			get { return fileVersion; }
			set { fileVersion = value; }
		}

		private string assemblyPath;

		public string AssemblyPath
		{
			get { return assemblyPath; }
			set { assemblyPath = value; }
		}

		private string assemblyDirectory;

		public string AssemblyDirectory
		{
			get { return assemblyDirectory; }
			set { assemblyDirectory = value; }
		}

		private DateTime lastWriteTime;

		public DateTime LastWriteTime
		{
			get { return lastWriteTime; }
			set { lastWriteTime = value; }
		}

		private string role;

		public string Role
		{
			get { return role; }
			set { role = value; }
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string assembly;

		public string Assembly
		{
			get { return assembly; }
			set { assembly = value; }
		}

		private string typeName;

		public string TypeName
		{
			get { return typeName; }
			set { typeName = value; }
		}
	}
}