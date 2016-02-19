using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace StaffHolidays
{
    public partial class AddStaff : Form
    {
        public AddStaff()
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
            addButton.Enabled = false;
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
                addButton.Enabled = true;
            }
        }

        private void AddStaffToDB()
        {
            if (typeComboBox.SelectedIndex >= 0)
            {
                try
                {
                    using (SQLiteConnection con = new SQLiteConnection(Variables.dataPath))
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandText = @"INSERT INTO Staff (Name, Type, YearToDateOff) VALUES (@name,@type,@yeartodateoff) ";
                        cmd.Connection = con;
                        cmd.Parameters.Add(new SQLiteParameter("@name", nameTextBox.Text));
                        cmd.Parameters.Add(new SQLiteParameter("@type", typeComboBox.SelectedIndex + 1));
                        cmd.Parameters.Add(new SQLiteParameter("@yeartodateoff", 0));

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
                CreateStaffHolidayTable();
            }
        }

        private void CreateStaffHolidayTable()
        {
            Directory.CreateDirectory(Variables.databaseFolder);

            string newStaffHolidayListName = "";

            try
            {
                if (nameTextBox.Text != "")
                {
                    newStaffHolidayListName = nameTextBox.Text + ".db";

                    // This is the query which will create a new table in our database file with three columns. An auto increment column called "ID", and two NVARCHAR type columns with the names "Key" and "Value"
                    string createStaffHolidayTableQuery = @"CREATE TABLE IF NOT EXISTS [" + nameTextBox.Text + @"] (
                          [Id] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,
                          [Start] TEXT NOT NULL,
                          [End] TEXT NOT NULL,
                          [Count] INTEGER NOT NULL,
                          [Reason] TEXT NOT NULL,
                          [Approved] INTEGER NOT NULL
                          )";

                    //System.Data.SQLite.SQLiteConnection.CreateFile(Path.Combine(Variables.databaseFolder, newStaffHolidayListName));        // Create the file which will be hosting our database
                    using (System.Data.SQLite.SQLiteConnection con = new System.Data.SQLite.SQLiteConnection(Variables.dataPath))
                    {
                        using (System.Data.SQLite.SQLiteCommand com = new System.Data.SQLite.SQLiteCommand(con))
                        {
                            con.Open();                             // Open the connection to the database

                            com.CommandText = createStaffHolidayTableQuery;     // Set CommandText to our query that will create the table
                            com.ExecuteNonQuery();                  // Execute the query

                            con.Close();        // Close the connection to the database
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddStaffToDB();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            SetErrorProviders();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetErrorProviders();
        }
    }
}
