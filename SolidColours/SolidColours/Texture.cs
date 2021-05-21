using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SolidColours
{
    [Serializable()]
    public class TextureValues

    {
        [XmlAttribute("Texture_Info")]
        public string Name { get; set; }
        public string Date { get; set; }

       
        public List<Point> Points { get; set; }
        public int Pensize { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public TextureValues() { }

        public TextureValues(string name, string date ,List<Point> points,int pensize,int width,int heigth)
        {
            this.Name = name;
            this.Date = date;
            this.Points = points;
            this.Pensize = pensize;
            this.Width = width;
            this.Height = heigth;

        }
    }

   /* [Serializable()]
    public class rootValues
    {
        public rootValues()
        {
            List<TextureValues> valuesArray = new List<TextureValues>();
        }

        [XmlElement("item", typeof(TextureValues))]
        public List<TextureValues> valuesList { get; set; }

    }
   */
}
