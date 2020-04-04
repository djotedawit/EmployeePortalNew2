using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.AbstractFactory
{
    public class MACLapTopFactory: MACFactory
    {
        public override ISystemType SystemType()
        {
            return new LapTop();
        }
    }
}