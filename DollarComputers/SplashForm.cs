﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
     

        private void SplashFromTimer_Tick(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();


            this.SplashFromTimer.Enabled = false;
            startForm.Show();
            this.Hide();
        }
    }
}
