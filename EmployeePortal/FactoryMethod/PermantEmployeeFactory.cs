using EmployeePortal.Manager;
using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.FactoryMethod
{
    public class PermantEmployeeFactory:BaseEmployeeFactory
    {
        
        public PermantEmployeeFactory(Employee emp) : base(emp)
        {

        }
           
        public override IEmployeeManager Create()
        {
             PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.MedicalAllowance = manager.GetHouseAllowance();
            return manager;
        }
    }


}