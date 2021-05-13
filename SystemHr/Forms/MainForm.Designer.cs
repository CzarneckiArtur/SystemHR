namespace SystemHr.UserInterface.Forms
{
    partial class MainForm
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
            this.TcMain = new System.Windows.Forms.TabControl();
            this.TpGeneral = new System.Windows.Forms.TabPage();
            this.BtnPositions = new System.Windows.Forms.Button();
            this.splitter5 = new System.Windows.Forms.Splitter();
            this.BtnDepartaments = new System.Windows.Forms.Button();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.BtnSalaries = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.BtnOrganisationalStructure = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.BtnContracts = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.BtnEmployees = new System.Windows.Forms.Button();
            this.TpConfiguration = new System.Windows.Forms.TabPage();
            this.SsMain = new System.Windows.Forms.StatusStrip();
            this.TsslWersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TcTabs = new System.Windows.Forms.TabControl();
            this.TcMain.SuspendLayout();
            this.TpGeneral.SuspendLayout();
            this.SsMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcMain
            // 
            this.TcMain.Controls.Add(this.TpGeneral);
            this.TcMain.Controls.Add(this.TpConfiguration);
            this.TcMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.TcMain.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TcMain.Location = new System.Drawing.Point(0, 0);
            this.TcMain.Name = "TcMain";
            this.TcMain.SelectedIndex = 0;
            this.TcMain.Size = new System.Drawing.Size(874, 100);
            this.TcMain.TabIndex = 0;
            // 
            // TpGeneral
            // 
            this.TpGeneral.Controls.Add(this.BtnPositions);
            this.TpGeneral.Controls.Add(this.splitter5);
            this.TpGeneral.Controls.Add(this.BtnDepartaments);
            this.TpGeneral.Controls.Add(this.splitter4);
            this.TpGeneral.Controls.Add(this.BtnSalaries);
            this.TpGeneral.Controls.Add(this.splitter3);
            this.TpGeneral.Controls.Add(this.BtnOrganisationalStructure);
            this.TpGeneral.Controls.Add(this.splitter2);
            this.TpGeneral.Controls.Add(this.BtnContracts);
            this.TpGeneral.Controls.Add(this.splitter1);
            this.TpGeneral.Controls.Add(this.BtnEmployees);
            this.TpGeneral.Location = new System.Drawing.Point(4, 22);
            this.TpGeneral.Name = "TpGeneral";
            this.TpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TpGeneral.Size = new System.Drawing.Size(866, 74);
            this.TpGeneral.TabIndex = 0;
            this.TpGeneral.Text = "Ogólne";
            this.TpGeneral.UseVisualStyleBackColor = true;
            // 
            // BtnPositions
            // 
            this.BtnPositions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnPositions.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnPositions.Location = new System.Drawing.Point(735, 3);
            this.BtnPositions.Name = "BtnPositions";
            this.BtnPositions.Size = new System.Drawing.Size(131, 68);
            this.BtnPositions.TabIndex = 10;
            this.BtnPositions.Text = "Stanowiska";
            this.BtnPositions.UseVisualStyleBackColor = false;
            // 
            // splitter5
            // 
            this.splitter5.Location = new System.Drawing.Point(732, 3);
            this.splitter5.Name = "splitter5";
            this.splitter5.Size = new System.Drawing.Size(3, 68);
            this.splitter5.TabIndex = 9;
            this.splitter5.TabStop = false;
            // 
            // BtnDepartaments
            // 
            this.BtnDepartaments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnDepartaments.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDepartaments.Location = new System.Drawing.Point(608, 3);
            this.BtnDepartaments.Name = "BtnDepartaments";
            this.BtnDepartaments.Size = new System.Drawing.Size(124, 68);
            this.BtnDepartaments.TabIndex = 8;
            this.BtnDepartaments.Text = "Działy";
            this.BtnDepartaments.UseVisualStyleBackColor = false;
            // 
            // splitter4
            // 
            this.splitter4.Location = new System.Drawing.Point(605, 3);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 68);
            this.splitter4.TabIndex = 7;
            this.splitter4.TabStop = false;
            // 
            // BtnSalaries
            // 
            this.BtnSalaries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSalaries.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnSalaries.Location = new System.Drawing.Point(454, 3);
            this.BtnSalaries.Name = "BtnSalaries";
            this.BtnSalaries.Size = new System.Drawing.Size(151, 68);
            this.BtnSalaries.TabIndex = 6;
            this.BtnSalaries.Text = "Wynagrodzenia";
            this.BtnSalaries.UseVisualStyleBackColor = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(451, 3);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 68);
            this.splitter3.TabIndex = 5;
            this.splitter3.TabStop = false;
            // 
            // BtnOrganisationalStructure
            // 
            this.BtnOrganisationalStructure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnOrganisationalStructure.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnOrganisationalStructure.Location = new System.Drawing.Point(302, 3);
            this.BtnOrganisationalStructure.Name = "BtnOrganisationalStructure";
            this.BtnOrganisationalStructure.Size = new System.Drawing.Size(149, 68);
            this.BtnOrganisationalStructure.TabIndex = 4;
            this.BtnOrganisationalStructure.Text = "Struktura Organizacyjna";
            this.BtnOrganisationalStructure.UseVisualStyleBackColor = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(299, 3);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 68);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // BtnContracts
            // 
            this.BtnContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnContracts.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnContracts.Location = new System.Drawing.Point(153, 3);
            this.BtnContracts.Name = "BtnContracts";
            this.BtnContracts.Size = new System.Drawing.Size(146, 68);
            this.BtnContracts.TabIndex = 2;
            this.BtnContracts.Text = "Umowy";
            this.BtnContracts.UseVisualStyleBackColor = false;
            this.BtnContracts.Click += new System.EventHandler(this.BtnContracts_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(150, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 68);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // BtnEmployees
            // 
            this.BtnEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEmployees.Location = new System.Drawing.Point(3, 3);
            this.BtnEmployees.Name = "BtnEmployees";
            this.BtnEmployees.Size = new System.Drawing.Size(147, 68);
            this.BtnEmployees.TabIndex = 0;
            this.BtnEmployees.Text = "Pracownicy";
            this.BtnEmployees.UseVisualStyleBackColor = false;
            this.BtnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // TpConfiguration
            // 
            this.TpConfiguration.Location = new System.Drawing.Point(4, 22);
            this.TpConfiguration.Name = "TpConfiguration";
            this.TpConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.TpConfiguration.Size = new System.Drawing.Size(866, 74);
            this.TpConfiguration.TabIndex = 1;
            this.TpConfiguration.Text = "Konfiguracja";
            this.TpConfiguration.UseVisualStyleBackColor = true;
            // 
            // SsMain
            // 
            this.SsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslWersion,
            this.TsslDataBase,
            this.TsslUser});
            this.SsMain.Location = new System.Drawing.Point(0, 539);
            this.SsMain.Name = "SsMain";
            this.SsMain.Size = new System.Drawing.Size(874, 22);
            this.SsMain.TabIndex = 1;
            this.SsMain.Text = "statusStrip1";
            // 
            // TsslWersion
            // 
            this.TsslWersion.Name = "TsslWersion";
            this.TsslWersion.Size = new System.Drawing.Size(72, 17);
            this.TsslWersion.Text = "Wersja: 1.0.0";
            // 
            // TsslDataBase
            // 
            this.TsslDataBase.Name = "TsslDataBase";
            this.TsslDataBase.Size = new System.Drawing.Size(50, 17);
            this.TsslDataBase.Text = "Baza HR";
            // 
            // TsslUser
            // 
            this.TsslUser.Name = "TsslUser";
            this.TsslUser.Size = new System.Drawing.Size(155, 17);
            this.TsslUser.Text = "Użytkownik: Artur Czarnecki";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TcTabs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 439);
            this.panel1.TabIndex = 2;
            // 
            // TcTabs
            // 
            this.TcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TcTabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TcTabs.ItemSize = new System.Drawing.Size(100, 18);
            this.TcTabs.Location = new System.Drawing.Point(0, 0);
            this.TcTabs.Name = "TcTabs";
            this.TcTabs.SelectedIndex = 0;
            this.TcTabs.Size = new System.Drawing.Size(874, 439);
            this.TcTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TcTabs.TabIndex = 0;
            this.TcTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.TcTabs_DrawItem);
            this.TcTabs.SelectedIndexChanged += new System.EventHandler(this.TcTabs_SelectedIndexChanged);
            this.TcTabs.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TcTabs_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SsMain);
            this.Controls.Add(this.TcMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemHr";
            this.TcMain.ResumeLayout(false);
            this.TpGeneral.ResumeLayout(false);
            this.SsMain.ResumeLayout(false);
            this.SsMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TcMain;
        private System.Windows.Forms.TabPage TpGeneral;
        private System.Windows.Forms.TabPage TpConfiguration;
        private System.Windows.Forms.Button BtnPositions;
        private System.Windows.Forms.Splitter splitter5;
        private System.Windows.Forms.Button BtnDepartaments;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Button BtnSalaries;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Button BtnOrganisationalStructure;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button BtnContracts;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button BtnEmployees;
        private System.Windows.Forms.StatusStrip SsMain;
        private System.Windows.Forms.ToolStripStatusLabel TsslWersion;
        private System.Windows.Forms.ToolStripStatusLabel TsslDataBase;
        private System.Windows.Forms.ToolStripStatusLabel TsslUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl TcTabs;
    }
}