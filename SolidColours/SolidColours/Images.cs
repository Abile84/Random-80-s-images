using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidColours
{
     public class ImageMaker
    {


        public void getImages(Bitmap image , int numberOfImages,Color color,string savePath)
        {
            for (int i = 0; i <= numberOfImages; i++)
            {
                Brush brush = new SolidBrush(color);
                //image.SetResolution(resolution, resolution);
                 using (Graphics gfx = Graphics.FromImage(image))

               
                    {
                        gfx.FillRectangle(brush, 0, 0, image.Width, image.Height);

                    }
                    image.Save(savePath);
                    image.Dispose();
            }
        }
        









    }
    


    

}
