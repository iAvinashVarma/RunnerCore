using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AV.Middle.Pattern.ShapePrototype.Abstract
{
	public abstract class Shape : ICloneable
	{
		private string id;

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		private string type;

		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		public abstract void Draw();

		public object Clone()
		{
			object clone = null;
			try
			{
				clone = base.MemberwiseClone();
			}
			catch (Exception ex)
			{
				Debug.WriteLine($"{ex}");
			}
			return clone;
		}
	}
}
