using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_WindowsForms
{
    internal class Board
    {
        private Border _boardBorder = new Border();

        public void Initialize(Form currentForm, int borderSize = 16)
        {
            _boardBorder.Draw(currentForm, borderSize);
        }
    }
}
