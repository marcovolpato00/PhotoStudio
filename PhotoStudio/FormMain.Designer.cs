namespace PhotoStudio
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esportaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.strumentiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.negativoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scalaDiGrigiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.luminositàToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanciamentoDelBiancoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.imgSizeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.locationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(980, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaToolStripMenuItem,
            this.esportaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importaToolStripMenuItem
            // 
            this.importaToolStripMenuItem.Name = "importaToolStripMenuItem";
            this.importaToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.importaToolStripMenuItem.Text = "Importa";
            this.importaToolStripMenuItem.Click += new System.EventHandler(this.ImportClicked);
            // 
            // esportaToolStripMenuItem
            // 
            this.esportaToolStripMenuItem.Name = "esportaToolStripMenuItem";
            this.esportaToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.esportaToolStripMenuItem.Text = "Esporta";
            this.esportaToolStripMenuItem.Click += new System.EventHandler(this.ExportClicked);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Immagini (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            this.openFileDialog.Title = "Apri immagine";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strumentiToolStripMenuItem1,
            this.modificaToolStripMenuItem1});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(143, 52);
            // 
            // strumentiToolStripMenuItem1
            // 
            this.strumentiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negativoToolStripMenuItem1,
            this.scalaDiGrigiToolStripMenuItem1});
            this.strumentiToolStripMenuItem1.Name = "strumentiToolStripMenuItem1";
            this.strumentiToolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.strumentiToolStripMenuItem1.Text = "Strumenti";
            // 
            // negativoToolStripMenuItem1
            // 
            this.negativoToolStripMenuItem1.Name = "negativoToolStripMenuItem1";
            this.negativoToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.negativoToolStripMenuItem1.Text = "Negativo";
            // 
            // scalaDiGrigiToolStripMenuItem1
            // 
            this.scalaDiGrigiToolStripMenuItem1.Name = "scalaDiGrigiToolStripMenuItem1";
            this.scalaDiGrigiToolStripMenuItem1.Size = new System.Drawing.Size(171, 26);
            this.scalaDiGrigiToolStripMenuItem1.Text = "Scala di grigi";
            // 
            // modificaToolStripMenuItem1
            // 
            this.modificaToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.luminositàToolStripMenuItem1,
            this.contrastoToolStripMenuItem1,
            this.bilanciamentoDelBiancoToolStripMenuItem1});
            this.modificaToolStripMenuItem1.Name = "modificaToolStripMenuItem1";
            this.modificaToolStripMenuItem1.Size = new System.Drawing.Size(142, 24);
            this.modificaToolStripMenuItem1.Text = "Modifica";
            // 
            // luminositàToolStripMenuItem1
            // 
            this.luminositàToolStripMenuItem1.Name = "luminositàToolStripMenuItem1";
            this.luminositàToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.luminositàToolStripMenuItem1.Text = "Luminosità";
            // 
            // contrastoToolStripMenuItem1
            // 
            this.contrastoToolStripMenuItem1.Name = "contrastoToolStripMenuItem1";
            this.contrastoToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.contrastoToolStripMenuItem1.Text = "Contrasto";
            // 
            // bilanciamentoDelBiancoToolStripMenuItem1
            // 
            this.bilanciamentoDelBiancoToolStripMenuItem1.Name = "bilanciamentoDelBiancoToolStripMenuItem1";
            this.bilanciamentoDelBiancoToolStripMenuItem1.Size = new System.Drawing.Size(253, 26);
            this.bilanciamentoDelBiancoToolStripMenuItem1.Text = "Bilanciamento del bianco";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imgSizeLabel,
            this.locationLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 679);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.statusStrip.Size = new System.Drawing.Size(980, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // imgSizeLabel
            // 
            this.imgSizeLabel.Name = "imgSizeLabel";
            this.imgSizeLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // locationLabel
            // 
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Immagini (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(980, 701);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhotoStudio";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem importaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem esportaToolStripMenuItem;
        public System.Windows.Forms.OpenFileDialog openFileDialog;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        public System.Windows.Forms.ToolStripMenuItem strumentiToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem negativoToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem scalaDiGrigiToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem luminositàToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem contrastoToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem bilanciamentoDelBiancoToolStripMenuItem1;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel imgSizeLabel;
        public System.Windows.Forms.ToolStripStatusLabel locationLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

