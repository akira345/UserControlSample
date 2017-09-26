using System;
using System.Windows.Forms;

namespace UserControlSample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string user_id = this.loginForm1.login_user;
            string password = this.loginForm1.password;
            MessageBox.Show("ユーザID：" + user_id + System.Environment.NewLine + "パスワード：" + password + System.Environment.NewLine);
           
        }
    }
}
