namespace SDP_SE1A_Group2
{
    partial class Staff_POS
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
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblQT = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showcaseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avalibleQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblItemID.Location = new System.Drawing.Point(74, 111);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(60, 16);
            this.lblItemID.TabIndex = 1;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQT.Location = new System.Drawing.Point(93, 233);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(32, 16);
            this.lblQT.TabIndex = 2;
            this.lblQT.Text = "QT:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPrice.Location = new System.Drawing.Point(60, 173);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(76, 16);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price(1pc):";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(57, 291);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(79, 16);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(159, 109);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(121, 22);
            this.txtItemID.TabIndex = 6;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(159, 230);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(121, 22);
            this.txtQT.TabIndex = 7;
            this.txtQT.TextChanged += new System.EventHandler(this.txtQT_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(159, 170);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(159, 288);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(121, 22);
            this.txtTotalPrice.TabIndex = 9;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPay.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPay.Location = new System.Drawing.Point(41, 333);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(113, 44);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showcaseid,
            this.itemid,
            this.avalibleQty,
            this.soldQty,
            this.TotalQty});
            this.dataGridView1.Location = new System.Drawing.Point(320, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(454, 236);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // showcaseid
            // 
            this.showcaseid.HeaderText = "showcaseid";
            this.showcaseid.Name = "showcaseid";
            // 
            // itemid
            // 
            this.itemid.HeaderText = "itemid";
            this.itemid.Name = "itemid";
            // 
            // avalibleQty
            // 
            this.avalibleQty.HeaderText = "avalibleQty";
            this.avalibleQty.Name = "avalibleQty";
            // 
            // soldQty
            // 
            this.soldQty.HeaderText = "soldQty";
            this.soldQty.Name = "soldQty";
            // 
            // TotalQty
            // 
            this.TotalQty.HeaderText = "TotalQty";
            this.TotalQty.Name = "TotalQty";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPrint.Location = new System.Drawing.Point(173, 333);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 44);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print receipt";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLocation.Location = new System.Drawing.Point(74, 65);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(67, 16);
            this.lblLocation.TabIndex = 14;
            this.lblLocation.Text = "Location:";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "CB",
            "MK",
            "KF",
            "S"});
            this.cmbLocation.Location = new System.Drawing.Point(159, 65);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(121, 20);
            this.cmbLocation.TabIndex = 15;
            // 
            // Staff_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(799, 457);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQT);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQT);
            this.Controls.Add(this.lblItemID);
            this.Name = "Staff_POS";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Staff_POS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn avalibleQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cmbLocation;
    }
}