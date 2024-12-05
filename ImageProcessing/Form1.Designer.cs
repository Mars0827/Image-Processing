namespace ImageProcessing
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelCopyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greyscalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mirrorVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lossyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossLaplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectQuickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectConvolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEHEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIP2KayDaghanNaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectHomogenityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectDifferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeEnhanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetFilterAbsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offsetFilterAntiAliasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomJitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swirlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sphereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.waterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rescalingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.countCointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dIPToolStripMenuItem,
            this.dIPToolStripMenuItem1,
            this.dIP2KayDaghanNaToolStripMenuItem,
            this.countCointsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // dIPToolStripMenuItem
            // 
            this.dIPToolStripMenuItem.Name = "dIPToolStripMenuItem";
            this.dIPToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // dIPToolStripMenuItem1
            // 
            this.dIPToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelCopyToolStripMenuItem1,
            this.greyscalingToolStripMenuItem,
            this.inversionToolStripMenuItem,
            this.mirrorHorizontalToolStripMenuItem,
            this.mirrorVerticalToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.blurToolStripMenuItem,
            this.sharpenToolStripMenuItem,
            this.embossToolStripMenuItem,
            this.smoothingToolStripMenuItem,
            this.shrinkToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.meanRemovalToolStripMenuItem,
            this.lossyToolStripMenuItem,
            this.horizOnlyToolStripMenuItem,
            this.vertOnlyToolStripMenuItem,
            this.embossLaplacianToolStripMenuItem,
            this.edgeDetectQuickToolStripMenuItem,
            this.edgeDetectConvolutionToolStripMenuItem,
            this.edgeDetectHorizontalToolStripMenuItem,
            this.edgeDetectVerticalToolStripMenuItem,
            this.hEHEToolStripMenuItem});
            this.dIPToolStripMenuItem1.Name = "dIPToolStripMenuItem1";
            this.dIPToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.dIPToolStripMenuItem1.Text = "DIP";
            // 
            // pixelCopyToolStripMenuItem1
            // 
            this.pixelCopyToolStripMenuItem1.Name = "pixelCopyToolStripMenuItem1";
            this.pixelCopyToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.pixelCopyToolStripMenuItem1.Text = "Pixel Copy";
            this.pixelCopyToolStripMenuItem1.Click += new System.EventHandler(this.pixelCopyToolStripMenuItem1_Click);
            // 
            // greyscalingToolStripMenuItem
            // 
            this.greyscalingToolStripMenuItem.Name = "greyscalingToolStripMenuItem";
            this.greyscalingToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.greyscalingToolStripMenuItem.Text = "Greyscaling";
            this.greyscalingToolStripMenuItem.Click += new System.EventHandler(this.greyscalingToolStripMenuItem_Click);
            // 
            // inversionToolStripMenuItem
            // 
            this.inversionToolStripMenuItem.Name = "inversionToolStripMenuItem";
            this.inversionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.inversionToolStripMenuItem.Text = "Inversion";
            this.inversionToolStripMenuItem.Click += new System.EventHandler(this.inversionToolStripMenuItem_Click);
            // 
            // mirrorHorizontalToolStripMenuItem
            // 
            this.mirrorHorizontalToolStripMenuItem.Name = "mirrorHorizontalToolStripMenuItem";
            this.mirrorHorizontalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mirrorHorizontalToolStripMenuItem.Text = "Mirror Horizontal";
            this.mirrorHorizontalToolStripMenuItem.Click += new System.EventHandler(this.mirrorHorizontalToolStripMenuItem_Click);
            // 
            // mirrorVerticalToolStripMenuItem
            // 
            this.mirrorVerticalToolStripMenuItem.Name = "mirrorVerticalToolStripMenuItem";
            this.mirrorVerticalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mirrorVerticalToolStripMenuItem.Text = "Mirror Vertical";
            this.mirrorVerticalToolStripMenuItem.Click += new System.EventHandler(this.mirrorVerticalToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.histogramToolStripMenuItem_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // blurToolStripMenuItem
            // 
            this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
            this.blurToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.blurToolStripMenuItem.Text = "Blur";
            this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
            // 
            // sharpenToolStripMenuItem
            // 
            this.sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            this.sharpenToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sharpenToolStripMenuItem.Text = "Sharpen";
            this.sharpenToolStripMenuItem.Click += new System.EventHandler(this.sharpenToolStripMenuItem_Click);
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.embossToolStripMenuItem.Text = "Emboss";
            this.embossToolStripMenuItem.Click += new System.EventHandler(this.embossToolStripMenuItem_Click);
            // 
            // smoothingToolStripMenuItem
            // 
            this.smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            this.smoothingToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.smoothingToolStripMenuItem.Text = "Smoothing";
            this.smoothingToolStripMenuItem.Click += new System.EventHandler(this.smoothingToolStripMenuItem_Click);
            // 
            // shrinkToolStripMenuItem
            // 
            this.shrinkToolStripMenuItem.Name = "shrinkToolStripMenuItem";
            this.shrinkToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.shrinkToolStripMenuItem.Text = "Shrink";
            this.shrinkToolStripMenuItem.Click += new System.EventHandler(this.shrinkToolStripMenuItem_Click);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            // 
            // meanRemovalToolStripMenuItem
            // 
            this.meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            this.meanRemovalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.meanRemovalToolStripMenuItem.Text = "Mean Removal";
            this.meanRemovalToolStripMenuItem.Click += new System.EventHandler(this.meanRemovalToolStripMenuItem_Click);
            // 
            // lossyToolStripMenuItem
            // 
            this.lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            this.lossyToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.lossyToolStripMenuItem.Text = "Lossy";
            this.lossyToolStripMenuItem.Click += new System.EventHandler(this.lossyToolStripMenuItem_Click);
            // 
            // horizOnlyToolStripMenuItem
            // 
            this.horizOnlyToolStripMenuItem.Name = "horizOnlyToolStripMenuItem";
            this.horizOnlyToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.horizOnlyToolStripMenuItem.Text = "Horiz Only";
            this.horizOnlyToolStripMenuItem.Click += new System.EventHandler(this.horizOnlyToolStripMenuItem_Click);
            // 
            // vertOnlyToolStripMenuItem
            // 
            this.vertOnlyToolStripMenuItem.Name = "vertOnlyToolStripMenuItem";
            this.vertOnlyToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.vertOnlyToolStripMenuItem.Text = "Vert Only";
            this.vertOnlyToolStripMenuItem.Click += new System.EventHandler(this.vertOnlyToolStripMenuItem_Click);
            // 
            // embossLaplacianToolStripMenuItem
            // 
            this.embossLaplacianToolStripMenuItem.Name = "embossLaplacianToolStripMenuItem";
            this.embossLaplacianToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.embossLaplacianToolStripMenuItem.Text = "EmbossLaplacian";
            this.embossLaplacianToolStripMenuItem.Click += new System.EventHandler(this.embossLaplacianToolStripMenuItem_Click);
            // 
            // edgeDetectQuickToolStripMenuItem
            // 
            this.edgeDetectQuickToolStripMenuItem.Name = "edgeDetectQuickToolStripMenuItem";
            this.edgeDetectQuickToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.edgeDetectQuickToolStripMenuItem.Text = "EdgeDetectQuick";
            this.edgeDetectQuickToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectQuickToolStripMenuItem_Click);
            // 
            // edgeDetectConvolutionToolStripMenuItem
            // 
            this.edgeDetectConvolutionToolStripMenuItem.Name = "edgeDetectConvolutionToolStripMenuItem";
            this.edgeDetectConvolutionToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.edgeDetectConvolutionToolStripMenuItem.Text = "EdgeDetectConvolution";
            this.edgeDetectConvolutionToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectConvolutionToolStripMenuItem_Click);
            // 
            // edgeDetectHorizontalToolStripMenuItem
            // 
            this.edgeDetectHorizontalToolStripMenuItem.Name = "edgeDetectHorizontalToolStripMenuItem";
            this.edgeDetectHorizontalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.edgeDetectHorizontalToolStripMenuItem.Text = "EdgeDetectHorizontal";
            this.edgeDetectHorizontalToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectHorizontalToolStripMenuItem_Click);
            // 
            // edgeDetectVerticalToolStripMenuItem
            // 
            this.edgeDetectVerticalToolStripMenuItem.Name = "edgeDetectVerticalToolStripMenuItem";
            this.edgeDetectVerticalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.edgeDetectVerticalToolStripMenuItem.Text = "EdgeDetectVertical";
            this.edgeDetectVerticalToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectVerticalToolStripMenuItem_Click);
            // 
            // hEHEToolStripMenuItem
            // 
            this.hEHEToolStripMenuItem.Name = "hEHEToolStripMenuItem";
            this.hEHEToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.hEHEToolStripMenuItem.Text = "HEHE";
            this.hEHEToolStripMenuItem.Click += new System.EventHandler(this.hEHEToolStripMenuItem_Click);
            // 
            // dIP2KayDaghanNaToolStripMenuItem
            // 
            this.dIP2KayDaghanNaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edgeDetectHomogenityToolStripMenuItem,
            this.edgeDetectDifferenceToolStripMenuItem,
            this.edgeEnhanceToolStripMenuItem,
            this.resizeToolStripMenuItem,
            this.offsetFilterAbsToolStripMenuItem,
            this.offsetFilterToolStripMenuItem,
            this.offsetFilterAntiAliasToolStripMenuItem,
            this.flipToolStripMenuItem,
            this.randomJitterToolStripMenuItem,
            this.swirlToolStripMenuItem,
            this.sphereToolStripMenuItem,
            this.timeWrapToolStripMenuItem,
            this.moireToolStripMenuItem,
            this.waterToolStripMenuItem,
            this.pixelateToolStripMenuItem});
            this.dIP2KayDaghanNaToolStripMenuItem.Name = "dIP2KayDaghanNaToolStripMenuItem";
            this.dIP2KayDaghanNaToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.dIP2KayDaghanNaToolStripMenuItem.Text = "DIP2 kay daghan na";
            // 
            // edgeDetectHomogenityToolStripMenuItem
            // 
            this.edgeDetectHomogenityToolStripMenuItem.Name = "edgeDetectHomogenityToolStripMenuItem";
            this.edgeDetectHomogenityToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.edgeDetectHomogenityToolStripMenuItem.Text = "EdgeDetectHomogenity";
            this.edgeDetectHomogenityToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectHomogenityToolStripMenuItem_Click);
            // 
            // edgeDetectDifferenceToolStripMenuItem
            // 
            this.edgeDetectDifferenceToolStripMenuItem.Name = "edgeDetectDifferenceToolStripMenuItem";
            this.edgeDetectDifferenceToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.edgeDetectDifferenceToolStripMenuItem.Text = "EdgeDetectDifference";
            this.edgeDetectDifferenceToolStripMenuItem.Click += new System.EventHandler(this.edgeDetectDifferenceToolStripMenuItem_Click);
            // 
            // edgeEnhanceToolStripMenuItem
            // 
            this.edgeEnhanceToolStripMenuItem.Name = "edgeEnhanceToolStripMenuItem";
            this.edgeEnhanceToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.edgeEnhanceToolStripMenuItem.Text = "EdgeEnhance";
            this.edgeEnhanceToolStripMenuItem.Click += new System.EventHandler(this.edgeEnhanceToolStripMenuItem_Click);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // offsetFilterAbsToolStripMenuItem
            // 
            this.offsetFilterAbsToolStripMenuItem.Name = "offsetFilterAbsToolStripMenuItem";
            this.offsetFilterAbsToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.offsetFilterAbsToolStripMenuItem.Text = "OffsetFilterAbs";
            // 
            // offsetFilterToolStripMenuItem
            // 
            this.offsetFilterToolStripMenuItem.Name = "offsetFilterToolStripMenuItem";
            this.offsetFilterToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.offsetFilterToolStripMenuItem.Text = "OffsetFilter";
            this.offsetFilterToolStripMenuItem.Click += new System.EventHandler(this.offsetFilterToolStripMenuItem_Click);
            // 
            // offsetFilterAntiAliasToolStripMenuItem
            // 
            this.offsetFilterAntiAliasToolStripMenuItem.Name = "offsetFilterAntiAliasToolStripMenuItem";
            this.offsetFilterAntiAliasToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.offsetFilterAntiAliasToolStripMenuItem.Text = "OffsetFilterAntiAlias";
            // 
            // flipToolStripMenuItem
            // 
            this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            this.flipToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.flipToolStripMenuItem.Text = "Flip";
            this.flipToolStripMenuItem.Click += new System.EventHandler(this.flipToolStripMenuItem_Click);
            // 
            // randomJitterToolStripMenuItem
            // 
            this.randomJitterToolStripMenuItem.Name = "randomJitterToolStripMenuItem";
            this.randomJitterToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.randomJitterToolStripMenuItem.Text = "RandomJitter";
            this.randomJitterToolStripMenuItem.Click += new System.EventHandler(this.randomJitterToolStripMenuItem_Click);
            // 
            // swirlToolStripMenuItem
            // 
            this.swirlToolStripMenuItem.Name = "swirlToolStripMenuItem";
            this.swirlToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.swirlToolStripMenuItem.Text = "Swirl";
            this.swirlToolStripMenuItem.Click += new System.EventHandler(this.swirlToolStripMenuItem_Click);
            // 
            // sphereToolStripMenuItem
            // 
            this.sphereToolStripMenuItem.Name = "sphereToolStripMenuItem";
            this.sphereToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.sphereToolStripMenuItem.Text = "Sphere";
            this.sphereToolStripMenuItem.Click += new System.EventHandler(this.sphereToolStripMenuItem_Click);
            // 
            // timeWrapToolStripMenuItem
            // 
            this.timeWrapToolStripMenuItem.Name = "timeWrapToolStripMenuItem";
            this.timeWrapToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.timeWrapToolStripMenuItem.Text = "TimeWrap";
            this.timeWrapToolStripMenuItem.Click += new System.EventHandler(this.timeWrapToolStripMenuItem_Click);
            // 
            // moireToolStripMenuItem
            // 
            this.moireToolStripMenuItem.Name = "moireToolStripMenuItem";
            this.moireToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.moireToolStripMenuItem.Text = "Moire";
            this.moireToolStripMenuItem.Click += new System.EventHandler(this.moireToolStripMenuItem_Click);
            // 
            // waterToolStripMenuItem
            // 
            this.waterToolStripMenuItem.Name = "waterToolStripMenuItem";
            this.waterToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.waterToolStripMenuItem.Text = "Water";
            this.waterToolStripMenuItem.Click += new System.EventHandler(this.waterToolStripMenuItem_Click);
            // 
            // pixelateToolStripMenuItem
            // 
            this.pixelateToolStripMenuItem.Name = "pixelateToolStripMenuItem";
            this.pixelateToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.pixelateToolStripMenuItem.Text = "Pixelate";
            this.pixelateToolStripMenuItem.Click += new System.EventHandler(this.pixelateToolStripMenuItem_Click);
            // 
            // pixelCopyToolStripMenuItem
            // 
            this.pixelCopyToolStripMenuItem.Name = "pixelCopyToolStripMenuItem";
            this.pixelCopyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pixelCopyToolStripMenuItem.Text = "pixel copy";
            // 
            // rescalingToolStripMenuItem
            // 
            this.rescalingToolStripMenuItem.Name = "rescalingToolStripMenuItem";
            this.rescalingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(481, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(590, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(481, 407);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // countCointsToolStripMenuItem
            // 
            this.countCointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToolStripMenuItem});
            this.countCointsToolStripMenuItem.Name = "countCointsToolStripMenuItem";
            this.countCointsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.countCointsToolStripMenuItem.Text = "Count Coints";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.goToolStripMenuItem.Text = "Go";
            this.goToolStripMenuItem.Click += new System.EventHandler(this.goToolStripMenuItem_Click);
            // 
            // ImageProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ImageProcessor";
            this.Text = "ImageProcessor";
            this.Load += new System.EventHandler(this.ImageProcessor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rescalingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pixelCopyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greyscalingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mirrorVerticalToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanRemovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lossyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vertOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossLaplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectQuickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectConvolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIP2KayDaghanNaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectHomogenityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectDifferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeEnhanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offsetFilterAbsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offsetFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offsetFilterAntiAliasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomJitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swirlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sphereToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem waterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEHEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countCointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
    }
}
