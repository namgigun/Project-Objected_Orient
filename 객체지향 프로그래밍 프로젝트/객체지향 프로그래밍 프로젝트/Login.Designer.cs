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
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(530, 226);
            button1.Name = "button1";
            button1.Size = new Size(121, 55);
            button1.TabIndex = 11;
            button1.Text = "회원가입";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Move_Sign_up;
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
            // textBox2
            // 
            textBox2.Location = new Point(279, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(279, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 27);
            textBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(530, 143);
            button2.Name = "button2";
            button2.Size = new Size(121, 55);
            button2.TabIndex = 12;
            button2.Text = "로그인";
            button2.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
    }
}