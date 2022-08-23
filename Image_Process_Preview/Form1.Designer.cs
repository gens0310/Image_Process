namespace Image_Process_Preview
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form 디자이너에서 생성한 코드
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sameImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inversionImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackWhiteMeanValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackWhiteMiddleValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometricToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sharpeningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geometricToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updownMirroringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftrightMirroringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expansionBackwardingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reductionBackwardingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomAngleRotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endInSearchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equalizingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbinIMG = new System.Windows.Forms.PictureBox();
            this.pboutIMG = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboutIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelPointToolStripMenuItem,
            this.geometricToolStripMenuItem,
            this.geometricToolStripMenuItem1,
            this.histogramToolStripMenuItem,
            this.etcToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // pixelPointToolStripMenuItem
            // 
            this.pixelPointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sameImageToolStripMenuItem,
            this.inversionImageToolStripMenuItem,
            this.brightnessControlToolStripMenuItem,
            this.blackWhiteMeanValueToolStripMenuItem,
            this.blackWhiteMiddleValueToolStripMenuItem});
            this.pixelPointToolStripMenuItem.Name = "pixelPointToolStripMenuItem";
            this.pixelPointToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.pixelPointToolStripMenuItem.Text = "Pixel Point";
            // 
            // sameImageToolStripMenuItem
            // 
            this.sameImageToolStripMenuItem.Name = "sameImageToolStripMenuItem";
            this.sameImageToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.sameImageToolStripMenuItem.Text = "Same Image";
            this.sameImageToolStripMenuItem.Click += new System.EventHandler(this.sameImageToolStripMenuItem_Click);
            // 
            // inversionImageToolStripMenuItem
            // 
            this.inversionImageToolStripMenuItem.Name = "inversionImageToolStripMenuItem";
            this.inversionImageToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.inversionImageToolStripMenuItem.Text = "Inversion Image";
            this.inversionImageToolStripMenuItem.Click += new System.EventHandler(this.inversionImageToolStripMenuItem_Click);
            // 
            // brightnessControlToolStripMenuItem
            // 
            this.brightnessControlToolStripMenuItem.Name = "brightnessControlToolStripMenuItem";
            this.brightnessControlToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.brightnessControlToolStripMenuItem.Text = "Brightness Control";
            this.brightnessControlToolStripMenuItem.Click += new System.EventHandler(this.brightnessControlToolStripMenuItem_Click);
            // 
            // blackWhiteMeanValueToolStripMenuItem
            // 
            this.blackWhiteMeanValueToolStripMenuItem.Name = "blackWhiteMeanValueToolStripMenuItem";
            this.blackWhiteMeanValueToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.blackWhiteMeanValueToolStripMenuItem.Text = "Black-white(Mean Value)";
            this.blackWhiteMeanValueToolStripMenuItem.Click += new System.EventHandler(this.blackWhiteMeanValueToolStripMenuItem_Click);
            // 
            // blackWhiteMiddleValueToolStripMenuItem
            // 
            this.blackWhiteMiddleValueToolStripMenuItem.Name = "blackWhiteMiddleValueToolStripMenuItem";
            this.blackWhiteMiddleValueToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.blackWhiteMiddleValueToolStripMenuItem.Text = "Black-white(Middle Value)";
            this.blackWhiteMiddleValueToolStripMenuItem.Click += new System.EventHandler(this.blackWhiteMiddleValueToolStripMenuItem_Click);
            // 
            // geometricToolStripMenuItem
            // 
            this.geometricToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurringToolStripMenuItem,
            this.sharpeningToolStripMenuItem,
            this.embossingToolStripMenuItem});
            this.geometricToolStripMenuItem.Name = "geometricToolStripMenuItem";
            this.geometricToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.geometricToolStripMenuItem.Text = "Pixel Area";
            // 
            // blurringToolStripMenuItem
            // 
            this.blurringToolStripMenuItem.Name = "blurringToolStripMenuItem";
            this.blurringToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.blurringToolStripMenuItem.Text = "Blurring(Gaussian)";
            this.blurringToolStripMenuItem.Click += new System.EventHandler(this.blurringToolStripMenuItem_Click);
            // 
            // sharpeningToolStripMenuItem
            // 
            this.sharpeningToolStripMenuItem.Name = "sharpeningToolStripMenuItem";
            this.sharpeningToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.sharpeningToolStripMenuItem.Text = "Sharpening";
            this.sharpeningToolStripMenuItem.Click += new System.EventHandler(this.sharpeningToolStripMenuItem_Click);
            // 
            // embossingToolStripMenuItem
            // 
            this.embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            this.embossingToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.embossingToolStripMenuItem.Text = "Embossing";
            this.embossingToolStripMenuItem.Click += new System.EventHandler(this.embossingToolStripMenuItem_Click);
            // 
            // geometricToolStripMenuItem1
            // 
            this.geometricToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updownMirroringToolStripMenuItem,
            this.leftrightMirroringToolStripMenuItem,
            this.expansionBackwardingToolStripMenuItem,
            this.reductionBackwardingToolStripMenuItem,
            this.randomAngleRotationToolStripMenuItem,
            this.moveLocationToolStripMenuItem});
            this.geometricToolStripMenuItem1.Name = "geometricToolStripMenuItem1";
            this.geometricToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.geometricToolStripMenuItem1.Text = "Geometric";
            // 
            // updownMirroringToolStripMenuItem
            // 
            this.updownMirroringToolStripMenuItem.Name = "updownMirroringToolStripMenuItem";
            this.updownMirroringToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.updownMirroringToolStripMenuItem.Text = "Up-down Mirroring";
            this.updownMirroringToolStripMenuItem.Click += new System.EventHandler(this.updownMirroringToolStripMenuItem_Click);
            // 
            // leftrightMirroringToolStripMenuItem
            // 
            this.leftrightMirroringToolStripMenuItem.Name = "leftrightMirroringToolStripMenuItem";
            this.leftrightMirroringToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.leftrightMirroringToolStripMenuItem.Text = "Left-right Mirroring";
            this.leftrightMirroringToolStripMenuItem.Click += new System.EventHandler(this.leftrightMirroringToolStripMenuItem_Click);
            // 
            // expansionBackwardingToolStripMenuItem
            // 
            this.expansionBackwardingToolStripMenuItem.Name = "expansionBackwardingToolStripMenuItem";
            this.expansionBackwardingToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.expansionBackwardingToolStripMenuItem.Text = "Expansion(Backwarding)";
            this.expansionBackwardingToolStripMenuItem.Click += new System.EventHandler(this.expansionBackwardingToolStripMenuItem_Click);
            // 
            // reductionBackwardingToolStripMenuItem
            // 
            this.reductionBackwardingToolStripMenuItem.Name = "reductionBackwardingToolStripMenuItem";
            this.reductionBackwardingToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.reductionBackwardingToolStripMenuItem.Text = "Reduction(Backwarding)";
            this.reductionBackwardingToolStripMenuItem.Click += new System.EventHandler(this.reductionBackwardingToolStripMenuItem_Click);
            // 
            // randomAngleRotationToolStripMenuItem
            // 
            this.randomAngleRotationToolStripMenuItem.Name = "randomAngleRotationToolStripMenuItem";
            this.randomAngleRotationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.randomAngleRotationToolStripMenuItem.Text = "Random Angle Rotation";
            this.randomAngleRotationToolStripMenuItem.Click += new System.EventHandler(this.randomAngleRotationToolStripMenuItem_Click);
            // 
            // moveLocationToolStripMenuItem
            // 
            this.moveLocationToolStripMenuItem.Name = "moveLocationToolStripMenuItem";
            this.moveLocationToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.moveLocationToolStripMenuItem.Text = "Move Location";
            this.moveLocationToolStripMenuItem.Click += new System.EventHandler(this.moveLocationToolStripMenuItem_Click);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stretchingToolStripMenuItem,
            this.endInSearchingToolStripMenuItem,
            this.equalizingToolStripMenuItem});
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.histogramToolStripMenuItem.Text = "Histogram";
            // 
            // stretchingToolStripMenuItem
            // 
            this.stretchingToolStripMenuItem.Name = "stretchingToolStripMenuItem";
            this.stretchingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.stretchingToolStripMenuItem.Text = "Stretching";
            this.stretchingToolStripMenuItem.Click += new System.EventHandler(this.stretchingToolStripMenuItem_Click);
            // 
            // endInSearchingToolStripMenuItem
            // 
            this.endInSearchingToolStripMenuItem.Name = "endInSearchingToolStripMenuItem";
            this.endInSearchingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.endInSearchingToolStripMenuItem.Text = "End-In Searching";
            this.endInSearchingToolStripMenuItem.Click += new System.EventHandler(this.endInSearchingToolStripMenuItem_Click);
            // 
            // equalizingToolStripMenuItem
            // 
            this.equalizingToolStripMenuItem.Name = "equalizingToolStripMenuItem";
            this.equalizingToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.equalizingToolStripMenuItem.Text = "Equalizing";
            this.equalizingToolStripMenuItem.Click += new System.EventHandler(this.equalizingToolStripMenuItem_Click);
            // 
            // etcToolStripMenuItem
            // 
            this.etcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gammaToolStripMenuItem,
            this.cAPToolStripMenuItem,
            this.cUPToolStripMenuItem});
            this.etcToolStripMenuItem.Name = "etcToolStripMenuItem";
            this.etcToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.etcToolStripMenuItem.Text = "etc.";
            // 
            // gammaToolStripMenuItem
            // 
            this.gammaToolStripMenuItem.Name = "gammaToolStripMenuItem";
            this.gammaToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.gammaToolStripMenuItem.Text = "Gamma";
            this.gammaToolStripMenuItem.Click += new System.EventHandler(this.gammaToolStripMenuItem_Click);
            // 
            // cAPToolStripMenuItem
            // 
            this.cAPToolStripMenuItem.Name = "cAPToolStripMenuItem";
            this.cAPToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cAPToolStripMenuItem.Text = "CAP";
            this.cAPToolStripMenuItem.Click += new System.EventHandler(this.cAPToolStripMenuItem_Click);
            // 
            // cUPToolStripMenuItem
            // 
            this.cUPToolStripMenuItem.Name = "cUPToolStripMenuItem";
            this.cUPToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cUPToolStripMenuItem.Text = "CUP";
            this.cUPToolStripMenuItem.Click += new System.EventHandler(this.cUPToolStripMenuItem_Click);
            // 
            // pbinIMG
            // 
            this.pbinIMG.BackColor = System.Drawing.SystemColors.Control;
            this.pbinIMG.Location = new System.Drawing.Point(0, 27);
            this.pbinIMG.Name = "pbinIMG";
            this.pbinIMG.Size = new System.Drawing.Size(250, 188);
            this.pbinIMG.TabIndex = 1;
            this.pbinIMG.TabStop = false;
            // 
            // pboutIMG
            // 
            this.pboutIMG.BackColor = System.Drawing.SystemColors.Control;
            this.pboutIMG.Location = new System.Drawing.Point(250, 27);
            this.pboutIMG.Name = "pboutIMG";
            this.pboutIMG.Size = new System.Drawing.Size(250, 188);
            this.pboutIMG.TabIndex = 2;
            this.pboutIMG.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 217);
            this.Controls.Add(this.pboutIMG);
            this.Controls.Add(this.pbinIMG);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Image Process Preview";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbinIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboutIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pixelPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sameImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inversionImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackWhiteMeanValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackWhiteMiddleValueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometricToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sharpeningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geometricToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updownMirroringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftrightMirroringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expansionBackwardingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reductionBackwardingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomAngleRotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endInSearchingToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbinIMG;
        private System.Windows.Forms.PictureBox pboutIMG;
        private System.Windows.Forms.ToolStripMenuItem etcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equalizingToolStripMenuItem;
    }
}