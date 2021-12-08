using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tual = panel1.CreateGraphics();
            kalem = new Pen(Color.Red, 2);
            firca = new SolidBrush(Color.Yellow);
        }
        int sonx = 0;
        int sony = 0;
        Graphics tual;
        Pen kalem;
        Brush firca;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sonx != 0 && sony != 0)
            {
                tual.DrawLine(kalem, e.X, e.Y, sonx, sony);
            }            
            if (çemberToolStripMenuItem.Checked == true)
            {
                tual.DrawEllipse(kalem, e.X, e.Y, sonx, sony);
            }
            if (dikdörtgenToolStripMenuItem.Checked == true)
            {
                tual.DrawRectangle(kalem, e.X, e.Y, sonx, sony);

            }
            sonx = e.X;
            sony = e.Y;
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sonx = 0;
            sony = 0;
            colorDialog1.ShowDialog();
            kalem.Color = colorDialog1.Color;
        }

        private void şekilToolStripMenuItem_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void çemberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
