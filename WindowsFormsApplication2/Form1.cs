﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
            timer1.Interval = 500;
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x++;
            if (x % 2 == 0)
                label1.ForeColor = Color.Red;
            else
                label1.ForeColor = Color.Blue;

        }      
    }
}
