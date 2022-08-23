using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Image_Process_Preview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openIMG();
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveIMG();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sameImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sameIMG();
        }
        private void inversionImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rvsIMG();
        }
        private void brightnessControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brtIMG();
        }
        private void blackWhiteMeanValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bwmnvIMG();
        }
        private void blackWhiteMiddleValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bwmdvIMG();
        }
        private void blurringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blrrIMG();
        }
        private void sharpeningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shrpIMG();
        }
        private void embossingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mbssIMG();
        }
        private void updownMirroringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            udmrrIMG();
        }
        private void leftrightMirroringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lrmrrIMG();
        }
        private void expansionBackwardingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xpnsIMG();
        }
        private void reductionBackwardingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdctIMG();
        }
        private void randomAngleRotationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rttnIMG();
        }
        private void moveLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mvlcIMG();
        }
        private void stretchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            strchIMG();
        }
        private void endInSearchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eischIMG();
        }
        private void equalizingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eqlzIMG();
        }
        private void gammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gammaIMG();
        }
        private void cAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capIMG();
        }
        private void cUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cupIMG();
        }
        // Variable
        string FULLNAME;
        static byte[,] inIMG, outIMG;
        static int inH, inW, outH, outW;
        static byte MIN = 0, MAX = 255;
        Bitmap inPaper, outPaper;
        // Common Method
        public void openIMG()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.DefaultExt = "raw";
            OFD.Filter = "로우 이미지 | *.raw; *.RAW";
            OFD.ShowDialog();
            FULLNAME = OFD.FileName;
            BinaryReader BR = new BinaryReader(File.Open(FULLNAME, FileMode.Open));
            long FILESIZE = new FileInfo(FULLNAME).Length;
            inH = inW = (int)Math.Sqrt(FILESIZE);
            inIMG = new byte[inH, inW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    inIMG[i, j] = BR.ReadByte();
            BR.Close();
            printInIMG();
        }
        public void saveIMG()
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.DefaultExt = "raw";
            SFD.Filter = "로우 이미지 | *.raw";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                string SAVEFNAME = SFD.FileName;
                BinaryWriter BW = new BinaryWriter(File.Open(SAVEFNAME, FileMode.Create));
                for (int i = 0; i < outH; i++)
                    for (int j = 0; j < outW; j++)
                        BW.Write(outIMG[i, j]);
                BW.Close();
            }
        }
        public void printInIMG()
        {
            inPaper = new Bitmap(inH, inW);
            pbinIMG.Size = new Size(inH, inW);
            pbinIMG.Location = new Point(0, menuStrip1.Height);
            if (inW > outW)
                this.ClientSize = new Size(inH + outH, inW + menuStrip1.Height);
            else
                this.ClientSize = new Size(inH + outH, outW + menuStrip1.Height);
            Color Pen;
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                {
                    byte Ink = inIMG[i, j];
                    Pen = Color.FromArgb(Ink, Ink, Ink);
                    inPaper.SetPixel(j, i, Pen);
                }
            pbinIMG.Image = inPaper;
            pboutIMG.Visible = false;
        }
        public void printOutIMG()
        {
            outPaper = new Bitmap(outH, outW);
            pboutIMG.Size = new Size(outH, outW);
            pboutIMG.Location = new Point(inH, menuStrip1.Height);
            if (inW > outW)
                this.ClientSize = new Size(inH + outH, inW + menuStrip1.Height);
            else
                this.ClientSize = new Size(inH + outH, outW + menuStrip1.Height);
            Color Pen;
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                {
                    byte Ink = outIMG[i, j];
                    Pen = Color.FromArgb(Ink, Ink, Ink);
                    outPaper.SetPixel(j, i, Pen);
                }
            pboutIMG.Image = outPaper;
            pboutIMG.Visible = true;
        }
        // Image Process
        //// Pixel Point Process Method
        public void sameIMG() // inIMG = outIMG
        {
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    outIMG[i, j] = inIMG[i, j];
            printOutIMG();
        }
        public void rvsIMG() // inIMG Color Reverse -> outIMG
        {
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    outIMG[i, j] = (byte)(MAX - inIMG[i, j]);
            printOutIMG();
        }
        public void brtIMG() // inIMG Brightness -> outIMG
        {
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            int BRT = 0;
            BRTinput tmp = new BRTinput();
            if (tmp.ShowDialog() == DialogResult.OK)
                BRT = (int)tmp.BRTvalue.Value;
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                {
                    if (inIMG[i, j] + BRT > MAX) outIMG[i, j] = MAX;
                    else if (inIMG[i, j] + BRT < MIN) outIMG[i, j] = MIN;
                    else outIMG[i, j] = (byte)(inIMG[i, j] + BRT);
                }
            printOutIMG();
        }
        public void bwmnvIMG() // inIMG Black White (Mean) -> outIMG
        {
            outH = inH;
            outW = inW;
            int SUM = 0;
            int MEAN;
            outIMG = new byte[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    SUM += inIMG[i, j];
            MEAN = SUM / (inH * inW);
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                {
                    if (inIMG[i, j] >= MEAN)
                        outIMG[i, j] = MAX;
                    else outIMG[i, j] = MIN;
                }
            printOutIMG();
        }
        public void bwmdvIMG() // inIMG Black White (Middle) -> outIMG
        {
            outH = inH;
            outW = inW;
            ArrayList numList = new ArrayList();
            outIMG = new byte[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    numList.Add(inIMG[i, j]);
            numList.Sort();
            byte mdVAL = (byte)numList[numList.Count / 2];
            outIMG = new byte[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                {
                    if (inIMG[i, j] > mdVAL)
                        outIMG[i, j] = MAX;
                    else outIMG[i, j] = MIN;
                }
            printOutIMG();
        }
        //// Pixel Area Process Method
        public void blrrIMG() // inIMG Blurring -> outIMG
        {
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            double SUM;
            double[,] MASK = {{1.0 / 16.0, 1.0 / 8.0, 1.0 / 16.0},
                              {1.0 / 8.0, 1.0 / 4.0, 1.0 / 8.0},
                              {1.0 / 16.0, 1.0 / 8.0, 1.0 / 16.0}};
            double[,] inTMP = new double[inH + 2, inW + 2];
            double[,] outTMP = new double[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    inTMP[i + 1, j + 1] = inIMG[i, j];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                {
                    SUM = 0.0;
                    for (int k = 0; k < 3; k++)
                        for (int l = 0; l < 3; l++)
                            SUM += inTMP[i + k, j + l] * MASK[k, l];
                    outTMP[i, j] = SUM;
                }
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                    outTMP[i, j] += 127.0;
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                {
                    double VALUE = outTMP[i, j];
                    if (VALUE > 255.0) VALUE = 255.0;
                    else if (VALUE < 0.0) VALUE = 0.0;
                    outIMG[i, j] = (byte)VALUE;
                }
            printOutIMG();
        }
        public void shrpIMG() // inIMG Sharpening -> outIMG
        {
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            double SUM;
            double[,] MASK = {{-1.0 / 9.0, 1.0 / 9.0, -1.0 / 9.0},
                              {-1.0 / 9.0, 8.0 / 9.0, -1.0 / 9.0},
                              {-1.0 / 9.0, 1.0 / 9.0, -1.0 / 9.0}};
            double[,] inTMP = new double[inH + 2, inW + 2];
            double[,] outTMP = new double[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    inTMP[i + 1, j + 1] = inIMG[i, j];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                {
                    SUM = 0.0;
                    for (int k = 0; k < 3; k++)
                        for (int l = 0; l < 3; l++)
                            SUM += inTMP[i + k, j + l] * MASK[k, l];
                    outTMP[i, j] = SUM;
                }
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                    outTMP[i, j] += 127.0;
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                {
                    double VALUE = outTMP[i, j];
                    if (VALUE > 255.0) VALUE = 255.0;
                    else if (VALUE < 0.0) VALUE = 0.0;
                    outIMG[i, j] = (byte)VALUE;
                }
            printOutIMG();
        }
        public void mbssIMG() // inIMG Embossing -> outIMG
        {
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            double SUM;
            double[,] MASK = {{-1.0, 0.0, 0.0},
                              {0.0, 0.0, 0.0},
                              {0.0, 0.0, 1.0}};
            double[,] inTMP = new double[inH + 2, inW + 2];
            double[,] outTMP = new double[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    inTMP[i + 1, j + 1] = inIMG[i, j];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                {
                    SUM = 0.0;
                    for (int k = 0; k < 3; k++)
                        for (int l = 0; l < 3; l++)
                            SUM += inTMP[i + k, j + l] * MASK[k, l];
                    outTMP[i, j] = SUM;
                }
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                    outTMP[i, j] += 127.0;
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                {
                    double VALUE = outTMP[i, j];
                    if (VALUE > 255.0) VALUE = 255.0;
                    else if (VALUE < 0.0) VALUE = 0.0;
                    outIMG[i, j] = (byte)VALUE;
                }
            printOutIMG();
        }
        //// Geometric Process Method
        public void udmrrIMG() // inIMG Up-Down Mirror -> outIMG
        {
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            byte[,] tmp = new byte[inH, inW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    tmp[i, j] = inIMG[i, j];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    outIMG[i, j] = tmp[inH - 1 - i, j];
            printOutIMG();
        }
        public void lrmrrIMG() // inIMG Left-Right Mirror -> outIMG
        {
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            byte[,] tmp = new byte[inH, inW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    tmp[i, j] = inIMG[i, j];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    outIMG[i, j] = tmp[i, inW - 1 - j];
            printOutIMG();
        }
        public void xpnsIMG() // inIMG *input Expansion -> outIMG
        {
            int SCALE = 0;
            MGNinput tmp = new MGNinput();
            if (tmp.ShowDialog() == DialogResult.OK)
                SCALE = (int)tmp.MGNvalue.Value;
            outH = inH * SCALE;
            outW = inW * SCALE;
            outIMG = new byte[outH, outW];
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                    outIMG[i, j] = inIMG[(int)(i / SCALE), (int)(j / SCALE)];
            printOutIMG();
        }
        public void rdctIMG() // inIMG /input Reduction -> outIMG
        {
            int SCALE = 0;
            MGNinput tmp = new MGNinput();
            if (tmp.ShowDialog() == DialogResult.OK)
                SCALE = (int)tmp.MGNvalue.Value;
            outH = (int)(inH / SCALE);
            outW = (int)(inW / SCALE);
            outIMG = new byte[outH, outW];
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                    outIMG[i, j] = inIMG[i * SCALE, j * SCALE];
            printOutIMG();
        }
        public void rttnIMG() // inIMG input Rotation -> outIMG
        {
            outH = inH;
            outW = inH;
            int ANGLE = 0;
            ANGinput tmp = new ANGinput();
            if (tmp.ShowDialog() == DialogResult.OK)
                ANGLE = (int)tmp.ANGvalue.Value;
            double RADIAN = (double)(ANGLE * Math.PI / 180.0);
            int cx = inH / 2;
            int cy = inW / 2;
            outIMG = new byte[outH, outW];
            /*
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                {
                    // k = sin(RDN) * x + cos(RDN) * y
                    // l = cos(RDN) * x - sin(RDN) * y
                    int k = (int)((Math.Cos(RADIAN) * (i - cx) + Math.Sin(RADIAN) * (j - cy)) + cx);
                    int l = (int)((Math.Cos(RADIAN) * (j - cy) - Math.Sin(RADIAN) * (i - cx)) + cy);
                    if (((k >= 0) && (k < outH)) && ((l >= 0) && (l < outW)))
                        outIMG[i, j] = inIMG[k, l];
                }
            */
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                {
                    // k = cos(RDN) * x - sin(RDN) * y
                    // l = sin(RDN) * x + cos(RDN) * y
                    int k = (int)((Math.Cos(RADIAN) * (i - cx) - Math.Sin(RADIAN) * (j - cy)) + cx);
                    int l = (int)((Math.Cos(RADIAN) * (j - cy) + Math.Sin(RADIAN) * (i - cx)) + cy);
                    if (((k >= 0) && (k < outH)) && ((l >= 0) && (l < outW)))
                        outIMG[i, j] = inIMG[k, l];
                }
            printOutIMG();
        }
        public void mvlcIMG() // inIMG input Move Location -> outIMG
        {
            int MOVE = 0;
            CRDinput tmp = new CRDinput();
            if (tmp.ShowDialog() == DialogResult.OK)
                MOVE = (int)tmp.CRDvalue.Value;
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            if (inH < MOVE) MOVE = 0;
            for (int i = MOVE; i < inH; i++)
                for (int j = MOVE; j < inW; j++)
                    outIMG[i, j] = inIMG[i - MOVE, j - MOVE];
            printOutIMG();
        }
        //// Histogram Process Method
        public void strchIMG() // inIMG Stretching -> outIMG
        {
            outH = inH;
            outW = inW;
            byte minVAL = MAX;
            byte maxVAL = MIN;
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    if (inIMG[i, j] <= minVAL) minVAL = inIMG[i, j];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    if (inIMG[i, j] >= maxVAL) maxVAL = inIMG[i, j];
            outIMG = new byte[outH, outW];
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                    outIMG[i, j] = (byte)((inIMG[i, j] - minVAL) * MAX / (maxVAL - minVAL));
            printOutIMG();
        }
        public void eischIMG() // inIMG End-in Searching -> OutIMG
        {
            outH = inH;
            outW = inW;
            int LEFT = 25;
            int RIGHT = 75;
            EISinput tmp = new EISinput();
            if (tmp.ShowDialog() == DialogResult.OK)
            {
                LEFT = (int)tmp.LEFTvalue.Value;
                RIGHT = (int)tmp.RIGHTvalue.Value;
            }
            double[] HIST = new double[256];
            double[] sumHIST = new double[256];
            byte VALUE;
            byte minVAL = MIN;
            byte maxVAL = MAX;
            double SUM = 0.0;
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                {
                    VALUE = inIMG[i, j];
                    HIST[VALUE]++;
                }
            for (int i = 0; i < 256; i++)
            {
                SUM += HIST[i];
                sumHIST[i] = SUM;
            }
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    if ((sumHIST[inIMG[i, j]] * 100 / (inH * inW)) <= LEFT)
                        minVAL = inIMG[i, j];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    if ((sumHIST[inIMG[i, j]] * 100 / (inH * inW)) >= RIGHT)
                        maxVAL = inIMG[i, j];
            outIMG = new byte[outH, outW];
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                {
                    if (inIMG[i, j] < minVAL)
                        outIMG[i, j] = MIN;
                    else if (inIMG[i, j] > maxVAL)
                        outIMG[i, j] = MAX;
                    else outIMG[i, j] = (byte)((inIMG[i, j] - minVAL) * MAX / (maxVAL - minVAL));
                }
            printOutIMG();
        }
        public void eqlzIMG() // inIMG Equalization -> OutIMG
        {
            outH = inH;
            outW = inW;
            byte VALUE;
            double[] HIST = new double[256];
            double[] sumHIST = new double[256];
            double SUM = 0.0;
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                {
                    VALUE = inIMG[i, j];
                    HIST[VALUE]++;
                }
            for (int i = 0; i < 256; i++)
            {
                SUM += HIST[i];
                sumHIST[i] = SUM;
            }
            outIMG = new byte[outH, outW];
            for (int i = 0; i < outH; i++)
                for (int j = 0; j < outW; j++)
                    outIMG[i, j] = (byte)(sumHIST[inIMG[i, j]] * MAX / (inH * inW));
            printOutIMG();
        }
        //// etc. Process Method
        public void gammaIMG()
        {
            double GAMMA = 0.0;
            GMinput tmp = new GMinput();
            if (tmp.ShowDialog() == DialogResult.OK)
                GAMMA = (double)tmp.GMvalue.Value;
            outH = inH;
            outW = inW;
            outIMG = new byte[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    outIMG[i, j] = (byte)(255.0 * (Math.Pow((inIMG[i, j] / 255.0), GAMMA)));
            printOutIMG();
        }
        public void capIMG()
        {
            outH = inH;
            outW = inW;
            // y = 255 * ((x / 127) - 1)^(2)
            outIMG = new byte[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    outIMG[i, j] = (byte)(255.0 * (Math.Pow((inIMG[i, j] / 127.0 - 1.0), 2)));
            printOutIMG();
        }
        public void cupIMG()
        {
            outH = inH;
            outW = inW;
            // y = (- 255) * ((x / 127) - 1)^(2) + 255
            outIMG = new byte[outH, outW];
            for (int i = 0; i < inH; i++)
                for (int j = 0; j < inW; j++)
                    outIMG[i, j] = (byte)(255.0 - 255.0 * (Math.Pow((inIMG[i, j] / 127.0 - 1.0), 2)));
            printOutIMG();
        }
    }
}