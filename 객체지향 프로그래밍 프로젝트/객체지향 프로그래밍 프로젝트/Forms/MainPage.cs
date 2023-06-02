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
using Mine;
using Raccoon;
using 이학성_가위바위보;
using TetrisGame.Forms;
using MatchingGame;
using TetrisGame;

namespace 객체지향_프로그래밍_프로젝트
{
    public partial class MainPage : Form
    {
        DBManager dbManager = new DBManager();
        Member member = new Member();
        public UserInfo userInfo = new UserInfo();

        public MainPage()
        {
            InitializeComponent();
        }

        public MainPage(Member member,UserInfo userInfo)
        {
            InitializeComponent();
            this.member = member;
            this.userInfo = userInfo;
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
            NickName_Label.Text = String.Format("{0} 님 환영합니다.", member.NickName);
        }

        private void Game1_Start_Btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();

            userInfo.Point += form.Manager.points;
            String Query = String.Format("UPDATE Data.userInfo SET Point = {0} WHERE NickName = '{1}';",userInfo.Point,userInfo.NickName);
            dbManager.update(Query);

            userInfo.HighScores[0] += form.Manager.Clear;
            Query = String.Format("UPDATE Data.userInfo SET HighScore_On_1 = {0} WHERE NickName = '{1}';", userInfo.HighScores[0], userInfo.NickName);
            dbManager.update(Query);
        }

        private void Game2_Start_Btn_Click(object sender, EventArgs e)
        {
            가위바위보 rcp = new 가위바위보();
            rcp.ShowDialog();

            userInfo.Point += rcp.rSPManager.points;
            String Query = String.Format("UPDATE Data.userInfo SET Point = {0} WHERE NickName = '{1}';", userInfo.Point, userInfo.NickName);
            dbManager.update(Query);

            if (userInfo.HighScores[1] < rcp.rSPManager.points)
            {
                userInfo.HighScores[1] = rcp.rSPManager.points;
                Query = String.Format("UPDATE Data.userInfo SET HighScore_On_2 = {0} WHERE NickName = '{1}';", userInfo.HighScores[1], userInfo.NickName);
                dbManager.update(Query);
            }
        }

        private void Game3_Start_Btn_Click(object sender, EventArgs e)
        {
            RacconForm form = new RacconForm();
            form.ShowDialog();

            userInfo.Point += form.raManager.points;
            MessageBox.Show(userInfo.NickName);
            String Query = String.Format("UPDATE Data.userInfo SET Point = {0} WHERE NickName = '{1}';", userInfo.Point, userInfo.NickName);
            dbManager.update(Query);

            if (userInfo.HighScores[2] < form.raManager.highScore) {
                userInfo.HighScores[2] = form.raManager.highScore;
                Query = String.Format("UPDATE Data.userInfo SET HighScore_On_3 = {0} WHERE NickName = '{1}';", userInfo.HighScores[2], userInfo.NickName);
                dbManager.update(Query);
            }
        }

        private void Game4_Start_Btn_Click(object sender, EventArgs e)
        {
            MatchingForm matchingForm = new MatchingForm();
            matchingForm.ShowDialog();

            userInfo.Point += matchingForm.matchingManager.points;
            String Query = String.Format("UPDATE Data.userInfo SET Point = {0} WHERE NickName = '{1}';", userInfo.Point, userInfo.NickName);
            dbManager.update(Query);

            if (userInfo.HighScores[3] > matchingForm.matchingManager.highScore)
            {
                userInfo.HighScores[3] = matchingForm.matchingManager.highScore;
                Query = String.Format("UPDATE Data.userInfo SET HighScore_On_4 = {0} WHERE NickName = '{1}';", userInfo.HighScores[3], userInfo.NickName);
                dbManager.update(Query);
            }
        }

        private void Game7_Start_Btn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(); //error
            menuForm.ShowDialog();

            userInfo.Point += menuForm.tetrisManager.points;
            String Query = String.Format("UPDATE Data.userInfo SET Point = {0} WHERE NickName = '{1}';", userInfo.Point, userInfo.NickName);
            dbManager.update(Query);

            if (userInfo.HighScores[6] < menuForm.tetrisManager.highScore) {
                userInfo.HighScores[6] = menuForm.tetrisManager.highScore;
                Query = String.Format("UPDATE Data.userInfo SET HighScore_On_7 = {0} WHERE NickName = '{1}';", userInfo.HighScores[6], userInfo.NickName);
                dbManager.update(Query);
            }
        }
    }
}
