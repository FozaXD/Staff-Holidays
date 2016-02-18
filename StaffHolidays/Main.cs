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
            accountNameLabel.Text = Variables.accountName;
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
                Variables.YearToDateOff = Convert.ToInt32(selectedRow.Cells[3].Value);

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
    }
}
