using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHr.DataAccessLayer;
using SystemHr.DataAccessLayer.Models;
using SystemHr.DataAccessLayer.Models.Dictionaries;
using SystemHr.DataAccessLayer.ViweModels;
using SystemHr.UserInterface.Classes;
using SystemHr.UserInterface.Forms.Employees.Base;
using SystemHr.UserInterface.Helpers;

namespace SystemHr.UserInterface.Forms.Employees
{
    public partial class EmployeesForm : BaseForm
    {
        #region Fields
        //singleton
        private static EmployeesForm _instance = null;
        private static IList<EmployeeViewModel> fakeEmployee;
        #endregion
        #region Properties
        public static EmployeesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EmployeesForm();
                }
                return _instance;
            }
        }
        //sprawdza czy instance jest null (potrzebne do otwierania karty)
        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;

            }
        }
        #endregion
        #region Constructor
        private EmployeesForm()
        {

            InitializeComponent();

            IEnumerable<EmployeeModel> employees = GlobalConfig.Connection.GetEmployees();

            fakeEmployee = MappingHelper.MapEmployeeModelToEmployeeViewModel(employees);
            PrepareEmployeesData();
        }
        #endregion
        #region Priv Methods
        private void PrepareEmployeesData()
        {
            var fakeEmployeesSorted = fakeEmployee.OrderBy(x => x.Code).ToList();
            BsEmployees.DataSource = new BindingList<EmployeeViewModel>(fakeEmployeesSorted);
            DgvEmployees.DataSource = BsEmployees;
        }
        #endregion
        #region Events
        private void EmployeesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Umożliwia ponowne otwarcie formularza
            _instance = null;
        }

        private void TlpEmployees_Paint(object sender, PaintEventArgs e)
        {

        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            EmployeeAddForm form = new EmployeeAddForm();
            form.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                if (eventArgs != null)
                {
                    //przeciązenie funkcji
                    EmployeeViewModel employee = MappingHelper.MapEmployeeModelToEmployeeViewModel(eventArgs.Employee);
                    BsEmployees.Add(employee);
                    DgvEmployees.ClearSelection();
                    DgvEmployees.Rows[DgvEmployees.Rows.Count -1].Selected = true;
                }
            };
            form.ShowDialog();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(DgvEmployees.CurrentRow.Cells["colId"].Value);
            int SelectedRowIndex = DgvEmployees.CurrentRow.Index;
            EmployeeEditForm form = new EmployeeEditForm(employeeId);
            form.ReloadEmployees += (s, ea) =>
            {
                EmployeeEventArgs eventArgs = ea as EmployeeEventArgs;
                if (eventArgs != null)
                {
                    //przeciązenie funkcji
                    EmployeeViewModel employee = MappingHelper.MapEmployeeModelToEmployeeViewModel(eventArgs.Employee);
                    BsEmployees[SelectedRowIndex] = employee;
                }
            };
            form.ShowDialog();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            int employeeId = Convert.ToInt32(DgvEmployees.CurrentRow.Cells["colId"].Value);
            int SelectedRowIndex = DgvEmployees.CurrentRow.Index;
            EmployeeViewModel employee = fakeEmployee.Where(x => x.Id == employeeId).FirstOrDefault();
            if (employee != null)
            {
                BsEmployees.Remove(employee);
                if (DgvEmployees.Rows.Count > 1)
                {
                    DgvEmployees.ClearSelection();
                    DgvEmployees.Rows[DgvEmployees.Rows.Count - 1].Selected = true;
                }
            }
        }
        #endregion


    }
    
}
