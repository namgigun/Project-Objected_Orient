﻿namespace 객체지향_프로그래밍_프로젝트
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
            Game1_Start_Btn = new Button();
            Game2_Start_Btn = new Button();
            Game3_Start_Btn = new Button();
            Game4_Start_Btn = new Button();
            Game7_Start_Btn = new Button();
            NickName_Label = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Game1_Start_Btn
            // 
            Game1_Start_Btn.Location = new Point(187, 183);
            Game1_Start_Btn.Name = "Game1_Start_Btn";
            Game1_Start_Btn.Size = new Size(113, 94);
            Game1_Start_Btn.TabIndex = 0;
            Game1_Start_Btn.Text = "지뢰찾기";
            Game1_Start_Btn.UseVisualStyleBackColor = true;
            Game1_Start_Btn.Click += Game1_Start_Btn_Click;
            // 
            // Game2_Start_Btn
            // 
            Game2_Start_Btn.Location = new Point(321, 183);
            Game2_Start_Btn.Name = "Game2_Start_Btn";
            Game2_Start_Btn.Size = new Size(113, 94);
            Game2_Start_Btn.TabIndex = 1;
            Game2_Start_Btn.Text = "가위바위보";
            Game2_Start_Btn.UseVisualStyleBackColor = true;
            Game2_Start_Btn.Click += Game2_Start_Btn_Click;
            // 
            // Game3_Start_Btn
            // 
            Game3_Start_Btn.Location = new Point(456, 183);
            Game3_Start_Btn.Name = "Game3_Start_Btn";
            Game3_Start_Btn.Size = new Size(113, 94);
            Game3_Start_Btn.TabIndex = 2;
            Game3_Start_Btn.Text = "Raccoon";
            Game3_Start_Btn.UseVisualStyleBackColor = true;
            Game3_Start_Btn.Click += Game3_Start_Btn_Click;
            // 
            // Game4_Start_Btn
            // 
            Game4_Start_Btn.Location = new Point(321, 302);
            Game4_Start_Btn.Name = "Game4_Start_Btn";
            Game4_Start_Btn.Size = new Size(113, 94);
            Game4_Start_Btn.TabIndex = 3;
            Game4_Start_Btn.Text = "Matching Game";
            Game4_Start_Btn.UseVisualStyleBackColor = true;
            Game4_Start_Btn.Click += Game4_Start_Btn_Click;
            // 
            // Game7_Start_Btn
            // 
            Game7_Start_Btn.Location = new Point(187, 302);
            Game7_Start_Btn.Name = "Game7_Start_Btn";
            Game7_Start_Btn.Size = new Size(113, 94);
            Game7_Start_Btn.TabIndex = 6;
            Game7_Start_Btn.Text = "테트리스";
            Game7_Start_Btn.UseVisualStyleBackColor = true;
            Game7_Start_Btn.Click += Game7_Start_Btn_Click;
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
            Controls.Add(NickName_Label);
            Controls.Add(Game7_Start_Btn);
            Controls.Add(Game4_Start_Btn);
            Controls.Add(Game3_Start_Btn);
            Controls.Add(Game2_Start_Btn);
            Controls.Add(Game1_Start_Btn);
            Name = "MainPage";
            Text = "MainPage";
            Load += MainPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Game1_Start_Btn;
        private Button Game2_Start_Btn;
        private Button Game3_Start_Btn;
        private Button Game4_Start_Btn;
        private Button Game7_Start_Btn;
        private Label NickName_Label;
        private Label label4;
    }
}