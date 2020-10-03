using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GinoGenius
{
    public partial class Obstacle : PictureBox, IGameEntity1
    {
        private int speed = 0;

        public Obstacle()
        {
            this.Image = Image.FromFile("rockk.png");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            ((Bitmap)this.Image).MakeTransparent(((Bitmap)this.Image).GetPixel(1, 1));
            this.BackColor = Color.Transparent;
            this.Height = 23;
            this.Width = 30;
            this.Left = 680;

            Random rd = new Random();
            this.speed = rd.Next(1, 3);
        }

        public Obstacle(Direction direction)
        {
            
        }

        public void MoveGameEntity(Direction direction)
        {
            throw new NotImplementedException();
        }

        public void Update(Play theCanvas)
        {
            throw new NotImplementedException();
        }
    }
}
