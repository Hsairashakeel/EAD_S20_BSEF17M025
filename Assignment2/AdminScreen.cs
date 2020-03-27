﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nameTxt.Text == "")
            {
                MessageBox.Show("Please fill the name field");
                return;
            }
            if (passwordTxt.Text == "")
            {
                MessageBox.Show("Please fill the email field");
                return;
            }
            bool result = EAD_BAL.AdminBO.IsValidUser(nameTxt.Text, passwordTxt.Text);
            if (result == true)
            {
                this.Hide();
                AdminHome home = new AdminHome();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid username/password");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen screen = new MainScreen();
            screen.Show();

        }
    }
}