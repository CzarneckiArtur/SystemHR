using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHr.DataAccessLayer;
using SystemHr.DataAccessLayer.Models;
using SystemHr.DataAccessLayer.Models.Dictionaries;
using SystemHr.UserInterface.Classes;
using SystemHr.UserInterface.Extensions;
using SystemHr.UserInterface.Forms.Employees.Base;
using SystemHr.UserInterface.Helpers;

namespace SystemHr.UserInterface.Forms.Employees
{
    public partial class EmployeeEditForm : BaseAddEditForm
    {
        #region Fields
        private EmployeeModel employee;
        public EventHandler ReloadEmployees;
        #endregion
        #region Constructor
        public EmployeeEditForm(int employeeId)
        {
            
            InitializeComponent();
            InitializeData();
            employee = GlobalConfig.Connection.GetEmployee(employeeId);
            PreparedEmployeeData(employee);
            ValidateControls();
        }

        private void PreparedEmployeeData(EmployeeModel employee)
        {
            TxtLastName.Text = employee.LastName;
            TxtFirstName.Text = employee.FirstName;
            CbGender.Text = employee.Gender != null ? employee.Gender.Value : null;
            DtpDateBirth.SetDateTimePickerValue(employee.DateBirth);
            TxtPesel.Text = employee.Pesel;
            TxtPhoneNumber.Text = employee.PhoneNumber;
            TxtEmailAddress.Text = employee.EmailAddress;
            TxtIdentityCardNumber.Text = employee.IdentityCardNumber;
            DtpIssueDateIdentityCard.SetDateTimePickerValue(employee.IssueDateIdentityCard);
            DtpExplorationDateIdentityCard.SetDateTimePickerValue(employee.ExplorationDateIdentityCard);                       
            TxtPassportNumber.Text = employee.PassportdNumber;
            DtpIssueDatePassport.SetDateTimePickerValue(employee.IssueDatePassport);
            DtpExplorationDatePassport.SetDateTimePickerValue(employee.ExplorationDatePassport);

            LblEmployee.Text = $"{employee.FirstName} {employee.LastName} {employee.Code.ToString().PadLeft(4, '0')} - {employee.Status} ";
        }


        #endregion
        #region priv Methods
        private void ValidateControls()
        {
            if (string.IsNullOrEmpty(TxtLastName.Text))
            {
                epLastName.SetError(TxtLastName, "Pole Nazwisko jest wymagane");
            }
            else
            {
                epLastName.Clear();
            }

            if (string.IsNullOrEmpty(TxtFirstName.Text))
            {

                EpFirstName.SetError(TxtFirstName, "Pole Imię jest wymagane");
            }
            else
            {

                EpFirstName.Clear();
            }
            if (!string.IsNullOrWhiteSpace(TxtPesel.Text) && !ValidatorHelper.IsValidPESEL(TxtPesel.Text))
            {
                EpPesel.SetError(TxtPesel, "Niepoprawny numer pesel");

            }
            else
            {
                EpPesel.Clear();
            }
        }

        private void InitializeData()
        {
            IList<GenderModel> gender = new List<GenderModel>()
            {
                new GenderModel("Kobieta"),
                new GenderModel("Męzczyzna"),
                new GenderModel(String.Empty)
            };
            BsGender.DataSource = gender;
            CbGender.Text = string.Empty;
        }

        private void EmployeeAddForm_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateForm()
        {
            //modyfikowalny ciąg znaków, zlepia odpowiedni ciąg znamów
            StringBuilder sbErrorMessage = new StringBuilder();
            //dla nazwiska
            string LastNameErrorMessage = epLastName.GetError(TxtLastName);
            if (!string.IsNullOrEmpty(LastNameErrorMessage))
                sbErrorMessage.Append(LastNameErrorMessage);
            //dla imienia
            string FirstNameErrorMessage = EpFirstName.GetError(TxtFirstName);
            if (!string.IsNullOrEmpty(FirstNameErrorMessage))
                sbErrorMessage.Append(FirstNameErrorMessage);
            //brak wypełnienia

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show
                    (sbErrorMessage.ToString(),
                    "Dodawanie pracownika",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            string PeselWarningMessage = EpPesel.GetError(TxtPesel);
            if (!string.IsNullOrEmpty(PeselWarningMessage))
            {
                DialogResult answer = MessageBox.Show(
                    PeselWarningMessage + Environment.NewLine + "Czy napewno chcesz dodac pracownika?",
                    "Dodawanie pracownika",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                    return false;

            }
            return true;
        }



        private void TxtLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void TxtFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void TxtPesel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtPesel_Validating(object sender, CancelEventArgs e)
        {
            string pesel = TxtPesel.Text;
            if (!string.IsNullOrWhiteSpace(pesel) && !ValidatorHelper.IsValidPESEL(pesel))
            {
                EpPesel.SetError(TxtPesel, "Niepoprawny numer pesel");

            }
            else
            {
                EpPesel.Clear();
            }
        }    

        #endregion
        #region Events
        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();

        }
        protected override void Cancel()
        {
            MessageBox.Show("Anulowwano");
            Close();
        }

        private void Dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;
            dtp.DateTimePickerValueChanged();


        }


        #endregion
        #region Override
        protected override void Save()
        {
            if (ValidateForm())
            {


                employee.LastName = TxtLastName.Text;
                employee.FirstName = TxtFirstName.Text;
                employee.Gender = new GenderModel(CbGender.Text);
                employee.DateBirth = DtpDateBirth.Value;
                employee.Pesel = TxtPesel.Text;
                employee.PhoneNumber = TxtPhoneNumber.Text;
                employee.EmailAddress = TxtEmailAddress.Text;
                employee.IdentityCardNumber = TxtIdentityCardNumber.Text;
                employee.IssueDateIdentityCard = DtpIssueDateIdentityCard.Value;
                employee.ExplorationDateIdentityCard = DtpExplorationDateIdentityCard.Value;
                employee.PassportdNumber = TxtPassportNumber.Text;
                employee.IssueDatePassport = DtpIssueDatePassport.Value;
                employee.ExplorationDatePassport = DtpExplorationDatePassport.Value;
                  //modyfikacja w bazie danych
                  

                ReloadEmployees?.Invoke(BtnSave, new EmployeeEventArgs(employee));


                Close();
            }


        }
        #endregion
    }
}
