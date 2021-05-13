using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemHr.DataAccessLayer.ViweModels
{
    public class EmployeeViewModel
    {
        private string lastName;
        private string firstName;
        private string code;
        public int Id { get; set; }
       
        public string LastName 
        { 
            get { return lastName.ToUpper(); }
            set { lastName = value; }
        }
        public string FirstName 
        {
            get { return firstName.ToUpper(); }
            set { firstName = value; }
        }
        public string Code 
        { 
            get { return code.PadLeft(4, '0'); }
            set { code = value; }
        }
        public string Position { get; set; }
        public string Status { get; set; }

    }
}
