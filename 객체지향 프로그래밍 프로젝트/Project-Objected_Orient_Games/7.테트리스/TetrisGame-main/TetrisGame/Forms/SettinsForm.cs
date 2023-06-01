using System;
using System.Windows.Forms;
using TetrisGame.Classes.Utils;
using TetrisGame.Entities;


namespace TetrisGame.Forms
{
    public partial class SettinsForm : Form
    {
        private CheckBox[,] checkBoxes = new CheckBox[4,4];
        GameSettings gameSettings = new GameSettings();
        public SettinsForm()
        {
            InitializeComponent();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string ch_name = "c" + i.ToString() + j.ToString();
                    Control[] r = panel1.Controls.Find(ch_name, false);
                    checkBoxes[i,j] = (CheckBox)r[0];
                }
            }
        }

        
        private void addNewButton_Click(object sender, EventArgs e)
        {
            int[,] newShapeArr = new int[1,4];
            int blocksCounter = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    newShapeArr[0, i] = newShapeArr[0, i] << 1;
                    if (checkBoxes[i,j].Checked)
                    {
                        if (!IsMayStay(i,j))
                            MessageBox.Show("Не верная фигура");
                        blocksCounter++;
                        newShapeArr[0, i] = newShapeArr[0, i] | 0b1;
                    }
                }
            }


            if (blocksCounter > 8)
                MessageBox.Show("Количество блоков больше 8"); ;

            Shapes.addNewShape(newShapeArr);
        }

        private bool IsMayStay(int x, int y) 
        {
            if (!IsCheked(x + 1, y) && !IsCheked(x - 1, y))
                return false;

            if (!IsCheked(x, y + 1) && !IsCheked(x, y - 1))
                return false;

            return true;
        }

        private bool IsCheked(int x, int y)
        {
            if(x < 0 || x >= 4 || y < 0 || y >= 4 )
            {
                return false;
            }

            return checkBoxes[x, y].Checked;

        }


        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(rowTextBox.Text, out int RowTry) && int.TryParse(columnTextBox.Text, out int ColumnTry))
            {
                if(RowTry >= 15 && ColumnTry >= 20 && RowTry <= 150 && ColumnTry <= 200)
                {
                    gameSettings.Row = RowTry;
                    gameSettings.Column = ColumnTry;
                    SaveAndLoad.Save<GameSettings>("settingsData.dat", gameSettings);
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Минимальный размер 15*20, а максимальный 150*200");
                }

            }
            else
            {
                MessageBox.Show("Введённое число не целое");
            }
            
        }
    }
}
