namespace Giris
{
    partial class Passengers
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
            this.ViewPassengerBtn = new System.Windows.Forms.Button();
            this.PBackBtn = new System.Windows.Forms.Button();
            this.PResetBtn = new System.Windows.Forms.Button();
            this.PRecordBtn = new System.Windows.Forms.Button();
            this.GenderCb = new System.Windows.Forms.ComboBox();
            this.NationalityCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PhoneTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PassId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PassportTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PassAd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PExitLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewPassengerBtn
            // 
            this.ViewPassengerBtn.BackColor = System.Drawing.Color.Navy;
            this.ViewPassengerBtn.FlatAppearance.BorderSize = 0;
            this.ViewPassengerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewPassengerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ViewPassengerBtn.ForeColor = System.Drawing.Color.White;
            this.ViewPassengerBtn.Location = new System.Drawing.Point(199, 463);
            this.ViewPassengerBtn.Name = "ViewPassengerBtn";
            this.ViewPassengerBtn.Size = new System.Drawing.Size(152, 35);
            this.ViewPassengerBtn.TabIndex = 41;
            this.ViewPassengerBtn.Text = "View Passengers";
            this.ViewPassengerBtn.UseVisualStyleBackColor = false;
            this.ViewPassengerBtn.Click += new System.EventHandler(this.ViewPassengerBtn_Click);
            // 
            // PBackBtn
            // 
            this.PBackBtn.BackColor = System.Drawing.Color.Navy;
            this.PBackBtn.FlatAppearance.BorderSize = 0;
            this.PBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PBackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PBackBtn.ForeColor = System.Drawing.Color.White;
            this.PBackBtn.Location = new System.Drawing.Point(344, 405);
            this.PBackBtn.Name = "PBackBtn";
            this.PBackBtn.Size = new System.Drawing.Size(120, 35);
            this.PBackBtn.TabIndex = 40;
            this.PBackBtn.Text = "Back";
            this.PBackBtn.UseVisualStyleBackColor = false;
            this.PBackBtn.Click += new System.EventHandler(this.PBackBtn_Click);
            // 
            // PResetBtn
            // 
            this.PResetBtn.BackColor = System.Drawing.Color.Navy;
            this.PResetBtn.FlatAppearance.BorderSize = 0;
            this.PResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PResetBtn.ForeColor = System.Drawing.Color.White;
            this.PResetBtn.Location = new System.Drawing.Point(218, 405);
            this.PResetBtn.Name = "PResetBtn";
            this.PResetBtn.Size = new System.Drawing.Size(120, 35);
            this.PResetBtn.TabIndex = 39;
            this.PResetBtn.Text = "Reset";
            this.PResetBtn.UseVisualStyleBackColor = false;
            this.PResetBtn.Click += new System.EventHandler(this.PResetBtn_Click);
            // 
            // PRecordBtn
            // 
            this.PRecordBtn.BackColor = System.Drawing.Color.Navy;
            this.PRecordBtn.FlatAppearance.BorderSize = 0;
            this.PRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PRecordBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PRecordBtn.ForeColor = System.Drawing.Color.White;
            this.PRecordBtn.Location = new System.Drawing.Point(92, 405);
            this.PRecordBtn.Name = "PRecordBtn";
            this.PRecordBtn.Size = new System.Drawing.Size(120, 35);
            this.PRecordBtn.TabIndex = 38;
            this.PRecordBtn.Text = "Record";
            this.PRecordBtn.UseVisualStyleBackColor = false;
            this.PRecordBtn.Click += new System.EventHandler(this.PRecordBtn_Click);
            // 
            // GenderCb
            // 
            this.GenderCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenderCb.ForeColor = System.Drawing.Color.Black;
            this.GenderCb.FormattingEnabled = true;
            this.GenderCb.Items.AddRange(new object[] {
            "",
            "MALE",
            "FEMALE"});
            this.GenderCb.Location = new System.Drawing.Point(140, 282);
            this.GenderCb.Name = "GenderCb";
            this.GenderCb.Size = new System.Drawing.Size(126, 29);
            this.GenderCb.TabIndex = 37;
            // 
            // NationalityCb
            // 
            this.NationalityCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NationalityCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NationalityCb.ForeColor = System.Drawing.Color.Black;
            this.NationalityCb.FormattingEnabled = true;
            this.NationalityCb.Items.AddRange(new object[] {
            "",
            "American",
            "British",
            "Chinese",
            "French",
            "German",
            "Italian",
            "Portuguese",
            "Russian",
            "Spanish",
            "Turkish",
            "Ukrainian"});
            this.NationalityCb.Location = new System.Drawing.Point(140, 248);
            this.NationalityCb.Name = "NationalityCb";
            this.NationalityCb.Size = new System.Drawing.Size(126, 29);
            this.NationalityCb.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(12, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nationality";
            // 
            // PhoneTb
            // 
            this.PhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PhoneTb.ForeColor = System.Drawing.Color.Black;
            this.PhoneTb.Location = new System.Drawing.Point(140, 316);
            this.PhoneTb.Name = "PhoneTb";
            this.PhoneTb.Size = new System.Drawing.Size(126, 27);
            this.PhoneTb.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(12, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Phone";
            // 
            // PassId
            // 
            this.PassId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PassId.ForeColor = System.Drawing.Color.Black;
            this.PassId.Location = new System.Drawing.Point(140, 99);
            this.PassId.Name = "PassId";
            this.PassId.Size = new System.Drawing.Size(126, 27);
            this.PassId.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Passenger ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(145, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Record New Passengers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Baysan Airline";
            // 
            // PassName
            // 
            this.PassName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PassName.ForeColor = System.Drawing.Color.Black;
            this.PassName.Location = new System.Drawing.Point(140, 135);
            this.PassName.Name = "PassName";
            this.PassName.Size = new System.Drawing.Size(126, 27);
            this.PassName.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "Name";
            // 
            // PassportTb
            // 
            this.PassportTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PassportTb.ForeColor = System.Drawing.Color.Black;
            this.PassportTb.Location = new System.Drawing.Point(140, 171);
            this.PassportTb.Name = "PassportTb";
            this.PassportTb.Size = new System.Drawing.Size(126, 27);
            this.PassportTb.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "Passport";
            // 
            // PassAd
            // 
            this.PassAd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PassAd.ForeColor = System.Drawing.Color.Black;
            this.PassAd.Location = new System.Drawing.Point(140, 210);
            this.PassAd.Name = "PassAd";
            this.PassAd.Size = new System.Drawing.Size(126, 27);
            this.PassAd.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(12, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 46;
            this.label9.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.PExitLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 55);
            this.panel1.TabIndex = 48;
            // 
            // PExitLbl
            // 
            this.PExitLbl.AutoSize = true;
            this.PExitLbl.BackColor = System.Drawing.Color.Red;
            this.PExitLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PExitLbl.ForeColor = System.Drawing.Color.White;
            this.PExitLbl.Location = new System.Drawing.Point(519, 7);
            this.PExitLbl.Name = "PExitLbl";
            this.PExitLbl.Size = new System.Drawing.Size(23, 23);
            this.PExitLbl.TabIndex = 49;
            this.PExitLbl.Text = "X";
            this.PExitLbl.Click += new System.EventHandler(this.PExitLbl_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 511);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 39);
            this.panel2.TabIndex = 53;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Giris.Properties.Resources.Passenger1;
            this.pictureBox1.Location = new System.Drawing.Point(272, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // Passengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PassAd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PassportTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PassName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ViewPassengerBtn);
            this.Controls.Add(this.PBackBtn);
            this.Controls.Add(this.PResetBtn);
            this.Controls.Add(this.PRecordBtn);
            this.Controls.Add(this.GenderCb);
            this.Controls.Add(this.NationalityCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PassId);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Passengers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassenger";
            this.Load += new System.EventHandler(this.AddPassenger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewPassengerBtn;
        private System.Windows.Forms.Button PBackBtn;
        private System.Windows.Forms.Button PResetBtn;
        private System.Windows.Forms.Button PRecordBtn;
        private System.Windows.Forms.ComboBox GenderCb;
        private System.Windows.Forms.ComboBox NationalityCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PhoneTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PassId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PassportTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PassAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label PExitLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}