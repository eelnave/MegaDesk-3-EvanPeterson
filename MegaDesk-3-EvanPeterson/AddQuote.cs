﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_EvanPeterson
{
    public partial class AddQuote : Form 
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void cancelAddQuoteButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void widthNumberBox_ValueChanged(object sender, EventArgs e)
        {
            if (widthNumberBox.Value > 96 || widthNumberBox.Value < 24)
            {
                widthLabel.Text = "Please Enter Valid Number";
            }
        }
    }
}
