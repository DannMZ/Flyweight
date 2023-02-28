using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Flyweight
{
    public class rainDrop
    {
        public Bitmap pic;
    }

    public class FirstDrop : rainDrop
    {
        public FirstDrop()
        {
            pic = new Bitmap(@"F:\Lab\labs\Flyweight\Flyweight\Крапля.png");
        }
    }
    public class ScndDrop : rainDrop
    {

        public ScndDrop()
        {
            pic = new Bitmap(@"F:\Lab\labs\Flyweight\Flyweight\Крапля.png");
        }
    }
    public class ThrdDrop : rainDrop
    {
        public ThrdDrop()
        {
            pic = new Bitmap(@"F:\Lab\labs\Flyweight\Flyweight\Крапля.png");
        }
    }

    public class Drop{
        public Point XnY;
        public rainDrop pict;
        public Drop(Point xny, rainDrop pict)
        {
            XnY = xny;
            this.pict = pict;
        }

        public Point Move(int move)
        {
            XnY.Y += move;
            return new Point(XnY.X, XnY.Y+move);
        }

        }
}
