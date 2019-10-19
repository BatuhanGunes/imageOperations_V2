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
        }

        private void buttonSetPiksel_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetPiksel_Click(object sender, EventArgs e)
        {

        }

        private void buttonGrayScale_Click(object sender, EventArgs e)
        {

        }

        private void buttonBitmap_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
