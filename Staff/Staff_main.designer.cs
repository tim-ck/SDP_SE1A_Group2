namespace SDP_SE1A_Group2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalesRecord = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Controls.Add(this.btnSalesRecord);
            this.panel2.Controls.Add(this.btnReserve);
            this.panel2.Controls.Add(this.btnAttendence);
            this.panel2.Controls.Add(this.btnPOS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 512);
            this.panel2.TabIndex = 1;
            // 
            // btnSalesRecord
            // 
            this.btnSalesRecord.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSalesRecord.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSalesRecord.ForeColor = System.Drawing.Color.White;
            this.btnSalesRecord.Location = new System.Drawing.Point(-27, 157);
            this.btnSalesRecord.Name = "btnSalesRecord";
            this.btnSalesRecord.Size = new System.Drawing.Size(237, 86);
            this.btnSalesRecord.TabIndex = 6;
            this.btnSalesRecord.Text = "SalesRecord";
            this.btnSalesRecord.UseVisualStyleBackColor = false;
            this.btnSalesRecord.Click += new System.EventHandler(this.btnSalesRecord_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReserve.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReserve.ForeColor = System.Drawing.Color.White;
            this.btnReserve.Location = new System.Drawing.Point(-10, 77);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(220, 86);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnAttendence
            // 
            this.btnAttendence.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAttendence.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAttendence.ForeColor = System.Drawing.Color.White;
            this.btnAttendence.Location = new System.Drawing.Point(-10, 237);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(220, 93);
            this.btnAttendence.TabIndex = 3;
            this.btnAttendence.Text = "Attendence";
            this.btnAttendence.UseVisualStyleBackColor = false;
            this.btnAttendence.Click += new System.EventHandler(this.btnAttendence_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPOS.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPOS.ForeColor = System.Drawing.Color.White;
            this.btnPOS.Location = new System.Drawing.Point(-10, -4);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(220, 86);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.SkyBlue;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(848, 512);
            this.panelChildForm.TabIndex = 2;
            // 
            // Staff_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 612);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Staff_main";
            this.Text = "Staff_main";
            this.Load += new System.EventHandler(this.Staff_main_Load);
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
    }
}