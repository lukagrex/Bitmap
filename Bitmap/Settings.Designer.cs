
namespace Bitmap
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.zoomDeltaTrackBar = new System.Windows.Forms.TrackBar();
            this.zoomDeltaTextBox = new System.Windows.Forms.TextBox();
            this.settingsOKButton = new System.Windows.Forms.Button();
            this.settingsCancelButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.zoomDeltaTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zoom Delta:";
            // 
            // zoomDeltaTrackBar
            // 
            this.zoomDeltaTrackBar.Location = new System.Drawing.Point(16, 43);
            this.zoomDeltaTrackBar.Maximum = 100;
            this.zoomDeltaTrackBar.Minimum = 1;
            this.zoomDeltaTrackBar.Name = "zoomDeltaTrackBar";
            this.zoomDeltaTrackBar.Size = new System.Drawing.Size(323, 56);
            this.zoomDeltaTrackBar.TabIndex = 1;
            this.zoomDeltaTrackBar.Value = 20;
            this.zoomDeltaTrackBar.ValueChanged += new System.EventHandler(this.zoomDeltaTrackBar_ValueChanged);
            // 
            // zoomDeltaTextBox
            // 
            this.zoomDeltaTextBox.Location = new System.Drawing.Point(104, 10);
            this.zoomDeltaTextBox.Name = "zoomDeltaTextBox";
            this.zoomDeltaTextBox.Size = new System.Drawing.Size(72, 22);
            this.zoomDeltaTextBox.TabIndex = 2;
            this.zoomDeltaTextBox.Text = "20";
            // 
            // settingsOKButton
            // 
            this.settingsOKButton.Location = new System.Drawing.Point(196, 100);
            this.settingsOKButton.Name = "settingsOKButton";
            this.settingsOKButton.Size = new System.Drawing.Size(83, 30);
            this.settingsOKButton.TabIndex = 3;
            this.settingsOKButton.Text = "OK";
            this.settingsOKButton.UseVisualStyleBackColor = true;
            this.settingsOKButton.Click += new System.EventHandler(this.settingsOKButton_Click);
            // 
            // settingsCancelButton
            // 
            this.settingsCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.settingsCancelButton.Location = new System.Drawing.Point(68, 100);
            this.settingsCancelButton.Name = "settingsCancelButton";
            this.settingsCancelButton.Size = new System.Drawing.Size(83, 30);
            this.settingsCancelButton.TabIndex = 4;
            this.settingsCancelButton.Text = "Cancel";
            this.settingsCancelButton.UseVisualStyleBackColor = true;
            this.settingsCancelButton.Click += new System.EventHandler(this.settingsCancelButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "%";
            // 
            // Settings
            // 
            this.AcceptButton = this.settingsOKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.settingsCancelButton;
            this.ClientSize = new System.Drawing.Size(351, 142);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.settingsCancelButton);
            this.Controls.Add(this.settingsOKButton);
            this.Controls.Add(this.zoomDeltaTextBox);
            this.Controls.Add(this.zoomDeltaTrackBar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.zoomDeltaTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar zoomDeltaTrackBar;
        private System.Windows.Forms.TextBox zoomDeltaTextBox;
        private System.Windows.Forms.Button settingsOKButton;
        private System.Windows.Forms.Button settingsCancelButton;
        private System.Windows.Forms.Label label2;
    }
}