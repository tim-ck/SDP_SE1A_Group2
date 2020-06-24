namespace SDP_SE1A_Group2.Tenant.SalesItem
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShowcaseId = new System.Windows.Forms.ComboBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rowNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.lbInShowcase.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.panelFilter.Controls.Add(this.btnSearch);
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
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(808, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 44);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(652, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Showcase ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
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
            this.panelDataGridView.BackColor = System.Drawing.SystemColors.Highlight;
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowNumber,
            this.itemId,
            this.itemName,
            this.location,
            this.showcaseId,
            this.qty,
            this.unitPrice});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 402);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // rowNumber
            // 
            this.rowNumber.HeaderText = "No.";
            this.rowNumber.MinimumWidth = 6;
            this.rowNumber.Name = "rowNumber";
            this.rowNumber.Width = 125;
            // 
            // itemId
            // 
            this.itemId.HeaderText = "Item ID";
            this.itemId.MinimumWidth = 6;
            this.itemId.Name = "itemId";
            this.itemId.Width = 125;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item Name";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.Width = 125;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.MinimumWidth = 6;
            this.location.Name = "location";
            this.location.Width = 125;
            // 
            // showcaseId
            // 
            this.showcaseId.HeaderText = "Showcase ID";
            this.showcaseId.MinimumWidth = 6;
            this.showcaseId.Name = "showcaseId";
            this.showcaseId.Width = 125;
            // 
            // qty
            // 
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.Width = 125;
            // 
            // unitPrice
            // 
            this.unitPrice.HeaderText = "Unit Price";
            this.unitPrice.MinimumWidth = 6;
            this.unitPrice.Name = "unitPrice";
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
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbShowcaseId;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rowNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPrice;
    }
}