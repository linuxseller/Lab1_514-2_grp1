using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_514_2_grp1
{
    public partial class Form0 : Form
    {
        Lab1 lab1 = null;
        public Form0()
        {
            InitializeComponent();
            lab1 = new Lab1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lab1.ShowDialog();
        }
    }
}
