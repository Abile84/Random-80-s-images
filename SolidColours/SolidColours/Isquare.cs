using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidColours
{
    interface ISquare : IShape
    {
        int x { get; set; }
        int y { get; set; }
        int Width { get; set; }
        int Heigth { get; set; }
        Bitmap bitmap { get; set; }
    }

    }
