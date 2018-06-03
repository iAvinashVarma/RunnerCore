using AV.Middle.Pattern.ChatRoom.Model;
using AV.Middle.Reflector.IService;
using log4net;
using System;
using System.Collections;
using System.Reflection;

namespace AV.Middle.Pattern.ChatRoom
{
	/// <summary>
	/// Behavioral design pattern: Mediator pattern is used to reduce communication complexity between multiple objects or classes. This pattern provides a mediator class which normally handles all the communications between different classes and supports easy maintenance of the code by loose coupling. Mediator pattern falls under behavioral pattern category.
	/// </summary>
	public class MediatorProcess : IProcess
    {
		public Hashtable Hashtable { get; set; }

		public void Start()
		{
			var userOne = new User("Avinash");
			var userTwo = new User("Pruthvi");
			userOne.SendMessage($"Hi! {userOne.Name}!");
			userTwo.SendMessage($"Hi! {userTwo.Name}!");
		}

		public bool Validate() => true;
	}
}
