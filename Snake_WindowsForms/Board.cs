using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_WindowsForms
{
    internal class Board : Control
    {
        const int Size = 20;

        PictureBox Picture = new PictureBox()
        {
            Size = new Size(20, 20),
            BackColor = Color.Black
        };

        public void Draw(Form f)
        {
            for (int i = 0 ; i < 12; i++)
            {
                Picture.Location = new Point(12 + Size, 16);
            }   

            f.Controls.Add(Picture);
        }

    }
}
