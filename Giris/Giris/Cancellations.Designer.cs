namespace Giris
{
    partial class Cancellations
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CIdTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CancellationDGV = new System.Windows.Forms.DataGridView();
            this.CBackBtn = new System.Windows.Forms.Button();
            this.CResetBtn = new System.Windows.Forms.Button();
            this.CCancelBtn = new System.Windows.Forms.Button();
            this.TIdCb = new System.Windows.Forms.ComboBox();
            this.FCodeTb = new System.Windows.Forms.TextBox();
            this.CDateDt = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CExitLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CancellationDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "Flight Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(272, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 73;
            this.label4.Text = "Ticket ID";
            // 
            // CIdTb
            // 
            this.CIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CIdTb.ForeColor = System.Drawing.Color.Black;
            this.CIdTb.Location = new System.Drawing.Point(127, 94);
            this.CIdTb.Name = "CIdTb";
            this.CIdTb.Size = new System.Drawing.Size(125, 27);
            this.CIdTb.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(12, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 75;
            this.label5.Text = "Cancel ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(272, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 19);
            this.label6.TabIndex = 77;
            this.label6.Text = "Cancel of Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(224, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 19);
            this.label10.TabIndex = 90;
            this.label10.Text = "Cancellation List";
            // 
            // CancellationDGV
            // 
            this.CancellationDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CancellationDGV.Location = new System.Drawing.Point(26, 340);
            this.CancellationDGV.Name = "CancellationDGV";
            this.CancellationDGV.Size = new System.Drawing.Size(498, 193);
            this.CancellationDGV.TabIndex = 89;
            this.CancellationDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CancellationDGV_CellContentClick);
            // 
            // CBackBtn
            // 
            this.CBackBtn.BackColor = System.Drawing.Color.Navy;
            this.CBackBtn.FlatAppearance.BorderSize = 0;
            this.CBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBackBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CBackBtn.ForeColor = System.Drawing.Color.White;
            this.CBackBtn.Location = new System.Drawing.Point(341, 258);
            this.CBackBtn.Name = "CBackBtn";
            this.CBackBtn.Size = new System.Drawing.Size(120, 35);
            this.CBackBtn.TabIndex = 93;
            this.CBackBtn.Text = "Back";
            this.CBackBtn.UseVisualStyleBackColor = false;
            this.CBackBtn.Click += new System.EventHandler(this.CBackBtn_Click);
            // 
            // CResetBtn
            // 
            this.CResetBtn.BackColor = System.Drawing.Color.Navy;
            this.CResetBtn.FlatAppearance.BorderSize = 0;
            this.CResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CResetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CResetBtn.ForeColor = System.Drawing.Color.White;
            this.CResetBtn.Location = new System.Drawing.Point(215, 258);
            this.CResetBtn.Name = "CResetBtn";
            this.CResetBtn.Size = new System.Drawing.Size(120, 35);
            this.CResetBtn.TabIndex = 92;
            this.CResetBtn.Text = "Reset";
            this.CResetBtn.UseVisualStyleBackColor = false;
            this.CResetBtn.Click += new System.EventHandler(this.CResetBtn_Click);
            // 
            // CCancelBtn
            // 
            this.CCancelBtn.BackColor = System.Drawing.Color.Navy;
            this.CCancelBtn.FlatAppearance.BorderSize = 0;
            this.CCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CCancelBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CCancelBtn.ForeColor = System.Drawing.Color.White;
            this.CCancelBtn.Location = new System.Drawing.Point(89, 258);
            this.CCancelBtn.Name = "CCancelBtn";
            this.CCancelBtn.Size = new System.Drawing.Size(120, 35);
            this.CCancelBtn.TabIndex = 91;
            this.CCancelBtn.Text = "Cancel";
            this.CCancelBtn.UseVisualStyleBackColor = false;
            this.CCancelBtn.Click += new System.EventHandler(this.CCancelBtn_Click);
            // 
            // TIdCb
            // 
            this.TIdCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TIdCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TIdCb.ForeColor = System.Drawing.Color.Black;
            this.TIdCb.FormattingEnabled = true;
            this.TIdCb.Location = new System.Drawing.Point(413, 92);
            this.TIdCb.Name = "TIdCb";
            this.TIdCb.Size = new System.Drawing.Size(125, 29);
            this.TIdCb.TabIndex = 95;
            this.TIdCb.SelectionChangeCommitted += new System.EventHandler(this.TIdCb_SelectionChangeCommitted);
            // 
            // FCodeTb
            // 
            this.FCodeTb.Enabled = false;
            this.FCodeTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FCodeTb.ForeColor = System.Drawing.Color.Black;
            this.FCodeTb.Location = new System.Drawing.Point(127, 139);
            this.FCodeTb.Name = "FCodeTb";
            this.FCodeTb.Size = new System.Drawing.Size(125, 27);
            this.FCodeTb.TabIndex = 96;
            this.FCodeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CDateDt
            // 
            this.CDateDt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CDateDt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CDateDt.Location = new System.Drawing.Point(413, 137);
            this.CDateDt.Name = "CDateDt";
            this.CDateDt.Size = new System.Drawing.Size(125, 27);
            this.CDateDt.TabIndex = 97;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.CExitLbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 55);
            this.panel1.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(172, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Ticket Cancellation";
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
            // CExitLbl
            // 
            this.CExitLbl.AutoSize = true;
            this.CExitLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CExitLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.CExitLbl.Location = new System.Drawing.Point(511, 6);
            this.CExitLbl.Name = "CExitLbl";
            this.CExitLbl.Size = new System.Drawing.Size(23, 23);
            this.CExitLbl.TabIndex = 50;
            this.CExitLbl.Text = "X";
            this.CExitLbl.Click += new System.EventHandler(this.CExitLbl_Click);
            // 
            // Cancellations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CDateDt);
            this.Controls.Add(this.FCodeTb);
            this.Controls.Add(this.TIdCb);
            this.Controls.Add(this.CBackBtn);
            this.Controls.Add(this.CResetBtn);
            this.Controls.Add(this.CCancelBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CancellationDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CIdTb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cancellations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancellationTbl";
            this.Load += new System.EventHandler(this.CancellationTbl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CancellationDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView CancellationDGV;
        private System.Windows.Forms.Button CBackBtn;
        private System.Windows.Forms.Button CResetBtn;
        private System.Windows.Forms.Button CCancelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label CExitLbl;
        private System.Windows.Forms.TextBox CIdTb;
        private System.Windows.Forms.ComboBox TIdCb;
        private System.Windows.Forms.TextBox FCodeTb;
        private System.Windows.Forms.DateTimePicker CDateDt;
        private System.Windows.Forms.Label label2;
    }
}