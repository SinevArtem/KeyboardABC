﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа__2_Вариант_8
{
    public partial class UserControl1 : UserControl
    {

        Form2 f2 = new Form2();
        public UserControl1()
        {
            InitializeComponent();
            f2.Show();
        }
        
        

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Font = new Font("Arial", 16);
            button2.Font = new Font("Arial", 9);
            button3.Font = new Font("Arial", 9);

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button1.Font = new Font("Arial", 9);
            button2.Font = new Font("Arial", 16);
            button3.Font = new Font("Arial", 9);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button1.Font = new Font("Arial", 9);
            button2.Font = new Font("Arial", 9);
            button3.Font = new Font("Arial", 16);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            f2.textBox1.Text += "A";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            f2.textBox1.Text += "B";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f2.textBox1.Text += "C";

        }

    }
}
