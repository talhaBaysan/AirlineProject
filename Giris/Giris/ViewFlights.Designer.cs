namespace Giris
{
    partial class ViewFlights
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
            this.FDestCb = new System.Windows.Forms.ComboBox();
            this.FSrcCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FCapTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FDateDt = new System.Windows.Forms.DateTimePicker();
            this.FlightDGV = new System.Windows.Forms.DataGridView();
            this.VFResetBtn = new System.Windows.Forms.Button();
            this.VFDeleteBtn = new System.Windows.Forms.Button();
            this.VFUptadeBtn = new System.Windows.Forms.Button();
            this.VFBackBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.VFExitLbl = new System.Windows.Forms.Label();
            this.FCodeCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(175, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "View Schdule Flights";
            // 
            // FDestCb
            // 
            this.FDestCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FDestCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FDestCb.ForeColor = System.Drawing.Color.Black;
            this.FDestCb.FormattingEnabled = true;
            this.FDestCb.Items.AddRange(new object[] {
            "",
            "Washington DC",
            "London",
            "Beijing",
            "Paris",
            "Berlin",
            "Rome",
            "Lisbon",
            "Moscow",
            "Madrid",
            "Ankara",
            "Istanbul",
            "Kiev"});
            this.FDestCb.Location = new System.Drawing.Point(407, 159);
            this.FDestCb.Name = "FDestCb";
            this.FDestCb.Size = new System.Drawing.Size(125, 29);
            this.FDestCb.TabIndex = 31;
            // 
            // FSrcCb
            // 
            this.FSrcCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FSrcCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FSrcCb.ForeColor = System.Drawing.Color.Black;
            this.FSrcCb.FormattingEnabled = true;
            this.FSrcCb.Items.AddRange(new object[] {
            "",
            "Washington DC",
            "London",
            "Beijing",
            "Paris",
            "Berlin",
            "Rome",
            "Lisbon",
            "Moscow",
            "Madrid",
            "Ankara",
            "Istanbul",
            "Kiev"});
            this.FSrcCb.Location = new System.Drawing.Point(407, 113);
            this.FSrcCb.Name = "FSrcCb";
            this.FSrcCb.Size = new System.Drawing.Size(125, 29);
            this.FSrcCb.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(12, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Take of Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(278, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(278, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Source";
            // 
            // FCapTb
            // 
            this.FCapTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FCapTb.ForeColor = System.Drawing.Color.Black;
            this.FCapTb.Location = new System.Drawing.Point(268, 217);
            this.FCapTb.Name = "FCapTb";
            this.FCapTb.Size = new System.Drawing.Size(123, 27);
            this.FCapTb.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(137, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Num of Seats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Flight Code";
            // 
            // FDateDt
            // 
            this.FDateDt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FDateDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FDateDt.Location = new System.Drawing.Point(142, 161);
            this.FDateDt.Name = "FDateDt";
            this.FDateDt.Size = new System.Drawing.Size(124, 27);
            this.FDateDt.TabIndex = 32;
            // 
            // FlightDGV
            // 
            this.FlightDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FlightDGV.Location = new System.Drawing.Point(16, 345);
            this.FlightDGV.Name = "FlightDGV";
            this.FlightDGV.Size = new System.Drawing.Size(498, 193);
            this.FlightDGV.TabIndex = 33;
            this.FlightDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FlightDGV_CellContentClick);
            // 
            // VFResetBtn
            // 
            this.VFResetBtn.BackColor = System.Drawing.Color.Navy;
            this.VFResetBtn.FlatAppearance.BorderSize = 0;
            this.VFResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VFResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VFResetBtn.ForeColor = System.Drawing.Color.White;
            this.VFResetBtn.Location = new System.Drawing.Point(268, 287);
            this.VFResetBtn.Name = "VFResetBtn";
            this.VFResetBtn.Size = new System.Drawing.Size(120, 35);
            this.VFResetBtn.TabIndex = 36;
            this.VFResetBtn.Text = "Reset";
            this.VFResetBtn.UseVisualStyleBackColor = false;
            this.VFResetBtn.Click += new System.EventHandler(this.VFResetBtn_Click);
            // 
            // VFDeleteBtn
            // 
            this.VFDeleteBtn.BackColor = System.Drawing.Color.Navy;
            this.VFDeleteBtn.FlatAppearance.BorderSize = 0;
            this.VFDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VFDeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VFDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.VFDeleteBtn.Location = new System.Drawing.Point(142, 287);
            this.VFDeleteBtn.Name = "VFDeleteBtn";
            this.VFDeleteBtn.Size = new System.Drawing.Size(120, 35);
            this.VFDeleteBtn.TabIndex = 35;
            this.VFDeleteBtn.Text = "Delete";
            this.VFDeleteBtn.UseVisualStyleBackColor = false;
            this.VFDeleteBtn.Click += new System.EventHandler(this.VFDeleteBtn_Click);
            // 
            // VFUptadeBtn
            // 
            this.VFUptadeBtn.BackColor = System.Drawing.Color.Navy;
            this.VFUptadeBtn.FlatAppearance.BorderSize = 0;
            this.VFUptadeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VFUptadeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VFUptadeBtn.ForeColor = System.Drawing.Color.White;
            this.VFUptadeBtn.Location = new System.Drawing.Point(16, 287);
            this.VFUptadeBtn.Name = "VFUptadeBtn";
            this.VFUptadeBtn.Size = new System.Drawing.Size(120, 35);
            this.VFUptadeBtn.TabIndex = 34;
            this.VFUptadeBtn.Text = "Update";
            this.VFUptadeBtn.UseVisualStyleBackColor = false;
            this.VFUptadeBtn.Click += new System.EventHandler(this.VFUptadeBtn_Click);
            // 
            // VFBackBtn
            // 
            this.VFBackBtn.BackColor = System.Drawing.Color.Navy;
            this.VFBackBtn.FlatAppearance.BorderSize = 0;
            this.VFBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VFBackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VFBackBtn.ForeColor = System.Drawing.Color.White;
            this.VFBackBtn.Location = new System.Drawing.Point(394, 287);
            this.VFBackBtn.Name = "VFBackBtn";
            this.VFBackBtn.Size = new System.Drawing.Size(120, 35);
            this.VFBackBtn.TabIndex = 37;
            this.VFBackBtn.Text = "Back";
            this.VFBackBtn.UseVisualStyleBackColor = false;
            this.VFBackBtn.Click += new System.EventHandler(this.VFBackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.VFExitLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 55);
            this.panel1.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(196, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Baysan Airline";
            // 
            // VFExitLbl
            // 
            this.VFExitLbl.AutoSize = true;
            this.VFExitLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VFExitLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.VFExitLbl.Location = new System.Drawing.Point(511, 6);
            this.VFExitLbl.Name = "VFExitLbl";
            this.VFExitLbl.Size = new System.Drawing.Size(23, 23);
            this.VFExitLbl.TabIndex = 50;
            this.VFExitLbl.Text = "X";
            this.VFExitLbl.Click += new System.EventHandler(this.VFExitLbl_Click);
            // 
            // FCodeCb
            // 
            this.FCodeCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FCodeCb.ForeColor = System.Drawing.Color.Black;
            this.FCodeCb.FormattingEnabled = true;
            this.FCodeCb.Location = new System.Drawing.Point(141, 107);
            this.FCodeCb.Name = "FCodeCb";
            this.FCodeCb.Size = new System.Drawing.Size(125, 29);
            this.FCodeCb.TabIndex = 92;
            this.FCodeCb.SelectionChangeCommitted += new System.EventHandler(this.FCodeCb_SelectionChangeCommitted);
            // 
            // ViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.FCodeCb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VFBackBtn);
            this.Controls.Add(this.VFResetBtn);
            this.Controls.Add(this.VFDeleteBtn);
            this.Controls.Add(this.VFUptadeBtn);
            this.Controls.Add(this.FlightDGV);
            this.Controls.Add(this.FDateDt);
            this.Controls.Add(this.FDestCb);
            this.Controls.Add(this.FSrcCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FCapTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFlights";
            this.Load += new System.EventHandler(this.ViewFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FlightDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FDestCb;
        private System.Windows.Forms.ComboBox FSrcCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FCapTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FDateDt;
        private System.Windows.Forms.DataGridView FlightDGV;
        private System.Windows.Forms.Button VFResetBtn;
        private System.Windows.Forms.Button VFDeleteBtn;
        private System.Windows.Forms.Button VFUptadeBtn;
        private System.Windows.Forms.Button VFBackBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label VFExitLbl;
        private System.Windows.Forms.ComboBox FCodeCb;
    }
}