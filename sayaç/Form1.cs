﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayaç
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            
            sayi = sayi + 1;
            label1.Text = sayi.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            sayi = sayi + 3;
            label2.Text = sayi.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
