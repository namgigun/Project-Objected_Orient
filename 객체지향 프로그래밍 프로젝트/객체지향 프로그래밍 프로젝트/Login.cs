﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Move_Sign_up(object sender, EventArgs e)
        {
            this.Visible = false;
            sign_Up_Page sign_Up_Page = new sign_Up_Page();
            sign_Up_Page.ShowDialog();
        }
    }
}
