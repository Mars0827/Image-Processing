using ImageProcessing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void pixelCopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;

            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);
                }
            }

            pictureBox2.Image = processed;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }

        private void greyscalingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int grey;
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel((int)x, (int)y);
                    grey = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    Color gray = Color.FromArgb(grey, grey, grey);
                    processed.SetPixel(x, y, gray);
                }
            }

            pictureBox2.Image = processed;
        }

        private void inversionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = 0; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel((int)x, (int)y);
                    Color temp = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(x, y, temp);
                }
            }

            pictureBox2.Image = processed;
        }

        private void mirrorHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int x = loaded.Width - 1; x > 0; x--)
            {
                for (int y = 0; y < loaded.Height; y++)
                {
                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(loaded.Width - x, y, pixel);
                }
            }
            pictureBox2.Image = processed;
        }

        private void mirrorVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = loaded.Height - 1; j > 0; j--)
                {
                    pixel = loaded.GetPixel(i, j);
                    processed.SetPixel(i, loaded.Height - j, pixel);
                }
            }
            pictureBox2.Image = processed;
        }


        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicDIP.Hist(ref loaded, ref processed);
            pictureBox2.Image = processed;
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel;
            double r, g, b;

            for (int i = 0; i < loaded.Width; i++)
            {
                for (int j = 0; j < loaded.Height; j++)
                {
                    pixel = loaded.GetPixel(i, j);
                    r = Math.Min((pixel.R * 0.393) + (pixel.G * 0.769) + (pixel.B * 0.189) * 1.2, 255);
                    g = Math.Min((pixel.R * 0.349) + (pixel.G * 0.686) + (pixel.B * 0.168) * 1.2, 255);
                    b = Math.Min((pixel.R * 0.272) + (pixel.G * 0.534) + (pixel.B * 0.131) * 1.2, 255);
                    Color sepia = Color.FromArgb((int)r, (int)g, (int)b);
                    processed.SetPixel(i, j, sepia);
                }
            }
            pictureBox2.Image = processed;
        }

        private void ImageProcessor_Load(object sender, EventArgs e)
        {

        }

        private void smoothingToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Smooth(processed);
            pictureBox2.Image = processed;

        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.GaussianBlur(processed);
            pictureBox2.Image = processed;

        }

        private void blurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.GaussianBlur(processed);
            pictureBox2.Image = processed;
        }

        private void embossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EmbossAllDirections(processed);
            pictureBox2.Image = processed;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Sharpen(processed);
            pictureBox2.Image = processed;
        }

        private void shrinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Sharpen(processed);
            pictureBox2.Image = processed;
        }

        private void meanRemovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.MeanRemoval(processed);
            pictureBox2.Image = processed;
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EmbossLossy(processed);
            pictureBox2.Image = processed;
        }

        private void horizOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EmbossHorizontal(processed);
            pictureBox2.Image = processed;
        }

        private void vertOnlyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EmbossVertical(processed);
            pictureBox2.Image = processed;
        }

        private void embossLaplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EmbossLaplacian(processed);
            pictureBox2.Image = processed;
        }

        private void edgeDetectQuickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectQuick(processed);
            pictureBox2.Image = processed;
        }

        private void edgeDetectConvolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectConvolution(processed, 1, 1);
            pictureBox2.Image = processed;
        }

        private void edgeDetectHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectHorizontal(processed);
            pictureBox2.Image = processed;
        }

        private void edgeDetectVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectVertical(processed);
            pictureBox2.Image = processed;
        }

        private void edgeDetectHomogenityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectHomogenity(processed, 1);
            pictureBox2.Image = processed;
        }

        private void edgeDetectDifferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EdgeDetectDifference(processed, 1);
            pictureBox2.Image = processed;
        }

        private void edgeEnhanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.EdgeEnhance(processed, 1);
            pictureBox2.Image = processed;
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Resize(processed, 5, 5, true);
            pictureBox2.Image = processed;
        }

        private void offsetFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.RandomJitter(processed, 1);
            pictureBox2.Image = processed;
        }

        private void flipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Flip(processed, true, true);
            pictureBox2.Image = processed;
        }

        private void randomJitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.RandomJitter(processed, 7);
            pictureBox2.Image = processed;
        }

        private void swirlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Swirl(processed, 5, true);
            pictureBox2.Image = processed;
        }

        private void sphereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Sphere(processed, true);
            pictureBox2.Image = processed;
        }

        private void timeWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.TimeWarp(processed, 5, true);
            pictureBox2.Image = processed;
        }

        private void moireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Moire(processed, 1);
            pictureBox2.Image = processed;
        }

        private void waterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Water(processed, 1, true);
            pictureBox2.Image = processed;
        }

        private void pixelateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loaded == null)
                return;

            processed = new Bitmap(loaded);
            BitmapFilter.Pixelate(processed, 2, true);
            pictureBox2.Image = processed;
        }

        private void hEHEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            processed = new Bitmap(loaded.Width, loaded.Height);
            Color pixel, gray, inv;

            for (int x = 0; x < loaded.Width / 2; x++)
            {
                for (int y = 0; y < loaded.Height / 2; y++)
                {

                    pixel = loaded.GetPixel(x, y);
                    inv = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    processed.SetPixel(x, y, inv);

                }
            }

            int grey;
            for (int x = loaded.Width / 2; x < loaded.Width; x++)
            {
                for (int y = 0; y < loaded.Height / 2; y++)
                {

                    pixel = loaded.GetPixel(x, y);
                    grey = (int)(pixel.R + pixel.G + pixel.B) / 3;
                    gray = Color.FromArgb(grey, grey, grey);
                    processed.SetPixel(x, y, gray);

                }
            }

            for (int x = 0; x < loaded.Width / 2; x++)
            {
                for (int y = loaded.Height / 2; y < loaded.Height; y++)
                {

                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, y, pixel);

                }
            }

            for (int x = loaded.Width / 2; x < loaded.Width; x++)
            {
                for (int y = loaded.Height / 2; y < loaded.Height; y++)
                {

                    pixel = loaded.GetPixel(x, y);
                    processed.SetPixel(x, loaded.Height - y + loaded.Height / 2 - 1, pixel);

                }
            }

            pictureBox2.Image = processed;
        }

        private void goToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);

            bool result = BitmapFilter.EdgeDetectConvolution(loaded, 1, 100);

            int coinCount = BitmapFilter.CountBlobs(loaded);

            Bitmap withText = new Bitmap(loaded);
            using (Graphics g = Graphics.FromImage(withText))
            {
                Font font = new Font("Arial", 24, FontStyle.Bold);
                Brush brush = new SolidBrush(Color.Red);
                PointF position = new PointF(10, 10);

                g.DrawString($"Coins: {coinCount}", font, brush, position);
            }

            pictureBox2.Image = withText;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }
    }
}