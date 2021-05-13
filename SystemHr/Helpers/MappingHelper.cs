using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHr.DataAccessLayer.Models;
using SystemHr.DataAccessLayer.ViweModels;

namespace SystemHr.UserInterface.Helpers
{
    public class MappingHelper
    {
        public static IList<EmployeeViewModel> MapEmployeeModelToEmployeeViewModel(IEnumerable<EmployeeModel> employeesModel)
        {

            IList<EmployeeViewModel> EmployeesViewModel = new List<EmployeeViewModel>();
            foreach (EmployeeModel employeeModel in employeesModel)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.Id = employeeModel.Id;
                employeeViewModel.LastName = employeeModel.LastName;
                employeeViewModel.FirstName = employeeModel.FirstName;
                employeeViewModel.Code = employeeModel.Code.ToString();
                employeeViewModel.Position = string.Empty;
                employeeViewModel.Status = employeeModel.Status.ToString();
                EmployeesViewModel.Add(employeeViewModel);
            }
            return EmployeesViewModel;
        }




        public static EmployeeViewModel MapEmployeeModelToEmployeeViewModel(EmployeeModel employeeModel)
        {

          
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.Id = employeeModel.Id;
                employeeViewModel.LastName = employeeModel.LastName;
                employeeViewModel.FirstName = employeeModel.FirstName;
                employeeViewModel.Code = employeeModel.Code.ToString();
                employeeViewModel.Position = string.Empty;
                employeeViewModel.Status = employeeModel.Status.ToString();
               
            
            return employeeViewModel;
        }

    }
}
