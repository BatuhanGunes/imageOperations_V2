﻿using System;
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
        private Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
        }


        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);    //TurnOff Aplication
        }

        private void ButtonUploadImage_Click(object sender, EventArgs e)
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
                ColorPanel.BackColor = Color.FromArgb(255, 255, 255);

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


        private void ButtonSetPiksel_Click(object sender, EventArgs e)
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

        private void ButtonGrayScale_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                // bmp refresh
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);

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
                XOryChange();
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }

        private void ButtonBitmap_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                // bmp refresh
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                int treshold = Convert.ToInt32(numericTreshold.Text);


                for (int y = 0; y < bmp.Height; y++)
                {
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        Color c = bmp.GetPixel(x, y);

                        int r = c.R;
                        int g = c.G;
                        int b = c.B;
                        int avg = (r + g + b) / 3;

                        if (avg >= treshold)
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                        }
                        else
                        {
                            bmp.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                        }
                    }
                }
                XOryChange();
                pictureBox.Image = bmp;
                this.Refresh();
            }
        }

        private void XOryChange()
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

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.Refresh();

            if (bmp != null)
            {
                NumericGetX.Text = Convert.ToString(e.X);
                NumericGetY.Text = Convert.ToString(e.Y);

                XOryChange();
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp = (Bitmap)Bitmap.FromFile(textBoxFileName.Text);
                pictureBox.Image = bmp;
                XOryChange();
                this.Refresh();
            }
        }

        private void RgbChange()
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
            XOryChange();
        }

        private void NumericGetY_ValueChanged(object sender, EventArgs e)
        {
            XOryChange();
        }

        private void NumericRed_ValueChanged(object sender, EventArgs e)
        {
            RgbChange();
        }

        private void NumericGreen_ValueChanged(object sender, EventArgs e)
        {
            RgbChange();
        }

        private void NumericBlue_ValueChanged(object sender, EventArgs e)
        {
            RgbChange();
        }
    }
}