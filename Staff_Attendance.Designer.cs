namespace SDP_SE1A_Group2
{
    partial class Staff_Attendance
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
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblWorkHour = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtWorkHour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(69, 41);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(42, 12);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "StaffID:";
            // 
            // lblWorkHour
            // 
            this.lblWorkHour.AutoSize = true;
            this.lblWorkHour.Location = new System.Drawing.Point(45, 86);
            this.lblWorkHour.Name = "lblWorkHour";
            this.lblWorkHour.Size = new System.Drawing.Size(66, 12);
            this.lblWorkHour.TabIndex = 1;
            this.lblWorkHour.Text = "Work Hours:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(195, 38);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(121, 22);
            this.txtStaffID.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(241, 136);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtWorkHour
            // 
            this.txtWorkHour.Location = new System.Drawing.Point(195, 83);
            this.txtWorkHour.Name = "txtWorkHour";
            this.txtWorkHour.Size = new System.Drawing.Size(121, 22);
            this.txtWorkHour.TabIndex = 5;
            // 
            // Staff_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 594);
            this.Controls.Add(this.txtWorkHour);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblWorkHour);
            this.Controls.Add(this.lblStaffID);
            this.Name = "Staff_Attendance";
            this.Text = "Staff_Attendance";
            this.Load += new System.EventHandler(this.Staff_Attendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblWorkHour;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtWorkHour;
    }
}