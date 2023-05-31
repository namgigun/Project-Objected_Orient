using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 객체지향_프로그래밍_프로젝트
{
    public partial class SignUpPage : Form
    {
        DBManager dbManager = new DBManager();

        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            dbManager.insert(String.Format("INSERT INTO Data.Member (NickName, ID, PWD) VALUES ('{0}','{1}','{2}');"
                , nicknameBox.Text, IdBox.Text, PwdBox.Text));

            dbManager.insert(String.Format("INSERT INTO Data.userInfo VALUES ('{0}',0,0,0,0,0,0,0,0,0);", nicknameBox.Text));

            MessageBox.Show("회원가입에 성공하셨습니다!");
            this.Close();
        }
    }
}
