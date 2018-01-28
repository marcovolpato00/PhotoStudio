using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio
{
    public partial class ImageForm : Form
    {
        public string imgName;
        public Image img;

        Image backupImage;
        FormMain main;

        public ImageForm(Image img, FormMain main)
        {
            InitializeComponent();
            this.img = img;
            this.main = main;
            backupImage = img;
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            Width = img.Width + 16;
            Height = img.Height + 39;
            imgName = img.Tag.ToString();
            Text = imgName;
            pictureBox.Image = img;
        }

        private void ResizeForm(object sender, EventArgs e)
        {
            if (img != null)
            {
                Height = GetScaledHeight();
            }
        }

        private int GetScaledHeight()
        {
            int height = (img.Height * Width) / img.Width;
            return height;
        }

        private void ImageForm_Activated(object sender, EventArgs e)
        {
            main.imgSizeLabel.Text = img.Width.ToString() + " x " + img.Height.ToString();
        }

        private void ImageForm_Deactivate(object sender, EventArgs e)
        {
            main.imgSizeLabel.Text = "";
        }

        #region Effetti immagine

        private void ResetImage(object sender, EventArgs e)
        {
            img = pictureBox.Image;
            pictureBox.Image = backupImage;
        }

        private void ApplyGreyscale(object sender, EventArgs e)
        {
            img = pictureBox.Image;
            pictureBox.Image = ImageEffects.Grayscale(img);
        }

        private void ApplyNegative(object sender, EventArgs e)
        {
            img = pictureBox.Image;
            pictureBox.Image = ImageEffects.Negative(img);
        }

        #endregion

        private void contrastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EffectControlForm control = new EffectControlForm(this, "Contrasto", 50, 0, 100);
            control.ShowDialog();
        }
    }
}
