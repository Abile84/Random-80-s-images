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

namespace SolidColours
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color color = new Color();
        string savepath = "";
        Random rnd = new Random();
        randomizer r = new randomizer();
        PatternBrush patternbrush = new PatternBrush();
        string colorNameImages;
        string destPathColor;
       


        Square square = new Square();
        
        private void buttonSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saveImages = new FolderBrowserDialog();
            if(saveImages.ShowDialog()==DialogResult.OK)
            {
                buttonStart.Enabled = true;
                savepath = saveImages.SelectedPath;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            ColorDialog chooseColour = new ColorDialog();
            if (chooseColour.ShowDialog()== DialogResult.OK)
            {
                color = chooseColour.Color;
            }
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {
           

            

            for (int i = 0; i < numericNImages.Value; i++)
            {
                square.Width= Convert.ToInt32(numeriCWidth.Value);
                square.Heigth= Convert.ToInt32(numericHeight.Value);
                square.bitmap = new Bitmap(square.Width, square.Heigth);
                int x = Convert.ToInt32(numeriCWidth.Value);
                int y = Convert.ToInt32(numericHeight.Value);

                if (checkBoxRandom.Checked ==true)
                {
                  //  color = r.RandomColorBg();
                    color = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
                

                    

                colorNameImages = rnd.Next().ToString() + ".jpg";
                destPathColor = Path.Combine(savepath, colorNameImages);
                Pen pen = new Pen(Brushes.Black);
                pen.Width = i + 10;

                //Bitmap bitmap = new Bitmap(x, y);
                square.bitmap.SetResolution(Convert.ToSingle(numericResolution.Value), Convert.ToSingle(numericResolution.Value));
                using (Graphics g = Graphics.FromImage(square.bitmap))
                {
                    g.FillRectangle(new SolidBrush(color), 0, 0, square.bitmap.Width, square.bitmap.Height);

                    
                      for (int c = 0; c < trackBartest.Value; c++)
                      {
                        square.DrawSolidSquareshadow();
                        square.DrawSolidTriangle();
                        square.DrawSolidCircleshadow();
                        square.DrawDotsSquare();
                        
                        square.DrawSolidSquare();



                      }
                      
                    
                   square.bitmap.Save(destPathColor);


                   square.bitmap.Dispose();
                }
            }



           

           
        }


        public void DisplayImage(Bitmap bitmap)
        {
            Form form = new Form();
            form.Width = bitmap.Width;
            form.Height = bitmap.Height;
            form.Text = "Pattern image Viewer";
            PictureBox imageControl = new PictureBox();
            Bitmap image = bitmap;
            imageControl.Dock = DockStyle.Fill;
            imageControl.Image = (Image)image;
            imageControl.SizeMode = PictureBoxSizeMode.StretchImage;
            
            form.Controls.Add(imageControl);
            form.ShowDialog();
            form.Refresh();
        }

        private void checkBoxRandom_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBoxRandom.Checked==true)
            {
                buttonSetColor.Enabled = false;
                numericNImages.Enabled = true;
            }
            else if (checkBoxRandom.Checked==false)
            {
                buttonSetColor.Enabled = true;
                numericNImages.Enabled = false;
            }
        }

        private void trackBartest_ValueChanged(object sender, EventArgs e)
        {
            labeltrack.Text = trackBartest.Value.ToString();
        }

        private void BtnTexture_Click(object sender, EventArgs e)
        {
            TextureMaker formText = new TextureMaker();
            formText.Show();
        }
    }



}
