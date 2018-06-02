using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Reflector.IService
{
    public class ProcessDecorator : ProcessTemplate, IDecorate
	{
		public ProcessDecorator(IProcess process, Hashtable hashtable) : base(process, hashtable)
		{
		}

		public override void Run()
		{
			base.Run();
		}
    }
}
