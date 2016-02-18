using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaffHolidays
{
    public partial class NameAccount : Form
    {
        public NameAccount()
        {
            InitializeComponent();
            SetErrorProviders();
        }

        private void SetErrorProviders()
        {
            errorProviderNameAccount.Clear();
            createButton.Enabled = false;
            if (accountNameTextBox.Text == "")
            {
                errorProviderNameAccount.SetIconAlignment(accountNameTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
                errorProviderNameAccount.SetError(accountNameTextBox, "Please enter a description.");
            }
            else
            {
                errorProviderNameAccount.Clear();
                createButton.Enabled = true;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (accountNameTextBox.Text != "")
            {
                Variables.accountName = accountNameTextBox.Text;
                if (useLocal.Checked == false)
                {
                    Variables.databaseFolder = AppDomain.CurrentDomain.BaseDirectory;
                }
                Close();
            }
        }

        private void accountNameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetErrorProviders();
        }
    }
}
