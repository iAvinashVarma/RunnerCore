using AV.Middle.Pattern.Behavioral.StatePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV.Middle.Pattern.Behavioral.StatePattern.Interface
{
    public interface IState
    {
		void DoAction(Context context);
    }
}
