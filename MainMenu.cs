﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPicker
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoScreen ins = new InfoScreen();
            ins.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();
            t.Show();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            label1.Text = "(" + id_korisnik.id_kor.ToString() + ") " + id_korisnik.user_name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WWStat ww = new WWStat();
            ww.Show();
            this.Close();
        }
    }
}
