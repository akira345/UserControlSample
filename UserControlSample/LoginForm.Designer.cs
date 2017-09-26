namespace UserControlSample
{
    partial class LoginForm
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_UserID = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Lbl_ID_Caution = new System.Windows.Forms.Label();
            this.Lbl_Pw_Caution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Txt_UserID
            // 
            this.Txt_UserID.Location = new System.Drawing.Point(99, 24);
            this.Txt_UserID.Name = "Txt_UserID";
            this.Txt_UserID.Size = new System.Drawing.Size(155, 19);
            this.Txt_UserID.TabIndex = 2;
            this.Txt_UserID.TextChanged += new System.EventHandler(this.Txt_UserID_TextChanged);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(99, 66);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(155, 19);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.UseSystemPasswordChar = true;
            this.Txt_Password.TextChanged += new System.EventHandler(this.Txt_Password_TextChanged);
            // 
            // Lbl_ID_Caution
            // 
            this.Lbl_ID_Caution.AutoSize = true;
            this.Lbl_ID_Caution.ForeColor = System.Drawing.Color.Red;
            this.Lbl_ID_Caution.Location = new System.Drawing.Point(107, 51);
            this.Lbl_ID_Caution.Name = "Lbl_ID_Caution";
            this.Lbl_ID_Caution.Size = new System.Drawing.Size(128, 12);
            this.Lbl_ID_Caution.TabIndex = 4;
            this.Lbl_ID_Caution.Text = "ユーザIDを入れてください。";
            // 
            // Lbl_Pw_Caution
            // 
            this.Lbl_Pw_Caution.AutoSize = true;
            this.Lbl_Pw_Caution.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Pw_Caution.Location = new System.Drawing.Point(107, 88);
            this.Lbl_Pw_Caution.Name = "Lbl_Pw_Caution";
            this.Lbl_Pw_Caution.Size = new System.Drawing.Size(134, 12);
            this.Lbl_Pw_Caution.TabIndex = 5;
            this.Lbl_Pw_Caution.Text = "パスワードを入れてください。";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Pw_Caution);
            this.Controls.Add(this.Lbl_ID_Caution);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_UserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Size = new System.Drawing.Size(298, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_UserID;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label Lbl_ID_Caution;
        private System.Windows.Forms.Label Lbl_Pw_Caution;
    }
}
