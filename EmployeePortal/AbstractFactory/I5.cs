using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.AbstractFactory.Enumerations;

namespace EmployeePortal.AbstractFactory
{
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Processors.I5.ToString(); 
        }
    }
}