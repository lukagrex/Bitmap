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
    public partial class Settings : Form
    {
        MainWindow mainWindow;

        public Settings(MainWindow main)
        {
            InitializeComponent();
            mainWindow = main;
            zoomDeltaTrackBar.Value = (int)(main.zoomDelta * 100);
        }

        private void settingsCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsOKButton_Click(object sender, EventArgs e)
        {
            mainWindow.zoomDelta = Double.Parse(zoomDeltaTextBox.Text) * 0.01;
            this.Close();
        }

        private void zoomDeltaTrackBar_ValueChanged(object sender, EventArgs e)
        {
            zoomDeltaTextBox.Text = zoomDeltaTrackBar.Value.ToString();
        }
    }
}
