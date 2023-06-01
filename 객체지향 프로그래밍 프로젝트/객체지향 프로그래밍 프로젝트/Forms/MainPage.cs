using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Galaga_assign;
using MatchingGame;
using Mine;
using Raccoon;
using Snake;
using 이학성_가위바위보;
using TetrisGame.Forms;

namespace 객체지향_프로그래밍_프로젝트
{
    public partial class MainPage : Form
    {
        DBManager dbManager = new DBManager();
        Member member = new Member();
        UserInfo userInfo = new UserInfo();

        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(Member member)
        {
            InitializeComponent();
            this.member = member;
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
            label4.ForeColor = ThemeColor.SecondaryColor;
            NickName_Label.ForeColor = ThemeColor.PrimaryColor;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadTheme();
            //NickName_Label.Text = String.Format("{0} 님 환영합니다.", member.NickName);
            //String Query = String.Format("SELECT * FROM Data.userInfo WHERE NickName = '{0}'", member.NickName);
            //DataTable table = dbManager.select(Query);

            //if (table == null)
            //{
            //    MessageBox.Show("테이블 비었음");
            //}

            //else
            //{
            //    DataRow Row = table.Rows[0];

            //    userInfo.NickName = Row["NickName"].ToString();

            //    userInfo.Point = int.Parse(Row["Point"].ToString());

            //    userInfo.HighScores = new int[8];

            //    userInfo.HighScores[0] = int.Parse(Row["HighScore_On_1"].ToString());
            //    userInfo.HighScores[1] = int.Parse(Row["HighScore_On_2"].ToString());
            //    userInfo.HighScores[2] = int.Parse(Row["HighScore_On_3"].ToString());
            //    userInfo.HighScores[3] = int.Parse(Row["HighScore_On_4"].ToString());
            //    userInfo.HighScores[4] = int.Parse(Row["HighScore_On_5"].ToString());
            //    userInfo.HighScores[5] = int.Parse(Row["HighScore_On_6"].ToString());
            //    userInfo.HighScores[6] = int.Parse(Row["HighScore_On_7"].ToString());
            //    userInfo.HighScores[7] = int.Parse(Row["HighScore_On_8"].ToString());
            //}

        }

        private void Move_MyPage(object sender, EventArgs e)
        {
            Mypage mypage = new Mypage(userInfo);
            mypage.ShowDialog();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            // 지금까지 게임했던 정보저장.
        }

        private void Game1_Start_Btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void Game2_Start_Btn_Click(object sender, EventArgs e)
        {
            가위바위보 rcp = new 가위바위보();
            rcp.ShowDialog();
        }

        private void Game3_Start_Btn_Click(object sender, EventArgs e)
        {
            RacconForm form = new RacconForm();
            form.ShowDialog();
        }

        private void Game4_Start_Btn_Click(object sender, EventArgs e)
        {
            MatchingForm form = new MatchingForm();
            form.ShowDialog();
        }

        private void Game5_Start_Btn_Click(object sender, EventArgs e)
        {
            MainConsole console = new MainConsole();
            console.ShowDialog();
        }

        private void Game6_Start_Btn_Click(object sender, EventArgs e)
        {
            SnakeForm snakeForm = new SnakeForm(); //빌드오류
            snakeForm.ShowDialog();
        }

        private void Game7_Start_Btn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(); //error
            menuForm.ShowDialog();
        }

        private void Game8_Start_Btn_Click(object sender, EventArgs e)
        {
            GalagaForm galagaForm = new GalagaForm();
            galagaForm.ShowDialog();
        }
    }
}
