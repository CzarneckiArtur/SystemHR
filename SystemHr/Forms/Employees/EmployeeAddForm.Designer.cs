namespace SystemHr.UserInterface.Forms.Employees
{
    partial class EmployeeAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LblEmployee = new System.Windows.Forms.Label();
            this.GbGeneral = new System.Windows.Forms.GroupBox();
            this.TxtPesel = new System.Windows.Forms.TextBox();
            this.LblPesel = new System.Windows.Forms.Label();
            this.DtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.laLblDateBirthbel1 = new System.Windows.Forms.Label();
            this.CbGender = new System.Windows.Forms.ComboBox();
            this.BsGender = new System.Windows.Forms.BindingSource(this.components);
            this.LblGender = new System.Windows.Forms.Label();
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.LblFirstName = new System.Windows.Forms.Label();
            this.LblLastName = new System.Windows.Forms.Label();
            this.GbContact = new System.Windows.Forms.GroupBox();
            this.TxtEmailAddress = new System.Windows.Forms.TextBox();
            this.LblEmailAddress = new System.Windows.Forms.Label();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.LblPhoneNumber = new System.Windows.Forms.Label();
            this.GbIdentityCard = new System.Windows.Forms.GroupBox();
            this.DtpExplorationDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.label1LblExplorationDateIdentityCard = new System.Windows.Forms.Label();
            this.DtpIssueDateIdentityCard = new System.Windows.Forms.DateTimePicker();
            this.LblIssueDateIdentityCard = new System.Windows.Forms.Label();
            this.TxtIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.LblIdentityCardNumber = new System.Windows.Forms.Label();
            this.Passport = new System.Windows.Forms.GroupBox();
            this.DtpExplorationDatePassport = new System.Windows.Forms.DateTimePicker();
            this.LblExplorationDatePassport = new System.Windows.Forms.Label();
            this.DtpIssueDatePassport = new System.Windows.Forms.DateTimePicker();
            this.LblIssueDatePassport = new System.Windows.Forms.Label();
            this.TxtPassportNumber = new System.Windows.Forms.TextBox();
            this.LblPassportNumber = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.EpFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.EpPesel = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsGender)).BeginInit();
            this.GbContact.SuspendLayout();
            this.GbIdentityCard.SuspendLayout();
            this.Passport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpPesel)).BeginInit();
            this.SuspendLayout();
            // 
            // LblEmployee
            // 
            this.LblEmployee.AutoSize = true;
            this.LblEmployee.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblEmployee.Location = new System.Drawing.Point(319, 34);
            this.LblEmployee.Name = "LblEmployee";
            this.LblEmployee.Size = new System.Drawing.Size(227, 29);
            this.LblEmployee.TabIndex = 0;
            this.LblEmployee.Text = "Dane Identyfikacyjne";
            // 
            // GbGeneral
            // 
            this.GbGeneral.Controls.Add(this.TxtPesel);
            this.GbGeneral.Controls.Add(this.LblPesel);
            this.GbGeneral.Controls.Add(this.DtpDateBirth);
            this.GbGeneral.Controls.Add(this.laLblDateBirthbel1);
            this.GbGeneral.Controls.Add(this.CbGender);
            this.GbGeneral.Controls.Add(this.LblGender);
            this.GbGeneral.Controls.Add(this.TxtFirstName);
            this.GbGeneral.Controls.Add(this.TxtLastName);
            this.GbGeneral.Controls.Add(this.LblFirstName);
            this.GbGeneral.Controls.Add(this.LblLastName);
            this.GbGeneral.Location = new System.Drawing.Point(27, 111);
            this.GbGeneral.Name = "GbGeneral";
            this.GbGeneral.Size = new System.Drawing.Size(387, 222);
            this.GbGeneral.TabIndex = 1;
            this.GbGeneral.TabStop = false;
            this.GbGeneral.Text = "Ogólne";
            // 
            // TxtPesel
            // 
            this.TxtPesel.Location = new System.Drawing.Point(137, 172);
            this.TxtPesel.Name = "TxtPesel";
            this.TxtPesel.Size = new System.Drawing.Size(215, 20);
            this.TxtPesel.TabIndex = 9;
            this.TxtPesel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPesel_KeyPress);
            this.TxtPesel.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPesel_Validating);
            // 
            // LblPesel
            // 
            this.LblPesel.AutoSize = true;
            this.LblPesel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPesel.Location = new System.Drawing.Point(7, 169);
            this.LblPesel.Name = "LblPesel";
            this.LblPesel.Size = new System.Drawing.Size(49, 23);
            this.LblPesel.TabIndex = 8;
            this.LblPesel.Text = "Pesel";
            // 
            // DtpDateBirth
            // 
            this.DtpDateBirth.CustomFormat = " ";
            this.DtpDateBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpDateBirth.Location = new System.Drawing.Point(137, 129);
            this.DtpDateBirth.Name = "DtpDateBirth";
            this.DtpDateBirth.Size = new System.Drawing.Size(215, 20);
            this.DtpDateBirth.TabIndex = 7;
            this.DtpDateBirth.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // laLblDateBirthbel1
            // 
            this.laLblDateBirthbel1.AutoSize = true;
            this.laLblDateBirthbel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.laLblDateBirthbel1.Location = new System.Drawing.Point(7, 128);
            this.laLblDateBirthbel1.Name = "laLblDateBirthbel1";
            this.laLblDateBirthbel1.Size = new System.Drawing.Size(127, 23);
            this.laLblDateBirthbel1.TabIndex = 6;
            this.laLblDateBirthbel1.Text = "Data urodzenia";
            // 
            // CbGender
            // 
            this.CbGender.DataSource = this.BsGender;
            this.CbGender.DisplayMember = "Value";
            this.CbGender.FormattingEnabled = true;
            this.CbGender.Location = new System.Drawing.Point(137, 96);
            this.CbGender.Name = "CbGender";
            this.CbGender.Size = new System.Drawing.Size(215, 21);
            this.CbGender.TabIndex = 5;
            this.CbGender.ValueMember = "Id";
            // 
            // BsGender
            // 
            this.BsGender.DataSource = typeof(SystemHr.DataAccessLayer.Models.Dictionaries.GenderModel);
            // 
            // LblGender
            // 
            this.LblGender.AutoSize = true;
            this.LblGender.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblGender.Location = new System.Drawing.Point(7, 94);
            this.LblGender.Name = "LblGender";
            this.LblGender.Size = new System.Drawing.Size(42, 23);
            this.LblGender.TabIndex = 4;
            this.LblGender.Text = "Płeć";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(137, 55);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(215, 20);
            this.TxtFirstName.TabIndex = 3;
            this.TxtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(137, 23);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(215, 20);
            this.TxtLastName.TabIndex = 2;
            this.TxtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
            // 
            // LblFirstName
            // 
            this.LblFirstName.AutoSize = true;
            this.LblFirstName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblFirstName.Location = new System.Drawing.Point(7, 55);
            this.LblFirstName.Name = "LblFirstName";
            this.LblFirstName.Size = new System.Drawing.Size(44, 23);
            this.LblFirstName.TabIndex = 1;
            this.LblFirstName.Text = "Imię";
            // 
            // LblLastName
            // 
            this.LblLastName.AutoSize = true;
            this.LblLastName.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblLastName.Location = new System.Drawing.Point(7, 20);
            this.LblLastName.Name = "LblLastName";
            this.LblLastName.Size = new System.Drawing.Size(81, 23);
            this.LblLastName.TabIndex = 0;
            this.LblLastName.Text = "Nazwisko";
            // 
            // GbContact
            // 
            this.GbContact.Controls.Add(this.TxtEmailAddress);
            this.GbContact.Controls.Add(this.LblEmailAddress);
            this.GbContact.Controls.Add(this.TxtPhoneNumber);
            this.GbContact.Controls.Add(this.LblPhoneNumber);
            this.GbContact.Location = new System.Drawing.Point(27, 340);
            this.GbContact.Name = "GbContact";
            this.GbContact.Size = new System.Drawing.Size(387, 163);
            this.GbContact.TabIndex = 2;
            this.GbContact.TabStop = false;
            this.GbContact.Text = "Kontakt";
            // 
            // TxtEmailAddress
            // 
            this.TxtEmailAddress.Location = new System.Drawing.Point(137, 78);
            this.TxtEmailAddress.Name = "TxtEmailAddress";
            this.TxtEmailAddress.Size = new System.Drawing.Size(215, 20);
            this.TxtEmailAddress.TabIndex = 12;
            // 
            // LblEmailAddress
            // 
            this.LblEmailAddress.AutoSize = true;
            this.LblEmailAddress.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblEmailAddress.Location = new System.Drawing.Point(7, 75);
            this.LblEmailAddress.Name = "LblEmailAddress";
            this.LblEmailAddress.Size = new System.Drawing.Size(101, 23);
            this.LblEmailAddress.TabIndex = 11;
            this.LblEmailAddress.Text = "Adres email";
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(137, 35);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(215, 20);
            this.TxtPhoneNumber.TabIndex = 10;
            // 
            // LblPhoneNumber
            // 
            this.LblPhoneNumber.AutoSize = true;
            this.LblPhoneNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPhoneNumber.Location = new System.Drawing.Point(7, 32);
            this.LblPhoneNumber.Name = "LblPhoneNumber";
            this.LblPhoneNumber.Size = new System.Drawing.Size(132, 23);
            this.LblPhoneNumber.TabIndex = 9;
            this.LblPhoneNumber.Text = "Numer Telefonu";
            // 
            // GbIdentityCard
            // 
            this.GbIdentityCard.Controls.Add(this.DtpExplorationDateIdentityCard);
            this.GbIdentityCard.Controls.Add(this.label1LblExplorationDateIdentityCard);
            this.GbIdentityCard.Controls.Add(this.DtpIssueDateIdentityCard);
            this.GbIdentityCard.Controls.Add(this.LblIssueDateIdentityCard);
            this.GbIdentityCard.Controls.Add(this.TxtIdentityCardNumber);
            this.GbIdentityCard.Controls.Add(this.LblIdentityCardNumber);
            this.GbIdentityCard.Location = new System.Drawing.Point(446, 111);
            this.GbIdentityCard.Name = "GbIdentityCard";
            this.GbIdentityCard.Size = new System.Drawing.Size(386, 139);
            this.GbIdentityCard.TabIndex = 3;
            this.GbIdentityCard.TabStop = false;
            this.GbIdentityCard.Text = "Dowód osobisty";
            // 
            // DtpExplorationDateIdentityCard
            // 
            this.DtpExplorationDateIdentityCard.CustomFormat = " ";
            this.DtpExplorationDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpExplorationDateIdentityCard.Location = new System.Drawing.Point(136, 97);
            this.DtpExplorationDateIdentityCard.Name = "DtpExplorationDateIdentityCard";
            this.DtpExplorationDateIdentityCard.Size = new System.Drawing.Size(214, 20);
            this.DtpExplorationDateIdentityCard.TabIndex = 13;
            this.DtpExplorationDateIdentityCard.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // label1LblExplorationDateIdentityCard
            // 
            this.label1LblExplorationDateIdentityCard.AutoSize = true;
            this.label1LblExplorationDateIdentityCard.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1LblExplorationDateIdentityCard.Location = new System.Drawing.Point(6, 94);
            this.label1LblExplorationDateIdentityCard.Name = "label1LblExplorationDateIdentityCard";
            this.label1LblExplorationDateIdentityCard.Size = new System.Drawing.Size(120, 23);
            this.label1LblExplorationDateIdentityCard.TabIndex = 12;
            this.label1LblExplorationDateIdentityCard.Text = "Data ważności";
            // 
            // DtpIssueDateIdentityCard
            // 
            this.DtpIssueDateIdentityCard.CustomFormat = " ";
            this.DtpIssueDateIdentityCard.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpIssueDateIdentityCard.Location = new System.Drawing.Point(136, 58);
            this.DtpIssueDateIdentityCard.Name = "DtpIssueDateIdentityCard";
            this.DtpIssueDateIdentityCard.Size = new System.Drawing.Size(214, 20);
            this.DtpIssueDateIdentityCard.TabIndex = 10;
            this.DtpIssueDateIdentityCard.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // LblIssueDateIdentityCard
            // 
            this.LblIssueDateIdentityCard.AutoSize = true;
            this.LblIssueDateIdentityCard.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblIssueDateIdentityCard.Location = new System.Drawing.Point(6, 58);
            this.LblIssueDateIdentityCard.Name = "LblIssueDateIdentityCard";
            this.LblIssueDateIdentityCard.Size = new System.Drawing.Size(114, 23);
            this.LblIssueDateIdentityCard.TabIndex = 11;
            this.LblIssueDateIdentityCard.Text = "Data wydania";
            // 
            // TxtIdentityCardNumber
            // 
            this.TxtIdentityCardNumber.Location = new System.Drawing.Point(136, 26);
            this.TxtIdentityCardNumber.Name = "TxtIdentityCardNumber";
            this.TxtIdentityCardNumber.Size = new System.Drawing.Size(214, 20);
            this.TxtIdentityCardNumber.TabIndex = 10;
            // 
            // LblIdentityCardNumber
            // 
            this.LblIdentityCardNumber.AutoSize = true;
            this.LblIdentityCardNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblIdentityCardNumber.Location = new System.Drawing.Point(6, 23);
            this.LblIdentityCardNumber.Name = "LblIdentityCardNumber";
            this.LblIdentityCardNumber.Size = new System.Drawing.Size(120, 23);
            this.LblIdentityCardNumber.TabIndex = 1;
            this.LblIdentityCardNumber.Text = "Numer dowodu";
            // 
            // Passport
            // 
            this.Passport.Controls.Add(this.DtpExplorationDatePassport);
            this.Passport.Controls.Add(this.LblExplorationDatePassport);
            this.Passport.Controls.Add(this.DtpIssueDatePassport);
            this.Passport.Controls.Add(this.LblIssueDatePassport);
            this.Passport.Controls.Add(this.TxtPassportNumber);
            this.Passport.Controls.Add(this.LblPassportNumber);
            this.Passport.Location = new System.Drawing.Point(446, 340);
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(386, 139);
            this.Passport.TabIndex = 4;
            this.Passport.TabStop = false;
            this.Passport.Text = "Paszport";
            // 
            // DtpExplorationDatePassport
            // 
            this.DtpExplorationDatePassport.CustomFormat = " ";
            this.DtpExplorationDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpExplorationDatePassport.Location = new System.Drawing.Point(136, 97);
            this.DtpExplorationDatePassport.Name = "DtpExplorationDatePassport";
            this.DtpExplorationDatePassport.Size = new System.Drawing.Size(214, 20);
            this.DtpExplorationDatePassport.TabIndex = 13;
            this.DtpExplorationDatePassport.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // LblExplorationDatePassport
            // 
            this.LblExplorationDatePassport.AutoSize = true;
            this.LblExplorationDatePassport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblExplorationDatePassport.Location = new System.Drawing.Point(6, 94);
            this.LblExplorationDatePassport.Name = "LblExplorationDatePassport";
            this.LblExplorationDatePassport.Size = new System.Drawing.Size(120, 23);
            this.LblExplorationDatePassport.TabIndex = 12;
            this.LblExplorationDatePassport.Text = "Data ważności";
            // 
            // DtpIssueDatePassport
            // 
            this.DtpIssueDatePassport.CustomFormat = " ";
            this.DtpIssueDatePassport.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpIssueDatePassport.Location = new System.Drawing.Point(136, 61);
            this.DtpIssueDatePassport.Name = "DtpIssueDatePassport";
            this.DtpIssueDatePassport.Size = new System.Drawing.Size(214, 20);
            this.DtpIssueDatePassport.TabIndex = 10;
            this.DtpIssueDatePassport.ValueChanged += new System.EventHandler(this.Dtp_ValueChanged);
            // 
            // LblIssueDatePassport
            // 
            this.LblIssueDatePassport.AutoSize = true;
            this.LblIssueDatePassport.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblIssueDatePassport.Location = new System.Drawing.Point(6, 58);
            this.LblIssueDatePassport.Name = "LblIssueDatePassport";
            this.LblIssueDatePassport.Size = new System.Drawing.Size(114, 23);
            this.LblIssueDatePassport.TabIndex = 11;
            this.LblIssueDatePassport.Text = "Data wydania";
            // 
            // TxtPassportNumber
            // 
            this.TxtPassportNumber.Location = new System.Drawing.Point(136, 26);
            this.TxtPassportNumber.Name = "TxtPassportNumber";
            this.TxtPassportNumber.Size = new System.Drawing.Size(214, 20);
            this.TxtPassportNumber.TabIndex = 10;
            // 
            // LblPassportNumber
            // 
            this.LblPassportNumber.AutoSize = true;
            this.LblPassportNumber.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblPassportNumber.Location = new System.Drawing.Point(6, 23);
            this.LblPassportNumber.Name = "LblPassportNumber";
            this.LblPassportNumber.Size = new System.Drawing.Size(114, 23);
            this.LblPassportNumber.TabIndex = 1;
            this.LblPassportNumber.Text = "Nr paszportu";
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnSave.Location = new System.Drawing.Point(664, 515);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(168, 36);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Zapisz";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnCancel.Location = new System.Drawing.Point(496, 515);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(162, 36);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Anuluj";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // epLastName
            // 
            this.epLastName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLastName.ContainerControl = this;
            // 
            // EpFirstName
            // 
            this.EpFirstName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EpFirstName.ContainerControl = this;
            // 
            // EpPesel
            // 
            this.EpPesel.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.EpPesel.ContainerControl = this;
            // 
            // EmployeeAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 563);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.GbIdentityCard);
            this.Controls.Add(this.GbContact);
            this.Controls.Add(this.GbGeneral);
            this.Controls.Add(this.LblEmployee);
            this.KeyPreview = true;
            this.Name = "EmployeeAddForm";
            this.Text = "Dodaj Pracownika";
            this.Load += new System.EventHandler(this.EmployeeAddForm_Load);
            this.GbGeneral.ResumeLayout(false);
            this.GbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BsGender)).EndInit();
            this.GbContact.ResumeLayout(false);
            this.GbContact.PerformLayout();
            this.GbIdentityCard.ResumeLayout(false);
            this.GbIdentityCard.PerformLayout();
            this.Passport.ResumeLayout(false);
            this.Passport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpPesel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmployee;
        private System.Windows.Forms.GroupBox GbGeneral;
        private System.Windows.Forms.TextBox TxtPesel;
        private System.Windows.Forms.Label LblPesel;
        private System.Windows.Forms.DateTimePicker DtpDateBirth;
        private System.Windows.Forms.Label laLblDateBirthbel1;
        private System.Windows.Forms.ComboBox CbGender;
        private System.Windows.Forms.Label LblGender;
        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label LblFirstName;
        private System.Windows.Forms.Label LblLastName;
        private System.Windows.Forms.GroupBox GbContact;
        private System.Windows.Forms.TextBox TxtEmailAddress;
        private System.Windows.Forms.Label LblEmailAddress;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.Label LblPhoneNumber;
        private System.Windows.Forms.GroupBox GbIdentityCard;
        private System.Windows.Forms.DateTimePicker DtpExplorationDateIdentityCard;
        private System.Windows.Forms.Label label1LblExplorationDateIdentityCard;
        private System.Windows.Forms.DateTimePicker DtpIssueDateIdentityCard;
        private System.Windows.Forms.Label LblIssueDateIdentityCard;
        private System.Windows.Forms.TextBox TxtIdentityCardNumber;
        private System.Windows.Forms.Label LblIdentityCardNumber;
        private System.Windows.Forms.GroupBox Passport;
        private System.Windows.Forms.DateTimePicker DtpExplorationDatePassport;
        private System.Windows.Forms.Label LblExplorationDatePassport;
        private System.Windows.Forms.DateTimePicker DtpIssueDatePassport;
        private System.Windows.Forms.Label LblIssueDatePassport;
        private System.Windows.Forms.TextBox TxtPassportNumber;
        private System.Windows.Forms.Label LblPassportNumber;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.BindingSource BsGender;
        private System.Windows.Forms.ErrorProvider epLastName;
        private System.Windows.Forms.ErrorProvider EpFirstName;
        private System.Windows.Forms.ErrorProvider EpPesel;
    }
}