using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SolidColours
{
    public partial class TextureMaker : Form
    {
        List<TextureValues> textureInfo = new List<TextureValues>();
        List<Point> p = new List<Point>();
        
        public TextureMaker()
        {
            InitializeComponent();
        }

        private void numTextWidth_ValueChanged(object sender, EventArgs e)
        {
            panelText.Width = (int)numTextWidth.Value;
        }

        private void numTextHeight_ValueChanged(object sender, EventArgs e)
        {
            panelText.Height = (int)numTextHeight.Value;
        }

        private void panelText_Click(object sender, EventArgs e)
        {
            p.Add(panelText.PointToClient(Cursor.Position));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           
            textureInfo.AddRange(new TextureValues[]
                {
                    new TextureValues(textBoxName.Text,DateTime.Now.ToString(),p,(int)numericPenSize.Value,(int)numTextWidth.Value,(int)numTextHeight.Value)
                });

            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\textures.xml";
            FileStream stream = File.Create(path); 
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<TextureValues>));
            xmlSerializer.Serialize(stream, textureInfo);
            stream.Close();
            p.Clear();
         }

        private void TextureMaker_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
