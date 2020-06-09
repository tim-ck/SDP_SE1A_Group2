namespace SDP_SE1A_Group2
{
    partial class TenantMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TenantMain));
            this.btnMyShowcase = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnRentShowcase = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnShowcase = new System.Windows.Forms.Button();
            this.panelShowcaseSubMenu = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnSalesItem = new System.Windows.Forms.Button();
            this.panelSalesItemSubMenu = new System.Windows.Forms.Panel();
            this.btnStockInItem = new System.Windows.Forms.Button();
            this.btnMySalesItem = new System.Windows.Forms.Button();
            this.panelRecordSubMenu = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.panelLogOut = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelShowcaseSubMenu.SuspendLayout();
            this.panelSalesItemSubMenu.SuspendLayout();
            this.panelRecordSubMenu.SuspendLayout();
            this.panelLogOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMyShowcase
            // 
            this.btnMyShowcase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyShowcase.FlatAppearance.BorderSize = 0;
            this.btnMyShowcase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.btnMyShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyShowcase.ForeColor = System.Drawing.Color.LightGray;
            this.btnMyShowcase.Location = new System.Drawing.Point(0, 40);
            this.btnMyShowcase.Name = "btnMyShowcase";
            this.btnMyShowcase.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMyShowcase.Size = new System.Drawing.Size(250, 40);
            this.btnMyShowcase.TabIndex = 0;
            this.btnMyShowcase.Text = "My Showcase";
            this.btnMyShowcase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyShowcase.UseVisualStyleBackColor = true;
            this.btnMyShowcase.Click += new System.EventHandler(this.btnMyShowcase_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Black;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.LightGray;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(250, 57);
            this.button6.TabIndex = 7;
            this.button6.Text = "Log out";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // btnRentShowcase
            // 
            this.btnRentShowcase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRentShowcase.FlatAppearance.BorderSize = 0;
            this.btnRentShowcase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRentShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRentShowcase.ForeColor = System.Drawing.Color.LightGray;
            this.btnRentShowcase.Location = new System.Drawing.Point(0, 0);
            this.btnRentShowcase.Name = "btnRentShowcase";
            this.btnRentShowcase.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnRentShowcase.Size = new System.Drawing.Size(250, 40);
            this.btnRentShowcase.TabIndex = 8;
            this.btnRentShowcase.Text = "Rent Showcase";
            this.btnRentShowcase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentShowcase.UseVisualStyleBackColor = true;
            this.btnRentShowcase.Click += new System.EventHandler(this.btnRentShowcase_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSideMenu.Controls.Add(this.panelLogOut);
            this.panelSideMenu.Controls.Add(this.panelRecordSubMenu);
            this.panelSideMenu.Controls.Add(this.btnRecord);
            this.panelSideMenu.Controls.Add(this.panelSalesItemSubMenu);
            this.panelSideMenu.Controls.Add(this.btnSalesItem);
            this.panelSideMenu.Controls.Add(this.panelShowcaseSubMenu);
            this.panelSideMenu.Controls.Add(this.btnShowcase);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 695);
            this.panelSideMenu.TabIndex = 17;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 18;
            // 
            // btnShowcase
            // 
            this.btnShowcase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowcase.FlatAppearance.BorderSize = 0;
            this.btnShowcase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.btnShowcase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowcase.ForeColor = System.Drawing.Color.LightGray;
            this.btnShowcase.Location = new System.Drawing.Point(0, 100);
            this.btnShowcase.Name = "btnShowcase";
            this.btnShowcase.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnShowcase.Size = new System.Drawing.Size(250, 45);
            this.btnShowcase.TabIndex = 19;
            this.btnShowcase.Text = "Showcase";
            this.btnShowcase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowcase.UseVisualStyleBackColor = true;
            this.btnShowcase.Click += new System.EventHandler(this.btnShowcase_Click);
            // 
            // panelShowcaseSubMenu
            // 
            this.panelShowcaseSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelShowcaseSubMenu.Controls.Add(this.btnMyShowcase);
            this.panelShowcaseSubMenu.Controls.Add(this.btnRentShowcase);
            this.panelShowcaseSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowcaseSubMenu.Location = new System.Drawing.Point(0, 145);
            this.panelShowcaseSubMenu.Name = "panelShowcaseSubMenu";
            this.panelShowcaseSubMenu.Size = new System.Drawing.Size(250, 85);
            this.panelShowcaseSubMenu.TabIndex = 20;
            this.panelShowcaseSubMenu.Visible = false;
            // 
            // btnSalesItem
            // 
            this.btnSalesItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesItem.FlatAppearance.BorderSize = 0;
            this.btnSalesItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.btnSalesItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesItem.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalesItem.Location = new System.Drawing.Point(0, 230);
            this.btnSalesItem.Name = "btnSalesItem";
            this.btnSalesItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalesItem.Size = new System.Drawing.Size(250, 45);
            this.btnSalesItem.TabIndex = 21;
            this.btnSalesItem.Text = "Sales Item";
            this.btnSalesItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesItem.UseVisualStyleBackColor = true;
            this.btnSalesItem.Click += new System.EventHandler(this.btnSalesItem_Click);
            // 
            // panelSalesItemSubMenu
            // 
            this.panelSalesItemSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSalesItemSubMenu.Controls.Add(this.btnStockInItem);
            this.panelSalesItemSubMenu.Controls.Add(this.btnMySalesItem);
            this.panelSalesItemSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalesItemSubMenu.Location = new System.Drawing.Point(0, 275);
            this.panelSalesItemSubMenu.Name = "panelSalesItemSubMenu";
            this.panelSalesItemSubMenu.Size = new System.Drawing.Size(250, 85);
            this.panelSalesItemSubMenu.TabIndex = 22;
            this.panelSalesItemSubMenu.Visible = false;
            // 
            // btnStockInItem
            // 
            this.btnStockInItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockInItem.FlatAppearance.BorderSize = 0;
            this.btnStockInItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.btnStockInItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockInItem.ForeColor = System.Drawing.Color.LightGray;
            this.btnStockInItem.Location = new System.Drawing.Point(0, 40);
            this.btnStockInItem.Name = "btnStockInItem";
            this.btnStockInItem.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStockInItem.Size = new System.Drawing.Size(250, 40);
            this.btnStockInItem.TabIndex = 0;
            this.btnStockInItem.Text = "Stock-in Item";
            this.btnStockInItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockInItem.UseVisualStyleBackColor = true;
            // 
            // btnMySalesItem
            // 
            this.btnMySalesItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMySalesItem.FlatAppearance.BorderSize = 0;
            this.btnMySalesItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnMySalesItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMySalesItem.ForeColor = System.Drawing.Color.LightGray;
            this.btnMySalesItem.Location = new System.Drawing.Point(0, 0);
            this.btnMySalesItem.Name = "btnMySalesItem";
            this.btnMySalesItem.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMySalesItem.Size = new System.Drawing.Size(250, 40);
            this.btnMySalesItem.TabIndex = 8;
            this.btnMySalesItem.Text = "My Sales Item";
            this.btnMySalesItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMySalesItem.UseVisualStyleBackColor = true;
            // 
            // panelRecordSubMenu
            // 
            this.panelRecordSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelRecordSubMenu.Controls.Add(this.button9);
            this.panelRecordSubMenu.Controls.Add(this.button10);
            this.panelRecordSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRecordSubMenu.Location = new System.Drawing.Point(0, 405);
            this.panelRecordSubMenu.Name = "panelRecordSubMenu";
            this.panelRecordSubMenu.Size = new System.Drawing.Size(250, 85);
            this.panelRecordSubMenu.TabIndex = 24;
            this.panelRecordSubMenu.Visible = false;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.LightGray;
            this.button9.Location = new System.Drawing.Point(0, 40);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(250, 40);
            this.button9.TabIndex = 0;
            this.button9.Text = "My Showcase";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.LightGray;
            this.button10.Location = new System.Drawing.Point(0, 0);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(250, 40);
            this.button10.TabIndex = 8;
            this.button10.Text = "Check Sales Record";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnRecord
            // 
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.FlatAppearance.BorderSize = 0;
            this.btnRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(49)))));
            this.btnRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecord.ForeColor = System.Drawing.Color.LightGray;
            this.btnRecord.Location = new System.Drawing.Point(0, 360);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRecord.Size = new System.Drawing.Size(250, 45);
            this.btnRecord.TabIndex = 23;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // panelLogOut
            // 
            this.panelLogOut.Controls.Add(this.button6);
            this.panelLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogOut.Location = new System.Drawing.Point(0, 490);
            this.panelLogOut.Name = "panelLogOut";
            this.panelLogOut.Size = new System.Drawing.Size(250, 67);
            this.panelLogOut.TabIndex = 25;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 100);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(250, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(962, 695);
            this.panelChildForm.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 695);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("PMingLiU", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form2";
            this.Text = "Tenant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelShowcaseSubMenu.ResumeLayout(false);
            this.panelSalesItemSubMenu.ResumeLayout(false);
            this.panelRecordSubMenu.ResumeLayout(false);
            this.panelLogOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMyShowcase;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnRentShowcase;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelShowcaseSubMenu;
        private System.Windows.Forms.Button btnShowcase;
        private System.Windows.Forms.Panel panelLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panelLogOut;
        private System.Windows.Forms.Panel panelRecordSubMenu;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Panel panelSalesItemSubMenu;
        private System.Windows.Forms.Button btnStockInItem;
        private System.Windows.Forms.Button btnMySalesItem;
        private System.Windows.Forms.Button btnSalesItem;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

