using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace StaffHolidays
{
    public partial class EditItem : Form
    {
        public EditItem()
        {
            InitializeComponent();

            SetupCategories();
            SetErrorProviders();
        }

        public void SetupCategories()
        {
            typeComboBox.Items.Clear();

            typeComboBox.Items.Add(Figures.category1);
            typeComboBox.Items.Add(Figures.category2);
            typeComboBox.Items.Add(Figures.category3);
            typeComboBox.Items.Add(Figures.category4);
        }

        private void SetErrorProviders()
        {
            errorProvider1.Clear();
            editButton.Enabled = false;
            if (nameTextBox.Text == "")
            {
                errorProvider1.SetIconAlignment(nameTextBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
                errorProvider1.SetError(nameTextBox, "Please enter a staff name.");
            }
            else if (typeComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetIconAlignment(typeComboBox, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
                errorProvider1.SetError(typeComboBox, "Please select the type of employment.");
            }
            else
            {
                errorProvider1.Clear();
                editButton.Enabled = true;
            }
        }

        private void editRecord()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(Variables.dataPath))
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    cmd.CommandText = @"Update Staff SET Name = @name, Type = @type where Id =" + Variables.Id;
                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@name", nameTextBox.Text));
                    cmd.Parameters.Add(new SQLiteParameter("@type", typeComboBox.SelectedIndex));

                    con.Open();

                    int i = cmd.ExecuteNonQuery();

                    if (i != 1)
                    {
                        MessageBox.Show("The database isn't being friendly at the moment. He doesn't want to talk to me.");
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SetFields()
        {
            nameTextBox.Text = Variables.Name;
            typeComboBox.SelectedIndex = Variables.TypeIndex;
        }

        private void descriptionText_Click(object sender, EventArgs e)
        {
            SetErrorProviders();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            editRecord();
        }
    }
}
