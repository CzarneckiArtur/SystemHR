using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHr.UserInterface.Forms.Contracts
{
    public partial class ContractsForm : Form
    {
        private static ContractsForm _instance = null;
        //singleton
        public static ContractsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ContractsForm();
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
        private ContractsForm()
        {
            InitializeComponent();
        }
        private void ContractsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Umożliwia ponowne otwarcie formularza
            _instance = null;
        }
    }
}
