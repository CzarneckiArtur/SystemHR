using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHr.DataAccessLayer.Models;

namespace SystemHr.UserInterface.Classes
{
    public class EmployeeEventArgs : EventArgs
    {
        public EmployeeModel Employee { private set; get; }
        public EmployeeEventArgs(EmployeeModel employee)
        {
            this.Employee = employee;
        }
    }
}
