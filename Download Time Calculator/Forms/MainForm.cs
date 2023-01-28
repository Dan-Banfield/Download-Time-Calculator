using System.Windows.Forms;

namespace Download_Time_Calculator.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        #endregion
    }
}