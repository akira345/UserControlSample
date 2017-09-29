using System;
using System.Drawing;
using System.Windows.Forms;

namespace UserControlSample
{
    public partial class LoginForm : UserControl
    {
        public LoginForm()
        {
            InitializeComponent();
            Lbl_ID_Caution.Text = "";
            Lbl_Pw_Caution.Text = "";
            Txt_UserID.Text = "";
            Txt_Password.Text = "";
            this.MinimumSize =new Size(298, 121);//大きさ固定


        }
        public string login_user {
            get { return this.Txt_UserID.Text; }
            set { this.Txt_UserID.Text = this.login_user; }
        }
        public string password
        {
            get { return this.Txt_Password.Text; }
            set { this.Txt_Password.Text = this.password; }
        }

        private void Txt_UserID_TextChanged(object sender, EventArgs e)
        {
            Lbl_ID_Caution.Text = "";
            if (string.IsNullOrEmpty(Txt_UserID.Text))
            {
                Lbl_ID_Caution.Text = "ユーザIDを入れてください。";
            }
            //Login_Txt_UserID_Changedがnullでなければ、イベントハンドラを外部へ通知する。
            Login_Txt_UserID_Changed?.Invoke(sender, e);

        }

        private void Txt_Password_TextChanged(object sender, EventArgs e)
        {
            Lbl_Pw_Caution.Text = "";
            if (string.IsNullOrEmpty(Txt_Password.Text))
            {
                Lbl_Pw_Caution.Text = "パスワードを入れてください。";
            }
        }
        //公開イベントハンドラを作成し、イベントを外部へ通知する。
        public event EventHandler Login_Txt_UserID_Changed;
       
    }
}
