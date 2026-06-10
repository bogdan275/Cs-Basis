namespace UI.Main
{
    partial class LoginForm
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
            buttonLogin = new Button();
            textBoxLoginLogin = new TextBox();
            textBoxLoginPassword = new TextBox();
            buttonRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxRole = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(132, 262);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(172, 29);
            buttonLogin.TabIndex = 1;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxLoginLogin
            // 
            textBoxLoginLogin.Location = new Point(26, 107);
            textBoxLoginLogin.Name = "textBoxLoginLogin";
            textBoxLoginLogin.Size = new Size(278, 27);
            textBoxLoginLogin.TabIndex = 2;
            // 
            // textBoxLoginPassword
            // 
            textBoxLoginPassword.Location = new Point(26, 160);
            textBoxLoginPassword.Name = "textBoxLoginPassword";
            textBoxLoginPassword.Size = new Size(278, 27);
            textBoxLoginPassword.TabIndex = 3;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(26, 262);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(100, 29);
            buttonRegister.TabIndex = 4;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(103, 22);
            label1.Name = "label1";
            label1.Size = new Size(113, 46);
            label1.TabIndex = 5;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 84);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 6;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 137);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 7;
            label3.Text = "Pasword";
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(26, 213);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(278, 28);
            comboBoxRole.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 190);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 9;
            label4.Text = "Role";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 303);
            Controls.Add(label4);
            Controls.Add(comboBoxRole);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxLoginPassword);
            Controls.Add(textBoxLoginLogin);
            Controls.Add(buttonLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonLogin;
        private TextBox textBoxLoginLogin;
        private TextBox textBoxLoginPassword;
        private Button buttonRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxRole;
        private Label label4;
    }
}