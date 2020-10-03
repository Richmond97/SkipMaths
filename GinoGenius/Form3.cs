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
    public partial class Form3 : Form
    {
   
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace GinoGenius
//{
//    public partial class Form3 : Form
//    {
//        private int _x;
//        private int _y;
//        public Form3()
//        {
//            InitializeComponent();
//        }

//        private void Form3_KeyDown(object sender, KeyEventArgs e)
//        {
//            _x = player.Location.X;
//            _y = player.Location.Y;

//            if (e.KeyCode == Keys.Up) _y -= 10;
//            else if (e.KeyCode == Keys.Down) _y += 10;

//            player.Location = new Point(_x, _y);
//        }
//    }
//}
