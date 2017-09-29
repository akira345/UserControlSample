using System;
using System.Windows.Forms;

namespace UserControlSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.loginForm1.Select();//カーソルをユーザコントロールへもっていく
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string user_id = this.loginForm1.login_user;
            string password = this.loginForm1.password;
            MessageBox.Show("ユーザID：" + user_id + System.Environment.NewLine + "パスワード：" + password + System.Environment.NewLine);
            
        }
        private void Login_Txt_UserID_Changed(object sender, EventArgs e)
        {
            Console.WriteLine("変更されました。");
        }
    }
}
