﻿using System;
using System.Windows.Forms;
using TetrisGame.Entities;

namespace TetrisGame.Forms
{
    public partial class MenuForm : Form
    {
        public TetrisManager tetrisManager = new TetrisManager();

        public MenuForm()
        {
            InitializeComponent();
            Shapes.Load();
        }

        public MenuForm(TetrisManager tetrisManager)
        { 
            InitializeComponent ();
            this.tetrisManager = tetrisManager;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            showForm(new GameForm(this));
            this.Width = 660;
            this.Height = 700;
        }

        private void showForm(Form form)
        {
            this.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
            this.Controls[0].Focus();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            showForm(new SettinsForm());
            this.Width = 360;
            this.Height = 400;
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
