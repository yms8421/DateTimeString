namespace BilgeAdam.DatetimeString
{
    partial class frmString
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
            this.txtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpper = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnTrim = new System.Windows.Forms.Button();
            this.btnLength = new System.Windows.Forms.Button();
            this.btnSubstring = new System.Windows.Forms.Button();
            this.btnPad = new System.Windows.Forms.Button();
            this.btnSplit = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.txtHelper = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEndStart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(57, 23);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(366, 20);
            this.txtText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metin";
            // 
            // btnUpper
            // 
            this.btnUpper.Location = new System.Drawing.Point(57, 86);
            this.btnUpper.Name = "btnUpper";
            this.btnUpper.Size = new System.Drawing.Size(87, 23);
            this.btnUpper.TabIndex = 2;
            this.btnUpper.Text = "Upper";
            this.btnUpper.UseVisualStyleBackColor = true;
            this.btnUpper.Click += new System.EventHandler(this.btnUpper_Click);
            // 
            // btnLower
            // 
            this.btnLower.Location = new System.Drawing.Point(150, 86);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(87, 23);
            this.btnLower.TabIndex = 2;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(243, 86);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(87, 23);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnTrim
            // 
            this.btnTrim.Location = new System.Drawing.Point(336, 85);
            this.btnTrim.Name = "btnTrim";
            this.btnTrim.Size = new System.Drawing.Size(87, 23);
            this.btnTrim.TabIndex = 2;
            this.btnTrim.Text = "Trim";
            this.btnTrim.UseVisualStyleBackColor = true;
            this.btnTrim.Click += new System.EventHandler(this.btnTrim_Click);
            // 
            // btnLength
            // 
            this.btnLength.Location = new System.Drawing.Point(57, 115);
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(87, 23);
            this.btnLength.TabIndex = 2;
            this.btnLength.Text = "Length";
            this.btnLength.UseVisualStyleBackColor = true;
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnSubstring
            // 
            this.btnSubstring.Location = new System.Drawing.Point(150, 115);
            this.btnSubstring.Name = "btnSubstring";
            this.btnSubstring.Size = new System.Drawing.Size(87, 23);
            this.btnSubstring.TabIndex = 2;
            this.btnSubstring.Text = "Substring";
            this.btnSubstring.UseVisualStyleBackColor = true;
            this.btnSubstring.Click += new System.EventHandler(this.btnSubstring_Click);
            // 
            // btnPad
            // 
            this.btnPad.Location = new System.Drawing.Point(243, 115);
            this.btnPad.Name = "btnPad";
            this.btnPad.Size = new System.Drawing.Size(87, 23);
            this.btnPad.TabIndex = 2;
            this.btnPad.Text = "Pad";
            this.btnPad.UseVisualStyleBackColor = true;
            this.btnPad.Click += new System.EventHandler(this.btnPad_Click);
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(336, 115);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(87, 23);
            this.btnSplit.TabIndex = 2;
            this.btnSplit.Text = "Split";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(8, 198);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(415, 248);
            this.rtbResult.TabIndex = 3;
            this.rtbResult.Text = "";
            // 
            // txtHelper
            // 
            this.txtHelper.Location = new System.Drawing.Point(57, 50);
            this.txtHelper.Name = "txtHelper";
            this.txtHelper.Size = new System.Drawing.Size(366, 20);
            this.txtHelper.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yardımcı";
            // 
            // btnEndStart
            // 
            this.btnEndStart.Location = new System.Drawing.Point(57, 144);
            this.btnEndStart.Name = "btnEndStart";
            this.btnEndStart.Size = new System.Drawing.Size(87, 23);
            this.btnEndStart.TabIndex = 6;
            this.btnEndStart.Text = "End && Start";
            this.btnEndStart.UseVisualStyleBackColor = true;
            this.btnEndStart.Click += new System.EventHandler(this.btnEndStart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(150, 144);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(87, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(243, 144);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 454);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEndStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHelper);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.btnTrim);
            this.Controls.Add(this.btnPad);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnSubstring);
            this.Controls.Add(this.btnLength);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnUpper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmString";
            this.Text = "Strings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpper;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnTrim;
        private System.Windows.Forms.Button btnLength;
        private System.Windows.Forms.Button btnSubstring;
        private System.Windows.Forms.Button btnPad;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.TextBox txtHelper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEndStart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
    }
}