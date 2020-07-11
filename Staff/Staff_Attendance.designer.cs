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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMonth = new System.Windows.Forms.Label();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStaffType = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStaffID.Location = new System.Drawing.Point(77, 25);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(69, 20);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "StaffID:";
            // 
            // lblWorkHour
            // 
            this.lblWorkHour.AutoSize = true;
            this.lblWorkHour.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWorkHour.Location = new System.Drawing.Point(45, 131);
            this.lblWorkHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkHour.Name = "lblWorkHour";
            this.lblWorkHour.Size = new System.Drawing.Size(106, 20);
            this.lblWorkHour.TabIndex = 1;
            this.lblWorkHour.Text = "Work Hours:";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(172, 24);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(160, 25);
            this.txtStaffID.TabIndex = 2;
            this.txtStaffID.TextChanged += new System.EventHandler(this.txtStaffID_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(233, 176);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 29);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtWorkHour
            // 
            this.txtWorkHour.Location = new System.Drawing.Point(172, 129);
            this.txtWorkHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWorkHour.Name = "txtWorkHour";
            this.txtWorkHour.Size = new System.Drawing.Size(160, 25);
            this.txtWorkHour.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffID,
            this.month,
            this.hour});
            this.dataGridView1.Location = new System.Drawing.Point(363, 18);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(457, 188);
            this.dataGridView1.TabIndex = 6;
            // 
            // staffID
            // 
            this.staffID.HeaderText = "staffID";
            this.staffID.MinimumWidth = 6;
            this.staffID.Name = "staffID";
            this.staffID.Width = 125;
            // 
            // month
            // 
            this.month.HeaderText = "month";
            this.month.MinimumWidth = 6;
            this.month.Name = "month";
            this.month.Width = 125;
            // 
            // hour
            // 
            this.hour.HeaderText = "hour";
            this.hour.MinimumWidth = 6;
            this.hour.Name = "hour";
            this.hour.Width = 125;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMonth.Location = new System.Drawing.Point(77, 76);
            this.lblMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(63, 20);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month:";
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "yyyy-MM";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(172, 76);
            this.dtpMonth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(160, 25);
            this.dtpMonth.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(57, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Staff Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(84, 292);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Salary:";
            // 
            // txtStaffType
            // 
            this.txtStaffType.Location = new System.Drawing.Point(172, 239);
            this.txtStaffType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStaffType.Name = "txtStaffType";
            this.txtStaffType.ReadOnly = true;
            this.txtStaffType.Size = new System.Drawing.Size(160, 25);
            this.txtStaffType.TabIndex = 11;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(172, 292);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.ReadOnly = true;
            this.txtSalary.Size = new System.Drawing.Size(160, 25);
            this.txtSalary.TabIndex = 12;

            // 
            // Staff_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1260, 742);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtStaffType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtWorkHour);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblWorkHour);
            this.Controls.Add(this.lblStaffID);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Staff_Attendance";
            this.Text = "Staff_Attendance";
            this.Load += new System.EventHandler(this.Staff_Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblWorkHour;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtWorkHour;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn hour;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStaffType;
        private System.Windows.Forms.TextBox txtSalary;
    }
}