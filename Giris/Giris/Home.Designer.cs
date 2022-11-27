namespace Giris
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.HExit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancellation = new System.Windows.Forms.Button();
            this.Ticket = new System.Windows.Forms.Button();
            this.Passenger = new System.Windows.Forms.Button();
            this.Flight = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.HExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 61);
            this.panel1.TabIndex = 0;
            // 
            // HExit
            // 
            this.HExit.AutoSize = true;
            this.HExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HExit.ForeColor = System.Drawing.Color.White;
            this.HExit.Location = new System.Drawing.Point(524, 9);
            this.HExit.Name = "HExit";
            this.HExit.Size = new System.Drawing.Size(23, 23);
            this.HExit.TabIndex = 42;
            this.HExit.Text = "X";
            this.HExit.Click += new System.EventHandler(this.HExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Baysan Airline";
            // 
            // Cancellation
            // 
            this.Cancellation.BackColor = System.Drawing.Color.Navy;
            this.Cancellation.FlatAppearance.BorderSize = 0;
            this.Cancellation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancellation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cancellation.ForeColor = System.Drawing.Color.White;
            this.Cancellation.Location = new System.Drawing.Point(403, 300);
            this.Cancellation.Name = "Cancellation";
            this.Cancellation.Size = new System.Drawing.Size(120, 35);
            this.Cancellation.TabIndex = 41;
            this.Cancellation.TabStop = false;
            this.Cancellation.Text = "Cancellation";
            this.Cancellation.UseVisualStyleBackColor = false;
            this.Cancellation.Click += new System.EventHandler(this.Cancellation_Click);
            // 
            // Ticket
            // 
            this.Ticket.BackColor = System.Drawing.Color.Navy;
            this.Ticket.FlatAppearance.BorderSize = 0;
            this.Ticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ticket.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ticket.ForeColor = System.Drawing.Color.White;
            this.Ticket.Location = new System.Drawing.Point(277, 300);
            this.Ticket.Name = "Ticket";
            this.Ticket.Size = new System.Drawing.Size(120, 35);
            this.Ticket.TabIndex = 40;
            this.Ticket.TabStop = false;
            this.Ticket.Text = "Ticket";
            this.Ticket.UseVisualStyleBackColor = false;
            this.Ticket.Click += new System.EventHandler(this.Ticket_Click);
            // 
            // Passenger
            // 
            this.Passenger.BackColor = System.Drawing.Color.Navy;
            this.Passenger.FlatAppearance.BorderSize = 0;
            this.Passenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Passenger.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Passenger.ForeColor = System.Drawing.Color.White;
            this.Passenger.Location = new System.Drawing.Point(151, 300);
            this.Passenger.Name = "Passenger";
            this.Passenger.Size = new System.Drawing.Size(120, 35);
            this.Passenger.TabIndex = 39;
            this.Passenger.TabStop = false;
            this.Passenger.Text = "Passenger";
            this.Passenger.UseVisualStyleBackColor = false;
            this.Passenger.Click += new System.EventHandler(this.Passenger_Click);
            // 
            // Flight
            // 
            this.Flight.BackColor = System.Drawing.Color.Navy;
            this.Flight.FlatAppearance.BorderSize = 0;
            this.Flight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Flight.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Flight.ForeColor = System.Drawing.Color.White;
            this.Flight.Location = new System.Drawing.Point(25, 300);
            this.Flight.Name = "Flight";
            this.Flight.Size = new System.Drawing.Size(120, 35);
            this.Flight.TabIndex = 38;
            this.Flight.TabStop = false;
            this.Flight.Text = "Flight";
            this.Flight.UseVisualStyleBackColor = false;
            this.Flight.Click += new System.EventHandler(this.Flight_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Giris.Properties.Resources.Home1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancellation);
            this.Controls.Add(this.Ticket);
            this.Controls.Add(this.Passenger);
            this.Controls.Add(this.Flight);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancellation;
        private System.Windows.Forms.Button Ticket;
        private System.Windows.Forms.Button Passenger;
        private System.Windows.Forms.Button Flight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}