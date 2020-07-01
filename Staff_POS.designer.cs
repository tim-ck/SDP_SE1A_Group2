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
            this.lblShowCase = new System.Windows.Forms.Label();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblQT = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.cmbShowCase = new System.Windows.Forms.ComboBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShowCase
            // 
            this.lblShowCase.AutoSize = true;
            this.lblShowCase.Location = new System.Drawing.Point(41, 33);
            this.lblShowCase.Name = "lblShowCase";
            this.lblShowCase.Size = new System.Drawing.Size(59, 12);
            this.lblShowCase.TabIndex = 0;
            this.lblShowCase.Text = "Show Case:";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(61, 95);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(44, 12);
            this.lblItemID.TabIndex = 1;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(80, 217);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(23, 12);
            this.lblQT.TabIndex = 2;
            this.lblQT.Text = "QT:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(47, 157);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(56, 12);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price(1pc):";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(44, 275);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(58, 12);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // cmbShowCase
            // 
            this.cmbShowCase.FormattingEnabled = true;
            this.cmbShowCase.Items.AddRange(new object[] {
            "Causeway Bay",
            "Mong Kok",
            "Kwai Fong",
            "Shatin"});
            this.cmbShowCase.Location = new System.Drawing.Point(157, 30);
            this.cmbShowCase.Name = "cmbShowCase";
            this.cmbShowCase.Size = new System.Drawing.Size(121, 20);
            this.cmbShowCase.TabIndex = 5;
            this.cmbShowCase.SelectedIndexChanged += new System.EventHandler(this.cmbShowCase_SelectedIndexChanged);
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(157, 93);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(121, 22);
            this.txtItemID.TabIndex = 6;
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(157, 214);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(121, 22);
            this.txtQT.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(157, 154);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(157, 272);
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
            this.btnPay.Size = new System.Drawing.Size(75, 21);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(303, 275);
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
            this.dataGridView1.Location = new System.Drawing.Point(303, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(353, 236);
            this.dataGridView1.TabIndex = 12;
            // 
            // Staff_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 457);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtQT);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.cmbShowCase);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblQT);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.lblShowCase);
            this.Name = "Staff_POS";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowCase;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.ComboBox cmbShowCase;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}