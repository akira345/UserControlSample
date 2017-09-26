namespace UserControlSample
{
    partial class Form2
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
            this.Btn_Login = new System.Windows.Forms.Button();
            this.loginForm1 = new UserControlSample.LoginForm();
            this.SuspendLayout();
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(59, 139);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(220, 23);
            this.Btn_Login.TabIndex = 1;
            this.Btn_Login.Text = "ログイン";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // loginForm1
            // 
            this.loginForm1.Location = new System.Drawing.Point(42, 12);
            this.loginForm1.login_user = "";
            this.loginForm1.MinimumSize = new System.Drawing.Size(298, 121);
            this.loginForm1.Name = "loginForm1";
            this.loginForm1.password = "";
            this.loginForm1.Size = new System.Drawing.Size(298, 121);
            this.loginForm1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 261);
            this.Controls.Add(this.loginForm1);
            this.Controls.Add(this.Btn_Login);
            this.Name = "Form2";
            this.Text = "あるシステム２";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_Login;
        private LoginForm loginForm1;
    }
}