using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHr.DataAccessLayer.Models;
using SystemHr.DataAccessLayer.Models.Dictionaries;
using SystemHr.UserInterface.Classes;
using SystemHr.UserInterface.Extensions;
using SystemHr.UserInterface.Forms.Employees.Base;
using SystemHr.UserInterface.Helpers;

namespace SystemHr.UserInterface.Forms.Employees
{
    public partial class EmployeeAddForm : BaseAddEditForm
    {
        #region Fields
        public EventHandler ReloadEmployees;
        #endregion
        #region Constructor
        public EmployeeAddForm()
        {
            InitializeComponent();
            InitializeData();
            ValidateControls();
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
                EmployeeModel employee = new EmployeeModel()
                {
                    LastName = TxtLastName.Text,
                    FirstName = TxtFirstName.Text,
                    Gender = new GenderModel(CbGender.Text),
                    DateBirth = DtpDateBirth.Value,
                    Pesel = TxtPesel.Text,
                    PhoneNumber = TxtPhoneNumber.Text,
                    EmailAddress = TxtEmailAddress.Text,
                    IdentityCardNumber = TxtIdentityCardNumber.Text,
                    IssueDateIdentityCard = DtpIssueDateIdentityCard.Value,
                    ExplorationDateIdentityCard = DtpExplorationDateIdentityCard.Value,
                    PassportdNumber = TxtPassportNumber.Text,
                    IssueDatePassport = DtpIssueDatePassport.Value,
                    ExplorationDatePassport = DtpExplorationDatePassport.Value,
                    Status = new StatusModel("Wprowadzony")

                };
                //  employee = CreateEmployee(employee);
                ReloadEmployees?.Invoke(BtnSave, new EmployeeEventArgs(employee));


                Close();
            }


        }
        #endregion
    }
}
