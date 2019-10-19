# imageOperations_V2

* get piksel, set piksel, bitmap and gray scale operations with c#


### Operations that can be done in the application

- Image upload
- See picture resolution
- get color value with piksel
- set color value with piksel
- get piksel valur with mouse move
- set image gray scale
- set image bitmap
- set color with color palet

### Screenshots
coming soon
![Screenshot]()

### code
coming soon
```javascript
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

      
    }
```
