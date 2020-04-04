using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.AbstractFactory
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Enumerations.Brands.DELL.ToString(); 
        }
    }
}