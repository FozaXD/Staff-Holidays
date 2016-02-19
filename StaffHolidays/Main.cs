using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace StaffHolidays
{
    public partial class Main : Form
    {

        string staff;
        List<DateTime> staffDatesOffList = new List<DateTime>();
        List<DateTime> Start = new List<DateTime>();
        List<DateTime> End = new List<DateTime>();

        public Main()
        {
            InitializeComponent();
            CheckReusePathExists();
            SetNames();

            Draw();
        }

        public void Draw()
        {
            SetStaffDataGridView();
            SetBoldedDates();
        }

        public void SetBoldedDates()
        {
            Start.Clear();
            End.Clear();
            staffDatesOffList.Clear();
            foreach (DataGridViewRow row in staffDataGridView.Rows)
            {
                staff = staffDataGridView[1, row.Index].Value.ToString();
                try
                {
                    SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                    con.Open();
                    Start.Clear();
                    End.Clear();
                    SQLiteCommand comm = new SQLiteCommand("Select Start, End From " + staff, con);
                    using (SQLiteDataReader read = comm.ExecuteReader())
                    {
                        while (read.Read())
                        {
                            Start.Add(Convert.ToDateTime(read[0]));
                            End.Add(Convert.ToDateTime(read[1]));
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                foreach (DateTime row2 in Start)
                {
                    int x = 0;                 
                    for (DateTime date = row2; date <= End[x]; date = date.AddDays(1))
                        staffDatesOffList.Add(date);
                    x++;
                }
                DateTime[] staffDatesOff = staffDatesOffList.ToArray();
                mainCalendar.BoldedDates = staffDatesOff; //new DateTime[] { new DateTime(2016, 2, 26, 0, 0, 0, 0), new DateTime(2016, 2, 27, 0, 0, 0, 0) };
            }

        }

        public void CheckReusePathExists()
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Reusepath.txt"))
            {
                reuse.Checked = true;
                Variables.dataPath = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "Reusepath.txt").Skip(0).Take(1).First();
                Variables.accountName = File.ReadLines(AppDomain.CurrentDomain.BaseDirectory + "Reusepath.txt").Skip(1).Take(1).First();
            }
            else
            {
                reuse.Checked = false;
                Startup1();
            }
        }

        public void Startup1()
        {
            StartupWindow startup = new StartupWindow();
            var dialogResult = startup.ShowDialog();
        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            AddStaff addStaffForm = new AddStaff();

            addStaffForm.ShowDialog();
            Draw();
        }

        private void SetNames()
        {
            Text += " - " + Variables.accountName;
            Refresh();
        }

        private void SetStaffDataGridView()
        {
            staffDataGridView.Rows.Clear();
            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();
                SQLiteCommand comm = new SQLiteCommand("Select * From Staff", con);
                using (SQLiteDataReader read = comm.ExecuteReader())
                {
                    while (read.Read())
                    {
                        staffDataGridView.Rows.Add(new object[] {
                    read.GetValue(0),  // U can use column index
                    read.GetValue(read.GetOrdinal("Name")),  // Or column name like this
                    read.GetValue(read.GetOrdinal("Type")),
                    read.GetValue(read.GetOrdinal("YearToDateOff"))
                    });
                    }
                }
                con.Close();
                if (staffDataGridView.Rows.Count != 0)
                {
                    removeStaffButton.Enabled = true;
                }
                else
                {
                    removeStaffButton.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SetIndividualStaffDataGridView()
        {
            indiStaffHoliDataGridView.Rows.Clear();
            try
            {
                SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                con.Open();

                // As multiple can be selected only get last.
                if (staffDataGridView.SelectedRows.Count == 1)
                {
                    foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
                    {
                        SQLiteCommand comm = new SQLiteCommand("Select * From " + staffDataGridView[1, row.Index].Value.ToString(), con);
                        using (SQLiteDataReader read = comm.ExecuteReader())
                        {
                            while (read.Read())
                            {
                                indiStaffHoliDataGridView.Rows.Add(new object[] {
                                read.GetValue(0),  // U can use column index
                                read.GetValue(read.GetOrdinal("Start")),  // Or column name like this
                                read.GetValue(read.GetOrdinal("End")),
                                read.GetValue(read.GetOrdinal("Count")),
                                read.GetValue(read.GetOrdinal("Reason")),
                                read.GetValue(read.GetOrdinal("Approved"))
                                });
                            }
                        }
                        con.Close();
                    }
                }

                if (indiStaffHoliDataGridView.Rows.Count != 0)
                {
                    removeHoliday.Enabled = true;
                }
                else
                {
                    removeHoliday.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void WriteReusePath()
        {
            string[] lines = { Variables.dataPath, Variables.accountName };
            try
            {
                System.IO.File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + "Reusepath.txt", lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reuse.Checked == true)
            {
                WriteReusePath();
            }
            else
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"\Reusepath.txt"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + @"\Reusepath.txt");
                }
            }
        }

        private void staffContextMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count == 1)
            {
                int selectedrowindex = staffDataGridView.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = staffDataGridView.Rows[selectedrowindex];

                Variables.Id = Convert.ToInt32(selectedRow.Cells[0].Value);
                Variables.Name = Convert.ToString(selectedRow.Cells[1].Value);
                Variables.TypeIndex = Convert.ToInt32(selectedRow.Cells[2].Value);

                EditItem editItem = new EditItem();
                editItem.ShowDialog();
                Draw();
            }
        }

        private void staffDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (staffDataGridView.RowCount > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.RowIndex != -1)
                    {
                        staffDataGridView.CurrentCell = staffDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        staffDataGridView.Rows[e.RowIndex].Selected = true;
                        staffDataGridView.Focus();
                    }
                }
            }
        }

        private void staffDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                staffContextMenu.Items.Clear();
                staffContextMenu.Items.Add("Edit Selected");
                var ht = staffDataGridView.HitTest(e.X, e.Y);

                if (ht.Type != DataGridViewHitTestType.None && ht.Type != DataGridViewHitTestType.ColumnHeader)
                {
                    staffContextMenu.Show(staffDataGridView, new Point(e.X, e.Y));
                }

            }
        }

        private void removeStaffButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove the selected record?", "Remove Record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                    con.Open();
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
                        {
                            cmd.CommandText = " DROP Table '" + staffDataGridView[1, row.Index].Value.ToString() + "'";
                            cmd.ExecuteNonQuery();
                            cmd.CommandText = String.Format("DELETE FROM Staff WHERE Id=" + int.Parse(staffDataGridView[0, row.Index].Value.ToString()), con);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                    Draw();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void staffDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in staffDataGridView.SelectedRows)
            {
                staff = staffDataGridView[1, row.Index].Value.ToString();
            }
            SetIndividualStaffDataGridView();
        }

        private void addHoliday_Click(object sender, EventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count == 1)
            {
                AddHoliday addHolidayForm = new AddHoliday(staff);
                addHolidayForm.ShowDialog();
                SetIndividualStaffDataGridView();
                SetBoldedDates();
            }
        }

        private void removeHoliday_Click(object sender, EventArgs e)
        {
            if (staffDataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Are you sure you wish to remove the selected record?", "Remove Record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        SQLiteConnection con = new SQLiteConnection(Variables.dataPath);
                        con.Open();
                        using (SQLiteCommand cmd = con.CreateCommand())
                        {
                            foreach (DataGridViewRow row in indiStaffHoliDataGridView.SelectedRows)
                            {
                                cmd.CommandText = String.Format("DELETE FROM " + staff + " WHERE Id=" + int.Parse(indiStaffHoliDataGridView[0, row.Index].Value.ToString()), con);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        con.Close();
                        SetIndividualStaffDataGridView();
                        SetBoldedDates();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        }
    }
}
