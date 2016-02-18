using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffHolidays
{
    class Variables
    {
        static string drive = Path.GetPathRoot(Environment.SystemDirectory);
        public static string dataPath = "";

        //Constants
        public static string connectionString = @" Data Source =";
        public static string accountName = "";
        public static string databaseFolder = drive + @"StaffHolidays\Databases";

        //Editing records
        public static int Id = 0;
        public static string Name = "";
        public static int TypeIndex = 0;
        public static int YearToDateOff = 0;
    }
}
