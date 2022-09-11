﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Canteen_Management_system.AllUserControls
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num == 0)
            {
                labelBanner.Location = new Point(94, 367);
                labelBanner.ForeColor = Color.RoyalBlue;
                num++;
            }
            else if(num == 1)
            {
                labelBanner.Location = new Point(166, 367);
                labelBanner.ForeColor = Color.LimeGreen;
                num++;
            }
            else if(num == 2)
            {
                labelBanner.Location = new Point(268, 367);
                labelBanner.ForeColor = Color.DarkOrange;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
