﻿namespace SDP_SE1A_Group2
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
            this.btnCount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.showcaseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avalibleQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(61, 67);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(44, 12);
            this.lblItemID.TabIndex = 1;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(80, 189);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(23, 12);
            this.lblQT.TabIndex = 2;
            this.lblQT.Text = "QT:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(47, 129);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 12);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price(1pc):";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(44, 247);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(58, 12);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(157, 65);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(121, 22);
            this.txtItemID.TabIndex = 6;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(157, 186);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(121, 22);
            this.txtQT.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(157, 126);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(157, 244);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(121, 22);
            this.txtTotalPrice.TabIndex = 9;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.txtTotalPrice_TextChanged);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(46, 329);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(94, 32);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(284, 247);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 21);
            this.btnCount.TabIndex = 11;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(374, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 236);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(166, 329);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 32);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Print receipt";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // Staff_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 457);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCount);
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
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn showcaseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemid;
        private System.Windows.Forms.DataGridViewTextBoxColumn avalibleQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQty;
    }
}