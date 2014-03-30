using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDrawing
{
    public interface IConnectable
        //vsichki tezi obezki shte mogat da se svyrzvat
    {
        void Connect(IConnectable target);
    }
}
