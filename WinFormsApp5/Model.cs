using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5
{
    internal class Model
    {
        public Model(string day, string dayMonth, string month, string year, string result)
        {
            Day = day;
            DayMonth = dayMonth;
            Month = month;
            Year = year;
            Result = result;
        }

        public string Day { get; set; }
        public string DayMonth { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string Result { get; set; }

    }
}
