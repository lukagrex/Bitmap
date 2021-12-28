using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitmap
{
    public partial class MainWindow : Form
    {
        private bool currentlyDragging;
        private int xPosition;
        private int yPosition;
        private bool imgIsLoaded = false;
        private bool ctrlIsPressed = false;
        private double zoomFactor = 1;
        public double zoomDelta = 0.2;
        private Image image;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files*.jpg; *.png; *.bmp)| *.jpg; *.png; *.bmp";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                image?.Dispose();
                image = Image.FromFile(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                pictureBox.Image = image;
                zoomFactor = 1;
                imgIsLoaded = true;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            var pb = sender as PictureBox;
            if (pb == null) return;
            currentlyDragging = false;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            currentlyDragging = true;
            xPosition = e.X;
            yPosition = e.Y;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            var pb = sender as PictureBox;
            if (!currentlyDragging || !imgIsLoaded || pb == null) return;
            var newPosTop = pb.Top + e.Y - yPosition;
            var newPosLeft = pb.Left + e.X - xPosition;
            pb.Top = Math.Max(5, newPosTop);
            pb.Left = Math.Max(5, newPosLeft);
        }

        private void picturePanel_KeyDown(object sender, KeyEventArgs e)
        {
            if(!e.Control) return;
            ctrlIsPressed = true;
        }

        private void picturePanel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control) return;
            ctrlIsPressed = false;
        }

        private void picturePanel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (imgIsLoaded)
            {
                if (ctrlIsPressed)
                {
                    if (e.Delta > 0)
                    {
                        zoomFactor = Math.Min(5, zoomFactor * (1 + zoomDelta));
                    }
                    else
                    {
                        zoomFactor = Math.Max(0.05, zoomFactor * (1 - zoomDelta));
                    }

                    var bitmap = new System.Drawing.Bitmap(image);
                    Size newSize = new Size((int)(bitmap.Width * zoomFactor), (int)(bitmap.Height * zoomFactor));
                    System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(bitmap, newSize);
                    pictureBox.Image = bmp;
                }
            }
        }

        private void picturePanel_MouseHover(object sender, EventArgs e)
        {
            picturePanel.Focus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settingsForm = new Settings(this);
            settingsForm.ShowDialog();
        }

    }
}
