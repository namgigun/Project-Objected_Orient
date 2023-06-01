namespace 객체지향_프로그래밍_프로젝트
{
    partial class MainForm
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
            LogoutButton = new Button();
            MypageButton = new Button();
            GameButton = new Button();
            LoginButton = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            panelMenu = new Panel();
            panelTitleBar = new Panel();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            panelDesktopPane = new Panel();
            panelLogo.SuspendLayout();
            panelMenu.SuspendLayout();
            panelTitleBar.SuspendLayout();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Dock = DockStyle.Top;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("야놀자 야체 B", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutButton.ForeColor = Color.Gainsboro;
            LogoutButton.Image = Properties.Resources.free_icon_sign_out_6461401;
            LogoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            LogoutButton.Location = new Point(0, 220);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Padding = new Padding(12, 0, 0, 0);
            LogoutButton.Size = new Size(170, 50);
            LogoutButton.TabIndex = 3;
            LogoutButton.Text = "  LogOut";
            LogoutButton.TextAlign = ContentAlignment.MiddleLeft;
            LogoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // MypageButton
            // 
            MypageButton.Dock = DockStyle.Top;
            MypageButton.FlatAppearance.BorderSize = 0;
            MypageButton.FlatStyle = FlatStyle.Flat;
            MypageButton.Font = new Font("야놀자 야체 B", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            MypageButton.ForeColor = Color.Gainsboro;
            MypageButton.Image = Properties.Resources.free_icon_user_7718888;
            MypageButton.ImageAlign = ContentAlignment.MiddleLeft;
            MypageButton.Location = new Point(0, 170);
            MypageButton.Name = "MypageButton";
            MypageButton.Padding = new Padding(12, 0, 0, 0);
            MypageButton.Size = new Size(170, 50);
            MypageButton.TabIndex = 2;
            MypageButton.Text = "  MyPage";
            MypageButton.TextAlign = ContentAlignment.MiddleLeft;
            MypageButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            MypageButton.UseVisualStyleBackColor = true;
            MypageButton.Click += MypageButton_Click;
            // 
            // GameButton
            // 
            GameButton.Dock = DockStyle.Top;
            GameButton.FlatAppearance.BorderSize = 0;
            GameButton.FlatStyle = FlatStyle.Flat;
            GameButton.Font = new Font("야놀자 야체 B", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            GameButton.ForeColor = Color.Gainsboro;
            GameButton.Image = Properties.Resources.free_icon_game_control_6875330;
            GameButton.ImageAlign = ContentAlignment.MiddleLeft;
            GameButton.Location = new Point(0, 120);
            GameButton.Name = "GameButton";
            GameButton.Padding = new Padding(12, 0, 0, 0);
            GameButton.Size = new Size(170, 50);
            GameButton.TabIndex = 1;
            GameButton.Text = "  Game";
            GameButton.TextAlign = ContentAlignment.MiddleLeft;
            GameButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            GameButton.UseVisualStyleBackColor = true;
            GameButton.Click += GameButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Dock = DockStyle.Top;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("야놀자 야체 B", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.Gainsboro;
            LoginButton.Image = Properties.Resources.free_icon_login_171206;
            LoginButton.ImageAlign = ContentAlignment.MiddleLeft;
            LoginButton.Location = new Point(0, 70);
            LoginButton.Name = "LoginButton";
            LoginButton.Padding = new Padding(12, 0, 0, 0);
            LoginButton.Size = new Size(170, 50);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "  LogIn";
            LoginButton.TextAlign = ContentAlignment.MiddleLeft;
            LoginButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(170, 70);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("야놀자 야체 B", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(63, 27);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 0;
            label1.Text = "Muu";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(LogoutButton);
            panelMenu.Controls.Add(MypageButton);
            panelMenu.Controls.Add(GameButton);
            panelMenu.Controls.Add(LoginButton);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(170, 603);
            panelMenu.TabIndex = 14;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(170, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(812, 70);
            panelTitleBar.TabIndex = 15;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.BackgroundImageLayout = ImageLayout.None;
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Font = new Font("아리따-돋움(TTF)-Medium", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(63, 70);
            btnCloseChildForm.TabIndex = 4;
            btnCloseChildForm.Text = "X";
            btnCloseChildForm.UseVisualStyleBackColor = true;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("야놀자 야체 B", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(379, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(73, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            panelDesktopPane.Dock = DockStyle.Fill;
            panelDesktopPane.Location = new Point(170, 70);
            panelDesktopPane.Name = "panelDesktopPane";
            panelDesktopPane.Size = new Size(812, 533);
            panelDesktopPane.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 603);
            Controls.Add(panelDesktopPane);
            Controls.Add(panelTitleBar);
            Controls.Add(panelMenu);
            Name = "MainForm";
            Text = "MainForm";
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button LogoutButton;
        private Button MypageButton;
        private Button GameButton;
        private Button LoginButton;
        private Panel panelLogo;
        private Panel panelMenu;
        private Panel panelTitleBar;
        private Label lblTitle;
        private Label label1;
        private Panel panelDesktopPane;
        private Button btnCloseChildForm;
    }
}