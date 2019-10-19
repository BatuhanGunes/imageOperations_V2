using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageOperations
{
    public partial class Form1 : Form
    {

        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //TurnOff Aplication
        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();
                pictureBox.ImageLocation = openFileDialog1.FileName;
                bmp = (Bitmap)Bitmap.FromFile(openFileDialog1.FileName);
                textBoxFileName.Text = openFileDialog1.FileName;
                labelResolution.Text = pictureBox.Height.ToString() + " X " + pictureBox.Width.ToString();

                NumericGetX.Value = 0;
                NumericGetY.Value = 0;
                NumericRed.Value = 255;
                NumericGreen.Value = 255;
                NumericBlue.Value = 255;
                textBoxHexa.Clear();
                ColorPanel.BackColor = Color.FromArgb(255,255,255);

                this.Refresh();
            }
            catch
            {
                MessageBox.Show("Please add a photo", "information");
            }
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            ColorDialog Color = new ColorDialog();
            Color.ShowDialog();
            ColorPanel.BackColor = Color.Color;

            NumericRed.Text = Convert.ToString(Color.Color.R);
            NumericGreen.Text = Convert.ToString(Color.Color.G);
            NumericBlue.Text = Convert.ToString(Color.Color.B);
            textBoxHexa.Text = Color.Color.Name;
        }

        
        private void buttonSetPiksel_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                if (!string.IsNullOrEmpty(NumericGetX.Text) && !string.IsNullOrEmpty(NumericGetY.Text))
                {
                    if (!string.IsNullOrEmpty(NumericRed.Text) && !string.IsNullOrEmpty(NumericGreen.Text) && !string.IsNullOrEmpty(NumericBlue.Text))
                    {
                        int r, g, b;
                        int x, y;

                        r = Convert.ToInt32(NumericRed.Text);
                        g = Convert.ToInt32(NumericGreen.Text);
                        b = Convert.ToInt32(NumericBlue.Text);

                        x = Convert.ToInt32(NumericGetX.Text);
                        y = Convert.ToInt32(NumericGetY.Text);

                        bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
                        ColorPanel.BackColor = Color.FromArgb(r, g, b);
                        textBoxHexa.Text = Color.FromArgb(r, g, b).Name;
                        this.Refresh();

                        MessageBox.Show("The values of the target pixels have been changed.", "information");
                    }
                }
            }
        }


        private void buttonGrayScale_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;
                        int avg = (r + g + b) / 3;
                        bmp.SetPixel(x, y, Color.FromArgb(avg, avg, avg));
                    }
                }
                xOryChange();
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }

        private void buttonBitmap_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                int rgb;
                Color c;

                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        c = bmp.GetPixel(x, y);
                        //now apply a sepia filter
                        rgb = (int)Math.Round(.299 * c.R + .587 * c.G + .114 * c.B);
                        bmp.SetPixel(x, y, Color.FromArgb(rgb, rgb, rgb));
                    }
                }
                xOryChange();
                pictureBox.Image = bmp;
                this.Refresh();
            }       
        }

        private void xOryChange()
        {
            if (bmp != null)
            {
                if (!string.IsNullOrEmpty(NumericGetX.Text) && !string.IsNullOrEmpty(NumericGetY.Text))
                {
                    int x, y;
                    x = Convert.ToInt32(NumericGetX.Text);
                    y = Convert.ToInt32(NumericGetY.Text);
                    Color color = bmp.GetPixel(x, y);

                    NumericRed.Text = Convert.ToString(color.R);
                    NumericGreen.Text = Convert.ToString(color.G);
                    NumericBlue.Text = Convert.ToString(color.B);

                    ColorPanel.BackColor = color;
                    textBoxHexa.Text = color.Name;
                }
            }

        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.Refresh();

            if (bmp != null)
            {
                NumericGetX.Text = Convert.ToString(e.X);
                NumericGetY.Text = Convert.ToString(e.Y);

                xOryChange();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                pictureBox.Image = bmp;
                xOryChange();
                this.Refresh();
            }
        }

        private void rgbChange()
        {
            if (!string.IsNullOrEmpty(NumericRed.Text) && !string.IsNullOrEmpty(NumericGreen.Text) && !string.IsNullOrEmpty(NumericBlue.Text))
            {
                int r, g, b;

                r = Convert.ToInt32(NumericRed.Text);
                g = Convert.ToInt32(NumericGreen.Text);
                b = Convert.ToInt32(NumericBlue.Text);

                ColorPanel.BackColor = Color.FromArgb(r, g, b);
                textBoxHexa.Text = Color.FromArgb(r, g, b).Name;
                this.Refresh();
            }
        }

        private void NumericGetX_ValueChanged(object sender, EventArgs e)
        {
            xOryChange();
        }

        private void NumericGetY_ValueChanged(object sender, EventArgs e)
        {
            xOryChange();
        }

        private void NumericRed_ValueChanged(object sender, EventArgs e)
        {
            rgbChange();
        }

        private void NumericGreen_ValueChanged(object sender, EventArgs e)
        {
            rgbChange();
        }

        private void NumericBlue_ValueChanged(object sender, EventArgs e)
        {
            rgbChange();
        }
    }
}
