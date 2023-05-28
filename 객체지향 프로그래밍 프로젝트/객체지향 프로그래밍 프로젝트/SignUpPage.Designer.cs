namespace 객체지향_프로그래밍_프로젝트
{
    partial class SignUpPage
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
            nicknameBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            IdBox = new TextBox();
            label3 = new Label();
            PwdBox = new TextBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // nicknameBox
            // 
            nicknameBox.Location = new Point(267, 102);
            nicknameBox.Name = "nicknameBox";
            nicknameBox.Size = new Size(237, 27);
            nicknameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 102);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "닉네임";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 157);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "아이디";
            // 
            // IdBox
            // 
            IdBox.Location = new Point(267, 154);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(237, 27);
            IdBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 208);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "비밀번호";
            // 
            // PwdBox
            // 
            PwdBox.Location = new Point(267, 205);
            PwdBox.Name = "PwdBox";
            PwdBox.Size = new Size(237, 27);
            PwdBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(312, 259);
            button1.Name = "button1";
            button1.Size = new Size(126, 78);
            button1.TabIndex = 8;
            button1.Text = "가입하기";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SignUp_Button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(281, 39);
            label5.Name = "label5";
            label5.Size = new Size(199, 35);
            label5.TabIndex = 9;
            label5.Text = "회원가입 페이지";
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(PwdBox);
            Controls.Add(label2);
            Controls.Add(IdBox);
            Controls.Add(label1);
            Controls.Add(nicknameBox);
            Name = "SignUpPage";
            Text = "SignUpPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nicknameBox;
        private Label label1;
        private Label label2;
        private TextBox IdBox;
        private Label label3;
        private TextBox PwdBox;
        private Button button1;
        private Label label5;
    }
}