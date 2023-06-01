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
            SignUp_Btn = new Button();
            label5 = new Label();
            NickName_Chk_Btn = new Button();
            Id_Chk_Btn = new Button();
            SuspendLayout();
            // 
            // nicknameBox
            // 
            nicknameBox.Location = new Point(269, 134);
            nicknameBox.Name = "nicknameBox";
            nicknameBox.Size = new Size(237, 27);
            nicknameBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 134);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 1;
            label1.Text = "닉네임";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 189);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 3;
            label2.Text = "아이디";
            // 
            // IdBox
            // 
            IdBox.Location = new Point(269, 186);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(237, 27);
            IdBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 240);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 5;
            label3.Text = "비밀번호";
            // 
            // PwdBox
            // 
            PwdBox.Location = new Point(269, 237);
            PwdBox.Name = "PwdBox";
            PwdBox.Size = new Size(237, 27);
            PwdBox.TabIndex = 4;
            // 
            // SignUp_Btn
            // 
            SignUp_Btn.Location = new Point(314, 291);
            SignUp_Btn.Name = "SignUp_Btn";
            SignUp_Btn.Size = new Size(126, 78);
            SignUp_Btn.TabIndex = 8;
            SignUp_Btn.Text = "가입하기";
            SignUp_Btn.UseVisualStyleBackColor = true;
            SignUp_Btn.Click += SignUp_Button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(283, 71);
            label5.Name = "label5";
            label5.Size = new Size(199, 35);
            label5.TabIndex = 9;
            label5.Text = "회원가입 페이지";
            // 
            // NickName_Chk_Btn
            // 
            NickName_Chk_Btn.Location = new Point(523, 134);
            NickName_Chk_Btn.Name = "NickName_Chk_Btn";
            NickName_Chk_Btn.Size = new Size(94, 29);
            NickName_Chk_Btn.TabIndex = 10;
            NickName_Chk_Btn.Text = "중복확인";
            NickName_Chk_Btn.UseVisualStyleBackColor = true;
            NickName_Chk_Btn.Click += NickName_Chk_Btn_Click;
            // 
            // Id_Chk_Btn
            // 
            Id_Chk_Btn.Location = new Point(523, 184);
            Id_Chk_Btn.Name = "Id_Chk_Btn";
            Id_Chk_Btn.Size = new Size(94, 29);
            Id_Chk_Btn.TabIndex = 10;
            Id_Chk_Btn.Text = "중복확인";
            Id_Chk_Btn.UseVisualStyleBackColor = true;
            Id_Chk_Btn.Click += Id_Chk_Btn_Click;
            // 
            // SignUpPage
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Id_Chk_Btn);
            Controls.Add(NickName_Chk_Btn);
            Controls.Add(label5);
            Controls.Add(SignUp_Btn);
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
        private Button SignUp_Btn;
        private Label label5;
        private Button NickName_Chk_Btn;
        private Button Id_Chk_Btn;
    }
}