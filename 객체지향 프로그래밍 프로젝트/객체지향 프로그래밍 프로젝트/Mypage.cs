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

        private void Mypage_Load(object sender, EventArgs e)
        {
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
