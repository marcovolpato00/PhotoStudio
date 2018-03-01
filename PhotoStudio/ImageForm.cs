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
        public Image backupImage;

        FormMain main;

        Func<Image, Bitmap> negative;
        Func<Image, Bitmap> greyScale;

        public ImageForm(Image img, FormMain main)
        {
            InitializeComponent();
            this.img = img;
            this.main = main;
            backupImage = img;

            greyScale = ImageEffects.Grayscale;
            negative = ImageEffects.Negative;
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
            pictureBox.Image = greyScale(img);
        }

        private void ApplyNegative(object sender, EventArgs e)
        {
            img = pictureBox.Image;
            pictureBox.Image = negative(img);
        }

        private void contrastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Image, int, Bitmap> effect = ImageEffects.Contrast;
            EffectControlForm control = new EffectControlForm(this, "Contrasto", effect, 0, 0, 100);
            control.ShowDialog();
        }

        private void luminositàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Image, int, Bitmap> effect = ImageEffects.Brightness;
            EffectControlForm control = new EffectControlForm(this, "Luminosità", effect, 50, 0, 100);
            control.ShowDialog();
        }

        private void bilanciamentoDelBiancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Func<Image, int, Bitmap> effect = ImageEffects.Contrast;
            EffectControlForm control = new EffectControlForm(this, "Bilanciamento del bianco", effect, 50, 0, 100);
            control.ShowDialog();
        }

        #endregion

        // rotazione senso antiorario
        private void RotateCCW(object sender, EventArgs e)
        {
            int height = Height;
            int width = Width;
            Height = width;
            Width = height;
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        // rotazione senso orario
        private void RotateCW(object sender, EventArgs e)
        {
            int height = Height;
            int width = Width;
            Height = width;
            Width = height;
            pictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }
    }
}
