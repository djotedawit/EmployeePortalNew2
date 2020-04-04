using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.AbstractFactory.Enumerations;

namespace EmployeePortal.AbstractFactory
{
    public class DeskTop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}