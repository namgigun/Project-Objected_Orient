namespace 객체지향_프로그래밍_프로젝트
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            NickName_Label = new Label();
            button9 = new Button();
            Mypage_Button = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(126, 184);
            button1.Name = "button1";
            button1.Size = new Size(113, 94);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(260, 184);
            button2.Name = "button2";
            button2.Size = new Size(113, 94);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(395, 184);
            button3.Name = "button3";
            button3.Size = new Size(113, 94);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(532, 184);
            button4.Name = "button4";
            button4.Size = new Size(113, 94);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(532, 294);
            button5.Name = "button5";
            button5.Size = new Size(113, 94);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(395, 294);
            button6.Name = "button6";
            button6.Size = new Size(113, 94);
            button6.TabIndex = 6;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(260, 294);
            button7.Name = "button7";
            button7.Size = new Size(113, 94);
            button7.TabIndex = 5;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(126, 294);
            button8.Name = "button8";
            button8.Size = new Size(113, 94);
            button8.TabIndex = 4;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // NickName_Label
            // 
            NickName_Label.AutoSize = true;
            NickName_Label.Location = new Point(126, 38);
            NickName_Label.Name = "NickName_Label";
            NickName_Label.Size = new Size(142, 20);
            NickName_Label.TabIndex = 8;
            NickName_Label.Text = "User 님 환영합니다.";
            // 
            // button9
            // 
            button9.Location = new Point(551, 38);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 11;
            button9.Text = "로그아웃";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Logout_Click;
            // 
            // Mypage_Button
            // 
            Mypage_Button.Location = new Point(551, 85);
            Mypage_Button.Name = "Mypage_Button";
            Mypage_Button.Size = new Size(94, 29);
            Mypage_Button.TabIndex = 12;
            Mypage_Button.Text = "마이페이지";
            Mypage_Button.UseVisualStyleBackColor = true;
            Mypage_Button.Click += Move_MyPage;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 148);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 13;
            label4.Text = "게임목록";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(Mypage_Button);
            Controls.Add(button9);
            Controls.Add(NickName_Label);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label NickName_Label;
        private Button button9;
        private Button Mypage_Button;
        private Label label4;
    }
}