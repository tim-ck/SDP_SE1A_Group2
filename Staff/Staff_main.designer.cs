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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMinBtn = new System.Windows.Forms.Label();
            this.lblCloseBtn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAcctSetting = new System.Windows.Forms.Button();
            this.btnAddstaff = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShowcase = new System.Windows.Forms.Button();
            this.btnSalesRecord = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnAttendence = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTitleBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1502, 91);
            this.panel1.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(111)))));
            this.panelTitleBar.Controls.Add(this.pictureBox1);
            this.panelTitleBar.Controls.Add(this.lblMinBtn);
            this.panelTitleBar.Controls.Add(this.lblCloseBtn);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1502, 90);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(111)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SDP_SE1A_Group2.Properties.Resources.cubeLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lblMinBtn
            // 
            this.lblMinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinBtn.AutoSize = true;
            this.lblMinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinBtn.ForeColor = System.Drawing.Color.White;
            this.lblMinBtn.Location = new System.Drawing.Point(1426, 0);
            this.lblMinBtn.Name = "lblMinBtn";
            this.lblMinBtn.Size = new System.Drawing.Size(35, 32);
            this.lblMinBtn.TabIndex = 5;
            this.lblMinBtn.Text = "__";
            this.lblMinBtn.Click += new System.EventHandler(this.lblMinBtn_Click_1);
            // 
            // lblCloseBtn
            // 
            this.lblCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCloseBtn.AutoSize = true;
            this.lblCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseBtn.ForeColor = System.Drawing.Color.White;
            this.lblCloseBtn.Location = new System.Drawing.Point(1467, 0);
            this.lblCloseBtn.Name = "lblCloseBtn";
            this.lblCloseBtn.Size = new System.Drawing.Size(29, 32);
            this.lblCloseBtn.TabIndex = 4;
            this.lblCloseBtn.Text = "X";
            this.lblCloseBtn.Click += new System.EventHandler(this.lblCloseBtn_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblTitle.Location = new System.Drawing.Point(299, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Staff";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAcctSetting);
            this.panel2.Controls.Add(this.btnAddstaff);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnShowcase);
            this.panel2.Controls.Add(this.btnSalesRecord);
            this.panel2.Controls.Add(this.btnReserve);
            this.panel2.Controls.Add(this.btnAttendence);
            this.panel2.Controls.Add(this.btnPOS);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 91);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 857);
            this.panel2.TabIndex = 1;
            // 
            // btnAcctSetting
            // 
            this.btnAcctSetting.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAcctSetting.Location = new System.Drawing.Point(0, 745);
            this.btnAcctSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAcctSetting.Name = "btnAcctSetting";
            this.btnAcctSetting.Size = new System.Drawing.Size(233, 57);
            this.btnAcctSetting.TabIndex = 10;
            this.btnAcctSetting.Text = "Account Setting";
            this.btnAcctSetting.UseVisualStyleBackColor = false;
            this.btnAcctSetting.Click += new System.EventHandler(this.btnAcctSetting_Click);
            // 
            // btnAddstaff
            // 
            this.btnAddstaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddstaff.Location = new System.Drawing.Point(0, 572);
            this.btnAddstaff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddstaff.Name = "btnAddstaff";
            this.btnAddstaff.Size = new System.Drawing.Size(233, 106);
            this.btnAddstaff.TabIndex = 9;
            this.btnAddstaff.Text = "Add Staff";
            this.btnAddstaff.UseVisualStyleBackColor = false;
            this.btnAddstaff.Click += new System.EventHandler(this.btnAddstaff_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 800);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(233, 57);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnShowcase
            // 
            this.btnShowcase.Location = new System.Drawing.Point(0, 467);
            this.btnShowcase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowcase.Name = "btnShowcase";
            this.btnShowcase.Size = new System.Drawing.Size(233, 106);
            this.btnShowcase.TabIndex = 7;
            this.btnShowcase.Text = "Showcase Management";
            this.btnShowcase.UseVisualStyleBackColor = true;
            this.btnShowcase.Click += new System.EventHandler(this.btnShowcase_Click);
            // 
            // btnSalesRecord
            // 
            this.btnSalesRecord.Location = new System.Drawing.Point(0, 336);
            this.btnSalesRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalesRecord.Name = "btnSalesRecord";
            this.btnSalesRecord.Size = new System.Drawing.Size(233, 134);
            this.btnSalesRecord.TabIndex = 6;
            this.btnSalesRecord.Text = "SalesRecord";
            this.btnSalesRecord.UseVisualStyleBackColor = true;
            this.btnSalesRecord.Click += new System.EventHandler(this.btnSalesRecord_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Location = new System.Drawing.Point(0, 218);
            this.btnReserve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(233, 122);
            this.btnReserve.TabIndex = 5;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnAttendence
            // 
            this.btnAttendence.Location = new System.Drawing.Point(0, 104);
            this.btnAttendence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAttendence.Name = "btnAttendence";
            this.btnAttendence.Size = new System.Drawing.Size(233, 116);
            this.btnAttendence.TabIndex = 3;
            this.btnAttendence.Text = "Attendence";
            this.btnAttendence.UseVisualStyleBackColor = true;
            this.btnAttendence.Click += new System.EventHandler(this.btnAttendence_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(0, 0);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(233, 108);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(233, 91);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1269, 857);
            this.panelChildForm.TabIndex = 2;
            // 
            // Staff_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 948);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Staff_main";
            this.Text = "Staff_main";
            this.Load += new System.EventHandler(this.Staff_main_Load);
            this.panel1.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
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
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblMinBtn;
        private System.Windows.Forms.Label lblCloseBtn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnShowcase;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnAddstaff;
        private System.Windows.Forms.Button btnAcctSetting;
    }
}