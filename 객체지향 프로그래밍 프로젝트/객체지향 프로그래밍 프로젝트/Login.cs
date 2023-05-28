using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        DBManager dbManager = new DBManager();

        public Login()
        {
            InitializeComponent();
        }

        private void Move_Sign_Up(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            signUpPage.ShowDialog();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Boolean success = false;

            Member member = new Member();
            member.ID = IdBox.Text;
            member.PWD = PwdBox.Text; 

            String Query = String.Format("SELECT * FROM Data.Member");

            DataTable table = dbManager.select(Query);

           foreach(DataRow row in table.Rows)
           {
                if (member.ID == row["ID"].ToString() && member.PWD == row["PWD"].ToString()) {
                    MessageBox.Show("로그인 성공!");
                    success = true;
                    MainPage mainPage = new MainPage();
                    mainPage.ShowDialog();
                    break;
                }
           }

            if (!success) {
                MessageBox.Show("로그인 실패!");
            }
        }
    }
}
