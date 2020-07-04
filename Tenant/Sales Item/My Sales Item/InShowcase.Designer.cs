namespace SDP_SE1A_Group2
{
    partial class InShowcase
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
            this.lbInShowcase = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShowcaseId = new System.Windows.Forms.ComboBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showcaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilter.SuspendLayout();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInShowcase
            // 
            this.lbInShowcase.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbInShowcase.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInShowcase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbInShowcase.ForeColor = System.Drawing.Color.LightGray;
            this.lbInShowcase.Location = new System.Drawing.Point(0, 0);
            this.lbInShowcase.Name = "lbInShowcase";
            this.lbInShowcase.Size = new System.Drawing.Size(1099, 20);
            this.lbInShowcase.TabIndex = 5;
            this.lbInShowcase.Text = "In Showcase";
            this.lbInShowcase.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelFilter.Controls.Add(this.btnImport);
            this.panelFilter.Controls.Add(this.panel3);
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Controls.Add(this.cbShowcaseId);
            this.panelFilter.Controls.Add(this.cbLocation);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.ForeColor = System.Drawing.Color.LightGray;
            this.panelFilter.Location = new System.Drawing.Point(0, 20);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1099, 80);
            this.panelFilter.TabIndex = 7;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btnImport.Location = new System.Drawing.Point(813, 7);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(178, 56);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Search";
            this.btnImport.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(45, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(970, 3);
            this.panel3.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(617, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Showcase ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(232, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location";
            // 
            // cbShowcaseId
            // 
            this.cbShowcaseId.FormattingEnabled = true;
            this.cbShowcaseId.Location = new System.Drawing.Point(449, 27);
            this.cbShowcaseId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbShowcaseId.Name = "cbShowcaseId";
            this.cbShowcaseId.Size = new System.Drawing.Size(160, 23);
            this.cbShowcaseId.TabIndex = 1;
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(64, 27);
            this.cbLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(160, 23);
            this.cbLocation.TabIndex = 0;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.AutoScroll = true;
            this.panelDataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.panelDataGridView.Controls.Add(this.dataGridView1);
            this.panelDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGridView.Location = new System.Drawing.Point(0, 100);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(1099, 402);
            this.panelDataGridView.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemId,
            this.itemName,
            this.location,
            this.showcaseId,
            this.qty,
            this.unitPrice});
            this.dataGridView1.Location = new System.Drawing.Point(120, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(871, 324);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // itemId
            // 
            this.itemId.HeaderText = "Item ID";
            this.itemId.MinimumWidth = 6;
            this.itemId.Name = "itemId";
            this.itemId.ReadOnly = true;
            this.itemId.Width = 80;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 125;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.MinimumWidth = 6;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            this.location.Width = 125;
            // 
            // showcaseId
            // 
            this.showcaseId.HeaderText = "Showcase ID";
            this.showcaseId.MinimumWidth = 6;
            this.showcaseId.Name = "showcaseId";
            this.showcaseId.ReadOnly = true;
            this.showcaseId.Width = 125;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 75;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 6;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.ReadOnly = true;
            this.unitPrice.Width = 125;
            // 
            // InShowcase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1099, 502);
            this.Controls.Add(this.panelDataGridView);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.lbInShowcase);
            this.Name = "InShowcase";
            this.Text = "In Showcase";
            this.Load += new System.EventHandler(this.InShowcase_Load);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbInShowcase;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbShowcaseId;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
    }
}