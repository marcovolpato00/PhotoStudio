namespace PhotoStudio
{
    partial class ImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.strumentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scalaDiGrigiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.luminositàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanciamentoDelBiancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ripristinaImmagineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(844, 620);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strumentiToolStripMenuItem,
            this.modificaToolStripMenuItem,
            this.ripristinaImmagineToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(212, 104);
            // 
            // strumentiToolStripMenuItem
            // 
            this.strumentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scalaDiGrigiToolStripMenuItem,
            this.negativoToolStripMenuItem});
            this.strumentiToolStripMenuItem.Name = "strumentiToolStripMenuItem";
            this.strumentiToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.strumentiToolStripMenuItem.Text = "Effetti";
            // 
            // scalaDiGrigiToolStripMenuItem
            // 
            this.scalaDiGrigiToolStripMenuItem.Name = "scalaDiGrigiToolStripMenuItem";
            this.scalaDiGrigiToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.scalaDiGrigiToolStripMenuItem.Text = "Scala di grigi";
            this.scalaDiGrigiToolStripMenuItem.Click += new System.EventHandler(this.ApplyGreyscale);
            // 
            // negativoToolStripMenuItem
            // 
            this.negativoToolStripMenuItem.Name = "negativoToolStripMenuItem";
            this.negativoToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.negativoToolStripMenuItem.Text = "Negativo";
            this.negativoToolStripMenuItem.Click += new System.EventHandler(this.ApplyNegative);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.luminositàToolStripMenuItem,
            this.contrastoToolStripMenuItem,
            this.bilanciamentoDelBiancoToolStripMenuItem});
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.modificaToolStripMenuItem.Text = "Modifica";
            // 
            // luminositàToolStripMenuItem
            // 
            this.luminositàToolStripMenuItem.Name = "luminositàToolStripMenuItem";
            this.luminositàToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.luminositàToolStripMenuItem.Text = "Luminosità";
            // 
            // contrastoToolStripMenuItem
            // 
            this.contrastoToolStripMenuItem.Name = "contrastoToolStripMenuItem";
            this.contrastoToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.contrastoToolStripMenuItem.Text = "Contrasto";
            this.contrastoToolStripMenuItem.Click += new System.EventHandler(this.contrastoToolStripMenuItem_Click);
            // 
            // bilanciamentoDelBiancoToolStripMenuItem
            // 
            this.bilanciamentoDelBiancoToolStripMenuItem.Name = "bilanciamentoDelBiancoToolStripMenuItem";
            this.bilanciamentoDelBiancoToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.bilanciamentoDelBiancoToolStripMenuItem.Text = "Bilanciamento del bianco";
            // 
            // ripristinaImmagineToolStripMenuItem
            // 
            this.ripristinaImmagineToolStripMenuItem.Name = "ripristinaImmagineToolStripMenuItem";
            this.ripristinaImmagineToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.ripristinaImmagineToolStripMenuItem.Text = "Ripristina immagine";
            this.ripristinaImmagineToolStripMenuItem.Click += new System.EventHandler(this.ResetImage);
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 620);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ImageForm";
            this.Activated += new System.EventHandler(this.ImageForm_Activated);
            this.Deactivate += new System.EventHandler(this.ImageForm_Deactivate);
            this.Load += new System.EventHandler(this.ImageForm_Load);
            this.ResizeBegin += new System.EventHandler(this.ResizeForm);
            this.ResizeEnd += new System.EventHandler(this.ResizeForm);
            this.Resize += new System.EventHandler(this.ResizeForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem strumentiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem luminositàToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem contrastoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem bilanciamentoDelBiancoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem negativoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem scalaDiGrigiToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem ripristinaImmagineToolStripMenuItem;
    }
}