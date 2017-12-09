using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IPHistogram
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            for (int i = 0; i < 256; i++)
            {
                btRefHistogram[i] = 0;
                LUTR[i] = 0;
                LUTG[i] = 0;
                LUTB[i] = 0;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.tif)|*.jpg; *.jpeg; *.gif; *.bmp; *.tif";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = new Bitmap(open.FileName);
                    lblWidth.Text = pictureBox.Image.Width.ToString();
                    lblHeight.Text = pictureBox.Image.Height.ToString();

                    ActivateFrom();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void comboColors_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DeactivateFrom();

            Color color = new Color();
            if (comboColors.SelectedIndex == 0)
                color = Color.Red;
            if (comboColors.SelectedIndex == 1)
                color = Color.Green;
            if (comboColors.SelectedIndex == 2)
                color = Color.Blue;

            Int32[] Histogram = new Int32[256];
            Int32[] CDFHistogram = new Int32[256];

            if (comboColors.SelectedIndex == 0)
            {
                Histogram = btRHistogram;
                CDFHistogram = btCDFRHistogram;
            }
            if (comboColors.SelectedIndex == 1)
            {
                Histogram = btGHistogram;
                CDFHistogram = btCDFGHistogram;
            }
            if (comboColors.SelectedIndex == 2)
            {
                Histogram = btBHistogram;
                CDFHistogram = btCDFBHistogram;
            }

            GetHistogram(new Bitmap(pictureBox.Image));
            DrawHistogram(Histogram, color, picHistogram);

            GetCDFHistogram(new Bitmap(pictureBox.Image));
            DrawHistogram(CDFHistogram, color, picCDF);

            if (picturePreview.Image != null)
            {
                GetHistogram(new Bitmap(picturePreview.Image));
                DrawHistogram(Histogram, color, picPreHistogram);

                GetCDFHistogram(new Bitmap(picturePreview.Image));
                DrawHistogram(CDFHistogram, color, picPreCDF);
            }
            ActivateFrom();
        }

        private void clearHistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picHistogram.Image = null;
            picCDF.Image = null;
            picPreHistogram.Image = null;
            picPreCDF.Image = null;
            picRef.Image = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picturePreview.Image = null;
            pictureBox.Image = null;
            DeactivateFrom();
        }

        private void SaveStripMenuItem_Click(object sender, EventArgs e)
        {
            if (picturePreview.Image != null)
                SavePicture(picturePreview.Image, "Save preview picture");
            else
                MessageBox.Show("There is no picture to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void tbAlfa_Scroll(object sender, EventArgs e)
        {
            txtAlfa.Text = tbAlfa.Value.ToString();
        }

        private void txtAlfa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbAlfa.Value = Convert.ToInt16(Convert.ToDouble(txtAlfa.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdGaussian_Click(object sender, EventArgs e)
        {

            DeactivateFrom();

            DrawReference(1);
            GetHistogram(new Bitmap(pictureBox.Image));
            GetCDFHistogram(new Bitmap(pictureBox.Image));

            ApplyLUT();

            ActivateFrom();
        }

        private void cmdExpShape_Click(object sender, EventArgs e)
        {
            DeactivateFrom();

            DrawReference(2);
            GetHistogram(new Bitmap(pictureBox.Image));
            GetCDFHistogram(new Bitmap(pictureBox.Image));

            ApplyLUT();

            ActivateFrom();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void cmdEqualization_Click(object sender, EventArgs e)
        {
            DeactivateFrom();
            DrawReference(3);

            GetHistogram(new Bitmap(pictureBox.Image));
            GetCDFHistogram(new Bitmap(pictureBox.Image));

            int i, j, intPercent = 0;
            decimal tR = 0, tG = 0, tB = 0;
            i = 0; j = 0;

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

                    tR = btCDFRHistogram[btMain.GetPixel(i, j).R] - 1;
                    tR = tR / ((btTemp.Width * btTemp.Height) - 1);
                    tR = tR * 255;
                    tR = Math.Round(tR);

                    tG = btCDFGHistogram[btMain.GetPixel(i, j).G] - 1;
                    tG = tG / ((btTemp.Width * btTemp.Height) - 1);
                    tG = tG * 255;
                    tG = Math.Round(tG);

                    tB = btCDFBHistogram[btMain.GetPixel(i, j).B] - 1;
                    tB = tB / ((btTemp.Width * btTemp.Height) - 1);
                    tB = tB * 255;
                    tB = Math.Round(tB);

                    Color color = Color.FromArgb((int)tR, (int)tG, (int)tB);
                    btTemp.SetPixel(i, j, color);

                }
            }

            picturePreview.Image = btTemp;
            picturePreview.Refresh();
            lblStatus.Text = "Filter applied successfully.";
            toolStripProgressBar.Visible = false;

            ActivateFrom();
        }

        private void tbLanda_Scroll(object sender, EventArgs e)
        {
            txtLanda.Text = (tbLanda.Value * 1.0 / 1000).ToString();
        }

        private void txtLanda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbLanda.Value = Convert.ToInt16(Convert.ToDouble(txtLanda.Text) * 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SavePicture(Image image, string title)
        {

            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "JPEG (*.jpg; *.jpeg)|*.jpg; *.jpeg";
                save.Filter += "|PNG (*.png)|*.png";
                save.Filter += "|GIF (*.gif)|*.gif";
                save.Filter += "|Bitmap (*.bmp)|*.bmp";
                save.Filter += "|TIFF (*.tif)|*.tif";
                save.OverwritePrompt = true;
                save.Title = title;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmpsave = new Bitmap(image);

                    if (Path.GetExtension(save.FileName).ToLower() == ".gif")
                        bmpsave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                    else if (Path.GetExtension(save.FileName).ToLower() == ".jpg")
                        bmpsave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    else if (Path.GetExtension(save.FileName).ToLower() == ".bmp")
                        bmpsave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                    else if (Path.GetExtension(save.FileName).ToLower() == ".png")
                        bmpsave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    else if (Path.GetExtension(save.FileName).ToLower() == ".tif")
                        bmpsave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Tiff);
                    else
                        bmpsave.Save(save.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                    bmpsave.Dispose();
                }
                save.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                //throw new ApplicationException("Failed saving image");
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void picturePreview_Click(object sender, EventArgs e)
        {
            if (picturePreview.Image != null)
                SavePicture(picturePreview.Image, "Save preview picture");
            else
                MessageBox.Show("There is no picture to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void picHistogram_Click(object sender, EventArgs e)
        {
            if (picHistogram.Image != null)
                SavePicture(picHistogram.Image, "Save histogram picture");
            else
                MessageBox.Show("There is no picture to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void picCDF_Click(object sender, EventArgs e)
        {
            if (picCDF.Image != null)
                SavePicture(picCDF.Image, "Save CDF histogram picture");
            else
                MessageBox.Show("There is no picture to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void picPreHistogram_Click(object sender, EventArgs e)
        {
            if (picPreHistogram.Image != null)
                SavePicture(picPreHistogram.Image, "Save preview histogram picture");
            else
                MessageBox.Show("There is no picture to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void picPreCDF_Click(object sender, EventArgs e)
        {
            if (picPreCDF.Image != null)
                SavePicture(picPreCDF.Image, "Save preview CDF histogram picture");
            else
                MessageBox.Show("There is no picture to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void picRef_Click(object sender, EventArgs e)
        {
            if (picRef.Image != null)
                SavePicture(picRef.Image, "Save reference graph");
            else
                MessageBox.Show("There is no picture to save.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

    }
}
