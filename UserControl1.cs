using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace distantaCintreABpunctexy2d
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        Form1 f;
        public int ismd = 0;

        private void UserControl1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void UserControl1_MouseDown(object sender, MouseEventArgs e)
        {
             ismd = 1;
        }

        private void UserControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
                f.calculeazadistanta();
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }
        }
    }
}
