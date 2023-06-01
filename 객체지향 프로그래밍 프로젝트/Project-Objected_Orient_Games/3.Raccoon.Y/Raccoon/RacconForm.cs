﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raccoon
{
    public partial class RacconForm : Form
    {
        Bitmap backGround;
        Character character;
        Obstruction obstruction;
        Ui ui;
        Enemy enemy;
        Timer time;
        bool stop;

        private void Time()
        {
            time = new Timer();
            time.Interval = 1;
            time.Tick += new EventHandler(timer);
            time.Start();
        }

        private void timer(object sender, EventArgs e)
        {
            character.move();
            character.ani(obstruction.gameover, enemy.gameOver);
            obstruction.collision(character.chRect);            
            ui.addData(obstruction.score, enemy.score, obstruction.count);
            enemy.move(character.chRect);
            Invalidate();
        }

        public RacconForm()
        {            
            backGround = Properties.Resources.BackGround;
            character = new Character();
            obstruction = new Obstruction();
            enemy = new Enemy();
            ui = new Ui();
            SetStyle(System.Windows.Forms.ControlStyles.DoubleBuffer | System.Windows.Forms.ControlStyles.UserPaint | System.Windows.Forms.ControlStyles.AllPaintingInWmPaint, true);
            Time();            
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {            
            Graphics g = e.Graphics;
            g.DrawImage(backGround, 0, 0);          
            obstruction.draw(e);              
            ui.draw(e);
            enemy.draw(e);
            character.draw(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
                character.State = 1;
            else if (e.KeyCode == Keys.Right)
                character.State = 2;
            else if (e.KeyCode == Keys.Up)
                character.State = 3;
            else if (e.KeyCode == Keys.Down)
                character.State = 4;            
            else if (e.KeyCode == Keys.Space && character.Jump == 0 && !character.xStop && !character.jumpStop)
            {
                character.Jump++;                
                character.jumpKey = true;
            }
            if (e.KeyCode == Keys.P)            
                stop = !stop;
            if (stop)
                time.Stop();
            else
                time.Start();
            if (e.KeyCode == Keys.S)
            {
                character.reSet();
                obstruction.reSet();
                enemy.reSet();
                ui.str1 = "";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (character.State == 1 && e.KeyCode == Keys.Left)                
                character.State = 0;
            if (character.State == 2 && e.KeyCode == Keys.Right)
                character.State = 0;
            if (character.State == 3 && e.KeyCode == Keys.Up)
                character.State = 0;
            if (character.State == 4 && e.KeyCode == Keys.Down)
                character.State = 0;                        
        }
    }
}
