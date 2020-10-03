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
    public partial class MoveObject : Form
    {

        enum position
        {
            Left, Right, up, down
        }
        private int _x;
        private int _y;
        ////private position _objposition;
        ////private Pen blackPen;

        public MoveObject()
            {
              
                InitializeComponent();
            //PreviewKeyDown += new KeyEventHandler(MoveObject_PreviewKeyDown);
                
            }
  

        private void MoveObject_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            _x = pictureBox1.Location.X;
            _y = pictureBox1.Location.Y;

            if (e.KeyCode == Keys.Up) _y += 10;
            else if (e.KeyCode == Keys.Down) _y += 10;

            pictureBox1.Location = new Point(_x, _y);


        }

        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
    } 
