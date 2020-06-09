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
            this.btnInShowcase = new System.Windows.Forms.Button();
            this.btnWaitForStockIn = new System.Windows.Forms.Button();
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
            this.lblMySalesItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMySalesItem.Name = "lblMySalesItem";
            this.lblMySalesItem.Size = new System.Drawing.Size(1116, 36);
            this.lblMySalesItem.TabIndex = 2;
            this.lblMySalesItem.Text = "My Sales Item";
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.btnWaitForStockIn);
            this.panelButton.Controls.Add(this.btnInShowcase);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 36);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(1116, 79);
            this.panelButton.TabIndex = 3;
            // 
            // btnInShowcase
            // 
            this.btnInShowcase.Location = new System.Drawing.Point(198, 3);
            this.btnInShowcase.Name = "btnInShowcase";
            this.btnInShowcase.Size = new System.Drawing.Size(195, 73);
            this.btnInShowcase.TabIndex = 0;
            this.btnInShowcase.Text = "In Showcase";
            this.btnInShowcase.UseVisualStyleBackColor = true;
            this.btnInShowcase.Click += new System.EventHandler(this.btnInShowcase_Click);
            // 
            // btnWaitForStockIn
            // 
            this.btnWaitForStockIn.Location = new System.Drawing.Point(628, 3);
            this.btnWaitForStockIn.Name = "btnWaitForStockIn";
            this.btnWaitForStockIn.Size = new System.Drawing.Size(195, 73);
            this.btnWaitForStockIn.TabIndex = 1;
            this.btnWaitForStockIn.Text = "Wait for Stock-in";
            this.btnWaitForStockIn.UseVisualStyleBackColor = true;
            this.btnWaitForStockIn.Click += new System.EventHandler(this.btnWaitForStockIn_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 115);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1116, 549);
            this.panelChildForm.TabIndex = 4;
            // 
            // TenantMySalesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1116, 664);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelButton);
            this.Controls.Add(this.lblMySalesItem);
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