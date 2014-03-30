using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SimpleDrawing
{
    public class Coefficient : IDrawable, ITransformable, IConnectable
    {
        private Rectangle _rect;
        private List<ITransformable> _refferences;
        
        public Rectangle Rectangle
        {
            get { return _rect; }
            set { _rect = value; }
        }

        public Coefficient(Rectangle rect)
        {
            _rect = rect;
            _refferences = new List<ITransformable>();
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Point start = new Point(this._rect.X + this._rect.Width / 2, this._rect.Y + this._rect.Height / 2);
            foreach (ITransformable item in this._refferences)
            {
                Rectangle target = item.GetBounds();
                g.DrawLine(pen, start, new Point(target.X + target.Width / 2, target.Y + target.Height / 2));
            }
            g.DrawEllipse(new Pen(Color.Black), _rect);
        }

        public void Translate(int dX, int dY)
        {
            int newX = dX + _rect.X;
            int newY = dY + _rect.Y;
            _rect = new Rectangle(newX, newY, _rect.Width, _rect.Height);
        }

        public bool Contains(int X, int Y)
        {
            return _rect.Contains(X, Y);
        }

        public Rectangle GetBounds()
        {
            return this._rect;
        }

        public void Connect(IConnectable target)
        {
            this._refferences.Add((ITransformable)target);
        }
    }
}
