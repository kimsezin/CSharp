﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studying_csharp_07
{
    public partial class LoadClosedEventApp : Form
    {
        public LoadClosedEventApp()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This form is loaded");
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("This form is closed");
        }
    }
}
