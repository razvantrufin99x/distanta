using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace distanta
{
    public partial class dotctrl : UserControl
    {
        public dotctrl()
        {
            InitializeComponent();
        }
        public int ismd = 0;

        private void dotctrl_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void dotctrl_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void dotctrl_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }
    }
}
