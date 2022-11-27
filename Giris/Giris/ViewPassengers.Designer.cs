namespace Giris
{
    partial class ViewPassengers
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
            this.label2 = new System.Windows.Forms.Label();
            this.PaddTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PpassTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PnameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GendCb = new System.Windows.Forms.ComboBox();
            this.NatCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PphoneTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VPBackBtn = new System.Windows.Forms.Button();
            this.VPResetBtn = new System.Windows.Forms.Button();
            this.VPDeleteBtn = new System.Windows.Forms.Button();
            this.VPUpdateBtn = new System.Windows.Forms.Button();
            this.PassangerDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.VPExitLbl = new System.Windows.Forms.Label();
            this.PidCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PassangerDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(185, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "View Passengers";
            // 
            // PaddTb
            // 
            this.PaddTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PaddTb.ForeColor = System.Drawing.Color.Black;
            this.PaddTb.Location = new System.Drawing.Point(401, 95);
            this.PaddTb.Name = "PaddTb";
            this.PaddTb.Size = new System.Drawing.Size(125, 27);
            this.PaddTb.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(272, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "Address";
            // 
            // PpassTb
            // 
            this.PpassTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PpassTb.ForeColor = System.Drawing.Color.Black;
            this.PpassTb.Location = new System.Drawing.Point(141, 167);
            this.PpassTb.Name = "PpassTb";
            this.PpassTb.Size = new System.Drawing.Size(125, 27);
            this.PpassTb.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(12, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = "Passport";
            // 
            // PnameTb
            // 
            this.PnameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PnameTb.ForeColor = System.Drawing.Color.Black;
            this.PnameTb.Location = new System.Drawing.Point(142, 131);
            this.PnameTb.Name = "PnameTb";
            this.PnameTb.Size = new System.Drawing.Size(124, 27);
            this.PnameTb.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 56;
            this.label6.Text = "Name";
            // 
            // GendCb
            // 
            this.GendCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GendCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GendCb.ForeColor = System.Drawing.Color.Black;
            this.GendCb.FormattingEnabled = true;
            this.GendCb.Items.AddRange(new object[] {
            "",
            "MALE",
            "FEMALE"});
            this.GendCb.Location = new System.Drawing.Point(401, 167);
            this.GendCb.Name = "GendCb";
            this.GendCb.Size = new System.Drawing.Size(125, 29);
            this.GendCb.TabIndex = 55;
            // 
            // NatCb
            // 
            this.NatCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NatCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NatCb.ForeColor = System.Drawing.Color.Black;
            this.NatCb.FormattingEnabled = true;
            this.NatCb.Items.AddRange(new object[] {
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
            this.NatCb.Location = new System.Drawing.Point(401, 131);
            this.NatCb.Name = "NatCb";
            this.NatCb.Size = new System.Drawing.Size(125, 29);
            this.NatCb.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(272, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(272, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nationality";
            // 
            // PphoneTb
            // 
            this.PphoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PphoneTb.ForeColor = System.Drawing.Color.Black;
            this.PphoneTb.Location = new System.Drawing.Point(239, 218);
            this.PphoneTb.Name = "PphoneTb";
            this.PphoneTb.Size = new System.Drawing.Size(125, 27);
            this.PphoneTb.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(162, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 50;
            this.label7.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Passenger ID";
            // 
            // VPBackBtn
            // 
            this.VPBackBtn.BackColor = System.Drawing.Color.Navy;
            this.VPBackBtn.FlatAppearance.BorderSize = 0;
            this.VPBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VPBackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VPBackBtn.ForeColor = System.Drawing.Color.White;
            this.VPBackBtn.Location = new System.Drawing.Point(394, 287);
            this.VPBackBtn.Name = "VPBackBtn";
            this.VPBackBtn.Size = new System.Drawing.Size(120, 35);
            this.VPBackBtn.TabIndex = 66;
            this.VPBackBtn.Text = "Back";
            this.VPBackBtn.UseVisualStyleBackColor = false;
            this.VPBackBtn.Click += new System.EventHandler(this.VPBackBtn_Click);
            // 
            // VPResetBtn
            // 
            this.VPResetBtn.BackColor = System.Drawing.Color.Navy;
            this.VPResetBtn.FlatAppearance.BorderSize = 0;
            this.VPResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VPResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VPResetBtn.ForeColor = System.Drawing.Color.White;
            this.VPResetBtn.Location = new System.Drawing.Point(268, 287);
            this.VPResetBtn.Name = "VPResetBtn";
            this.VPResetBtn.Size = new System.Drawing.Size(120, 35);
            this.VPResetBtn.TabIndex = 65;
            this.VPResetBtn.Text = "Reset";
            this.VPResetBtn.UseVisualStyleBackColor = false;
            this.VPResetBtn.Click += new System.EventHandler(this.VPResetBtn_Click);
            // 
            // VPDeleteBtn
            // 
            this.VPDeleteBtn.BackColor = System.Drawing.Color.Navy;
            this.VPDeleteBtn.FlatAppearance.BorderSize = 0;
            this.VPDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VPDeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VPDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.VPDeleteBtn.Location = new System.Drawing.Point(142, 287);
            this.VPDeleteBtn.Name = "VPDeleteBtn";
            this.VPDeleteBtn.Size = new System.Drawing.Size(120, 35);
            this.VPDeleteBtn.TabIndex = 64;
            this.VPDeleteBtn.Text = "Delete";
            this.VPDeleteBtn.UseVisualStyleBackColor = false;
            this.VPDeleteBtn.Click += new System.EventHandler(this.VPDeleteBtn_Click);
            // 
            // VPUpdateBtn
            // 
            this.VPUpdateBtn.BackColor = System.Drawing.Color.Navy;
            this.VPUpdateBtn.FlatAppearance.BorderSize = 0;
            this.VPUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VPUpdateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VPUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.VPUpdateBtn.Location = new System.Drawing.Point(16, 287);
            this.VPUpdateBtn.Name = "VPUpdateBtn";
            this.VPUpdateBtn.Size = new System.Drawing.Size(120, 35);
            this.VPUpdateBtn.TabIndex = 63;
            this.VPUpdateBtn.Text = "Update";
            this.VPUpdateBtn.UseVisualStyleBackColor = false;
            this.VPUpdateBtn.Click += new System.EventHandler(this.VPUpdateBtn_Click);
            // 
            // PassangerDGV
            // 
            this.PassangerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassangerDGV.Location = new System.Drawing.Point(16, 337);
            this.PassangerDGV.Name = "PassangerDGV";
            this.PassangerDGV.Size = new System.Drawing.Size(498, 193);
            this.PassangerDGV.TabIndex = 62;
            this.PassangerDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PassangerDGV_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.VPExitLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 55);
            this.panel1.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(196, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 23);
            this.label10.TabIndex = 2;
            this.label10.Text = "Baysan Airline";
            // 
            // VPExitLbl
            // 
            this.VPExitLbl.AutoSize = true;
            this.VPExitLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VPExitLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.VPExitLbl.Location = new System.Drawing.Point(511, 6);
            this.VPExitLbl.Name = "VPExitLbl";
            this.VPExitLbl.Size = new System.Drawing.Size(23, 23);
            this.VPExitLbl.TabIndex = 50;
            this.VPExitLbl.Text = "X";
            this.VPExitLbl.Click += new System.EventHandler(this.VPExitLbl_Click);
            // 
            // PidCb
            // 
            this.PidCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PidCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PidCb.ForeColor = System.Drawing.Color.Black;
            this.PidCb.FormattingEnabled = true;
            this.PidCb.Items.AddRange(new object[] {
            "",
            ""});
            this.PidCb.Location = new System.Drawing.Point(142, 95);
            this.PidCb.Name = "PidCb";
            this.PidCb.Size = new System.Drawing.Size(124, 29);
            this.PidCb.TabIndex = 92;
            this.PidCb.SelectionChangeCommitted += new System.EventHandler(this.PidCb_SelectionChangeCommitted);
            // 
            // ViewPassengers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.PidCb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VPBackBtn);
            this.Controls.Add(this.VPResetBtn);
            this.Controls.Add(this.VPDeleteBtn);
            this.Controls.Add(this.VPUpdateBtn);
            this.Controls.Add(this.PassangerDGV);
            this.Controls.Add(this.PaddTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PpassTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PnameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GendCb);
            this.Controls.Add(this.NatCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PphoneTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPassengers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassengers";
            this.Load += new System.EventHandler(this.ViewPassengers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PassangerDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PaddTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PpassTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PnameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox GendCb;
        private System.Windows.Forms.ComboBox NatCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PphoneTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button VPBackBtn;
        private System.Windows.Forms.Button VPResetBtn;
        private System.Windows.Forms.Button VPDeleteBtn;
        private System.Windows.Forms.Button VPUpdateBtn;
        private System.Windows.Forms.DataGridView PassangerDGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label VPExitLbl;
        private System.Windows.Forms.ComboBox PidCb;
    }
}