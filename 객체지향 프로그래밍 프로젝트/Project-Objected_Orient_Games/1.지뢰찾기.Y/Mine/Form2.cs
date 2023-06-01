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
    public partial class Form2 : Form
    {
        public int Mine_Count;
        public int Block_Length;

        public Form2(int mine_count , int block_length)
        {
            Mine_Count = mine_count;
            Block_Length = block_length;
            InitializeComponent();
            textBox1.Text = Mine_Count.ToString();
            textBox2.Text = Block_Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mines = 0;
            int blocks = 0;
            if (int.TryParse(textBox1.Text , out mines) && int.TryParse(textBox2.Text , out blocks))
            {
                if (mines < 5 || mines > 300)
                {
                    MessageBox.Show("지뢰 갯수는 5 ~ 300 까지 설정할 수 있습니다.");
                    return;
                }
                if (blocks < 5 || blocks > 20)
                {
                    MessageBox.Show("블럭 길이는 5 ~ 20 까지 설정할 수 있습니다.");
                    return;
                }
                if ((blocks * blocks) <= mines)
                {
                    MessageBox.Show("지뢰 갯수가 블럭 갯수보다 큽니다.");
                    return;
                }

                if (MessageBox.Show("설정을 저장하면 게임이 재시작됩니다. 정말로 저장할까요?" , "경고" , MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Mine_Count = mines;
                    Block_Length = blocks;

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("잘못된 숫자입니다.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
