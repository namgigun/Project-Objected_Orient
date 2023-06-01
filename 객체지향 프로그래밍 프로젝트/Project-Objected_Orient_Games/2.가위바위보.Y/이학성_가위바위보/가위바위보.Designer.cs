namespace 이학성_가위바위보
{
    partial class 가위바위보
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(가위바위보));
            this.lbCom = new System.Windows.Forms.Label();
            this.lbMe = new System.Windows.Forms.Label();
            this.gawei = new System.Windows.Forms.Button();
            this.bawei = new System.Windows.Forms.Button();
            this.bo = new System.Windows.Forms.Button();
            this.lbUserResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbComResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMeScore = new System.Windows.Forms.Label();
            this.lbComScore = new System.Windows.Forms.Label();
            this.lbDrawScore = new System.Windows.Forms.Label();
            this.lbTotalScore = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMeGawei = new System.Windows.Forms.Label();
            this.lbMeBawei = new System.Windows.Forms.Label();
            this.lbMeBo = new System.Windows.Forms.Label();
            this.lbComGawei = new System.Windows.Forms.Label();
            this.lbComBawei = new System.Windows.Forms.Label();
            this.lbComBo = new System.Windows.Forms.Label();
            this.btn_View_Result = new System.Windows.Forms.Button();
            this.Timer_View_Result = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Location = new System.Drawing.Point(12, 91);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(22, 15);
            this.lbCom.TabIndex = 0;
            this.lbCom.Text = "컴";
            // 
            // lbMe
            // 
            this.lbMe.AutoSize = true;
            this.lbMe.Location = new System.Drawing.Point(12, 218);
            this.lbMe.Name = "lbMe";
            this.lbMe.Size = new System.Drawing.Size(22, 15);
            this.lbMe.TabIndex = 1;
            this.lbMe.Text = "나";
            // 
            // gawei
            // 
            this.gawei.Image = ((System.Drawing.Image)(resources.GetObject("gawei.Image")));
            this.gawei.Location = new System.Drawing.Point(15, 303);
            this.gawei.Name = "gawei";
            this.gawei.Size = new System.Drawing.Size(100, 100);
            this.gawei.TabIndex = 2;
            this.gawei.Text = "가위";
            this.gawei.UseVisualStyleBackColor = true;
            this.gawei.Click += new System.EventHandler(this.gawei_Click);
            // 
            // bawei
            // 
            this.bawei.Image = ((System.Drawing.Image)(resources.GetObject("bawei.Image")));
            this.bawei.Location = new System.Drawing.Point(121, 303);
            this.bawei.Name = "bawei";
            this.bawei.Size = new System.Drawing.Size(100, 100);
            this.bawei.TabIndex = 3;
            this.bawei.Text = "바위";
            this.bawei.UseVisualStyleBackColor = true;
            this.bawei.Click += new System.EventHandler(this.bawei_Click);
            // 
            // bo
            // 
            this.bo.Image = ((System.Drawing.Image)(resources.GetObject("bo.Image")));
            this.bo.Location = new System.Drawing.Point(227, 303);
            this.bo.Name = "bo";
            this.bo.Size = new System.Drawing.Size(100, 100);
            this.bo.TabIndex = 4;
            this.bo.Text = "보";
            this.bo.UseVisualStyleBackColor = true;
            this.bo.Click += new System.EventHandler(this.bo_Click);
            // 
            // lbUserResult
            // 
            this.lbUserResult.AutoSize = true;
            this.lbUserResult.Location = new System.Drawing.Point(184, 218);
            this.lbUserResult.Name = "lbUserResult";
            this.lbUserResult.Size = new System.Drawing.Size(0, 15);
            this.lbUserResult.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(63, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // lbComResult
            // 
            this.lbComResult.AutoSize = true;
            this.lbComResult.Location = new System.Drawing.Point(186, 91);
            this.lbComResult.Name = "lbComResult";
            this.lbComResult.Size = new System.Drawing.Size(0, 15);
            this.lbComResult.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "가위바위보 결과";
            // 
            // lbMeScore
            // 
            this.lbMeScore.AutoSize = true;
            this.lbMeScore.Location = new System.Drawing.Point(396, 32);
            this.lbMeScore.Name = "lbMeScore";
            this.lbMeScore.Size = new System.Drawing.Size(122, 15);
            this.lbMeScore.TabIndex = 10;
            this.lbMeScore.Text = "내가 이긴 횟수 : ";
            // 
            // lbComScore
            // 
            this.lbComScore.AutoSize = true;
            this.lbComScore.Location = new System.Drawing.Point(396, 69);
            this.lbComScore.Name = "lbComScore";
            this.lbComScore.Size = new System.Drawing.Size(152, 15);
            this.lbComScore.TabIndex = 11;
            this.lbComScore.Text = "컴퓨터가 이긴 횟수 : ";
            // 
            // lbDrawScore
            // 
            this.lbDrawScore.AutoSize = true;
            this.lbDrawScore.Location = new System.Drawing.Point(396, 107);
            this.lbDrawScore.Name = "lbDrawScore";
            this.lbDrawScore.Size = new System.Drawing.Size(122, 15);
            this.lbDrawScore.TabIndex = 12;
            this.lbDrawScore.Text = "서로 비긴 횟수 : ";
            // 
            // lbTotalScore
            // 
            this.lbTotalScore.AutoSize = true;
            this.lbTotalScore.Location = new System.Drawing.Point(399, 173);
            this.lbTotalScore.Name = "lbTotalScore";
            this.lbTotalScore.Size = new System.Drawing.Size(235, 15);
            this.lbTotalScore.TabIndex = 13;
            this.lbTotalScore.Text = "총 0 번의 게임을 진행하였습니다.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "나";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "컴퓨터";
            // 
            // lbMeGawei
            // 
            this.lbMeGawei.AutoSize = true;
            this.lbMeGawei.Location = new System.Drawing.Point(402, 277);
            this.lbMeGawei.Name = "lbMeGawei";
            this.lbMeGawei.Size = new System.Drawing.Size(107, 15);
            this.lbMeGawei.TabIndex = 16;
            this.lbMeGawei.Text = "가위 낸 횟수 : ";
            // 
            // lbMeBawei
            // 
            this.lbMeBawei.AutoSize = true;
            this.lbMeBawei.Location = new System.Drawing.Point(402, 320);
            this.lbMeBawei.Name = "lbMeBawei";
            this.lbMeBawei.Size = new System.Drawing.Size(107, 15);
            this.lbMeBawei.TabIndex = 17;
            this.lbMeBawei.Text = "바위 낸 횟수 : ";
            // 
            // lbMeBo
            // 
            this.lbMeBo.AutoSize = true;
            this.lbMeBo.Location = new System.Drawing.Point(402, 358);
            this.lbMeBo.Name = "lbMeBo";
            this.lbMeBo.Size = new System.Drawing.Size(92, 15);
            this.lbMeBo.TabIndex = 18;
            this.lbMeBo.Text = "보 낸 횟수 : ";
            // 
            // lbComGawei
            // 
            this.lbComGawei.AutoSize = true;
            this.lbComGawei.Location = new System.Drawing.Point(583, 277);
            this.lbComGawei.Name = "lbComGawei";
            this.lbComGawei.Size = new System.Drawing.Size(107, 15);
            this.lbComGawei.TabIndex = 19;
            this.lbComGawei.Text = "가위 낸 횟수 : ";
            // 
            // lbComBawei
            // 
            this.lbComBawei.AutoSize = true;
            this.lbComBawei.Location = new System.Drawing.Point(583, 320);
            this.lbComBawei.Name = "lbComBawei";
            this.lbComBawei.Size = new System.Drawing.Size(107, 15);
            this.lbComBawei.TabIndex = 20;
            this.lbComBawei.Text = "바위 낸 횟수 : ";
            // 
            // lbComBo
            // 
            this.lbComBo.AutoSize = true;
            this.lbComBo.Location = new System.Drawing.Point(583, 358);
            this.lbComBo.Name = "lbComBo";
            this.lbComBo.Size = new System.Drawing.Size(92, 15);
            this.lbComBo.TabIndex = 21;
            this.lbComBo.Text = "보 낸 횟수 : ";
            // 
            // btn_View_Result
            // 
            this.btn_View_Result.Location = new System.Drawing.Point(252, 250);
            this.btn_View_Result.Name = "btn_View_Result";
            this.btn_View_Result.Size = new System.Drawing.Size(75, 23);
            this.btn_View_Result.TabIndex = 22;
            this.btn_View_Result.Text = "결과보기";
            this.btn_View_Result.UseVisualStyleBackColor = true;
            this.btn_View_Result.Click += new System.EventHandler(this.btn_View_Result_Click);
            // 
            // Timer_View_Result
            // 
            this.Timer_View_Result.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 가위바위보
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.btn_View_Result);
            this.Controls.Add(this.lbComBo);
            this.Controls.Add(this.lbComBawei);
            this.Controls.Add(this.lbComGawei);
            this.Controls.Add(this.lbMeBo);
            this.Controls.Add(this.lbMeBawei);
            this.Controls.Add(this.lbMeGawei);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbTotalScore);
            this.Controls.Add(this.lbDrawScore);
            this.Controls.Add(this.lbComScore);
            this.Controls.Add(this.lbMeScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbComResult);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbUserResult);
            this.Controls.Add(this.bo);
            this.Controls.Add(this.bawei);
            this.Controls.Add(this.gawei);
            this.Controls.Add(this.lbMe);
            this.Controls.Add(this.lbCom);
            this.MaximumSize = new System.Drawing.Size(760, 470);
            this.MinimumSize = new System.Drawing.Size(370, 470);
            this.Name = "가위바위보";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.가위바위보_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.Label lbMe;
        private System.Windows.Forms.Button gawei;
        private System.Windows.Forms.Button bawei;
        private System.Windows.Forms.Button bo;
        private System.Windows.Forms.Label lbUserResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbComResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMeScore;
        private System.Windows.Forms.Label lbComScore;
        private System.Windows.Forms.Label lbDrawScore;
        private System.Windows.Forms.Label lbTotalScore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMeGawei;
        private System.Windows.Forms.Label lbMeBawei;
        private System.Windows.Forms.Label lbMeBo;
        private System.Windows.Forms.Label lbComGawei;
        private System.Windows.Forms.Label lbComBawei;
        private System.Windows.Forms.Label lbComBo;
        private System.Windows.Forms.Button btn_View_Result;
        private System.Windows.Forms.Timer Timer_View_Result;
    }
}

