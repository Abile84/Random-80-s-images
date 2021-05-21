using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidColours
{
    
    class PatternBrush
    {
        randomizer randP = new randomizer();
        public TextureBrush BrushPatternLines(int x, int Nlines)
        {

            int size = randP.RandomPatternSize(x);
            Pen selPen = new Pen(randP.Randomcolor());
            selPen.Width = size / 15;
            //selPen.Color = randP.Randomcolor();
            selPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            selPen.StartCap= System.Drawing.Drawing2D.LineCap.Round;
            Image pattern = new Bitmap(size, size);
            Graphics gfx = Graphics.FromImage(pattern);
            for(int i=0 ;i<Nlines;i++)
            {
                gfx.DrawLine(selPen, randP.RandomPoint(size), randP.RandomPoint(size));
            }
            TextureBrush texture = new TextureBrush(pattern);
            texture.WrapMode = System.Drawing.Drawing2D.WrapMode.TileFlipXY;
            return texture;
        }

        public TextureBrush BrushPatternCircles(int x, int NCircles)
        {
            int size = randP.RandomPatternSize(x);
            int dimension = randP.randomSize(x);
            Pen selPen = new Pen(randP.Randomcolor());
            selPen.Width = size / 15;
            //selPen.Color = randP.Randomcolor();
            selPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            selPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Image pattern = new Bitmap(size, size);
            Graphics gfx = Graphics.FromImage(pattern);
            for (int i = 0; i < NCircles; i++)
            {
                gfx.FillEllipse(new  SolidBrush(randP.Randomcolor()), randP.RandomCoordinate(size), randP.RandomCoordinate(size), dimension,dimension);
            }
            TextureBrush texture = new TextureBrush(pattern);
            //texture.WrapMode = System.Drawing.Drawing2D.WrapMode.TileFlipXY;
            return texture;
        }

    }
}
