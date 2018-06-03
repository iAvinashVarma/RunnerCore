using AV.Middle.Pattern.Behavioral.ChatRoom.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.ChatRoom.Model
{
    public class User
    {
		private string _name;

		public User(string name) => _name = name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public void SendMessage(string message) => new Room().ShowMessage(this, message);
	}
}
