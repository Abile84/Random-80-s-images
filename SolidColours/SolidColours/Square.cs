using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SolidColours
{
    public class Square : ISquare
    {
        public int x { get; set; }
        public int y { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }

        public Bitmap bitmap { get; set; }

        randomizer rand = new randomizer();



        Graphics GetGraphics()
        {
            Graphics graphics = Graphics.FromImage(bitmap);
            return graphics;
        }


        public int ShapeType(int SelectType)
        {
            return SelectType;
        }

        Point[] Gridpoint()
        {
            Point p = new Point(rand.RandomCoordinate(Width), rand.RandomCoordinate(Heigth));
            Point[] gridpoint =
            {
                p,
                new Point(p.X,p.Y-Heigth),
                new Point(p.X,p.Y+Heigth),
                new Point(p.X-Width,p.Y),
                new Point(p.X+Width,p.Y),
                new Point(p.X+Width,p.Y+Heigth),
                new Point(p.X+Width,p.Y-Heigth),
                new Point(p.X-Width,p.Y-Heigth),
                new Point(p.X-Width,p.Y+Heigth)

            };
            return gridpoint;
        }

        Rectangle GetRect()
        {
            int lato = rand.MaxXSquare(Width, Heigth);
            Rectangle rect = new Rectangle(rand.RandomCoordinate(Width), rand.RandomCoordinate(Heigth), lato, lato);
            return rect;
        }

        Rectangle[] Getrects()
        {
            int lato = rand.MaxXSquare(Width, Heigth);
            Size size = new Size(lato, lato);
            Rectangle[] rects =
            {
                new Rectangle(Gridpoint()[0],size),
                new Rectangle(Gridpoint()[1],size),
                new Rectangle(Gridpoint()[2],size),
                new Rectangle(Gridpoint()[3],size),
                new Rectangle(Gridpoint()[4],size),
                new Rectangle(Gridpoint()[5],size),
                new Rectangle(Gridpoint()[6],size),
                new Rectangle(Gridpoint()[7],size),
                new Rectangle(Gridpoint()[8],size),

            };

            return rects;
        }


        Color GetColor()
        {
            Color color = (rand.Randomcolor());
            return color;
        }

        Pen Getpen()
        {
            Pen pen = new Pen(GetColor());
            pen.Width = rand.PenSize(Width / 100, Width / 70);
            return pen;
        }

        SolidBrush Getbrush()
        {
            SolidBrush brush = new SolidBrush(GetColor());
            return brush;
        }

        TextureBrush GetTextureBrush()
        {
            Image textImage = new Bitmap(40, 40);
            Graphics grText = Graphics.FromImage(textImage);
            Pen selpen = new Pen(rand.Randomcolor());
            selpen.Width = 10;
            grText.DrawLine(selpen,textImage.Width/2 ,0 ,textImage.Width/2, textImage.Height);
            TextureBrush texture = new TextureBrush(textImage);
            return texture;
        }

        Matrix GetMatrix()
        {
            Matrix matrix = new Matrix();
            matrix.RotateAt(rand.RandomRotation(), new PointF(GetRect().Left + (GetRect().Width / 2), GetRect().Top + (GetRect().Height / 2)));
            return matrix;
        }







        public void DrawSolidSquare()
        {

            GetGraphics().FillRectangle(GetTextureBrush(), GetRect());
            GetGraphics().RotateTransform(rand.RandomRotation());
            GetGraphics().Dispose();

        }

        public void DrawSolidSquareshadow()
        {
            int offset = rand.Random(Width / 90, Width / 80);
            Rectangle rect = GetRect();
            Rectangle rectshadow = new Rectangle(rect.Left + offset, rect.Top + offset, rect.Width, rect.Height);
            GetGraphics().FillRectangle(new SolidBrush(Color.Black), rectshadow);
            GetGraphics().FillRectangle(Getbrush(), rect);
            GetGraphics().RotateTransform(rand.RandomRotation());
            GetGraphics().Dispose();

        }

        public void Draw9Square()
        {
            foreach (var rect in Getrects())
            {
                GetGraphics().FillRectangle(new SolidBrush(Color.Black), rect);
            }
        }

        public void DrawSolidCircles()
        {

            GetGraphics().FillEllipse(Getbrush(), GetRect());
            GetGraphics().Dispose();

        }

        public void DrawSolidCircleshadow()
        {
            int offset = rand.Random(Width / 90, Width / 80);
            Rectangle rect = GetRect();
            Rectangle rectshadow = new Rectangle(rect.Left + offset, rect.Top + offset, rect.Width, rect.Height);
            GetGraphics().FillEllipse(new SolidBrush(Color.Black), rectshadow);
            GetGraphics().FillEllipse(Getbrush(), rect);
            GetGraphics().RotateTransform(rand.RandomRotation());
            GetGraphics().Dispose();

        }

        public void DrawSolidTriangle()
        {
            Rectangle rect = GetRect();
            Point[] point =
            {
                new Point (rect.Left+rect.Width/2, rect.Top),
                new Point (rect.Left,rect.Bottom),
                new Point (rect.Right,rect.Bottom)
            };
            GetGraphics().RotateTransform(rand.RandomRotation());
            GetGraphics().FillPolygon(Getbrush(), point);
            
            GetGraphics().Dispose();
        }

        public void DrawSine()
        {
            float x1 = 0;
            float y1 = 0;
            float y2 = 0;
            float yEx = 200;
            float eF = 40;
            Pen pen = new Pen(Color.Black, 8.0f);

            for (float x = 0; x < 20; x += 0.1F)
            {
                y2 = (float)Math.Sin(x);
                GetGraphics().DrawLine(pen, x1 * eF, y1 * eF + yEx, x * eF, y2 * eF + yEx);
            }
        }





        public void DrawRotatedSquare()
        {

            GetGraphics().Transform = GetMatrix();
            GetGraphics().DrawRectangle(Getpen(), GetRect());
            GetGraphics().ResetTransform();
            GetGraphics().Dispose();

        }

        public void DrawSquareRandom(int times)
        {
            for (int i = 0; i < times; i++)
            {
                Rectangle rectangle1 = GetRect();

                if (GetRect().IntersectsWith(GetRect()) == false)
                {
                    DrawSolidSquare();
                }
            }
        }



        /// <summary>
        /// Disegna un quadrato vuoto sotto e uno pieno sopra
        /// </summary>
        /// <param name="offset"></param>
        public void DrawOffsetSquare(int offset) // disegna due quadrati l'uno sopra l'altro
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Color color = rand.Randomcolor();
            Pen selPen = new Pen(rand.Randomcolor());
            selPen.Width = rand.PenSize(10, 20);
            // gr.RotateTransform(rand.RandomRotation());
            gr.DrawRectangle(selPen, GetRect());
            gr.FillRectangle(new SolidBrush(color), GetRect().Left + offset, GetRect().Top + offset, GetRect().Width, GetRect().Height);
            gr.Dispose();

        }

        public void DrawSolidSquare(Point[] points)
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Color color = rand.Randomcolor();
            for (int i = 0; i < points.Length; i++)
            {
                //gr.RotateTransform(rand.RandomRotation());
                gr.FillRectangle(new SolidBrush(rand.Randomcolor()), points[i].X, points[i].Y, Width / 30, Width / 30);
            }
            // gr.TranslateTransform(width / 2, width / 2);
            // gr.RotateTransform(rand.RandomRotation());
            // gr.FillRectangle(new SolidBrush(color), x, y, width, width);
            gr.Dispose();

        }






        public void DrawSolidSquareSeamPatt()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Color color = rand.Randomcolor();
            SolidBrush brush = new SolidBrush(color);
            int lato = rand.MaxXSquare(Width, Heigth);
            Size size = new Size(lato, lato);
            // Matrix m = new Matrix();//

            Point point = new Point(rand.RandomCoordinate(Width), rand.RandomCoordinate(Heigth));

            Rectangle rect = new Rectangle(point, size);
            // m.RotateAt(rand.RandomRotation(), new PointF(rect.Left + rect.Width / 2, rect.Top +rect.Height / 2));//
            // gr.Transform = m;//
            gr.FillRectangle(new SolidBrush(color), rect);

            if (rect.Right < rect.Width)
            {
                if (rect.Bottom < rect.Height)
                {
                    gr.FillRectangle(brush, rect.Left + Width, rect.Top + Heigth, lato, lato);
                }
                else
                    gr.FillRectangle(brush, rect.Left + Width, rect.Top, lato, lato);
            }

            if (rect.Right > Width)
            {
                if (rect.Bottom < rect.Height)
                {
                    gr.FillRectangle(brush, rect.Left - Width, rect.Top + Heigth, lato, lato);
                }
                else
                    gr.FillRectangle(brush, rect.Left - Width, rect.Top, lato, lato);
            }

            if (rect.Bottom < rect.Height)
            {
                if (rect.Right > Width)
                {
                    gr.FillRectangle(brush, rect.Left - Width, rect.Top + Heigth, lato, lato);
                }
                else
                    gr.FillRectangle(brush, rect.Left, rect.Top + Heigth, lato, lato);
            }

            if (rect.Bottom > Heigth)
            {
                if (rect.Right < rect.Width)
                {
                    gr.FillRectangle(brush, rect.Left + Width, rect.Top - Heigth, lato, lato);
                }
                else
                    gr.FillRectangle(brush, rect.Left, rect.Top - Heigth, lato, lato);
            }


            gr.Dispose();
        }





        public void DrawHollowSquare()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Pen selPen = new Pen(rand.Randomcolor());
            selPen.Width = rand.PenSize(20, 40);
            int lato = rand.MaxXSquare(Width, Heigth);
            Rectangle rect = new Rectangle(rand.RandomCoordinate(Width), rand.RandomCoordinate(Heigth), lato, lato);
            gr.DrawRectangle(selPen, rect);
            //gr.RotateTransform(rand.RandomRotation());
            gr.Dispose();

        }

        public void DrawDotsSquare()
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Image textImage = new Bitmap(40, 40);
            Graphics grtexture = Graphics.FromImage(textImage);
            grtexture.FillEllipse(new SolidBrush(rand.Randomcolor()), 5, 5, 10, 10);
              int lato = rand.MaxXSquare(Width*2, Heigth*2);
              Rectangle rect = new Rectangle(rand.RandomCoordinate(Width), rand.RandomCoordinate(Heigth), lato, lato);
            TextureBrush texture = new TextureBrush(textImage);
              gr.RotateTransform(rand.RandomRotation());
            gr.FillRectangle(texture, rect);

            gr.Dispose();
        }

        public TextureBrush texturize()
        {
            int TextureDimension = rand.MaxXSquare(Width, Heigth);
            int maxcircles = rand.MaxXSquare(TextureDimension, TextureDimension);
            Bitmap bitmapTexture = new Bitmap(TextureDimension, TextureDimension);
            Graphics gr = Graphics.FromImage(bitmapTexture);
            gr.FillEllipse(new SolidBrush(rand.Randomcolor()), rand.RandOXSquare(bitmapTexture.Width), rand.RandOYSquare(bitmapTexture.Height), maxcircles, maxcircles);
            TextureBrush texture = new TextureBrush(bitmapTexture);
            texture.WrapMode = WrapMode.Tile;
            Matrix M = new Matrix();
            M.Translate(Width, Heigth);
            texture.MultiplyTransform(M, MatrixOrder.Prepend);
            gr.Dispose();
            return texture;

        }



        public void DrawLinesSquare() // disegna un quadrato di linee oblique
        {
            Graphics gr = Graphics.FromImage(bitmap);
            Color color = rand.Randomcolor();
            Pen selpPen = new Pen(color);
            selpPen.Width = rand.PenSize(10, 90);
            int augment = rand.Random(90, 150);
            // gr.RotateTransform(rand.RandomRotation());
            for (int i = 0; i <= Width; i++)
            {
                gr.DrawLine(selpPen, i, 0, i, Heigth);
                i += augment - 1;
            }
            gr.Dispose();

        }

        /*
          public  void FillPattern( Bitmap bitmap)
          {
              Rectangle imageRect;
              Rectangle drawRect;

              for (int x = GetRect().X; x < GetRect().Right; x += bitmap.Width)
              {
                  for (int y = GetRect().Y; y < GetRect().Bottom; y += bitmap.Height)
                  {
                      drawRect = new Rectangle(x, y, Math.Min(bitmap.Width, GetRect().Right - x),
                                     Math.Min(bitmap.Height, GetRect().Bottom - y));
                      imageRect = new Rectangle(0, 0, drawRect.Width, drawRect.Height);

                      DrawDotsSquare().DrawImage(bitmap, drawRect, imageRect, GraphicsUnit.Pixel);
                  }
              }
          }
        */

        public void SquareDesigner()
        {
            int number = rand.ShapeSelection();

            switch (number)
            {
                case 1:
                    DrawSolidSquare();
                    break;

                case 2:
                    DrawHollowSquare();
                    break;

                case 3:
                    DrawDotsSquare();
                    break;

                case 4:
                    DrawOffsetSquare(rand.SquareOffset());
                    break;

            }

        }

    }
}
