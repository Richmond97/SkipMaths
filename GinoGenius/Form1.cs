using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GinoGenius
{
    public partial class Form1 : Form
    {
        private int BubbleTimer = 0;
        int x;
        int y;
        
        public Form1()
        {
            InitializeComponent();
            
            pictureBox1.BackColor = Color.Transparent;
        }
        private void MoveObject_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.LightBlue, x, y, 100, 100);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            BubbleTimer++;

            //if (_objposition == position.Right)
            //{
            //    _x += 10;
            //}
            //else if (_objposition == position.Left)
            //{
            //    _x -= 10;
            //}
            //else if (_objposition == position.up)
            //{
            //    _y -= 10;
            //}
            //else if (_objposition == position.down)
            //{
            //    _y += 10;
            //}
            Invalidate();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            //new Form2().Show();
            new Play().Show();
        }

       
    }
}
