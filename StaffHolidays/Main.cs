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

namespace StaffHolidays
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            CheckReusePathExists();
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
    }
}
