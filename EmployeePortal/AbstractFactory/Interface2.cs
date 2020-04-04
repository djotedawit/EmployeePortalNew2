using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmployeePortal.AbstractFactory.Enumerations;

namespace EmployeePortal.AbstractFactory
{
   public class LapTop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }
}
