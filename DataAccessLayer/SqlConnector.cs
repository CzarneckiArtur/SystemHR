using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHr.DataAccessLayer.Models;
using SystemHr.DataAccessLayer.Models.Dictionaries;

namespace SystemHr.DataAccessLayer
{
    public class SqlConnector : IDataConnection
    {
        IList<EmployeeModel> fakeSqlEmployeesModel = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    Id=1,
                    LastName= "andrzejewski",
                    FirstName= "Franek",
                    Code=1,
                    Gender= new GenderModel("mężczyzna"),
                    DateBirth= new DateTime(1990,4,11),
                    Pesel= "98989898989",
                    PhoneNumber= "454545454",
                    EmailAddress="fdsf@sdf.pl",
                    IdentityCardNumber= "AAA111111",
                    IssueDateIdentityCard= new DateTime(2022,2,4),
                    ExplorationDateIdentityCard= new DateTime(2026,5,4),
                    PassportdNumber="fdsr434r34rf3",
                    IssueDatePassport= new DateTime(2012,3,4),
                    ExplorationDatePassport= new DateTime(2025,4,4),
                    Status= new StatusModel("wprowadzony")

                },
                 new EmployeeModel()
                {
                    Id=2,
                    LastName= "Kozłowski",
                    FirstName= "Mariusz",
                    Code=2,
                    Gender= new GenderModel("mężczyzna"),
                    DateBirth= new DateTime(1990,4,11),
                    Pesel= "98989898989",
                    PhoneNumber= "454545454",
                    EmailAddress="fdsf@sdf.pl",
                    IdentityCardNumber= "AAA111111",
                    IssueDateIdentityCard= new DateTime(2022,2,4),
                    ExplorationDateIdentityCard= new DateTime(2026,5,4),
                    PassportdNumber="fdsr434r34rf3",
                    IssueDatePassport= new DateTime(2012,3,4),
                    ExplorationDatePassport= new DateTime(2025,4,4),
                    Status= new StatusModel("zatrudniony")
                },
                new EmployeeModel()
                {
                    Id=3,
                    LastName= "Borkowski",
                    FirstName= "Tomasz",
                    Code=3,
                    Gender= new GenderModel("mężczyzna"),
                    DateBirth= new DateTime(1990,4,11),
                    Pesel= "98989898989",
                    PhoneNumber= "454545454",
                    EmailAddress="fdsf@sdf.pl",
                    IdentityCardNumber= "AAA111111",
                    IssueDateIdentityCard= new DateTime(2022,2,4),
                    ExplorationDateIdentityCard= new DateTime(2026,5,4),
                    PassportdNumber="fdsr434r34rf3",
                    IssueDatePassport= new DateTime(2012,3,4),
                    ExplorationDatePassport= new DateTime(2025,4,4),
                    Status= new StatusModel("zatrudniony")
                },
                 new EmployeeModel()
                {
                    Id=4,
                    LastName= "Głuchowska",
                    FirstName= "Aleksandra",
                    Code=4,
                    Gender= new GenderModel("kobieta"),
                    DateBirth= new DateTime(1990,4,11),
                    Pesel= "98989898989",
                    PhoneNumber= "454545454",
                    EmailAddress="fdsf@sdf.pl",
                    IdentityCardNumber= "AAA111111",
                    IssueDateIdentityCard= new DateTime(2022,2,4),
                    ExplorationDateIdentityCard= new DateTime(2026,5,4),
                    PassportdNumber="fdsr434r34rf3",
                    IssueDatePassport= new DateTime(2012,3,4),
                    ExplorationDatePassport= new DateTime(2025,4,4),
                    Status= new StatusModel("zatrudniony")
                }

            };
        public IEnumerable<EmployeeModel> GetEmployees()
        {
            return fakeSqlEmployeesModel;
        }
        public EmployeeModel GetEmployee(int id)
        {
            return fakeSqlEmployeesModel.Single(x => x.Id == id);
        }
        public EmployeeModel ModifyEmployee(EmployeeModel model)
        {
            return model;
        }
        public void RemoveEmployee(int id)
        {
            
        }
        public EmployeeModel CreateEmployee(EmployeeModel model)
        {
            return model;
        }


    }
}
