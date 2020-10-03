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
    public partial class Bubble : PictureBox,IGameEntity1
    {
        private int speed = 0;

        public Bubble()
        {

            this.Image = Image.FromFile("bubbles.png");
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            ((Bitmap)this.Image).MakeTransparent(((Bitmap)this.Image).GetPixel(1, 1));
            this.BackColor = Color.Transparent;
            this.Height = 23;
            this.Width = 30;
            this.Left = 680;




            Random rd = new Random();
            this.speed = rd.Next(1, 3);
            //direction = Direction.Right;
        }

        public void Update(Panel canvas)
        {
            MoveGameEntity(Direction.Left);

        }
        public void MoveGameEntity(Direction direction)
        {
            if (direction == Direction.Left)
            {
                this.Left -= speed;
            }

            // Invalidate();
        }

        public void Update(Play theCanvas)
        {
            throw new NotImplementedException();
        }
    }
}



















/* private void timer1_Tick(object sender, EventArgs e)
             {
                 if (direction == Direction.Right)
                 {
                     x += 10;
                 }
                 else if (_objposition == Direction.Left)
                 {
                     x -= 10;
                 }
                 else if (_objposition == Direction.Up)
                 {
                     y -= 10;
                 }
                 else if (_objposition == Direction.Down)
                 {
                     y += 10;
                 }*/
