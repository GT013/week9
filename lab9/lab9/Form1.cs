using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen[] obpen = new Pen[11];
            for(int i =0;i<11;i++)
            {
                obpen[i] = new Pen(Color.Blue, 9);
            }
            obpen[0].EndCap = LineCap.AnchorMask;
            obpen[1].EndCap = LineCap.ArrowAnchor;
            obpen[2].EndCap = LineCap.Custom;
            obpen[3].EndCap = LineCap.DiamondAnchor;
            obpen[4].EndCap = LineCap.Flat;
            obpen[5].EndCap = LineCap.NoAnchor;
            obpen[6].EndCap = LineCap.Round;
            obpen[7].EndCap = LineCap.RoundAnchor;
            obpen[8].EndCap = LineCap.Square;
            obpen[9].EndCap = LineCap.SquareAnchor;
            obpen[10].EndCap = LineCap.Triangle;
            
            for(int i =0;i<11;i++)
            {
                g.DrawLine(obpen[i],10,10 + 20 * i, 200,10 + 20 * i);
                obpen[i].Dispose();
            }
            g.Dispose();
        }
    }
}
