using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDrawing
{
    public interface ITransformable
    {
        //transformable - da se mestiat
        //smiata che tova sa svoistvata koito stock shte ima
        void Translate(int dX, int dY); //da se premesti obekta
        bool Contains(int X, int Y); //pri natiskaneto na mishkata, dali tochkata koiato sym natisnala e v obekta
        Rectangle GetBounds(); //vryshta granicite na obekta
    }
}
