using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHr.UserInterface.Forms.Contracts;
using SystemHr.UserInterface.Forms.Employees;
using SystemHr.UserInterface.Helpers;

namespace SystemHr.UserInterface.Forms
{
    public partial class MainForm : Form
    {
        #region Fields
        private TabPage _tpEmployees;
        private TabPage _tpContracts;
        #endregion
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion
        #region Events
        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            //pojedyncza zakładka w tabcontrol

            if (EmployeesForm.IsNull)
            {
                _tpEmployees = new TabPage();
                ShowFormInTabPAge(_tpEmployees, EmployeesForm.Instance);
            }
            else
                TcTabs.SelectedTab = _tpEmployees;
        }

        private void BtnContracts_Click(object sender, EventArgs e)
        {
            if (ContractsForm.IsNull)
            {
                _tpContracts = new TabPage();

                ShowFormInTabPAge(_tpContracts, ContractsForm.Instance);
            }
            else
                TcTabs.SelectedTab = _tpContracts;

        }

        private void TcTabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Obsługa ikony do zamykania kart
        private void TcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.TcTabs.TabPages[e.Index];
                var tabRect = this.TcTabs.GetTabRect(e.Index);

                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void TcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.TcTabs.TabPages.Count; i++)
            {
                var tabRect = this.TcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{ResourcesHelper.ResourcesFilePath}\\{ResourcesHelper.CloseButtonName}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    //dostanie sie do odpalonego tctab i jego zamkniecie
                    var form = TcTabs.TabPages[i].Controls[0] as Form;
                    form.Close();

                    this.TcTabs.TabPages.RemoveAt(i);

                    break;
                }
            }
        }
        #endregion
        #region PrivMethods
        private void ShowFormInTabPAge(TabPage tp, Form form)
        {

            //dodanie kontrolki
            TcTabs.Controls.Add(tp);

            tp.Text = form.Text;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tp.Controls.Add(form);
            TcTabs.SelectedTab = tp;
        }
        #endregion
     }
        
}
