using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoFaceDetect
{

    public partial class frmChap5 : Form
    {
        private static OpenFileDialog ofd = new OpenFileDialog();
        public frmChap5()
        {
            InitializeComponent();
            //ofd.Filter = "Images|*.jpg;*.jpeg;*.png;....";
            ofd.Title = "Choose an Image";
        }

        private void toolColorDrawing_Click(object sender, EventArgs e)
        {
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(picBox.Width, picBox.Height, new
                                            Bgr(255,0,0));
            picBox.Image = image.ToBitmap();
        }

        private void toolFromFile_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image<Bgr, Byte> image = new Image<Bgr, byte>(ofd.FileName);
                picBox.Image = image.ToBitmap();
            }
        }

        private void toolRandomMaxtrix_Click(object sender, EventArgs e)
        {
            //Create an image
            Image<Bgr, Byte> image = new Image<Bgr, Byte>(picBox.Width, picBox.Height, new
                                        Bgr(255, 0, 0));
            //Set yellow(0, 255, 255) pixel point
            Byte b1 = 255;
            Bgr yellow = new Bgr(0, 255, 255);

            for(int i = 20; i < 60; i++)
            {
                for(int j = 20; j< 60; j++)
                {
                    image.Data[i, j, 0] = 0;
                    image.Data[i, j, 1] = b1;
                    image.Data[i, j, 2] = b1;
                }
            }

            //Change the color by setting an bgr color
            for (int i = 120; i< 160; i++)
            {
                for(int j = 20; j< 60; j++)
                {
                    image[i, j] = yellow;
                }
            }

            //Reduce performance
            byte[,,] data = image.Data;
            for(int i = 20; i < 60; i++)
            {
                for (int j = 100; j < 140; j++)
                {
                    data[i, j, 0] = 0;
                    data[i, j, 1] = b1;
                    data[i, j, 2] = b1;
                }
            }

            picBox.Image = image.ToBitmap();
        }

        private void toolGrayscale_Click(object sender, EventArgs e)
        {

            if(ofd.FileName == "")
            {
                MessageBox.Show("No file choosen", "You didn't choose any file!", MessageBoxButtons.OK);
            }
            else
            {
                
                    Image<Bgr, Byte> input = new Image<Bgr, Byte>(ofd.FileName);
                    Bgr tmp;

                    Image<Bgr, Byte> result = input.Copy();

                    for (int i = 0; i < input.Height; i++)
                    {
                        for (int j = 0; j < input.Width; j++)
                        {
                            //
                            tmp = input[i, j];

                            double gray = (tmp.Green * 0.587 + tmp.Blue * 0.114 + tmp.Red * 0.299);

                            result[i, j] = new Bgr(gray, gray, gray);
                        }
                    }
                    picResult.Image = result.ToBitmap();
                
            }
            
        }

        private void toolCrop_Click(object sender, EventArgs e)
        {
            picResult.Image = null;
            int p1X, p1Y, p2X, p2Y;
            using (frmInput form = new frmInput())
            {
                form.ShowDialog();
                p1X = form.getP1X();
                p1Y = form.getP1Y();
                p2X = form.getP2X();
                p2Y = form.getP2Y();
            }

            Image<Bgr, Byte> input = new Image<Bgr, Byte>(ofd.FileName);
            int maxWidth = Math.Max(p2X, p1X) - Math.Min(p2X, p1X); //??
            int maxHeight = Math.Max(p2Y, p1Y) - Math.Min(p2Y, p1Y);
            Console.WriteLine("SIZE = " + maxWidth + "x" + maxHeight);

            Image<Bgr, Byte> result = new Image<Bgr, byte>(maxHeight + 1, maxWidth +1 );
            int w = 0;
            int h = 0;

            try
            {
                for (int i = p1X; i <= p2X; i++)
                {
                    for (int j = p1Y; j <= p2Y; j++)
                    {
                        Bgr tmp = input[i, j];
                        result[h, w] = new Bgr(tmp.Blue, tmp.Green, tmp.Red);
                        Console.WriteLine("h = " + h + ", w = " + w);
                        w++;
                    }
                    w = 0;
                    h++;
                }
                picResult.Image = result.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vượt quá giới hạn ảnh gốc: " + input.Width + "x" + input.Height, ex.Message, MessageBoxButtons.OK);
            }

        }
    }
}
