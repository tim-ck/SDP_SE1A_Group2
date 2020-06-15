namespace SDP_SE1A_Group2
{
    partial class TenantMySalesItem
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
            this.lblMySalesItem = new System.Windows.Forms.Label();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnWaitForStockIn = new System.Windows.Forms.Button();
            this.btnInShowcase = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMySalesItem
            // 
            this.lblMySalesItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMySalesItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMySalesItem.ForeColor = System.Drawing.Color.LightGray;
            this.lblMySalesItem.Location = new System.Drawing.Point(0, 0);
            this.lblMySalesItem.Name = "lblMySalesItem";
            this.lblMySalesItem.Size = new System.Drawing.Size(837, 31);
            this.lblMySalesItem.TabIndex = 2;
            this.lblMySalesItem.Text = "My Sales Item";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnWaitForStockIn);
            this.panelButton.Controls.Add(this.btnInShowcase);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 31);
            this.panelButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(837, 68);
            this.panelButton.TabIndex = 3;
            // 
            // btnWaitForStockIn
            // 
            this.btnWaitForStockIn.Location = new System.Drawing.Point(565, 3);
            this.btnWaitForStockIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnWaitForStockIn.Name = "btnWaitForStockIn";
            this.btnWaitForStockIn.Size = new System.Drawing.Size(146, 63);
            this.btnWaitForStockIn.TabIndex = 1;
            this.btnWaitForStockIn.Text = "Wait for Stock-in";
            this.btnWaitForStockIn.UseVisualStyleBackColor = true;
            this.btnWaitForStockIn.Click += new System.EventHandler(this.btnWaitForStockIn_Click);
            // 
            // btnInShowcase
            // 
            this.btnInShowcase.Location = new System.Drawing.Point(242, 3);
            this.btnInShowcase.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInShowcase.Name = "btnInShowcase";
            this.btnInShowcase.Size = new System.Drawing.Size(146, 63);
            this.btnInShowcase.TabIndex = 0;
            this.btnInShowcase.Text = "In Showcase";
            this.btnInShowcase.UseVisualStyleBackColor = true;
            this.btnInShowcase.Click += new System.EventHandler(this.btnInShowcase_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 99);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(837, 476);
            this.panelChildForm.TabIndex = 4;
            // 
            // TenantMySalesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(837, 575);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.lblMySalesItem);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "TenantMySalesItem";
            this.Text = "Tenant_MySalesItem";
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMySalesItem;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnWaitForStockIn;
        private System.Windows.Forms.Button btnInShowcase;
        private System.Windows.Forms.Panel panelChildForm;
    }
}