using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace distanta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int ismd = 0;

        public Graphics g;
        Pen pen0 = new Pen(Color.Black);
        Font font0;
        Brush brush0 = new SolidBrush(Color.Red);

        public int Min(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }
        public double fdistanta(dotctrl a, dotctrl b)
        {
            try
            {

                label1.Left = 20+Min(a.Left,b.Left)+ Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Left - b.Left),2))/2);
                label1.Top = Min(a.Top, b.Top) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Top - b.Top), 2))/2);
            }catch{}
            return Math.Sqrt(Math.Abs(a.Left - b.Left) * Math.Abs(a.Left - b.Left) + Math.Abs(a.Top - b.Top) * Math.Abs(a.Top - b.Top));
        }
        public double unghiul(dotctrl a, dotctrl b)
        {
            double degrees;
            if (b.Left - a.Left == 0)
            {
                if (b.Top > a.Top)
                {
                    degrees = 90;
                }
                else
                {
                    degrees = 270;
                }
            }
            else
            {
                double riseoverrun = Convert.ToDouble(Math.Abs((b.Top - a.Top)) / Convert.ToDouble(Math.Abs(b.Left - a.Left)));
                double radians = Math.Atan(riseoverrun);
                degrees = radians * Convert.ToDouble(180/Math.PI);
            }
            if (Math.Abs(b.Left - a.Left) < 0 || Math.Abs(b.Top - a.Top) < 0)
            {
              degrees += 180;
            }
            if (Math.Abs(b.Left - a.Left) > 0 && Math.Abs(b.Top - a.Top) < 0)
            {
              degrees -= 180;
            }
            if(degrees<0)
            {
              degrees += 360;
            }


          
            return degrees; 
        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(BackColor);
            label1.Text = fdistanta(dotctrl1,dotctrl2).ToString();
            label1.Text +=  " : " + unghiul(dotctrl1,dotctrl2);
            g.DrawLine(pen0, dotctrl1.Left, dotctrl1.Top, dotctrl2.Left, dotctrl2.Top);
            //g.DrawLine(pen0, dotctrl1.Left+10, dotctrl1.Top+10, dotctrl2.Left+10, dotctrl2.Top+10);
            //g.DrawLine(pen0, dotctrl1.Left - 10, dotctrl1.Top - 10, dotctrl2.Left - 10, dotctrl2.Top - 10);
            g.DrawString(dotctrl1.Left.ToString() + " : " + dotctrl1.Top.ToString(), font0, brush0, dotctrl1.Left, dotctrl1.Top);
            g.DrawString(dotctrl2.Left.ToString() + " : " + dotctrl2.Top.ToString(), font0, brush0, dotctrl2.Left, dotctrl2.Top);
            /*
            for (int j = 0; j < Convert.ToInt16(fdistanta(dotctrl1, dotctrl2)); j += 5)
            {
                g.DrawLine(pen0, dotctrl1.Left + j, dotctrl1.Top + j, dotctrl1.Left + j + j, dotctrl1.Top + j + j);
            }
             */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            font0 = this.Font;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                //you can not move the dotctrl1 and dotctrl2 relative to form
                Left += e.X;
                Top += e.Y;
                //this will not work
                //try to calculate de distance between positions start and final
                /*
                dotctrl1.Left += e.X;
                dotctrl1.Top += e.Y;
                dotctrl2.Left += e.X;
                dotctrl2.Top += e.Y;
                 */

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }
    }
}
