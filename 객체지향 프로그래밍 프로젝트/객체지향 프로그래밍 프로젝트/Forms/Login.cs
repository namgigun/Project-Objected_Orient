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

        private void Login_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

            private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.PrimaryColor;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Boolean success = false;

            Member member = new Member();
            member.ID = IdBox.Text;
            member.PWD = PwdBox.Text;

            String Query = String.Format("SELECT * FROM Data.Member");

            DataTable table = dbManager.select(Query);


            foreach (DataRow row in table.Rows)
            {
                if (member.ID == row["ID"].ToString() && member.PWD == row["PWD"].ToString())
                {
                    MessageBox.Show("로그인 성공!");
                    success = true;
                    member.NickName = row["NickName"].ToString();
                    MainPage mainPage = new MainPage(member);
                    mainPage.ShowDialog();
                    break;
                }
            }

            if (!success)
            {
                MessageBox.Show("로그인 실패!");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}
