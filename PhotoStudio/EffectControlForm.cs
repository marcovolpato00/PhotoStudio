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
    public partial class EffectControlForm : Form
    {
        ImageForm form;
        string effectName;
        int defaultValue;

        public EffectControlForm(ImageForm form, string effectName, int defaultValue, int minValue, int maxValue)
        {
            InitializeComponent();

            this.form = form;
            this.effectName = effectName;
            this.defaultValue = defaultValue;

            Text = effectName;

            labelValue.Text = defaultValue.ToString();

            trackBar.Minimum = minValue;
            trackBar.Maximum = maxValue;
            trackBar.Value = defaultValue;
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            labelValue.Text = trackBar.Value.ToString();
        }

        private void trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            ApplyEffect(trackBar.Value);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetValue();
        }

        private void ApplyEffect(int level)
        {
            form.pictureBox.Image = ImageEffects.Contrast(form.pictureBox.Image, level);
        }

        private void ResetValue()
        {
            trackBar.Value = defaultValue;
            labelValue.Text = defaultValue.ToString();
        }
    }
}
