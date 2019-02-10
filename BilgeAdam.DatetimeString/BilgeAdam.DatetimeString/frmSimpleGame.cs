using System;
using System.Windows.Forms;

namespace BilgeAdam.DatetimeString
{
    public partial class frmSimpleGame : Form
    {
        public frmSimpleGame()
        {
            InitializeComponent();
        }

        private void frmSimpleGame_Load(object sender, EventArgs e)
        {
            tmrCounter.Start();
            btnLeft.BackgroundImage = imlEmojis.Images[1];
            btnLeft.BackgroundImageLayout = ImageLayout.Stretch;
            btnRight.BackgroundImage = imlEmojis.Images[1];
            btnRight.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void tmrCounter_Tick(object sender, EventArgs e)
        {
            btnLeft.Left++;
            btnRight.Left--;
            if ((btnLeft.Left + btnLeft.Width) == btnRight.Left)
            {
                btnLeft.BackgroundImage = btnRight.BackgroundImage = imlEmojis.Images[0];
                tmrCounter.Stop();
            }
        }
    }
}
