using EmployeePortal.AbstractFactory;
using EmployeePortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeePortal.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory  Create(Employee e)
        {
            IComputerFactory returnValue = null;
            if (e.EmployeeTypeId == 1)
            {
                if (e.Job_Description == "Manager")
                {
                    returnValue= new MACLapTopFactory();
                }
                else
                {
                    returnValue = new MACFactory();
                }
            }
            else if (e.EmployeeTypeId == 2)
            {
                if (e.Job_Description == "Manager")
                {
                    returnValue = new DellLapTopFactory();
                }
                else
                    returnValue = new DellFactory();
            }
            return returnValue;
        }
        

    }
}