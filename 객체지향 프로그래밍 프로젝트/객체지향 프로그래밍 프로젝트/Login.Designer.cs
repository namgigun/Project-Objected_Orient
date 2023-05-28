namespace 객체지향_프로그래밍_프로젝트
{
    partial class Login
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
            Login_Button = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            PwdBox = new TextBox();
            IdBox = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // Login_Button
            // 
            Login_Button.Location = new Point(527, 178);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(121, 55);
            Login_Button.TabIndex = 11;
            Login_Button.Text = "로그인";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 230);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "비밀번호";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 178);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 9;
            label2.Text = "아이디";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 106);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 8;
            label1.Text = "로그인 페이지";
            // 
            // PwdBox
            // 
            PwdBox.Location = new Point(279, 223);
            PwdBox.Name = "PwdBox";
            PwdBox.Size = new Size(226, 27);
            PwdBox.TabIndex = 7;
            // 
            // IdBox
            // 
            IdBox.Location = new Point(279, 171);
            IdBox.Name = "IdBox";
            IdBox.Size = new Size(226, 27);
            IdBox.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(330, 280);
            button2.Name = "button2";
            button2.Size = new Size(121, 55);
            button2.TabIndex = 12;
            button2.Text = "회원가입";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Move_Sign_Up;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(Login_Button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PwdBox);
            Controls.Add(IdBox);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_Button;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox PwdBox;
        private TextBox IdBox;
        private Button button2;
    }
}