using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            g.FillEllipse(sb, 20, 20, 50, 50);

            sb = new SolidBrush(Color.DeepPink);
            g.FillEllipse(sb, 180, 20, 50, 50);

            g.DrawEllipse(new Pen(Brushes.Black), 100, 150, 50, 50);
        }
    }
}
