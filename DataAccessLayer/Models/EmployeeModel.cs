using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHr.DataAccessLayer.Models.Dictionaries;

namespace SystemHr.DataAccessLayer.Models
{
    public class EmployeeModel:EntityModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Code { get; set; }
        public GenderModel Gender { get; set; }
        public DateTime? DateBirth { get; set; }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string IdentityCardNumber { get; set; }
        public DateTime? IssueDateIdentityCard { get; set; }
        public DateTime? ExplorationDateIdentityCard { get; set; }

        public string PassportdNumber { get; set; }
        public DateTime? IssueDatePassport { get; set; }
        public DateTime? ExplorationDatePassport { get; set; }
        public StatusModel Status { get; set; }


    }
}
