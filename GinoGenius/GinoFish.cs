using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GinoGenius
{
    

        public class GinoFish : PictureBox, IGameEntity1
        {
            private int velocity = 10;


            public GinoFish()
        {
            try {
               
                this.Image = Image.FromFile("fish.gif");
                SizeMode = PictureBoxSizeMode.StretchImage;
                ((Bitmap)Image).MakeTransparent(((Bitmap)Image).GetPixel(1, 1));
                BackColor = Color.Transparent;
                Height = 40;
                Width = 40;

            }
            catch {MessageBox.Show("Image not found "); }

            }

            public void Update(Panel theCanvas)
            {
                

            }

            public void MoveGameEntity(Direction direction)
            {
                if (direction == Direction.Left)
                {
                    this.Left -= velocity;
                }
                if (direction == Direction.Right)
                {
                    this.Left += velocity;
                }
                if (direction == Direction.Up)
                {
                    this.Top -= velocity;
                }
                if (direction == Direction.Down)
                {
                    this.Top += velocity;
                }

            }

        public void Update(Play theCanvas)
        {
            throw new System.NotImplementedException();
        }
    }
}


