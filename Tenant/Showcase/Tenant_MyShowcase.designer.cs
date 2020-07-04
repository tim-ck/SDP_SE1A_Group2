namespace SDP_SE1A_Group2
{
    partial class TenantMyShowcase
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radOld = new System.Windows.Forms.RadioButton();
            this.radCurrent = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showcaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Extend Lease";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 664);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radOld);
            this.groupBox1.Controls.Add(this.radCurrent);
            this.groupBox1.Location = new System.Drawing.Point(327, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 54);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radOld
            // 
            this.radOld.AutoSize = true;
            this.radOld.Checked = true;
            this.radOld.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.radOld.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radOld.Location = new System.Drawing.Point(242, 24);
            this.radOld.Name = "radOld";
            this.radOld.Size = new System.Drawing.Size(111, 21);
            this.radOld.TabIndex = 22;
            this.radOld.TabStop = true;
            this.radOld.Text = "Old Record";
            this.radOld.UseVisualStyleBackColor = true;
            this.radOld.CheckedChanged += new System.EventHandler(this.radOld_CheckedChanged);
            // 
            // radCurrent
            // 
            this.radCurrent.AutoSize = true;
            this.radCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.radCurrent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radCurrent.Location = new System.Drawing.Point(26, 24);
            this.radCurrent.Name = "radCurrent";
            this.radCurrent.Size = new System.Drawing.Size(140, 21);
            this.radCurrent.TabIndex = 21;
            this.radCurrent.Text = "Current Record";
            this.radCurrent.UseVisualStyleBackColor = true;
            this.radCurrent.CheckedChanged += new System.EventHandler(this.radCurrent_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showcaseId,
            this.size,
            this.rentalPerDay,
            this.startDate,
            this.endDate,
            this.scStatus});
            this.dataGridView1.Location = new System.Drawing.Point(89, 248);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(739, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(924, 337);
            this.dataGridView1.TabIndex = 16;
            // 
            // showcaseId
            // 
            this.showcaseId.HeaderText = "Showcase ID";
            this.showcaseId.MinimumWidth = 6;
            this.showcaseId.Name = "showcaseId";
            this.showcaseId.ReadOnly = true;
            this.showcaseId.Width = 125;
            // 
            // size
            // 
            this.size.HeaderText = "Size";
            this.size.MinimumWidth = 6;
            this.size.Name = "size";
            this.size.ReadOnly = true;
            this.size.Width = 125;
            // 
            // rentalPerDay
            // 
            this.rentalPerDay.HeaderText = "Rental / Day";
            this.rentalPerDay.MinimumWidth = 6;
            this.rentalPerDay.Name = "rentalPerDay";
            this.rentalPerDay.ReadOnly = true;
            this.rentalPerDay.Width = 125;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Start Date";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 125;
            // 
            // endDate
            // 
            this.endDate.HeaderText = "End Date";
            this.endDate.MinimumWidth = 6;
            this.endDate.Name = "endDate";
            this.endDate.ReadOnly = true;
            this.endDate.Width = 125;
            // 
            // scStatus
            // 
            this.scStatus.HeaderText = "Status";
            this.scStatus.MinimumWidth = 6;
            this.scStatus.Name = "scStatus";
            this.scStatus.ReadOnly = true;
            this.scStatus.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Showcase";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(433, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pick one to check";
            // 
            // TenantMyShowcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1116, 664);
            this.Controls.Add(this.panel1);
            this.Name = "TenantMyShowcase";
            this.Text = "My Showcase";
            this.Load += new System.EventHandler(this.Form2MyShowcase_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radOld;
        private System.Windows.Forms.RadioButton radCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn scStatus;
        private System.Windows.Forms.Label label3;
    }
}