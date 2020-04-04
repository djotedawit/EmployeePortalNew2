using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.AbstractFactory
{
    public class MACFactory:IComputerFactory
    {
        public IBrand Brand()
        {
            return new Mac();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new DeskTop();
        }
    }
   
}