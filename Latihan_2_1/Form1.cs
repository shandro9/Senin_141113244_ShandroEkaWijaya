using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class Form1 : Form
    {
        int nomorBulan;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(1997, 2, 15));
            for (DateTime i = new DateTime(2016, 1, 1); i.Year < 2017; i = i.AddDays(1))
            {
                if (i.DayOfWeek == DayOfWeek.Saturday || i.DayOfWeek == DayOfWeek.Sunday)
                {
                    monthCalendar1.AddBoldedDate(i);
                }
            }
            monthCalendar1.UpdateBoldedDates();
            domainUpDown1.Items.Add("Januari");
            domainUpDown1.Items.Add("Februari");
            domainUpDown1.Items.Add("Maret");
            domainUpDown1.Items.Add("April");
            domainUpDown1.Items.Add("Mei");
            domainUpDown1.Items.Add("Juni");
            domainUpDown1.Items.Add("Juli");
            domainUpDown1.Items.Add("Agustus");
            domainUpDown1.Items.Add("September");
            domainUpDown1.Items.Add("Oktober");
            domainUpDown1.Items.Add("November");
            domainUpDown1.Items.Add("Desember");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomorBulan = CheckNoBulan(domainUpDown1.Text);
            monthCalendar1.AddAnnuallyBoldedDate(new DateTime(DateTime.Now.Year, nomorBulan, Convert.ToInt32(numericUpDown1.Value)));
            monthCalendar1.UpdateBoldedDates();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            nomorBulan = CheckNoBulan(domainUpDown1.Text);
            monthCalendar1.RemoveAnnuallyBoldedDate(new DateTime(DateTime.Now.Year, nomorBulan, Convert.ToInt32(numericUpDown1.Value)));
            monthCalendar1.UpdateBoldedDates();
        }

        private int CheckNoBulan(string textBulan) {
            if (textBulan == "Januari") return 1;
            else if (textBulan == "Februari") return 2;
            else if (textBulan == "Maret") return 3;
            else if (textBulan == "April") return 4;
            else if (textBulan == "Mei") return 5;
            else if (textBulan == "Juni") return 6;
            else if (textBulan == "Juli") return 7;
            else if (textBulan == "Agustus") return 8;
            else if (textBulan == "September") return 9;
            else if (textBulan == "Oktober") return 10;
            else if (textBulan == "November") return 11;
            else if (textBulan == "Desember") return 12;
            else return 0;
        }
    }
}
