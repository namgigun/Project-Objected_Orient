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
    public partial class Mypage : Form
    {
        UserInfo userinfo = new UserInfo();

        public Mypage()
        {
            InitializeComponent();
        }

        public Mypage(UserInfo userInfo)
        {
            InitializeComponent();
            this.userinfo = userInfo;
        }
        //private void Mypage_Load(object sender, EventArgs e)
        //{
        //    LoadTheme();
        //}

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
            label3.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.SecondaryColor;
            label6.ForeColor = ThemeColor.SecondaryColor;
            label7.ForeColor = ThemeColor.SecondaryColor;
            label8.ForeColor = ThemeColor.SecondaryColor;
            label9.ForeColor = ThemeColor.SecondaryColor;
            label10.ForeColor = ThemeColor.SecondaryColor;
            label11.ForeColor = ThemeColor.SecondaryColor;
            label1.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            label12.ForeColor = ThemeColor.PrimaryColor;
            Point_Label.ForeColor = ThemeColor.PrimaryColor;
            HighScore_1.ForeColor = ThemeColor.PrimaryColor;
            HighScore_2.ForeColor = ThemeColor.PrimaryColor;
            HighScore_3.ForeColor = ThemeColor.PrimaryColor;
            HighScore_4.ForeColor = ThemeColor.PrimaryColor;
            HighScore_5.ForeColor = ThemeColor.PrimaryColor;
            HighScore_6.ForeColor = ThemeColor.PrimaryColor;
            HighScore_7.ForeColor = ThemeColor.PrimaryColor;
            HighScore_8.ForeColor = ThemeColor.PrimaryColor;
        }

        private void Mypage_Load(object sender, EventArgs e)
        {
            LoadTheme();
            Label[] highScoreLabels = { HighScore_1, HighScore_2, HighScore_3, HighScore_4,
                HighScore_5, HighScore_6, HighScore_7, HighScore_8 };

            for (int i = 0; i < 8; i++)
            {
                highScoreLabels[i].Text = userinfo.HighScores[i].ToString();
            }

            Point_Label.Text = userinfo.Point.ToString();
        }
    }
}
