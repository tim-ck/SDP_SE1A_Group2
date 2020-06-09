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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBrowseItemPage = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnShoppingCartPage = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(200, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 74);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 101);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 539);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnShoppingCartPage);
            this.panel2.Controls.Add(this.btnBrowseItemPage);
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 702);
            this.panel2.TabIndex = 1;
            // 
            // btnBrowseItemPage
            // 
            this.btnBrowseItemPage.Location = new System.Drawing.Point(0, 0);
            this.btnBrowseItemPage.Name = "btnBrowseItemPage";
            this.btnBrowseItemPage.Size = new System.Drawing.Size(200, 83);
            this.btnBrowseItemPage.TabIndex = 0;
            this.btnBrowseItemPage.Text = "Browse Item";
            this.btnBrowseItemPage.UseVisualStyleBackColor = true;
            this.btnBrowseItemPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.Location = new System.Drawing.Point(200, 126);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1233, 702);
            this.panelChildForm.TabIndex = 2;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(1193, 13);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(230, 41);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go to Tenant Page ";
            this.btnGo.UseVisualStyleBackColor = true;
            // 
            // btnShoppingCartPage
            // 
            this.btnShoppingCartPage.Location = new System.Drawing.Point(0, 79);
            this.btnShoppingCartPage.Name = "btnShoppingCartPage";
            this.btnShoppingCartPage.Size = new System.Drawing.Size(200, 83);
            this.btnShoppingCartPage.TabIndex = 1;
            this.btnShoppingCartPage.Text = "Shopping Cart";
            this.btnShoppingCartPage.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(0, 336);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 83);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // CustomerMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 826);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerMain";
            this.Text = "customerMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBrowseItemPage;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnShoppingCartPage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}