using System;
using System.Windows.Forms;

namespace Download_Time_Calculator.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Enables double-buffering (prevents WinForms flicker).
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;     
                return handleParam;
            }
        }

        #region Event Handlers

        #region File Size Checkboxes

        private void kbCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            switch (kbCheckBox.Checked)
            {
                case true:
                    mbCheckBox.Checked = false;
                    gbCheckBox.Checked = false;
                    break;
                case false:
                    if (!mbCheckBox.Checked && !gbCheckBox.Checked)
                        kbCheckBox.Checked = true;
                    break;
            }
        }

        private void mbCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            switch (mbCheckBox.Checked)
            {
                case true:
                    kbCheckBox.Checked = false;
                    gbCheckBox.Checked = false;
                    break;
                case false:
                    if (!kbCheckBox.Checked && !gbCheckBox.Checked)
                        mbCheckBox.Checked = true;
                    break;
            }
        }

        private void gbCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            switch (gbCheckBox.Checked)
            {
                case true:
                    kbCheckBox.Checked = false;
                    mbCheckBox.Checked = false;
                    break;
                case false:
                    if (!kbCheckBox.Checked && !mbCheckBox.Checked)
                        gbCheckBox.Checked = true;
                    break;
            }
        }

        #endregion

        #region Your Speed Checkboxes

        private void kbpsCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            switch (kbpsCheckBox.Checked)
            {
                case true:
                    mbpsCheckBox.Checked = false;
                    gbpsCheckBox.Checked = false;
                    break;
                case false:
                    if (!mbpsCheckBox.Checked && !gbpsCheckBox.Checked)
                        kbpsCheckBox.Checked = true;
                    break;
            }
        }

        private void mbpsCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            switch (mbpsCheckBox.Checked)
            {
                case true:
                    kbpsCheckBox.Checked = false;
                    gbpsCheckBox.Checked = false;
                    break;
                case false:
                    if (!kbpsCheckBox.Checked && !gbpsCheckBox.Checked)
                        mbpsCheckBox.Checked = true;
                    break;
            }
        }

        private void gbpsCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            switch (gbpsCheckBox.Checked)
            {
                case true:
                    mbpsCheckBox.Checked = false;
                    kbpsCheckBox.Checked = false;
                    break;
                case false:
                    if (!mbpsCheckBox.Checked && !kbpsCheckBox.Checked)
                        gbpsCheckBox.Checked = true;
                    break;
            }
        }

        #endregion

        private void calculateButton_Click(object sender, System.EventArgs e)
        {
            TimeSpan downloadTime = CalculateDownloadTime(GetFileSizeBytes(), 
                GetDownloadSpeedBytes());

            resultLabel.Text = $"It will take {(int)downloadTime.TotalHours} hours, {downloadTime.Minutes} minutes and {downloadTime.Seconds} seconds to download this file.";
        }

        #endregion

        #region Methods

        private double GetFileSizeBytes()
        {
            double fileSizeBytes = Convert.ToDouble(fileSizeTextBox.Text);

            if (kbCheckBox.Checked)
                fileSizeBytes = fileSizeBytes * 1000;
            else if (mbCheckBox.Checked)
                fileSizeBytes = fileSizeBytes * 1000000;
            else if (gbCheckBox.Checked)
                fileSizeBytes = fileSizeBytes * 1000000000;

            return fileSizeBytes;
        }

        private double GetDownloadSpeedBytes()
        {
            double downloadSpeedBytes = Convert.ToDouble(yourSpeedTextBox.Text);

            if (kbpsCheckBox.Checked)
                downloadSpeedBytes = downloadSpeedBytes * 1000;
            else if (mbpsCheckBox.Checked)
                downloadSpeedBytes = downloadSpeedBytes * 1000000;
            else if (gbpsCheckBox.Checked)
                downloadSpeedBytes = downloadSpeedBytes * 1000000000;

            return downloadSpeedBytes;
        }

        private TimeSpan CalculateDownloadTime(double fileSizeBytes, 
            double downloadSpeedBytes)
        {
            double seconds = (fileSizeBytes / downloadSpeedBytes);
            TimeSpan result = TimeSpan.FromSeconds(seconds);

            return result;
        }

        #endregion
    }
}