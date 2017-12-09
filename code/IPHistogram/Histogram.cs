using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPHistogram
{
    public partial class frmMain : Form
    {
        #region Private Attributes
        Int32[] btRHistogram = new Int32[256];
        Int32[] btGHistogram = new Int32[256];
        Int32[] btBHistogram = new Int32[256];

        Int32[] btCDFRHistogram = new Int32[256];
        Int32[] btCDFGHistogram = new Int32[256];
        Int32[] btCDFBHistogram = new Int32[256];

        Double[] btRefHistogram = new Double[256];

        int[] LUTR = new int[256];
        int[] LUTG = new int[256];
        int[] LUTB = new int[256];
        #endregion

        #region Histogram
        private void GetHistogram(Bitmap image)
        {
            lblStatus.Text = "Please wait...";
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = true;
            Application.DoEvents();

            int j, i, intPercent;
            //RED
            for (j = 0; j <= 255; j++)
            {
                btRHistogram[j] = 0;
                btGHistogram[j] = 0;
                btBHistogram[j] = 0;

                btCDFRHistogram[j] = 0;
                btCDFGHistogram[j] = 0;
                btCDFBHistogram[j] = 0;
            }

            Bitmap btTemp = new Bitmap(image);

            for (i = 0; i < btTemp.Width; i++)
            {

                lblStatus.Text = "Please wait... ";
                intPercent = (((i + 1) * (j + 1) * 100) / (btTemp.Width * btTemp.Height));
                lblStatus.Text += intPercent.ToString();
                lblStatus.Text += "% of stage 1/2 completed.";

                if (toolStripProgressBar.Value < 100)
                    toolStripProgressBar.Value = intPercent;

                Application.DoEvents();

                for (j = 0; j < btTemp.Height; j++)
                {
                    btRHistogram[Convert.ToInt32(btTemp.GetPixel(i, j).R)]++;
                    btGHistogram[Convert.ToInt32(btTemp.GetPixel(i, j).G)]++;
                    btBHistogram[Convert.ToInt32(btTemp.GetPixel(i, j).B)]++;
                }
            }

            lblStatus.Text = "Histogram created successfully.";
            toolStripProgressBar.Visible = false;

        }
        private void GetCDFHistogram(Bitmap image)
        {
            lblStatus.Text = "Please wait...";
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = true;
            Application.DoEvents();


            int i;
            Bitmap btTemp = new Bitmap(image);

            int btRHi = 0, btGHi = 0, btBHi = 0, intPercent;
            for (i = 0; i < 256; i++)
            {
                if (btRHistogram[i] > 0 && i > 0)
                {
                    btCDFRHistogram[i] = btRHi + btRHistogram[i];
                    btRHi = btCDFRHistogram[i];
                }
                if (btGHistogram[i] > 0 && i > 0)
                {
                    btCDFGHistogram[i] = btGHi + btGHistogram[i];
                    btGHi = btCDFGHistogram[i];
                }
                if (btBHistogram[i] > 0 && i > 0)
                {
                    btCDFBHistogram[i] = btBHi + btBHistogram[i];
                    btBHi = btCDFBHistogram[i];
                }

                lblStatus.Text = "Please wait... ";
                intPercent = ((i * 100) / 256);
                lblStatus.Text += intPercent.ToString();
                lblStatus.Text += "% of stage 1/2 completed.";

                if (toolStripProgressBar.Value < 100)
                    toolStripProgressBar.Value = intPercent;

                Application.DoEvents();
            }
            lblStatus.Text = "Histogram computed completed.";
            toolStripProgressBar.Visible = false;

        }
        private void DrawHistogram(Int32[] Histgram, Color color, PictureBox picbox)
        {
            lblStatus.Text = "Please wait...";
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = true;
            Application.DoEvents();


            int i;

            Point pt = new Point();
            Point pt2 = new Point();

            Pen selPen = new Pen(color); ;
            Bitmap bm = new Bitmap(256, 256);

            Graphics graphic = Graphics.FromImage(bm);

            int HistoMax = 0;

            HistoMax = FindMax(Histgram);

            lblValue.Text = HistoMax.ToString();

            int intRatio = 1;

            int btHi = 0, intPercent;
            for (i = 0; i < 256; i++)
            {

                btHi = Histgram[i];

                pt.X = i; pt.Y = 256;
                pt2.X = i; pt2.Y = 256 - ((btHi * 256 / HistoMax) * intRatio);
                graphic.DrawLine(selPen, pt, pt2);

                lblStatus.Text = "Please wait... ";
                intPercent = ((i * 100) / 256);
                lblStatus.Text += intPercent.ToString();
                lblStatus.Text += "% of stage 2/2 completed.";

                if (toolStripProgressBar.Value < 100)
                    toolStripProgressBar.Value = intPercent;

                Application.DoEvents();
            }
            picbox.Image = bm;
            picbox.Refresh();
            lblStatus.Text = "Histogram drawing completed.";
            toolStripProgressBar.Visible = false;

        }
        private void DrawReference(int intType)
        {
            lblStatus.Text = "Please wait...";
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = true;
            Application.DoEvents();


            int i;
            //RED

            Point pt = new Point();
            Point pt2 = new Point();

            Pen selPen = new Pen(Color.Gray);
            Bitmap bm = new Bitmap(256, 256);

            Graphics graphic = Graphics.FromImage(bm);

            double HiMax = 0;
            int intPercent;

            if (intType == 1)
                Guassian(Convert.ToDouble(txtAlfa.Text));
            if (intType == 2)
                Exponential(Convert.ToDouble(txtLanda.Text));
            if (intType == 3)
                Equalize();
            HiMax = FindMax(btRefHistogram);
            for (i = 0; i < 256; i++)
            {
                pt.X = i; pt.Y = 256;
                pt2.X = i; pt2.Y = 256 - (Convert.ToInt32(btRefHistogram[i]) * 256 / Convert.ToInt32(HiMax));
                graphic.DrawLine(selPen, pt, pt2);

                lblStatus.Text = "Please wait... ";
                intPercent = ((i * 100) / 256);
                lblStatus.Text += intPercent.ToString();
                lblStatus.Text += "% of stage 2/2 completed.";

                if (toolStripProgressBar.Value < 100)
                    toolStripProgressBar.Value = intPercent;

                Application.DoEvents();
            }
            picRef.Image = bm;
            picRef.Refresh();
            lblStatus.Text = "Histogram drawing completed.";
            toolStripProgressBar.Visible = false;
        }

        #endregion

        #region Calculations
        private int FindMax(int[] Histogram)
        {
            int intMax = 0;
            for (int i = 0; i < 256; i++)
            {
                if (Histogram[i] > intMax)
                {
                    intMax = Histogram[i];
                    lblColor.Text = i.ToString();
                }
            }
            return intMax;
        }
        private double FindMax(Double[] Histogram)
        {
            Double intMax = 0;
            for (int i = 0; i < 256; i++)
            {
                if (Histogram[i] > intMax)
                {
                    intMax = Histogram[i];
                    lblColor.Text = i.ToString();
                }
            }
            return intMax;
        }

        void Guassian(double sigma)
        {
            double sigma2 = 2 * sigma * sigma;
            for (int i = 0; i < 256; i++)
            {
                double x = 128 - i;
                double g = Math.Exp(-(x * x) / sigma2) / sigma;
                btRefHistogram[i] = (double)Math.Round(10000 * g);
            }
        }
        void Exponential(double landa)
        {
            for (int i = 0; i < 256; i++)
            {
                double g = 1 - Math.Exp(-1 * landa * i);
                btRefHistogram[i] = (double)Math.Round(g * 255);
            }
        }
        void Equalize()
        {
            for (int i = 0; i < 256; i++)
            {
                btRefHistogram[i] = (double)i;
            }
        }
        #endregion

        #region Normalize-LUT
        Double[] Normalize(Double[] Histogram)
        {
            Double dblMax = FindMax(Histogram);
            for (int i = 0; i < 256; i++)
            {
                double g = (Histogram[i] * 255) / dblMax;
                Histogram[i] = (double)((int)g);
            }
            return Histogram;
        }
        Int32[] Normalize(Int32[] Histogram)
        {
            Int32 dblMax = FindMax(Histogram);
            for (int i = 0; i < 256; i++)
            {
                int g = (Histogram[i] * 255) / dblMax;
                Histogram[i] = (int)g;
            }
            return Histogram;
        }

        void ApplyLUT()
        {
            btRefHistogram = Normalize(btRefHistogram);
            btCDFRHistogram = Normalize(btCDFRHistogram);
            btCDFGHistogram = Normalize(btCDFGHistogram);
            btCDFBHistogram = Normalize(btCDFBHistogram);

            int i = 0, j = 0, j1, j2, j3;
            for (int a = 0; a < 256; a++)
            {
                j1 = 256 - 1;
                do
                {
                    LUTR[a] = j1;
                    j1--;
                } while (j1 >= 0 && btCDFRHistogram[a] <= btRefHistogram[j1]);

                j2 = 256 - 1;
                do
                {
                    LUTG[a] = j2;
                    j2--;
                } while (j2 >= 0 && btCDFGHistogram[a] <= btRefHistogram[j2]);

                j3 = 256 - 1;
                do
                {
                    LUTB[a] = j3;
                    j3--;
                } while (j3 >= 0 && btCDFBHistogram[a] <= btRefHistogram[j3]);
            }

            int intPercent = 0;
            int tR = 0, tG = 0, tB = 0;
            Bitmap btMain = new Bitmap(pictureBox.Image);
            Bitmap btTemp = new Bitmap(btMain.Width, btMain.Height);
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = true;

            for (i = 0; i < btTemp.Width; i++)
            {
                lblStatus.Text = "Please wait... ";
                intPercent = ((i + 1) * (j + 1) * 100) / (btTemp.Width * btTemp.Height);
                lblStatus.Text += intPercent.ToString();
                lblStatus.Text += "% completed.";

                if (toolStripProgressBar.Value < 100)
                    toolStripProgressBar.Value = intPercent;

                Application.DoEvents();


                for (j = 0; j < btTemp.Height; j++)
                {
                    tR = 0; tG = 0; tB = 0;

                    tR = LUTR[btMain.GetPixel(i, j).R];
                    tG = LUTG[btMain.GetPixel(i, j).G];
                    tB = LUTB[btMain.GetPixel(i, j).B];

                    Color color = Color.FromArgb((int)tR, (int)tG, (int)tB);
                    btTemp.SetPixel(i, j, color);

                }
            }

            picturePreview.Image = btTemp;
            picturePreview.Refresh();
            lblStatus.Text = "Filter applied successfully.";
            toolStripProgressBar.Visible = false;

        }
        #endregion

        #region FormControling
        void ActivateFrom()
        {
            cmdEqualization.Enabled = true;
            cmdGaussian.Enabled = true;
            cmdExpShape.Enabled = true;
            comboColors.Enabled = true;
        }
        void DeactivateFrom()
        {
            cmdEqualization.Enabled = false;
            cmdGaussian.Enabled = false;
            cmdExpShape.Enabled = false;
            comboColors.Enabled = false;
        }
        #endregion

    }
}
