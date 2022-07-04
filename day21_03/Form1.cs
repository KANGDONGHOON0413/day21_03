using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day21_03
{   
    public partial class Form1 : Form
    {
        int  SIZ= 300;
        Rectangle[] Rect;
        public Form1()
        {
            InitializeComponent();
            Rect = new Rectangle[100];
            Width = SIZ;
            Height = SIZ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var rand = new Random();
            for( int i = 0; i <Rect.Length; i++)
            {
                Rect[i].X = rand.Next(200);
                Rect[i].Y = rand.Next(200);
                Rect[i].Width = 60;
                Rect[i].Height = 60;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < Rect.Length; i++) e.Graphics.DrawRectangle(Pens.Black, Rect[i]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("pause");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;

            ctrl.Width = SIZ;
            ctrl.Height = SIZ;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Logout?", "quit", MessageBoxButtons.YesNo) == DialogResult.No) e.Cancel = true;
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Logout success");
        }
    }
}
