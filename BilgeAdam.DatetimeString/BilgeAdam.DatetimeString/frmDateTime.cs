using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.DatetimeString
{
    public partial class frmDateTime : Form
    {
        public frmDateTime()
        {
            InitializeComponent();
        }

        private void frmDateTime_Load(object sender, EventArgs e)
        {
            lblNow.Text += DateTime.Now.ToString();
            lblNowFormatted.Text += DateTime.Now.ToString("dd/MM/yyyy HH:mm - dddd");
            lblTomorrow.Text += DateTime.Now.AddDays(1).ToShortDateString();
            lblYesterday.Text += DateTime.Now.AddDays(-1).ToShortDateString();
            lblNextMonth.Text += DateTime.Now.AddMonths(1).ToShortDateString();
            lblCustomDate.Text += new DateTime(1988, 2, 8).ToString();
            lblDaysCountOfCurrentMonth.Text += DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            tmrTick.Start();           
        }

        private void tmrTick_Tick(object sender, EventArgs e)
        {
            var birthDateOfDeniz = new DateTime(1996, 6, 21, 7, 20, 0);
            var currentDate = DateTime.Now;
            var a = currentDate.ToUniversalTime();
            var lifeTime = currentDate - birthDateOfDeniz;
            var year = lifeTime.Days / 365;
            var days = lifeTime.Days - (year * 365);
            var month = days / 30;
            days = days - month * 30;
            var time = string.Format("{0:D2}:{1:D2}:{2:D2}", lifeTime.Hours, lifeTime.Minutes, lifeTime.Seconds);
            lblDiff.Text = $"Deniz'in yaşı : {year} Yıl, {month} Ay, {days} Gün, {time}";
        }
    }
}
