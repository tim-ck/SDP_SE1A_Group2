namespace SDP_SE1A_Group2.Account
{
    partial class ForgotPasswordForm
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
            this.lblCloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoC = new System.Windows.Forms.RadioButton();
            this.rdoS = new System.Windows.Forms.RadioButton();
            this.rdoT = new System.Windows.Forms.RadioButton();
            this.btnSendemail = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtErrMsg = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCloseButton
            // 
            this.lblCloseButton.AutoSize = true;
            this.lblCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.lblCloseButton.Location = new System.Drawing.Point(527, -1);
            this.lblCloseButton.Name = "lblCloseButton";
            this.lblCloseButton.Size = new System.Drawing.Size(34, 40);
            this.lblCloseButton.TabIndex = 15;
            this.lblCloseButton.Text = "X";
            this.lblCloseButton.Click += new System.EventHandler(this.lblCloseButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(30, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 2);
            this.label1.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(98, 417);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(432, 36);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Text = "cck001117@gmail.com";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(115, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 54);
            this.label3.TabIndex = 20;
            this.label3.Text = "Account recovery";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(32, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(498, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Recover your Hong Kong Cube Shop account";
            // 
            // rdoC
            // 
            this.rdoC.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.rdoC.ForeColor = System.Drawing.Color.White;
            this.rdoC.Location = new System.Drawing.Point(24, 316);
            this.rdoC.Name = "rdoC";
            this.rdoC.Size = new System.Drawing.Size(146, 41);
            this.rdoC.TabIndex = 22;
            this.rdoC.TabStop = true;
            this.rdoC.Text = "Customer";
            this.rdoC.UseVisualStyleBackColor = true;
            this.rdoC.Click += new System.EventHandler(this.rdoT_Click);
            // 
            // rdoS
            // 
            this.rdoS.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.rdoS.ForeColor = System.Drawing.Color.White;
            this.rdoS.Location = new System.Drawing.Point(382, 316);
            this.rdoS.Name = "rdoS";
            this.rdoS.Size = new System.Drawing.Size(148, 41);
            this.rdoS.TabIndex = 24;
            this.rdoS.TabStop = true;
            this.rdoS.Text = "Staff";
            this.rdoS.UseVisualStyleBackColor = true;
            this.rdoS.Click += new System.EventHandler(this.rdoT_Click);
            // 
            // rdoT
            // 
            this.rdoT.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.rdoT.ForeColor = System.Drawing.Color.White;
            this.rdoT.Location = new System.Drawing.Point(202, 316);
            this.rdoT.Name = "rdoT";
            this.rdoT.Size = new System.Drawing.Size(148, 41);
            this.rdoT.TabIndex = 25;
            this.rdoT.TabStop = true;
            this.rdoT.Text = "Tenant";
            this.rdoT.UseVisualStyleBackColor = true;
            this.rdoT.Click += new System.EventHandler(this.rdoT_Click);
            // 
            // btnSendemail
            // 
            this.btnSendemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnSendemail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendemail.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btnSendemail.Location = new System.Drawing.Point(34, 557);
            this.btnSendemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendemail.Name = "btnSendemail";
            this.btnSendemail.Size = new System.Drawing.Size(490, 82);
            this.btnSendemail.TabIndex = 27;
            this.btnSendemail.Text = "Find my Password";
            this.btnSendemail.UseVisualStyleBackColor = false;
            this.btnSendemail.Click += new System.EventHandler(this.btnSendemail_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnBack.Location = new System.Drawing.Point(263, 677);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(260, 46);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = "Back To Sign In Page";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnForgotPassword_Click);
            // 
            // txtErrMsg
            // 
            this.txtErrMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.txtErrMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtErrMsg.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.txtErrMsg.ForeColor = System.Drawing.Color.Red;
            this.txtErrMsg.Location = new System.Drawing.Point(22, 472);
            this.txtErrMsg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtErrMsg.Multiline = true;
            this.txtErrMsg.Name = "txtErrMsg";
            this.txtErrMsg.Size = new System.Drawing.Size(508, 77);
            this.txtErrMsg.TabIndex = 57;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::SDP_SE1A_Group2.Properties.Resources.cubeLogo1;
            this.pictureBox1.Location = new System.Drawing.Point(200, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SDP_SE1A_Group2.Properties.Resources.email_P;
            this.pictureBox2.Location = new System.Drawing.Point(34, 397);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(58, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(558, 761);
            this.Controls.Add(this.txtErrMsg);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSendemail);
            this.Controls.Add(this.rdoT);
            this.Controls.Add(this.rdoS);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdoC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblCloseButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rdoS;
        private System.Windows.Forms.RadioButton rdoT;
        private System.Windows.Forms.Button btnSendemail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtErrMsg;
    }
}