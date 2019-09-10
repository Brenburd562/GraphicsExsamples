using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExsamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //duel slashes for comment 
            Graphics G = this.CreateGraphics();
            Pen drawpen = new Pen(Color.Red);
            SolidBrush drawbrush = new SolidBrush(Color.Black);
            SolidBrush drawbrush1 = new SolidBrush(Color.Blue);

            G.Clear(Color.Blue);
            G.DrawLine(drawpen, 0, 0, 100, 100);
            G.DrawRectangle(drawpen, 30, 30, 100, 200);
            G.FillRectangle(drawbrush, 30, 30, 100, 200);
            G.DrawEllipse(drawpen, 30, 30, 100, 100);
            G.DrawArc(drawpen, 300, 30, 50, 50, 30, 300);
            G.DrawPie(drawpen, 400, 40, 50, 50, 30, 300);   
            G.FillPie(drawbrush1, 50, 40, 50, 50, 30, 300);

            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            G.DrawString("yall \n cool", drawFont, drawbrush, 300, 200);

            SolidBrush adsfadf = new SolidBrush(Color.FromArgb(255, 0, 0)); //Red, Green, blue value. use MsPaint

        }
    }
}
