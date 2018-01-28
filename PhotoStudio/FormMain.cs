using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoStudio
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }

        private void ImportClicked(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadImage(openFileDialog.FileName);
            }
        }

        private void ExportClicked(object sender, EventArgs e)
        {
            if (GetActiveForm() != null)
            {
                ImageForm form = GetActiveForm();
                saveFileDialog.FileName = form.imgName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    form.pictureBox.Image.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Nessuna immagine da esportare.");
            }
        }

        private void LoadImage(string path)
        {
            Image img = Image.FromFile(path);
            img.Tag = Path.GetFileName(path);

            ImageForm imgForm = new ImageForm(img, this);
            imgForm.MdiParent = this;
            imgForm.Show();
        }

        private ImageForm GetActiveForm()
        {
            ImageForm form = (ImageForm)ActiveMdiChild;
            return form;
        }
    }
}
