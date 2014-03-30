using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SimpleDrawing
{
    public class Stock : IDrawable, ITransformable,  IConnectable
    {
        private Rectangle _rect;
        private List<ITransformable> _refferences; //spisyk ot vsichki referencii kym tozi obekt

        public Rectangle Rectangle  //property za da se zastypva pravoygylnika, da se vzimat stoinost i da davat stoinosti
        {
            get { return _rect; }
            set { _rect = value; }
        }

        public Stock(Rectangle rect)
        {
            _rect = rect; //inicializira pravoygylnika
            _refferences = new List<ITransformable>(); //vryzkite, da otdeli pamet za tiah
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black); //zadavame cviat 
            //gornata liava tochka, s neia se opredelia pravoygylnika, nadiasno pravi 5 piksela, nadolu pravi 10 piksela
            Point start = new Point(this._rect.X + this._rect.Width / 2, this._rect.Y + this._rect.Height / 2); //po tozi nachin namirame sredata na pravoygylnika
            
            foreach (ITransformable item in this._refferences) //obikaliame vsichki referencii
            {
                Rectangle target = item.GetBounds(); //obikaliame vsichki drugi pravoygylnici kym koito imame referencia, i syzdavame linia
                g.DrawLine(pen, start, new Point(target.X + target.Width / 2, target.Y + target.Height / 2)); //ako syshestvuva takava refencia ia izchertava
            }
            g.DrawRectangle(pen, _rect); //pyrvo risuva referencia, posle pravoygylnik
        }

        public void Translate(int dX, int dY)
        {
            int newX = dX + _rect.X; //translacia mesti figurata, myrda se na vseki piksel 
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