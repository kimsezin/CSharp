﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studying_csharp_09
{
    public partial class ModalApp : Form
    {
        public ModalApp()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            ModalDialogBox form2 = new ModalDialogBox();
            form2.ShowDialog();
        }
    }
}
