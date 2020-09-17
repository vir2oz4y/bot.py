using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1_5sem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Procedure1 procedure1 = new Procedure1();
            procedure1.Show(this);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Procedure2 procedure2 = new Procedure2();
            procedure2.Show(this);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Procedure4 procedure4 = new Procedure4();
            procedure4.Show(this);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Procedure7 procedure7 = new Procedure7();
            procedure7.Show(this);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Procedure8 procedure8 = new Procedure8();
            procedure8.Show(this);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Procedure3 procedure3 = new Procedure3();
            procedure3.Show(this);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Procedure5 procedure5 = new Procedure5();
            procedure5.Show(this);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Procedure6 procedure6 = new Procedure6();
            procedure6.Show(this);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
