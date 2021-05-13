namespace SystemHr.UserInterface.Forms.Employees
{
    partial class EmployeesForm
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
            this.TlpEmployees = new System.Windows.Forms.TableLayoutPanel();
            this.PEmployees = new System.Windows.Forms.Panel();
            this.BtnSendEmail = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnDismiss = new System.Windows.Forms.Button();
            this.BtnModify = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.DgvEmployees = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.TlpEmployees.SuspendLayout();
            this.PEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // TlpEmployees
            // 
            this.TlpEmployees.ColumnCount = 1;
            this.TlpEmployees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpEmployees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpEmployees.Controls.Add(this.PEmployees, 0, 0);
            this.TlpEmployees.Controls.Add(this.DgvEmployees, 0, 1);
            this.TlpEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpEmployees.Location = new System.Drawing.Point(0, 0);
            this.TlpEmployees.Name = "TlpEmployees";
            this.TlpEmployees.RowCount = 2;
            this.TlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TlpEmployees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpEmployees.Size = new System.Drawing.Size(800, 450);
            this.TlpEmployees.TabIndex = 0;
            this.TlpEmployees.Paint += new System.Windows.Forms.PaintEventHandler(this.TlpEmployees_Paint);
            // 
            // PEmployees
            // 
            this.PEmployees.Controls.Add(this.BtnSendEmail);
            this.PEmployees.Controls.Add(this.BtnRefresh);
            this.PEmployees.Controls.Add(this.BtnRemove);
            this.PEmployees.Controls.Add(this.BtnDismiss);
            this.PEmployees.Controls.Add(this.BtnModify);
            this.PEmployees.Controls.Add(this.BtnCreate);
            this.PEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PEmployees.Location = new System.Drawing.Point(3, 3);
            this.PEmployees.Name = "PEmployees";
            this.PEmployees.Size = new System.Drawing.Size(794, 34);
            this.PEmployees.TabIndex = 0;
            // 
            // BtnSendEmail
            // 
            this.BtnSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnSendEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSendEmail.Location = new System.Drawing.Point(704, 0);
            this.BtnSendEmail.Name = "BtnSendEmail";
            this.BtnSendEmail.Size = new System.Drawing.Size(90, 34);
            this.BtnSendEmail.TabIndex = 5;
            this.BtnSendEmail.Text = "Wyślij Email";
            this.BtnSendEmail.UseVisualStyleBackColor = false;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRefresh.Location = new System.Drawing.Point(360, 0);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(90, 34);
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.Text = "Odśwież";
            this.BtnRefresh.UseVisualStyleBackColor = false;
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRemove.Location = new System.Drawing.Point(270, 0);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(90, 34);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "Usuń";
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnDismiss
            // 
            this.BtnDismiss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnDismiss.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDismiss.Location = new System.Drawing.Point(180, 0);
            this.BtnDismiss.Name = "BtnDismiss";
            this.BtnDismiss.Size = new System.Drawing.Size(90, 34);
            this.BtnDismiss.TabIndex = 2;
            this.BtnDismiss.Text = "Zwolnij";
            this.BtnDismiss.UseVisualStyleBackColor = false;
            // 
            // BtnModify
            // 
            this.BtnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnModify.Location = new System.Drawing.Point(90, 0);
            this.BtnModify.Name = "BtnModify";
            this.BtnModify.Size = new System.Drawing.Size(90, 34);
            this.BtnModify.TabIndex = 1;
            this.BtnModify.Text = "Edytuj";
            this.BtnModify.UseVisualStyleBackColor = false;
            this.BtnModify.Click += new System.EventHandler(this.BtnModify_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnCreate.Location = new System.Drawing.Point(0, 0);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(90, 34);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "Dodaj";
            this.BtnCreate.UseVisualStyleBackColor = false;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // DgvEmployees
            // 
            this.DgvEmployees.AllowUserToAddRows = false;
            this.DgvEmployees.AllowUserToDeleteRows = false;
            this.DgvEmployees.AutoGenerateColumns = false;
            this.DgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.DgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColLastName,
            this.ColFirstName,
            this.ColCod,
            this.ColPosition,
            this.ColStatus});
            this.DgvEmployees.DataSource = this.BsEmployees;
            this.DgvEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvEmployees.Location = new System.Drawing.Point(3, 43);
            this.DgvEmployees.Name = "DgvEmployees";
            this.DgvEmployees.ReadOnly = true;
            this.DgvEmployees.RowHeadersVisible = false;
            this.DgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmployees.Size = new System.Drawing.Size(794, 404);
            this.DgvEmployees.TabIndex = 1;
            // 
            // ColId
            // 
            this.ColId.DataPropertyName = "Id";
            this.ColId.HeaderText = "Id";
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            // 
            // ColLastName
            // 
            this.ColLastName.DataPropertyName = "LastName";
            this.ColLastName.HeaderText = "Nazwisko";
            this.ColLastName.Name = "ColLastName";
            this.ColLastName.ReadOnly = true;
            this.ColLastName.ToolTipText = "Nazwisko Pracownika";
            // 
            // ColFirstName
            // 
            this.ColFirstName.DataPropertyName = "FirstName";
            this.ColFirstName.HeaderText = "Imie";
            this.ColFirstName.Name = "ColFirstName";
            this.ColFirstName.ReadOnly = true;
            this.ColFirstName.ToolTipText = "Imie Pracownika";
            // 
            // ColCod
            // 
            this.ColCod.DataPropertyName = "Code";
            this.ColCod.HeaderText = "Kod";
            this.ColCod.Name = "ColCod";
            this.ColCod.ReadOnly = true;
            this.ColCod.ToolTipText = "Kod Pracownika";
            // 
            // ColPosition
            // 
            this.ColPosition.DataPropertyName = "Position";
            this.ColPosition.HeaderText = "Stanowisko";
            this.ColPosition.Name = "ColPosition";
            this.ColPosition.ReadOnly = true;
            this.ColPosition.ToolTipText = "Aktualnie zajmowane stanowisko";
            this.ColPosition.Width = 150;
            // 
            // ColStatus
            // 
            this.ColStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColStatus.DataPropertyName = "Status";
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            this.ColStatus.ToolTipText = "Status pracownika";
            // 
            // BsEmployees
            // 
            this.BsEmployees.DataSource = typeof(SystemHr.DataAccessLayer.ViweModels.EmployeeViewModel);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TlpEmployees);
            this.Name = "EmployeesForm";
            this.Text = "Pracownicy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EmployeesForm_FormClosed);
            this.TlpEmployees.ResumeLayout(false);
            this.PEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BsEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TlpEmployees;
        private System.Windows.Forms.Panel PEmployees;
        private System.Windows.Forms.Button BtnSendEmail;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnDismiss;
        private System.Windows.Forms.Button BtnModify;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.DataGridView DgvEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.BindingSource BsEmployees;
    }
}