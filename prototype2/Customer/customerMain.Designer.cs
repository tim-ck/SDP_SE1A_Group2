﻿namespace SDP_SE1A_Group2.Customer
{
    partial class CustomerMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblMinBtn = new System.Windows.Forms.Label();
            this.lblCloseBtn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnAccountSetting = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnAccountSetting);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 900);
            this.panel1.TabIndex = 0;
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnOrder.Image = global::SDP_SE1A_Group2.Properties.Resources.order_p;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 300);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(250, 100);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "  Orders";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnLogOut.Image = global::SDP_SE1A_Group2.Properties.Resources.logout_s;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 830);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(250, 70);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "   Log out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCart
            // 
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnCart.Image = global::SDP_SE1A_Group2.Properties.Resources.cart_P;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 200);
            this.btnCart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCart.Size = new System.Drawing.Size(250, 100);
            this.btnCart.TabIndex = 3;
            this.btnCart.Text = "  Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnProduct.Image = global::SDP_SE1A_Group2.Properties.Resources.item_P;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 100);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(250, 100);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "  Products";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 100);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(111)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SDP_SE1A_Group2.Properties.Resources.cubeLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(111)))));
            this.panelTitleBar.Controls.Add(this.lblMinBtn);
            this.panelTitleBar.Controls.Add(this.lblCloseBtn);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1214, 100);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblMinBtn
            // 
            this.lblMinBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinBtn.AutoSize = true;
            this.lblMinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinBtn.ForeColor = System.Drawing.Color.White;
            this.lblMinBtn.Location = new System.Drawing.Point(1143, 0);
            this.lblMinBtn.Name = "lblMinBtn";
            this.lblMinBtn.Size = new System.Drawing.Size(35, 32);
            this.lblMinBtn.TabIndex = 5;
            this.lblMinBtn.Text = "__";
            this.lblMinBtn.Click += new System.EventHandler(this.lblMinBtn_Click);
            // 
            // lblCloseBtn
            // 
            this.lblCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCloseBtn.AutoSize = true;
            this.lblCloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseBtn.ForeColor = System.Drawing.Color.White;
            this.lblCloseBtn.Location = new System.Drawing.Point(1184, 0);
            this.lblCloseBtn.Name = "lblCloseBtn";
            this.lblCloseBtn.Size = new System.Drawing.Size(29, 32);
            this.lblCloseBtn.TabIndex = 4;
            this.lblCloseBtn.Text = "X";
            this.lblCloseBtn.Click += new System.EventHandler(this.lblCloseBtn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.lblTitle.Location = new System.Drawing.Point(17, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(631, 38);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Welcome Customer (customer name)!";
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackgroundImage = global::SDP_SE1A_Group2.Properties.Resources.cubeLogo1;
            this.panelChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1214, 800);
            this.panelChildForm.TabIndex = 2;
            // 
            // btnAccountSetting
            // 
            this.btnAccountSetting.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAccountSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountSetting.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.btnAccountSetting.Image = global::SDP_SE1A_Group2.Properties.Resources.setting;
            this.btnAccountSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSetting.Location = new System.Drawing.Point(0, 747);
            this.btnAccountSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAccountSetting.Name = "btnAccountSetting";
            this.btnAccountSetting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnAccountSetting.Size = new System.Drawing.Size(250, 83);
            this.btnAccountSetting.TabIndex = 7;
            this.btnAccountSetting.Text = "Account  Setting";
            this.btnAccountSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountSetting.UseVisualStyleBackColor = true;
            this.btnAccountSetting.Click += new System.EventHandler(this.btnAccountSetting_Click);
            // 
            // CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 900);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCloseBtn;
        private System.Windows.Forms.Label lblMinBtn;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnAccountSetting;
    }
}