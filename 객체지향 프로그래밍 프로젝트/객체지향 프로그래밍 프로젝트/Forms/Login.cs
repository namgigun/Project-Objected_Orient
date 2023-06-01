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

        public Boolean success = false;
        public Member member = new Member();
        public UserInfo userInfo = new UserInfo();

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
            success = false;
            Member member = new Member();
            member.ID = IdBox.Text;
            member.PWD = PwdBox.Text;

            String Query = String.Format("SELECT * FROM Data.Member");

            DataTable table = dbManager.select(Query);


            foreach (DataRow row in table.Rows)
            {
                if (member.ID == row["ID"].ToString() && member.PWD == row["PWD"].ToString())
                {
                    success = true;
                    member.NickName = row["NickName"].ToString();

                    Query = String.Format("SELECT * FROM Data.userInfo WHERE NickName = '{0}'", member.NickName);
                    table = dbManager.select(Query);

                    if (table == null)
                    {
                        MessageBox.Show("테이블 비었음");
                    }

                    else
                    {
                        DataRow Row = table.Rows[0];

                        userInfo.NickName = Row["NickName"].ToString();

                        userInfo.Point = int.Parse(Row["Point"].ToString());

                        userInfo.HighScores = new int[8];

                        userInfo.HighScores[0] = int.Parse(Row["HighScore_On_1"].ToString());
                        userInfo.HighScores[1] = int.Parse(Row["HighScore_On_2"].ToString());
                        userInfo.HighScores[2] = int.Parse(Row["HighScore_On_3"].ToString());
                        userInfo.HighScores[3] = int.Parse(Row["HighScore_On_4"].ToString());
                        userInfo.HighScores[4] = int.Parse(Row["HighScore_On_5"].ToString());
                        userInfo.HighScores[5] = int.Parse(Row["HighScore_On_6"].ToString());
                        userInfo.HighScores[6] = int.Parse(Row["HighScore_On_7"].ToString());
                        userInfo.HighScores[7] = int.Parse(Row["HighScore_On_8"].ToString());
                    }
                    break;
                }
            }

            if (success)
            {
                MessageBox.Show("로그인 성공!");

                // MainForm으로 돌아갑니다.
                MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                if (mainForm != null)
                {
                    mainForm.ReturnToMainForm(member,userInfo);
                }

                this.Close(); // LoginForm을 닫습니다.
            }
            else
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
