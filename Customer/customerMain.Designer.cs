namespace SDP_SE1A_Group2.Customer
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnShoppingCartPage = new System.Windows.Forms.Button();
            this.btnBrowseItemPage = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 817);
            this.panel2.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 716);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(250, 83);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnShoppingCartPage
            // 
            this.btnShoppingCartPage.Location = new System.Drawing.Point(0, 179);
            this.btnShoppingCartPage.Name = "btnShoppingCartPage";
            this.btnShoppingCartPage.Size = new System.Drawing.Size(250, 83);
            this.btnShoppingCartPage.TabIndex = 1;
            this.btnShoppingCartPage.Text = "Shopping Cart";
            this.btnShoppingCartPage.UseVisualStyleBackColor = true;
            // 
            // btnBrowseItemPage
            // 
            this.btnBrowseItemPage.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnBrowseItemPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseItemPage.Location = new System.Drawing.Point(0, 99);
            this.btnBrowseItemPage.Name = "btnBrowseItemPage";
            this.btnBrowseItemPage.Size = new System.Drawing.Size(250, 83);
            this.btnBrowseItemPage.TabIndex = 0;
            this.btnBrowseItemPage.Text = "Browse Item";
            this.btnBrowseItemPage.UseVisualStyleBackColor = true;
            this.btnBrowseItemPage.Click += new System.EventHandler(this.btnBrowseItemPage_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(50)))), ((int)(((byte)(62)))));
            this.panelChildForm.Location = new System.Drawing.Point(250, 100);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1135, 717);
            this.panelChildForm.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1135, 100);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.pictureBox1.Image = global::SDP_SE1A_Group2.Properties.Resources.cubeLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 811);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Name = "CustomerMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerMain";
            this.Load += new System.EventHandler(this.CustomerMain_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}