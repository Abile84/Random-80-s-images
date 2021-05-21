using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidColours
{
    class randomizer
    {

       static Random rand = new Random();

        public int Random(int max)
        {
            return rand.Next(max);
        }
        
        public int Random(int min,int max)
        {
            return rand.Next(min,max);
        }
        /// <summary>
        /// Restituisce un valore random di minimo e massimo valore di x nell'origine di un quadrato.
        /// </summary>
        /// <param name="xSquare"></param>
        /// <returns></returns>
         public int RandOXSquare(int x) 
        {
            return rand.Next(0, x / 2);
        }

        /// <summary>
        /// Restituisce un valore random di minimo e massimo valore di y nell'origine di un quadrato.
        /// </summary>
        /// <param name="ySquare"></param>
        /// <returns></returns>
         public int RandOYSquare(int y) //origine y min/max quadrati
        {
            return rand.Next(0, y / 2);
        }

        /// <summary>
        /// Restituisce un valore random di minimo e massimo valore di larghezza di un quadrato (Inserirlo nella funzione DrawRectangle 2 volte).
        /// </summary>
        /// <param name="Xsquare"></param>
        /// <returns></returns>
         public int MaxXSquare(int x, int y)
        {
            int num = 0;
            if (x <= y)
            {
                num = rand.Next(x / 20, x / 5);   
            }
            else if (x > y)
            {
                num = rand.Next(y / 15, y / 5);   
            }
            return num;
        }

        /// <summary>
        /// Restituisce un valore random di minimo e massimo valore di altezza di un quadrato (Inserirlo nella funzione DrawRectangle se si vuole ottenere un rettangolo).
        /// </summary>
        /// <param name="Ysquare"></param>
        /// <returns></returns>
         public int MaxYSquare(int y)
        {
            return rand.Next(y / 10, y / 2);
        }

        /// <summary>
        /// >Metodo che seleziona un metodo di disegno forme casuale tra quelli contenuti 
        /// </summary>
        /// <returns></returns>
        public int ShapeSelection()
        {
            return rand.Next(1, 4);
        }

        /// <summary>
        /// Seleziona dimensione casuale penna 
        /// </summary>
        /// <returns></returns>
        public int PenSize(int min,int max)
        {
            return rand.Next(min,max);
        }

        /// <summary>
        /// Seleziona dimensione immagine pattern in base alla dimensione di x 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int RandomPatternSize(int x)
        {
            return rand.Next(x / 15, x / 5);
        }

        /// <summary>
        /// Restituisce un angolo casuale di rotazione 
        /// </summary>
        /// <returns></returns>
        public float RandomRotation()
        {
            return rand.Next(-45, 45);
        }



        /// <summary>
        /// Restituisce un valore random di offset per il disegno di quadrati sovrapposti
        /// </summary>
        /// <returns></returns>
        public int SquareOffset()
        {
            return rand.Next(20, 100);
        }

        public Color RandomBackgroundcolor()
        {
            Color color = new Color();
            color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256), rand.Next(256));
            return color;
        }


        //Array contenente i colori generalmente usati per gli sfondi
        static Color[] RandomColorBackground =
        {
            Color.FromArgb(20,22,22),
            Color.FromArgb(18,16,16),
            Color.FromArgb(241,239,239),
            Color.FromArgb(232,230,230),
            Color.FromArgb(228,228,228),
            Color.FromArgb(32,89,89)   ,
            Color.FromArgb(38,41,41)   ,
            Color.FromArgb(248,175,175),
            Color.FromArgb(0,0,0)      ,
            Color.FromArgb(248,211,211),
            Color.FromArgb(132,65,65)  ,
            Color.FromArgb(79,115,115) ,
            Color.FromArgb(44,43,43)   ,
            Color.FromArgb(163,119,119),
            Color.FromArgb(207,123,123),
            Color.FromArgb(251,176,176),
            Color.FromArgb(164,218,218),
            Color.FromArgb(32,21,21)   ,
            Color.FromArgb(242,242,242),
            Color.FromArgb(181,219,219),
            Color.FromArgb(239,239,239),
            Color.FromArgb(247,215,215),
            Color.FromArgb(247,236,236),
            Color.FromArgb(16,93,93)   ,
            Color.FromArgb(163,217,217),
            Color.FromArgb(209,152,152),
            Color.FromArgb(161,198,198),
            Color.FromArgb(242,232,232),
            Color.FromArgb(199,147,147),
            Color.FromArgb(80,203,203) ,
            Color.FromArgb(132,185,185),
            Color.FromArgb(55,141,141) ,
            Color.FromArgb(234,78,78)  ,
            Color.FromArgb(131,160,160),
            Color.FromArgb(102,68,68)  ,
            Color.FromArgb(215,105,105),
            Color.FromArgb(157,151,151),
            Color.FromArgb(160,123,123),
            Color.FromArgb(247,235,235),
            Color.FromArgb(21,23,23)   ,
            Color.FromArgb(92,92,92)   ,
            Color.FromArgb(183,196,196),
            Color.FromArgb(7,3,3)      ,
            Color.FromArgb(28,125,125) ,
            Color.FromArgb(208,209,209),
            Color.FromArgb(242,178,178),
            Color.FromArgb(129,197,197),
            Color.FromArgb(27,28,28)   ,
            Color.FromArgb(3,98,98)    ,
            Color.FromArgb(244,95,95)  ,
            Color.FromArgb(246,142,142),
            Color.FromArgb(153,151,151),
            Color.FromArgb(137,201,201),
            Color.FromArgb(240,166,166),
            Color.FromArgb(179,195,195),
            Color.FromArgb(119,158,158),
            Color.FromArgb(41,241,241) ,
            Color.FromArgb(24,132,132) ,
            Color.FromArgb(247,247,247)
        };
        
        /// <summary>
        /// Restituisce un colore casuale per lo sfondo.
        /// </summary>
        /// <returns></returns>
        public Color RandomColorBg()
        {
            return RandomColorBackground[rand.Next(RandomColorBackground.Length)];
        }


        //Array contenente i colori generalmente usati per le forme
        static Color[] RandColorShape =
        {
            Color.FromArgb(45,67,67),
            Color.FromArgb(55,14,14),
            Color.FromArgb(126,98,98),
            Color.FromArgb(47,84,84),
            Color.FromArgb(55,43,43),
            Color.FromArgb(30,131,131),
            Color.FromArgb(166,142,142),
            Color.FromArgb(40,148,148) ,
            Color.FromArgb(111,189,189),
            Color.FromArgb(150,126,126),
            Color.FromArgb(41,32,32)   ,
            Color.FromArgb(141,147,147),
            Color.FromArgb(69,94,94)   ,
            Color.FromArgb(192,52,52)  ,
            Color.FromArgb(85,165,165) ,
            Color.FromArgb(87,162,162) ,
            Color.FromArgb(178,149,149),
            Color.FromArgb(78,188,188) ,
            Color.FromArgb(251,201,201),
            Color.FromArgb(68,68,68)   ,
            Color.FromArgb(251,220,220),
            Color.FromArgb(158,124,124),
            Color.FromArgb(243,142,142),
            Color.FromArgb(124,232,232),
            Color.FromArgb(173,173,173),
            Color.FromArgb(225,55,55)  ,
            Color.FromArgb(111,170,170),
            Color.FromArgb(231,206,206),
            Color.FromArgb(64,130,130) ,
            Color.FromArgb(250,238,238),
            Color.FromArgb(0,104,104)  ,
            Color.FromArgb(50,253,253) ,
            Color.FromArgb(125,197,197),
            Color.FromArgb(166,138,138),
            Color.FromArgb(249,104,104),
            Color.FromArgb(219,219,219),
            Color.FromArgb(195,168,168),
            Color.FromArgb(133,202,202),
            Color.FromArgb(239,127,127),
            Color.FromArgb(238,181,181),
            Color.FromArgb(159,6,6)    ,
            Color.FromArgb(152,112,112),
            Color.FromArgb(58,161,161) ,
            Color.FromArgb(107,186,186),
            Color.FromArgb(249,238,238),
            Color.FromArgb(164,138,138),
            Color.FromArgb(153,182,182),
            Color.FromArgb(46,63,63)   ,
            Color.FromArgb(238,116,116),
            Color.FromArgb(243,243,243),
            Color.FromArgb(21,162,162) ,
            Color.FromArgb(224,140,140),
            Color.FromArgb(166,187,187),
            Color.FromArgb(93,148,148) ,
            Color.FromArgb(205,129,129),
            Color.FromArgb(225,120,120),
            Color.FromArgb(246,28,28)  ,
            Color.FromArgb(162,123,123),
            Color.FromArgb(246,211,211),
            Color.FromArgb(194,199,199),
            Color.FromArgb(93,128,128) ,
            Color.FromArgb(224,224,224),
            Color.FromArgb(243,200,200),
            Color.FromArgb(237,176,176),
            Color.FromArgb(246,110,110),
            Color.FromArgb(132,212,212),
            Color.FromArgb(243,46,46)  ,
            Color.FromArgb(16,146,146) ,
            Color.FromArgb(246,0,0)    ,
            Color.FromArgb(47,160,160) ,
            Color.FromArgb(243,220,220),
            Color.FromArgb(199,94,94)  ,
            Color.FromArgb(162,42,42)
        };

        /// <summary>
        /// restituisce un colore casuale per le forme
        /// </summary>
        /// <returns></returns>
        public Color Randomcolor()
        {
            return RandColorShape[rand.Next(RandColorShape.Length)];
        }

        /// <summary>
        /// Restituisce un punto casuale data una dimensione x
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Point RandomPoint(int x)
        {
            Point point = new Point(rand.Next(x), rand.Next(x));
            return point;
        }

        public int RandomCoordinate(int x)
        {
            return rand.Next(-x,2*x);
        }

        public int randomSize(int x)
        {
            return rand.Next(x / 40, x / 20);
        }

        /// <summary>
        /// Restituisce un array di punti secondo una matrice. Il valore della x e della y e riferito alle dimensioni finali dell immagine
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Point[] Pointmatrix(int x, int y)
        {
            int div = rand.Next(x / 40, x / 20);
            List<Point> pointMatrix = new List<Point>();
            for (int asc=0 ; asc<x ; asc++)
            {
                for (int ord = 0; ord < y; ord++)
                {
                    pointMatrix.Add(new Point(asc,ord));
                    ord += div - 1;
                }
                asc += div - 1;
            }
            Point[] points = pointMatrix.ToArray();
            return points;
        }

        /// <summary>
        /// Restituisce un punto casuale di una matrice di punti 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public Point RandomPointmatrix(int x,int y)
        {
            return Pointmatrix(x, y)[rand.Next(Pointmatrix(x,y).Length)];
        }


    }
}
