﻿namespace SDP_SE1A_Group2
{
    partial class Staff_main
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalesRecord = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 108);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SDP_SE1A_Group2.Properties.Resources.cubeLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(51, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.btnSalesRecord);
            this.panel2.Controls.Add(this.btnReserve);
            this.panel2.Controls.Add(this.btnAttendence);
            this.panel2.Controls.Add(this.btnPOS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 756);
            this.panel2.TabIndex = 1;
            // 
            // btnSalesRecord
            // 
            this.btnSalesRecord.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalesRecord.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSalesRecord.ForeColor = System.Drawing.Color.White;
            this.btnSalesRecord.Location = new System.Drawing.Point(-27, 170);
            this.btnSalesRecord.Name = "btnSalesRecord";
            this.btnSalesRecord.Size = new System.Drawing.Size(237, 93);
            this.btnSalesRecord.TabIndex = 6;
            this.btnSalesRecord.Text = "SalesRecord";
            this.btnSalesRecord.UseVisualStyleBackColor = false;
            this.btnSalesRecord.Click += new System.EventHandler(this.btnSalesRecord_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReserve.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(-10, 83);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(220, 93);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnAttendence
            // 
            this.btnAttendence.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAttendence.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAttendence.ForeColor = System.Drawing.Color.White;
            this.btnAttendence.Location = new System.Drawing.Point(-10, 257);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(220, 101);
            this.btnAttendence.TabIndex = 3;
            this.btnAttendence.Text = "Attendence";
            this.btnAttendence.UseVisualStyleBackColor = false;
            this.btnAttendence.Click += new System.EventHandler(this.btnAttendence_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPOS.Font = new System.Drawing.Font("PMingLiU", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(-10, -4);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(220, 93);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.SkyBlue;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panelChildForm.Location = new System.Drawing.Point(200, 108);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1249, 756);
            this.panelChildForm.TabIndex = 2;
            // 
            // Staff_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 864);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Staff_main";
            this.Text = "Staff_main";
            this.Load += new System.EventHandler(this.Staff_main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalesRecord;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnAttendence;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}