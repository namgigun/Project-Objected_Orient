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
            NickName_Label.Text = String.Format("{0} 님 환영합니다.", member.NickName);
        }

        private void Game1_Start_Btn_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            userInfo.Point += form.Manager.points;
        }

        private void Game2_Start_Btn_Click(object sender, EventArgs e)
        {
            가위바위보 rcp = new 가위바위보();
            rcp.ShowDialog();
            userInfo.Point += rcp.rSPManager.points;
        }

        private void Game3_Start_Btn_Click(object sender, EventArgs e)
        {
            RacconForm form = new RacconForm();
            form.ShowDialog();
            userInfo.Point += form.raManager.points;
        }

        private void Game4_Start_Btn_Click(object sender, EventArgs e)
        {
            MatchingForm matchingForm = new MatchingForm();
            matchingForm.ShowDialog();
            userInfo.Point += matchingForm.matchingManager.points;
        }

        private void Game7_Start_Btn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(); //error
            menuForm.ShowDialog();
            //userInfo.Point += 
    }
    }
}
