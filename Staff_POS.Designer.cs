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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShowCase
            // 
            this.lblShowCase.AutoSize = true;
            this.lblShowCase.Location = new System.Drawing.Point(141, 84);
            this.lblShowCase.Name = "lblShowCase";
            this.lblShowCase.Size = new System.Drawing.Size(64, 13);
            this.lblShowCase.TabIndex = 0;
            this.lblShowCase.Text = "Show Case:";
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(161, 152);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(44, 13);
            this.lblItemID.TabIndex = 1;
            this.lblItemID.Text = "Item ID:";
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(180, 213);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(25, 13);
            this.lblQT.TabIndex = 2;
            this.lblQT.Text = "QT:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(147, 278);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price(1pc):";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(144, 342);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(61, 13);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // cmbShowCase
            // 
            this.cmbShowCase.FormattingEnabled = true;
            this.cmbShowCase.Location = new System.Drawing.Point(257, 81);
            this.cmbShowCase.Name = "cmbShowCase";
            this.cmbShowCase.Size = new System.Drawing.Size(121, 21);
            this.cmbShowCase.TabIndex = 5;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(257, 149);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(121, 20);
            this.txtItemID.TabIndex = 6;
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(257, 210);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(121, 20);
            this.txtQT.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(257, 275);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(257, 339);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(121, 20);
            this.txtTotalPrice.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(435, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Staff_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 495);
            this.Controls.Add(this.button1);
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
            this.Text = "Staff_POS";
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
        private System.Windows.Forms.Button button1;
    }
}