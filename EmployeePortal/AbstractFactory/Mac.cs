using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static EmployeePortal.AbstractFactory.Enumerations;

namespace EmployeePortal.AbstractFactory
{
    public class Mac : IBrand
    {
        public string GetBrand()
        {
            return Brands.APPLE.ToString();
        }
    }
}