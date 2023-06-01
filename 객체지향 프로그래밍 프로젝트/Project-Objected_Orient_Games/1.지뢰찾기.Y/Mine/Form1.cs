using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine
{
    public partial class Form1 : Form
    {
        int Map_Length = 10;
        int Mine_Count = 10;

        int fdme = 0;
        int FindMine
        {
            get
            {
                return fdme;
            }
            set
            {
                fdme = value;
                if (fdme == Mine_Count && flagcount == 0)
                {
                    MessageBox.Show("승리!");
                    F_Map.Enabled = false;
                }

            }
        }

        int flagcount = 0;
        int Flag_Count
        {
            get
            {
                return flagcount;
            }
            set
            {
                flagcount = value;
                label1.Text = "지뢰 : " + value.ToString() + "개";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateMap();
            label1.Text = "지뢰 : " + Mine_Count + "개";
        }

        private void CreateMap()
        {
            FindMine = 0;
            flagcount = Mine_Count;
            Flag_Count = Mine_Count;

            //길이 = (지뢰길이 * 지뢰수) + (5 * (지뢰수 + 1))
            int h = (40 * Map_Length) + (5 * (Map_Length + 1));
            F_Map.Width = h;
            F_Map.Height = h;
            this.Width = h + 20;
            this.Height = h + 100;

            F_Map.Enabled = true;
            F_Map.Controls.Clear();
            for (int i = 1; i <= Math.Pow(Map_Length , 2); i++)
            {
                var btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = SystemColors.ControlDark;
                btn.TabStop = false;
                btn.Margin = new Padding(0, 0, 5, 5);
                btn.Size = new Size(40, 40);
                btn.MouseUp += Btn_Click;
                F_Map.Controls.Add(btn);
            }

            var rnd = new Random();
            var mineList = new List<int>();

            for (int i = 1; i <= Mine_Count; i++)
            {
                int M_Pos = 0;
                do
                {
                    M_Pos = rnd.Next(1, (int)Math.Pow(Map_Length , 2));
                } while (mineList.Contains(M_Pos));
                mineList.Add(M_Pos);

                var cnt = (Button)F_Map.Controls[M_Pos - 1];
                cnt.TabStop = true;
            }
            Console.WriteLine("만들어진 지뢰 : {0}", string.Join("," , mineList));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 재시작 할까요?" , "재시작" , MessageBoxButtons.YesNo) == DialogResult.Yes)
                CreateMap();
        }

        private void Btn_Click(object sender, MouseEventArgs e)
        {
            var btn = (Button)sender;
            if (e.Button == MouseButtons.Left)
            {
                if (btn.BackgroundImage != null)
                    return;

                if (btn.TabStop)
                {
                    MessageBox.Show("실패");
                    CreateMap();
                    return;
                }

                int p = F_Map.Controls.IndexOf(btn) + 1;
                checkMine(btn , p);
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (btn.BackgroundImage == null)
                {
                    btn.BackgroundImage = Mine.Properties.Resources.Flag_Black;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;

                    Flag_Count--;
                    if (btn.TabStop)
                        FindMine++;
                }
                else
                {
                    btn.BackgroundImage = null;

                    Flag_Count++;
                    if (btn.TabStop)
                        FindMine--;
                }
            }
        }

        List<int> posList = new List<int>();
        private void checkMine(int pos)
        {
            Button btn = (Button)F_Map.Controls[pos];
            checkMine(btn , ++pos);
        }

        private void checkMine(Button btn , int p)
        {
            if (btn.Enabled == false)
                return;

            btn.Enabled = false;
            btn.BackColor = SystemColors.ControlLightLight;
            btn.ForeColor = Color.Black;

            int c = 0;

            if (p % Map_Length != 1 && g(p - 1))
                c++;
            if (p % Map_Length != 0 && g(p + 1))
                c++;
            if (g(p + Map_Length))
                c++;
            if (g(p - Map_Length))
                c++;
            if (p % Map_Length != 1 && g(p - (Map_Length+1)))
                c++;
            if (p % Map_Length != 0 && g(p - (Map_Length-1)))
                c++;
            if (p % Map_Length != 0 && g(p + (Map_Length+1)))
                c++;
            if (p % Map_Length != 1 && g(p + (Map_Length-1)))
                c++;

            if (c == 0)
            {
                if (p % Map_Length != 1)
                    zcheckMine(p - 1);
                if (p % Map_Length != 0)
                    zcheckMine(p + 1);
                if (!(p + Map_Length > Math.Pow(Map_Length , 2)))
                    zcheckMine(p + Map_Length);
                if (!(p - Map_Length < 0))
                    zcheckMine(p - Map_Length);
                if (p % Map_Length != 1)
                    zcheckMine(p - (Map_Length+1));
                if (p % Map_Length != 0)
                    zcheckMine(p - (Map_Length-1));
                if (p % Map_Length != 0)
                    zcheckMine(p + (Map_Length+1));
                if (p % Map_Length != 1)
                    zcheckMine(p + (Map_Length-1));
            }
            else
                btn.Text = c.ToString();
        }

        private void zcheckMine(int pos)
        {
            if (pos > Math.Pow(Map_Length , 2) || pos < 1)
                return;

            Button btn = (Button)F_Map.Controls[pos-1];
            if (btn.TabStop || btn.Enabled == false)
                return;
            else
                checkMine(btn, pos);
        }

        private bool g(int ind)
        {
            if (ind < 1)
                return false;

            if (ind > Math.Pow(Map_Length , 2))
                return false;

            Button control = (Button)F_Map.Controls[ind-1];
            return control.TabStop;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var setting = new Form2(Mine_Count, Map_Length);
            setting.ShowDialog();
            Mine_Count = setting.Mine_Count;
            Map_Length = setting.Block_Length;
            Console.WriteLine("설정 변경 : mine {0} , map {1}" , Mine_Count , Map_Length);
            CreateMap();
        }
    }
}
