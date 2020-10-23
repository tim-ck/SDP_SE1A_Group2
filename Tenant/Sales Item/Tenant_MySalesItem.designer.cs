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
            this.lblMySalesItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
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
            this.panelButton.Size = new System.Drawing.Size(1116, 78);
            this.panelButton.TabIndex = 3;
            // 
            // btnWaitForStockIn
            // 
            this.btnWaitForStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnWaitForStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaitForStockIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnWaitForStockIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btnWaitForStockIn.Location = new System.Drawing.Point(753, 3);
            this.btnWaitForStockIn.Name = "btnWaitForStockIn";
            this.btnWaitForStockIn.Size = new System.Drawing.Size(220, 75);
            this.btnWaitForStockIn.TabIndex = 1;
            this.btnWaitForStockIn.Text = "Pre-Input";
            this.btnWaitForStockIn.UseVisualStyleBackColor = false;
            this.btnWaitForStockIn.Click += new System.EventHandler(this.btnWaitForStockIn_Click);
            // 
            // btnInShowcase
            // 
            this.btnInShowcase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnInShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInShowcase.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnInShowcase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btnInShowcase.Location = new System.Drawing.Point(323, 3);
            this.btnInShowcase.Name = "btnInShowcase";
            this.btnInShowcase.Size = new System.Drawing.Size(220, 75);
            this.btnInShowcase.TabIndex = 0;
            this.btnInShowcase.Text = "In Showcase";
            this.btnInShowcase.UseVisualStyleBackColor = false;
            this.btnInShowcase.Click += new System.EventHandler(this.btnInShowcase_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.ForeColor = System.Drawing.Color.Coral;
            this.panelChildForm.Location = new System.Drawing.Point(0, 114);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1116, 549);
            this.panelChildForm.TabIndex = 4;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // TenantMySalesItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1116, 663);
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