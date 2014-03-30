using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SimpleDrawing
{
    public interface IDrawable
    {
        //risuvaneto stava s obekti Graphics, vsiaka figura ima takyv metod
        void Draw(Graphics g);
    }
}
