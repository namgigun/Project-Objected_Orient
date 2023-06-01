using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSPGame;

namespace 이학성_가위바위보
{
    public partial class 가위바위보 : Form
    {
        int MeScore, ComScore, DrawScore, TotalScore = 0;
        int Me_Gawei, Me_Bawei, Me_Bo = 0;
        bool result_view;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int size = 20;
            if (!result_view)
            {
                if(Width >= MaximumSize.Width)
                {
                    Width = MaximumSize.Width;
                    result_view = true;
                    btn_View_Result.Text = "결과 접기 ◀";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width += size;
                }
            }
            else
            {
                if(Width <= MinimumSize.Width)
                {
                    Width = MinimumSize.Width;
                    result_view = false;
                    btn_View_Result.Text = "결과 보기 ▶";
                    Timer_View_Result.Stop();
                }
                else
                {
                    Width -= size;
                }
            }
        }

        private void btn_View_Result_Click(object sender, EventArgs e)
        {
            Timer_View_Result.Start();
        }

        
        int Com_Gawei, Com_Bawei, Com_Bo = 0;
        public 가위바위보()
        {
            InitializeComponent();
        }
        /*
        private void gawei_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "Images/gawei.jpg";
            //RSPMachine.intToRSPChoiceString(RSPMachine.RSPChoice.PAPER);
            RSPMachine.RSPChoiceTostring(RSPMachine.RSPChoice.SCISSORS);
            switch (RSPMachine.getRandomRSPChoice())
            {
                case RSPMachine.RSPChoice.PAPER:
                    pictureBox1.ImageLocation = "Images/bo.jpg";
                    lbUserResult.Text = "WIN";
                    lbComResult.Text = "LOSE";
                    MeScore++;
                    lbMeScore.Text = "내가 이긴 횟수 : "+MeScore; 
                    Me_Gawei++;
                    lbMeGawei.Text = "가위 낸 횟수 : "+Me_Gawei;
                    Com_Bo++;
                    lbComBo.Text = "보 낸 횟수 : "+Com_Bo;
                    break;
                case RSPMachine.RSPChoice.ROCK:
                    pictureBox1.ImageLocation = "Images/bawei.jpg";
                    lbUserResult.Text = "LOSE";
                    lbComResult.Text = "WIN";
                    ComScore++;
                    lbComScore.Text = "컴퓨터가 이긴 횟수 : " + ComScore;
                    Me_Gawei++;
                    lbMeGawei.Text = "가위 낸 횟수 : " + Me_Gawei;
                    Com_Bawei++;
                    lbComBawei.Text = "바위 낸 횟수 : " + Com_Bawei;
                    break;
                case RSPMachine.RSPChoice.SCISSORS:
                    pictureBox1.ImageLocation = "Images/gawei.jpg";
                    lbUserResult.Text = "DRAW";
                    lbComResult.Text = "DRAW";
                    DrawScore++;
                    lbDrawScore.Text = "서로 비긴 횟수 : "+ DrawScore;
                    Me_Gawei++;
                    lbMeGawei.Text = "가위 낸 횟수 : " + Me_Gawei;
                    Com_Gawei++;
                    lbComGawei.Text = "가위 낸 횟수 : " + Me_Gawei;
                    break;
            }
            TotalScore++;
            lbTotalScore.Text = "총 " + TotalScore + " 번의 게임을 진행하였습니다.";
        }

        private void bawei_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "Images/bawei.jpg";
            RSPMachine.RSPChoiceTostring(RSPMachine.RSPChoice.ROCK);
            switch (RSPMachine.getRandomRSPChoice())
            {
                case RSPMachine.RSPChoice.PAPER:
                    pictureBox1.ImageLocation = "Images/bo.jpg";
                    lbUserResult.Text = "LOSE";
                    lbComResult.Text = "WIN";
                    ComScore++;
                    lbComScore.Text = "컴퓨터가 이긴 횟수 : " + ComScore;
                    Me_Bawei++;
                    lbMeBawei.Text = "바위 낸 횟수 : " + Me_Bawei;
                    Com_Bo++;
                    lbComBo.Text = "보 낸 횟수 : " + Com_Bo;
                    break;
                case RSPMachine.RSPChoice.ROCK:
                    pictureBox1.ImageLocation = "Images/bawei.jpg";
                    lbUserResult.Text = "DRAW";
                    lbComResult.Text = "DRAW";
                    DrawScore++;
                    lbDrawScore.Text = "서로 비긴 횟수 : " + DrawScore;
                    Me_Bawei++;
                    lbMeBawei.Text = "바위 낸 횟수 : " + Me_Bawei;
                    Com_Bawei++;
                    lbComBawei.Text = "바위 낸 횟수 : " + Com_Bawei;
                    break;
                case RSPMachine.RSPChoice.SCISSORS:
                    pictureBox1.ImageLocation = "Images/gawei.jpg";
                    lbUserResult.Text = "WIN";
                    lbComResult.Text = "LOSE";
                    MeScore++;
                    lbMeScore.Text = "내가 이긴 횟수 : " + MeScore;
                    Me_Bawei++;
                    lbMeBawei.Text = "바위 낸 횟수 : " + Me_Bawei;
                    Com_Gawei++;
                    lbComGawei.Text = "가위 낸 횟수 : " + Me_Gawei;
                    break;
            }
            TotalScore++;
            lbTotalScore.Text = "총 " + TotalScore + " 번의 게임을 진행하였습니다.";
        }

        private void bo_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = "Images/bo.jpg";
            RSPMachine.RSPChoiceTostring(RSPMachine.RSPChoice.PAPER);

            switch (RSPMachine.getRandomRSPChoice())
            {
                case RSPMachine.RSPChoice.PAPER:
                    pictureBox1.ImageLocation = "Images/bo.jpg";
                    lbUserResult.Text = "DRAW";
                    lbComResult.Text = "DRAW";
                    DrawScore++;
                    lbDrawScore.Text = "서로 비긴 횟수 : " + DrawScore;
                    Me_Bo++;
                    lbMeBo.Text = "보 낸 횟수 : " + Me_Bo;
                    Com_Bo++;
                    lbComBo.Text = "보 낸 횟수 : " + Com_Bo;
                    break;
                case RSPMachine.RSPChoice.ROCK:
                    pictureBox1.ImageLocation = "Images/bawei.jpg";
                    lbUserResult.Text = "WIN";
                    lbComResult.Text = "LOSE";
                    MeScore++;
                    lbMeScore.Text = "내가 이긴 횟수 : " + MeScore;
                    Me_Bo++;
                    lbMeBo.Text = "보 낸 횟수 : " + Me_Bo;
                    Com_Bawei++;
                    lbComBawei.Text = "바위 낸 횟수 : " + Com_Bawei;
                    break;
                case RSPMachine.RSPChoice.SCISSORS:
                    pictureBox1.ImageLocation = "Images/gawei.jpg";
                    lbUserResult.Text = "LOSE";
                    lbComResult.Text = "WIN";
                    ComScore++;
                    lbComScore.Text = "컴퓨터가 이긴 횟수 : " + ComScore;
                    Me_Bo++;
                    lbMeBo.Text = "보 낸 횟수 : " + Me_Bo;
                    Com_Gawei++;
                    lbComGawei.Text = "가위 낸 횟수 : " + Com_Gawei;
                    break;
            }
            TotalScore++;
            lbTotalScore.Text = "총 " + TotalScore + " 번의 게임을 진행하였습니다.";
        }
        */
        private void gawei_Click(object sender, EventArgs e)
        {
            CheckRGP(1);
        }

        private void bawei_Click(object sender, EventArgs e)
        {
            CheckRGP(2);
        }

        private void bo_Click(object sender, EventArgs e)
        {
            CheckRGP(3);
        }
        void CheckRGP(int my_cho)
        {
            if (my_cho == 1)
            {
                pictureBox2.ImageLocation = "Images/gawei.jpg";
                RSPMachine.RSPChoiceTostring(RSPMachine.RSPChoice.SCISSORS);
                        pictureBox1.ImageLocation = "Images/bawei.jpg";
                        lbUserResult.Text = "LOSE";
                        lbComResult.Text = "WIN";
                        ComScore++;
                        lbComScore.Text = "컴퓨터가 이긴 횟수 : " + ComScore;
                        Me_Gawei++;
                        lbMeGawei.Text = "가위 낸 횟수 : " + Me_Gawei;
                        Com_Bawei++;
                        lbComBawei.Text = "바위 낸 횟수 : " + Com_Bawei;
            }
            else if (my_cho == 2)
            {
                pictureBox2.ImageLocation = "Images/bawei.jpg";
                RSPMachine.RSPChoiceTostring(RSPMachine.RSPChoice.ROCK);
                        pictureBox1.ImageLocation = "Images/bo.jpg";
                        lbUserResult.Text = "LOSE";
                        lbComResult.Text = "WIN";
                        ComScore++;
                        lbComScore.Text = "컴퓨터가 이긴 횟수 : " + ComScore;
                        Me_Bawei++;
                        lbMeBawei.Text = "바위 낸 횟수 : " + Me_Bawei;
                        Com_Bo++;
                        lbComBo.Text = "보 낸 횟수 : " + Com_Bo;
                
            }
            else if (my_cho == 3)
            {
                        pictureBox1.ImageLocation = "Images/gawei.jpg";
                        lbUserResult.Text = "LOSE";
                        lbComResult.Text = "WIN";
                        ComScore++;
                        lbComScore.Text = "컴퓨터가 이긴 횟수 : " + ComScore;
                        Me_Bo++;
                        lbMeBo.Text = "보 낸 횟수 : " + Me_Bo;
                        Com_Gawei++;
                        lbComGawei.Text = "가위 낸 횟수 : " + Com_Gawei;
            }
            TotalScore++;
            lbTotalScore.Text = "총 " + TotalScore + " 번의 게임을 진행하였습니다.";
        }
    }
}
