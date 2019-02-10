namespace BilgeAdam.DatetimeString
{
    partial class frmSimpleGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimpleGame));
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.tmrCounter = new System.Windows.Forms.Timer(this.components);
            this.imlEmojis = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(744, 21);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(44, 42);
            this.btnRight.TabIndex = 0;
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(12, 21);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(44, 42);
            this.btnLeft.TabIndex = 1;
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // tmrCounter
            // 
            this.tmrCounter.Interval = 10;
            this.tmrCounter.Tick += new System.EventHandler(this.tmrCounter_Tick);
            // 
            // imlEmojis
            // 
            this.imlEmojis.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlEmojis.ImageStream")));
            this.imlEmojis.TransparentColor = System.Drawing.Color.Transparent;
            this.imlEmojis.Images.SetKeyName(0, "love.png");
            this.imlEmojis.Images.SetKeyName(1, "sad.png");
            // 
            // frmSimpleGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 87);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Name = "frmSimpleGame";
            this.Text = "frmSimpleGame";
            this.Load += new System.EventHandler(this.frmSimpleGame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Timer tmrCounter;
        private System.Windows.Forms.ImageList imlEmojis;
    }
}