namespace BilgeAdam.DatetimeString
{
    partial class frmDateTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNow = new System.Windows.Forms.Label();
            this.lblTomorrow = new System.Windows.Forms.Label();
            this.lblYesterday = new System.Windows.Forms.Label();
            this.lblCustomDate = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.lblNextMonth = new System.Windows.Forms.Label();
            this.lblDaysCountOfCurrentMonth = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNowFormatted = new System.Windows.Forms.Label();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblNow
            // 
            this.lblNow.AutoSize = true;
            this.lblNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNow.Location = new System.Drawing.Point(58, 26);
            this.lblNow.Name = "lblNow";
            this.lblNow.Size = new System.Drawing.Size(125, 20);
            this.lblNow.TabIndex = 0;
            this.lblNow.Text = "Şimdiki Zaman : ";
            // 
            // lblTomorrow
            // 
            this.lblTomorrow.AutoSize = true;
            this.lblTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTomorrow.Location = new System.Drawing.Point(125, 59);
            this.lblTomorrow.Name = "lblTomorrow";
            this.lblTomorrow.Size = new System.Drawing.Size(58, 20);
            this.lblTomorrow.TabIndex = 0;
            this.lblTomorrow.Text = "Yarın : ";
            // 
            // lblYesterday
            // 
            this.lblYesterday.AutoSize = true;
            this.lblYesterday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYesterday.Location = new System.Drawing.Point(132, 91);
            this.lblYesterday.Name = "lblYesterday";
            this.lblYesterday.Size = new System.Drawing.Size(51, 20);
            this.lblYesterday.TabIndex = 0;
            this.lblYesterday.Text = "Dün : ";
            // 
            // lblCustomDate
            // 
            this.lblCustomDate.AutoSize = true;
            this.lblCustomDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomDate.Location = new System.Drawing.Point(91, 126);
            this.lblCustomDate.Name = "lblCustomDate";
            this.lblCustomDate.Size = new System.Drawing.Size(92, 20);
            this.lblCustomDate.TabIndex = 0;
            this.lblCustomDate.Text = "Özel Tarih : ";
            // 
            // lblDiff
            // 
            this.lblDiff.AutoSize = true;
            this.lblDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDiff.Location = new System.Drawing.Point(92, 159);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(91, 20);
            this.lblDiff.TabIndex = 0;
            this.lblDiff.Text = "Gün Farkı : ";
            // 
            // lblNextMonth
            // 
            this.lblNextMonth.AutoSize = true;
            this.lblNextMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNextMonth.Location = new System.Drawing.Point(63, 191);
            this.lblNextMonth.Name = "lblNextMonth";
            this.lblNextMonth.Size = new System.Drawing.Size(120, 20);
            this.lblNextMonth.TabIndex = 0;
            this.lblNextMonth.Text = "Bir Sonraki Ay : ";
            // 
            // lblDaysCountOfCurrentMonth
            // 
            this.lblDaysCountOfCurrentMonth.AutoSize = true;
            this.lblDaysCountOfCurrentMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDaysCountOfCurrentMonth.Location = new System.Drawing.Point(11, 221);
            this.lblDaysCountOfCurrentMonth.Name = "lblDaysCountOfCurrentMonth";
            this.lblDaysCountOfCurrentMonth.Size = new System.Drawing.Size(172, 20);
            this.lblDaysCountOfCurrentMonth.TabIndex = 0;
            this.lblDaysCountOfCurrentMonth.Text = "Bu Aydaki Gün Sayısı : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(58, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Şimdiki Zaman : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(58, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Şimdiki Zaman : ";
            // 
            // lblNowFormatted
            // 
            this.lblNowFormatted.AutoSize = true;
            this.lblNowFormatted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNowFormatted.Location = new System.Drawing.Point(430, 26);
            this.lblNowFormatted.Name = "lblNowFormatted";
            this.lblNowFormatted.Size = new System.Drawing.Size(186, 20);
            this.lblNowFormatted.TabIndex = 1;
            this.lblNowFormatted.Text = "Formatlı Şimdiki Zaman : ";
            // 
            // tmrTick
            // 
            this.tmrTick.Interval = 1000;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // frmDateTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 360);
            this.Controls.Add(this.lblNowFormatted);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNextMonth);
            this.Controls.Add(this.lblYesterday);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDiff);
            this.Controls.Add(this.lblTomorrow);
            this.Controls.Add(this.lblDaysCountOfCurrentMonth);
            this.Controls.Add(this.lblCustomDate);
            this.Controls.Add(this.lblNow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDateTime";
            this.Text = "DateTime";
            this.Load += new System.EventHandler(this.frmDateTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNow;
        private System.Windows.Forms.Label lblTomorrow;
        private System.Windows.Forms.Label lblYesterday;
        private System.Windows.Forms.Label lblCustomDate;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label lblNextMonth;
        private System.Windows.Forms.Label lblDaysCountOfCurrentMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNowFormatted;
        private System.Windows.Forms.Timer tmrTick;
    }
}