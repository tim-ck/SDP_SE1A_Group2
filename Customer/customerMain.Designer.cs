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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShoppingCartPage = new System.Windows.Forms.Button();
            this.btnBrowseItemPage = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCloseButton = new System.Windows.Forms.Label();
            this.btnTenantPage = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnShoppingCartPage);
            this.panel2.Controls.Add(this.btnBrowseItemPage);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 1131);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.pictureBox1.Image = global::SDP_SE1A_Group2.Properties.Resources.cubeLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 991);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(375, 115);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnShoppingCartPage
            // 
            this.btnShoppingCartPage.Location = new System.Drawing.Point(0, 248);
            this.btnShoppingCartPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShoppingCartPage.Name = "btnShoppingCartPage";
            this.btnShoppingCartPage.Size = new System.Drawing.Size(375, 115);
            this.btnShoppingCartPage.TabIndex = 1;
            this.btnShoppingCartPage.Text = "Shopping Cart";
            this.btnShoppingCartPage.UseVisualStyleBackColor = true;
            // 
            // btnBrowseItemPage
            // 
            this.btnBrowseItemPage.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnBrowseItemPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseItemPage.Location = new System.Drawing.Point(0, 137);
            this.btnBrowseItemPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseItemPage.Name = "btnBrowseItemPage";
            this.btnBrowseItemPage.Size = new System.Drawing.Size(375, 115);
            this.btnBrowseItemPage.TabIndex = 0;
            this.btnBrowseItemPage.Text = "Browse Item";
            this.btnBrowseItemPage.UseVisualStyleBackColor = true;
            this.btnBrowseItemPage.Click += new System.EventHandler(this.btnBrowseItemPage_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.panelChildForm.Location = new System.Drawing.Point(375, 138);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1702, 993);
            this.panelChildForm.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnTenantPage);
            this.panel1.Controls.Add(this.lblCloseButton);
            this.panel1.Location = new System.Drawing.Point(375, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1702, 138);
            this.panel1.TabIndex = 3;
            // 
            // lblCloseButton
            // 
            this.lblCloseButton.AutoSize = true;
            this.lblCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lblCloseButton.Location = new System.Drawing.Point(1651, 0);
            this.lblCloseButton.Name = "lblCloseButton";
            this.lblCloseButton.Size = new System.Drawing.Size(51, 60);
            this.lblCloseButton.TabIndex = 15;
            this.lblCloseButton.Text = "X";
            this.lblCloseButton.Click += new System.EventHandler(this.lblCloseButton_Click);
            // 
            // btnTenantPage
            // 
            this.btnTenantPage.Location = new System.Drawing.Point(1372, 60);
            this.btnTenantPage.Name = "btnTenantPage";
            this.btnTenantPage.Size = new System.Drawing.Size(254, 55);
            this.btnTenantPage.TabIndex = 16;
            this.btnTenantPage.Text = "Go To Tenant Form ->";
            this.btnTenantPage.UseVisualStyleBackColor = true;
            // 
            // CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1123);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerMain";
            this.Load += new System.EventHandler(this.CustomerMain_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBrowseItemPage;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnShoppingCartPage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCloseButton;
        private System.Windows.Forms.Button btnTenantPage;
    }
}