namespace Annons.Views
{
    partial class FrmLoginRegister
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
            lblFyndit = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            btnClose = new Button();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // lblFyndit
            // 
            lblFyndit.AutoSize = true;
            lblFyndit.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFyndit.Location = new Point(38, 39);
            lblFyndit.Name = "lblFyndit";
            lblFyndit.Size = new Size(142, 54);
            lblFyndit.TabIndex = 1;
            lblFyndit.Text = "Fyndit";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(38, 236);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(115, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-postadress";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(38, 264);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(38, 357);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(319, 31);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(38, 329);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 25);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Lösenord";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(38, 431);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Logga in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(200, 431);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(157, 34);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Registrera";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(235, 515);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(122, 40);
            btnClose.TabIndex = 8;
            btnClose.Text = "Gå tillbaka";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(38, 169);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(230, 30);
            lblLogin.TabIndex = 9;
            lblLogin.Text = "Logga in / Registrera";
            // 
            // FrmLoginRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 610);
            Controls.Add(lblLogin);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(lblFyndit);
            Name = "FrmLoginRegister";
            Text = "Logga in / Registrera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFyndit;
        private Label lblEmail;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnClose;
        private Label lblLogin;
    }
}