using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 객체지향_프로그래밍_프로젝트
{
    public partial class MainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        DBManager dBManager;
        private Boolean Login_Success = false;
        private Member member = new Member();
        private UserInfo userInfo = new UserInfo();

        //Constructor
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void ReturnToMainForm(Member member, UserInfo userInfo)
        {
            Reset();
            LoginButton.Enabled = false;
            // MainForm으로 돌아가는 동작을 수행합니다.
            // 예를 들어, MainForm의 홈 화면을 표시하거나 다른 작업을 수행할 수 있습니다.
            // 이 메서드를 필요에 따라 수정하여 원하는 동작을 수행하세요.
            Login_Success = true;
            this.member = member;
            this.userInfo = userInfo;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("야놀자 야체 B", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            OpenChildForm(login, sender);
        }

        private void GameButton_Click(object sender, EventArgs e)
        {
            if (Login_Success == false)
            {
                MessageBox.Show("로그인이 필요한 서비스입니다.");
            }

            else
            {
                MainPage mainPage = new MainPage(member,userInfo);
                OpenChildForm(mainPage, sender);
            }
        }

        private void MypageButton_Click(object sender, EventArgs e)
        {
            if (Login_Success == false)
            {
                MessageBox.Show("로그인이 필요한 서비스입니다.");
            }

            else { 
                Mypage mypage = new Mypage(userInfo);
                OpenChildForm(mypage, sender);
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
