using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dreptunghi_sfera_diagonale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics Desen;
            Desen = this.CreateGraphics();
            System.Drawing.Pen Creion_albastru;
            Creion_albastru = new System.Drawing.Pen(System.Drawing.Color.Blue);
            System.Drawing.SolidBrush Pensula_roz;
            Pensula_roz = new System.Drawing.SolidBrush(System.Drawing.Color.Pink);
            Desen.FillRectangle(Pensula_roz, 100, 60, 300, 300);
            Desen.DrawRectangle(Creion_albastru, 105, 65, 290, 290);
            Desen.DrawEllipse(Creion_albastru, 105, 65, 290, 290);
            Desen.DrawEllipse(Creion_albastru, 145, 65, 200, 290);
            Desen.DrawLine(Creion_albastru, 250, 65, 250, 355);
            Desen.DrawLine(Creion_albastru, 105, 65, 395, 355);
            Desen.DrawLine(Creion_albastru, 105, 355, 395, 65);
            Desen.DrawLine(Creion_albastru, 105, 210, 395, 210);
        }
    }
}
