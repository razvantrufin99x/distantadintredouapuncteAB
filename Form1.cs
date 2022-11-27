using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace distantaCintreABpunctexy2d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public float distantaintredouapuncte2dxy(float x1, float y1, float x2, float y2)
        { 
            float c;
            c = (float)Math.Sqrt(Math.Abs(x1 - x2) * Math.Abs(x1 - x2) + Math.Abs(y1 - y2) * Math.Abs(y1 - y2));
                return c;
        }

        public void calculeazadistanta()
        {
            float r = distantaintredouapuncte2dxy(button1.Left, button1.Top, button2.Left, button2.Top);
            Text = r.ToString();
            label1.Text = Text;
            if (button1.Top < button2.Top)
            {
                label1.Top = button1.Top + Math.Abs(button1.Top - button2.Top)/2;
            }
            else
            {
                label1.Top = button2.Top + Math.Abs(button1.Top - button2.Top)/2;
            }

            if (button1.Left < button2.Left)
            {
                label1.Left = button1.Left + Math.Abs(button1.Left - button2.Left)/2;
            }
            else
            {
                label1.Left = button2.Left + Math.Abs(button1.Left - button2.Left)/2;
            }

            lineShape1.X1 = button1.Left;
            lineShape1.X2 = button2.Left;
            lineShape1.Y1 = button1.Top;
            lineShape1.Y2 = button2.Top;

            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            calculeazadistanta();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
