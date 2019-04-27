using MHG.ImageProcess.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MHG.ImageProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbProcessType.SelectedIndex = 0;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            switch (cbProcessType.SelectedItem.ToString())
            {
                case "Negative":
                    ProcessNegativeImage();
                    break;
                case "Gray":
                    ProcessGrayImage();
                    break;
                case "Black And White":
                    ProcessBlackAndWhiteImage(ProcessGrayImage(), 128);
                    break;
                case "Brightness":
                    ProcessBrightnessImage();
                    break;
                default:
                    break;
            }
        }

        private void ProcessBrightnessImage()
        {
            var image = new Bitmap(pbOriginal.Image);
            int brightnessValue = tbBrightness.Value;
            int r = 0, g = 0, b = 0;
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var pixel = image.GetPixel(x, y);

                    if (pixel.R + brightnessValue > 255)
                        r = 255;
                    else if (pixel.R + brightnessValue < 0)
                        r = 0;
                    else
                        r = pixel.R + brightnessValue;

                    if (pixel.G + brightnessValue > 255)
                        g = 255;
                    else if (pixel.G + brightnessValue < 0)
                        g = 0;
                    else
                        g = pixel.G + brightnessValue;

                    if (pixel.B + brightnessValue > 255)
                        b = 255;
                    else if (pixel.B + brightnessValue < 0)
                        b = 0;
                    else
                        b = pixel.B + brightnessValue;

                    image.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pbProcessed.Image = image;
        }

        private void ProcessBlackAndWhiteImage(Image grayImage, int val)
        {
            var image = new Bitmap(grayImage ?? pbOriginal.Image);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var pixel = image.GetPixel(x, y);
                    Color color;
                    if (pixel.R >= val)
                        color = Color.FromArgb(255, 255, 255);
                    else
                        color = Color.FromArgb(0, 0, 0);
                    image.SetPixel(x, y, color);
                }
            }

            pbProcessed.Image = image;
        }

        private Image ProcessGrayImage()
        {
            var image = new Bitmap(pbOriginal.Image);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var pixel = image.GetPixel(x, y);
                    var tone = Convert.ToInt16(pixel.R * 0.299) + Convert.ToInt16(pixel.G * 0.587) + Convert.ToInt16(pixel.B * 0.114);
                    image.SetPixel(x, y, Color.FromArgb(tone, tone, tone));
                }
            }

            pbProcessed.Image = image;
            return image;
        }

        private void ProcessNegativeImage()
        {
            var image = new Bitmap(pbOriginal.Image);

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    var pixel = image.GetPixel(x, y);
                    var r = 255 - pixel.R;
                    var g = 255 - pixel.G;
                    var b = 255 - pixel.B;
                    image.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            pbProcessed.Image = image;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.gif;*.png;*.jpeg";
            dialog.Title = "Please choose your image for process";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pbOriginal.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void cbProcessType_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbBrightness.Visible = lblBrightness.Visible = cbProcessType.SelectedIndex == 3;
        }

        private void tbBrightness_ValueChanged(object sender, EventArgs e)
        {
            lblBrightness.Text = tbBrightness.Value.ToString();
            ProcessBrightnessImage();
        }
    }
}
