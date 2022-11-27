namespace Giris
{
    partial class Tickets
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
            this.TBackBtn = new System.Windows.Forms.Button();
            this.TResetBtn = new System.Windows.Forms.Button();
            this.TBookingBtn = new System.Windows.Forms.Button();
            this.TicketDGV = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.PPassTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TIdTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PNameTb = new System.Windows.Forms.TextBox();
            this.FCodeCb = new System.Windows.Forms.ComboBox();
            this.PIdCb = new System.Windows.Forms.ComboBox();
            this.PNatTb = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.TExitLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBackBtn
            // 
            this.TBackBtn.BackColor = System.Drawing.Color.Navy;
            this.TBackBtn.FlatAppearance.BorderSize = 0;
            this.TBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TBackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBackBtn.ForeColor = System.Drawing.Color.White;
            this.TBackBtn.Location = new System.Drawing.Point(334, 265);
            this.TBackBtn.Name = "TBackBtn";
            this.TBackBtn.Size = new System.Drawing.Size(120, 35);
            this.TBackBtn.TabIndex = 87;
            this.TBackBtn.Text = "Back";
            this.TBackBtn.UseVisualStyleBackColor = false;
            this.TBackBtn.Click += new System.EventHandler(this.TBackBtn_Click);
            // 
            // TResetBtn
            // 
            this.TResetBtn.BackColor = System.Drawing.Color.Navy;
            this.TResetBtn.FlatAppearance.BorderSize = 0;
            this.TResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TResetBtn.ForeColor = System.Drawing.Color.White;
            this.TResetBtn.Location = new System.Drawing.Point(208, 265);
            this.TResetBtn.Name = "TResetBtn";
            this.TResetBtn.Size = new System.Drawing.Size(120, 35);
            this.TResetBtn.TabIndex = 86;
            this.TResetBtn.Text = "Reset";
            this.TResetBtn.UseVisualStyleBackColor = false;
            this.TResetBtn.Click += new System.EventHandler(this.TResetBtn_Click);
            // 
            // TBookingBtn
            // 
            this.TBookingBtn.BackColor = System.Drawing.Color.Navy;
            this.TBookingBtn.FlatAppearance.BorderSize = 0;
            this.TBookingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TBookingBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBookingBtn.ForeColor = System.Drawing.Color.White;
            this.TBookingBtn.Location = new System.Drawing.Point(82, 265);
            this.TBookingBtn.Name = "TBookingBtn";
            this.TBookingBtn.Size = new System.Drawing.Size(120, 35);
            this.TBookingBtn.TabIndex = 85;
            this.TBookingBtn.Text = "Booking";
            this.TBookingBtn.UseVisualStyleBackColor = false;
            this.TBookingBtn.Click += new System.EventHandler(this.TBookingBtn_Click);
            // 
            // TicketDGV
            // 
            this.TicketDGV.Location = new System.Drawing.Point(12, 334);
            this.TicketDGV.Name = "TicketDGV";
            this.TicketDGV.Size = new System.Drawing.Size(526, 204);
            this.TicketDGV.TabIndex = 93;
            this.TicketDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDGV_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(278, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 81;
            this.label9.Text = "Flight Code";
            // 
            // PPassTb
            // 
            this.PPassTb.Enabled = false;
            this.PPassTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PPassTb.ForeColor = System.Drawing.Color.Black;
            this.PPassTb.Location = new System.Drawing.Point(147, 164);
            this.PPassTb.Name = "PPassTb";
            this.PPassTb.Size = new System.Drawing.Size(125, 27);
            this.PPassTb.TabIndex = 80;
            this.PPassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(18, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 19);
            this.label8.TabIndex = 79;
            this.label8.Text = "Passport";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(18, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 77;
            this.label6.Text = "Passenger ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(278, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "Nationality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(278, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "Name";
            // 
            // AmountTb
            // 
            this.AmountTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AmountTb.ForeColor = System.Drawing.Color.Black;
            this.AmountTb.Location = new System.Drawing.Point(250, 220);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(125, 27);
            this.AmountTb.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(168, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 71;
            this.label7.Text = "Amount";
            // 
            // TIdTb
            // 
            this.TIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TIdTb.ForeColor = System.Drawing.Color.Black;
            this.TIdTb.Location = new System.Drawing.Point(147, 97);
            this.TIdTb.Name = "TIdTb";
            this.TIdTb.Size = new System.Drawing.Size(125, 27);
            this.TIdTb.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(18, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 69;
            this.label3.Text = "Ticket ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(195, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 68;
            this.label2.Text = "Ticket Booking";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(220, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 19);
            this.label10.TabIndex = 88;
            this.label10.Text = "Bookings";
            // 
            // PNameTb
            // 
            this.PNameTb.Enabled = false;
            this.PNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PNameTb.ForeColor = System.Drawing.Color.Black;
            this.PNameTb.Location = new System.Drawing.Point(408, 135);
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(124, 27);
            this.PNameTb.TabIndex = 89;
            this.PNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FCodeCb
            // 
            this.FCodeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FCodeCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FCodeCb.ForeColor = System.Drawing.Color.Black;
            this.FCodeCb.FormattingEnabled = true;
            this.FCodeCb.Location = new System.Drawing.Point(408, 97);
            this.FCodeCb.Name = "FCodeCb";
            this.FCodeCb.Size = new System.Drawing.Size(124, 29);
            this.FCodeCb.TabIndex = 90;
            // 
            // PIdCb
            // 
            this.PIdCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PIdCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PIdCb.ForeColor = System.Drawing.Color.Black;
            this.PIdCb.FormattingEnabled = true;
            this.PIdCb.Location = new System.Drawing.Point(147, 129);
            this.PIdCb.Name = "PIdCb";
            this.PIdCb.Size = new System.Drawing.Size(125, 29);
            this.PIdCb.TabIndex = 91;
            this.PIdCb.SelectionChangeCommitted += new System.EventHandler(this.PIdCb_SelectionChangeCommitted);
            // 
            // PNatTb
            // 
            this.PNatTb.Enabled = false;
            this.PNatTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PNatTb.ForeColor = System.Drawing.Color.Black;
            this.PNatTb.Location = new System.Drawing.Point(408, 173);
            this.PNatTb.Name = "PNatTb";
            this.PNatTb.Size = new System.Drawing.Size(124, 27);
            this.PNatTb.TabIndex = 92;
            this.PNatTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.TExitLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 55);
            this.panel1.TabIndex = 94;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(196, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Baysan Airline";
            // 
            // TExitLbl
            // 
            this.TExitLbl.AutoSize = true;
            this.TExitLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TExitLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TExitLbl.Location = new System.Drawing.Point(511, 6);
            this.TExitLbl.Name = "TExitLbl";
            this.TExitLbl.Size = new System.Drawing.Size(23, 23);
            this.TExitLbl.TabIndex = 50;
            this.TExitLbl.Text = "X";
            this.TExitLbl.Click += new System.EventHandler(this.TExitLbl_Click);
            // 
            // Tickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PNatTb);
            this.Controls.Add(this.PIdCb);
            this.Controls.Add(this.FCodeCb);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TBackBtn);
            this.Controls.Add(this.TResetBtn);
            this.Controls.Add(this.TBookingBtn);
            this.Controls.Add(this.TicketDGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PPassTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TIdTb);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tickets";
            this.Load += new System.EventHandler(this.Tickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TBackBtn;
        private System.Windows.Forms.Button TResetBtn;
        private System.Windows.Forms.Button TBookingBtn;
        private System.Windows.Forms.DataGridView TicketDGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PPassTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TIdTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PNameTb;
        private System.Windows.Forms.ComboBox FCodeCb;
        private System.Windows.Forms.ComboBox PIdCb;
        private System.Windows.Forms.TextBox PNatTb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TExitLbl;
    }
}