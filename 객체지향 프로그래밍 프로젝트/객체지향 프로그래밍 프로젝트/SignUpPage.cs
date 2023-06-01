using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 객체지향_프로그래밍_프로젝트
{
    public partial class SignUpPage : Form
    {
        DBManager dbManager = new DBManager();

        Boolean Full_Chk = true; // 양식을 모두 채웠는지
        Boolean NickName_Chk = false; // 닉네임 중복체크
        Boolean Id_Chk = false; // 아이디 중복체크

        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUp_Button_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = { nicknameBox, IdBox, PwdBox };

            for (int i = 0; i < 3; i++)
            {
                if (textBoxes[i].Text == "")
                {
                    Full_Chk = false;
                }
            }

            if (Full_Chk == false)
            {
                MessageBox.Show("모든 양식을 다 채워주세요.");
                return;
            }

            else if (NickName_Chk == false)
            {
                MessageBox.Show("닉네임 중복체크 필요.");
                return;
            }

            else if (Id_Chk == false)
            {
                MessageBox.Show("아이디 중복체크 필요.");
                return;
            }

            dbManager.insert(String.Format("INSERT INTO Data.Member (NickName, ID, PWD) VALUES ('{0}','{1}','{2}');"
                , nicknameBox.Text, IdBox.Text, PwdBox.Text));

            dbManager.insert(String.Format("INSERT INTO Data.userInfo VALUES ('{0}',0,0,0,0,0,0,0,0,0);", nicknameBox.Text));

            MessageBox.Show("회원가입에 성공하셨습니다!");
            this.Close();
        }

        private void NickName_Chk_Btn_Click(object sender, EventArgs e)
        {
            if (nicknameBox.Text == "")
            {
                MessageBox.Show("닉네임을 입력해주세요.");
                return;
            }

            String Query = string.Format("SELECT * FROM Data.Member WHERE NickName = '{0}'", nicknameBox.Text);
            DataTable table = dbManager.select(Query);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("사용가능한 닉네임입니다.");
                NickName_Chk = true;
            }

            else
            {
                MessageBox.Show("중복되는 닉네임이 이미 존재합니다.");
            }
        }

        private void Id_Chk_Btn_Click(object sender, EventArgs e)
        {
            if (IdBox.Text == "")
            {
                MessageBox.Show("아이디를 입력해주세요.");
                return;
            }

            String Query = string.Format("SELECT * FROM Data.Member WHERE ID = '{0}'", IdBox.Text);
            DataTable table = dbManager.select(Query);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("사용가능한 아이디입니다.");
            }

            else
            {
                MessageBox.Show("중복되는 아이디가 이미 존재합니다.");
            }
        }
    }
}
