namespace CodeFirst
{
    partial class loginForm
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label_userName = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_otmena = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(38, 43);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(151, 20);
            this.UserName.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(38, 105);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '●';
            this.Password.Size = new System.Drawing.Size(151, 20);
            this.Password.TabIndex = 1;
            // 
            // label_userName
            // 
            this.label_userName.AutoSize = true;
            this.label_userName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_userName.Location = new System.Drawing.Point(38, 23);
            this.label_userName.Margin = new System.Windows.Forms.Padding(4);
            this.label_userName.Name = "label_userName";
            this.label_userName.Size = new System.Drawing.Size(41, 15);
            this.label_userName.TabIndex = 2;
            this.label_userName.Text = "Логин";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(38, 85);
            this.label_password.Margin = new System.Windows.Forms.Padding(4);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(49, 15);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Пароль";
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_ok.Location = new System.Drawing.Point(19, 159);
            this.button_ok.Margin = new System.Windows.Forms.Padding(10);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(95, 30);
            this.button_ok.TabIndex = 4;
            this.button_ok.Text = "ОК";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_otmena
            // 
            this.button_otmena.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_otmena.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_otmena.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_otmena.Location = new System.Drawing.Point(194, 159);
            this.button_otmena.Margin = new System.Windows.Forms.Padding(10);
            this.button_otmena.Name = "button_otmena";
            this.button_otmena.Size = new System.Drawing.Size(95, 30);
            this.button_otmena.TabIndex = 5;
            this.button_otmena.Text = "Отмена";
            this.button_otmena.UseVisualStyleBackColor = false;
            this.button_otmena.Click += new System.EventHandler(this.button_otmena_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 211);
            this.Controls.Add(this.button_otmena);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_userName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Name = "LoginForm";
            this.Text = "LoginForm ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_userName;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_otmena;
        public System.Windows.Forms.TextBox UserName;
        public System.Windows.Forms.TextBox Password;
    }
}