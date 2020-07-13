namespace SDP_SE1A_Group2.Staff
{
    partial class Staff_showcaseManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShowShowcaseRecord = new System.Windows.Forms.Button();
            this.listBoxShowcaseID = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowItemList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRentPage = new System.Windows.Forms.Button();
            this.txtShowCaseID = new System.Windows.Forms.TextBox();
            this.txtStoreAddress = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtShowcaseSize = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.dataGridViewRentalRecord = new System.Windows.Forms.DataGridView();
            this.rentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenantID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewItem = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentalRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "ShowcaseID :";
            // 
            // btnShowShowcaseRecord
            // 
            this.btnShowShowcaseRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(81)))));
            this.btnShowShowcaseRecord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowShowcaseRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(140)))), ((int)(((byte)(70)))));
            this.btnShowShowcaseRecord.FlatAppearance.BorderSize = 2;
            this.btnShowShowcaseRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(150)))), ((int)(((byte)(74)))));
            this.btnShowShowcaseRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(70)))));
            this.btnShowShowcaseRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowShowcaseRecord.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnShowShowcaseRecord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnShowShowcaseRecord.Location = new System.Drawing.Point(16, 702);
            this.btnShowShowcaseRecord.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnShowShowcaseRecord.Name = "btnShowShowcaseRecord";
            this.btnShowShowcaseRecord.Size = new System.Drawing.Size(203, 50);
            this.btnShowShowcaseRecord.TabIndex = 15;
            this.btnShowShowcaseRecord.Text = "Rent Record>>";
            this.btnShowShowcaseRecord.UseVisualStyleBackColor = false;
            this.btnShowShowcaseRecord.Click += new System.EventHandler(this.btnShowShowcaseRecord_Click);
            // 
            // listBoxShowcaseID
            // 
            this.listBoxShowcaseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxShowcaseID.ForeColor = System.Drawing.Color.Green;
            this.listBoxShowcaseID.FormattingEnabled = true;
            this.listBoxShowcaseID.ItemHeight = 15;
            this.listBoxShowcaseID.Location = new System.Drawing.Point(17, 56);
            this.listBoxShowcaseID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxShowcaseID.Name = "listBoxShowcaseID";
            this.listBoxShowcaseID.Size = new System.Drawing.Size(203, 600);
            this.listBoxShowcaseID.TabIndex = 14;
            this.listBoxShowcaseID.SelectedIndexChanged += new System.EventHandler(this.listBoxShowcaseID_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.panel1.Controls.Add(this.btnShowItemList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnShowShowcaseRecord);
            this.panel1.Controls.Add(this.listBoxShowcaseID);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 857);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnShowItemList
            // 
            this.btnShowItemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(81)))));
            this.btnShowItemList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowItemList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(140)))), ((int)(((byte)(70)))));
            this.btnShowItemList.FlatAppearance.BorderSize = 2;
            this.btnShowItemList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(150)))), ((int)(((byte)(74)))));
            this.btnShowItemList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(70)))));
            this.btnShowItemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowItemList.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.btnShowItemList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.btnShowItemList.Location = new System.Drawing.Point(16, 762);
            this.btnShowItemList.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnShowItemList.Name = "btnShowItemList";
            this.btnShowItemList.Size = new System.Drawing.Size(206, 51);
            this.btnShowItemList.TabIndex = 17;
            this.btnShowItemList.Text = " Item Detail >>";
            this.btnShowItemList.UseVisualStyleBackColor = false;
            this.btnShowItemList.Click += new System.EventHandler(this.btnShowItemList_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(1089, 827);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 4);
            this.label1.TabIndex = 31;
            // 
            // btnRentPage
            // 
            this.btnRentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnRentPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRentPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnRentPage.FlatAppearance.BorderSize = 3;
            this.btnRentPage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnRentPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(170)))), ((int)(((byte)(217)))));
            this.btnRentPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentPage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnRentPage.ForeColor = System.Drawing.Color.White;
            this.btnRentPage.Location = new System.Drawing.Point(1089, 765);
            this.btnRentPage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRentPage.Name = "btnRentPage";
            this.btnRentPage.Size = new System.Drawing.Size(129, 62);
            this.btnRentPage.TabIndex = 30;
            this.btnRentPage.Text = "Rent";
            this.btnRentPage.UseVisualStyleBackColor = false;
            // 
            // txtShowCaseID
            // 
            this.txtShowCaseID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(211)))));
            this.txtShowCaseID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShowCaseID.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtShowCaseID.Location = new System.Drawing.Point(254, 86);
            this.txtShowCaseID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShowCaseID.Name = "txtShowCaseID";
            this.txtShowCaseID.Size = new System.Drawing.Size(264, 34);
            this.txtShowCaseID.TabIndex = 32;
            this.txtShowCaseID.Text = "Showcase ID:";
            // 
            // txtStoreAddress
            // 
            this.txtStoreAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStoreAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(211)))));
            this.txtStoreAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStoreAddress.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtStoreAddress.Location = new System.Drawing.Point(254, 48);
            this.txtStoreAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStoreAddress.Name = "txtStoreAddress";
            this.txtStoreAddress.Size = new System.Drawing.Size(964, 34);
            this.txtStoreAddress.TabIndex = 33;
            this.txtStoreAddress.Text = "Store address:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 18F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblTitle.Location = new System.Drawing.Point(251, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 29);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "Showcase Detail:";
            // 
            // txtShowcaseSize
            // 
            this.txtShowcaseSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtShowcaseSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(211)))));
            this.txtShowcaseSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtShowcaseSize.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtShowcaseSize.Location = new System.Drawing.Point(565, 86);
            this.txtShowcaseSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShowcaseSize.Name = "txtShowcaseSize";
            this.txtShowcaseSize.Size = new System.Drawing.Size(394, 34);
            this.txtShowcaseSize.TabIndex = 37;
            this.txtShowcaseSize.Text = "Showcase Size:";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(179)))), ((int)(((byte)(211)))));
            this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.txtStatus.Location = new System.Drawing.Point(993, 86);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(225, 34);
            this.txtStatus.TabIndex = 38;
            this.txtStatus.Text = "Status:";
            // 
            // dataGridViewRentalRecord
            // 
            this.dataGridViewRentalRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewRentalRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRentalRecord.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.dataGridViewRentalRecord.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewRentalRecord.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRentalRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRentalRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentalRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentID,
            this.tenantID,
            this.startDate,
            this.duration,
            this.EndDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRentalRecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRentalRecord.EnableHeadersVisualStyles = false;
            this.dataGridViewRentalRecord.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dataGridViewRentalRecord.Location = new System.Drawing.Point(254, 126);
            this.dataGridViewRentalRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewRentalRecord.Name = "dataGridViewRentalRecord";
            this.dataGridViewRentalRecord.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRentalRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRentalRecord.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(229)))));
            this.dataGridViewRentalRecord.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewRentalRecord.RowTemplate.Height = 50;
            this.dataGridViewRentalRecord.Size = new System.Drawing.Size(977, 617);
            this.dataGridViewRentalRecord.TabIndex = 43;
            // 
            // rentID
            // 
            this.rentID.HeaderText = "rentID";
            this.rentID.MinimumWidth = 6;
            this.rentID.Name = "rentID";
            this.rentID.ReadOnly = true;
            // 
            // tenantID
            // 
            this.tenantID.HeaderText = "tenantID";
            this.tenantID.MinimumWidth = 6;
            this.tenantID.Name = "tenantID";
            this.tenantID.ReadOnly = true;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "startDate";
            this.startDate.MinimumWidth = 6;
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            // 
            // duration
            // 
            this.duration.HeaderText = "duration";
            this.duration.MinimumWidth = 6;
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            // 
            // dataGridViewItem
            // 
            this.dataGridViewItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(195)))), ((int)(((byte)(231)))));
            this.dataGridViewItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(58)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.availableQty,
            this.availability,
            this.SoldQty});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(254)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewItem.EnableHeadersVisualStyles = false;
            this.dataGridViewItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(52)))), ((int)(((byte)(88)))));
            this.dataGridViewItem.Location = new System.Drawing.Point(254, 126);
            this.dataGridViewItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewItem.Name = "dataGridViewItem";
            this.dataGridViewItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(190)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewItem.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(130)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 15F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(107)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(229)))));
            this.dataGridViewItem.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewItem.RowTemplate.Height = 50;
            this.dataGridViewItem.Size = new System.Drawing.Size(977, 547);
            this.dataGridViewItem.TabIndex = 44;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Descriptioon";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // availableQty
            // 
            this.availableQty.HeaderText = "Available Quantity";
            this.availableQty.MinimumWidth = 6;
            this.availableQty.Name = "availableQty";
            // 
            // availability
            // 
            this.availability.HeaderText = "availability";
            this.availability.MinimumWidth = 6;
            this.availability.Name = "availability";
            // 
            // SoldQty
            // 
            this.SoldQty.HeaderText = "Sold quantity";
            this.SoldQty.MinimumWidth = 6;
            this.SoldQty.Name = "SoldQty";
            // 
            // Staff_showcaseManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(1269, 857);
            this.Controls.Add(this.dataGridViewItem);
            this.Controls.Add(this.dataGridViewRentalRecord);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtShowcaseSize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtStoreAddress);
            this.Controls.Add(this.txtShowCaseID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRentPage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Staff_showcaseManagment";
            this.Text = "Peter";
            this.Load += new System.EventHandler(this.Staff_showcaseManagment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentalRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnShowShowcaseRecord;
        private System.Windows.Forms.ListBox listBoxShowcaseID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRentPage;
        private System.Windows.Forms.TextBox txtShowCaseID;
        private System.Windows.Forms.TextBox txtStoreAddress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtShowcaseSize;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnShowItemList;
        private System.Windows.Forms.DataGridView dataGridViewRentalRecord;
        private System.Windows.Forms.DataGridView dataGridViewItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenantID;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
    }
}