using System;

namespace AV.Middle.Common.CustomException
{
    public class ListNotFoundException : Exception
    {
		public ListNotFoundException()
		{

		}

		public ListNotFoundException(string message) : base(message)
		{

		}

		public ListNotFoundException(string message, Exception exception) : base(message, exception)
		{

		}
    }
}
