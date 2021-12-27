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
                var image = Image.FromFile(openFileDialog.FileName);
                //System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(image);
                pictureBox.Image = image;
                imgIsLoaded = true;
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                
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
            pb.Top = pb.Top + e.Y - yPosition;
            pb.Left = pb.Left + e.X - xPosition;
        }
    }
}
