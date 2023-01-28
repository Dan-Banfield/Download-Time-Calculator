namespace Download_Time_Calculator.Forms
{
    partial class MainForm
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
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.fileSizeTextBox = new System.Windows.Forms.TextBox();
            this.yourSpeedLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.kbCheckBox = new System.Windows.Forms.CheckBox();
            this.mbCheckBox = new System.Windows.Forms.CheckBox();
            this.gbCheckBox = new System.Windows.Forms.CheckBox();
            this.kbpsCheckBox = new System.Windows.Forms.CheckBox();
            this.mbpsCheckBox = new System.Windows.Forms.CheckBox();
            this.gbpsCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeLabel.Location = new System.Drawing.Point(18, 21);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(73, 20);
            this.fileSizeLabel.TabIndex = 0;
            this.fileSizeLabel.Text = "File Size:";
            // 
            // fileSizeTextBox
            // 
            this.fileSizeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeTextBox.Location = new System.Drawing.Point(97, 18);
            this.fileSizeTextBox.Name = "fileSizeTextBox";
            this.fileSizeTextBox.Size = new System.Drawing.Size(207, 26);
            this.fileSizeTextBox.TabIndex = 1;
            this.fileSizeTextBox.TabStop = false;
            // 
            // yourSpeedLabel
            // 
            this.yourSpeedLabel.AutoSize = true;
            this.yourSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourSpeedLabel.Location = new System.Drawing.Point(18, 67);
            this.yourSpeedLabel.Name = "yourSpeedLabel";
            this.yourSpeedLabel.Size = new System.Drawing.Size(98, 20);
            this.yourSpeedLabel.TabIndex = 5;
            this.yourSpeedLabel.Text = "Your Speed:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(122, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TabStop = false;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(22, 111);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(458, 63);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.TabStop = false;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(18, 193);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(191, 20);
            this.resultLabel.TabIndex = 11;
            this.resultLabel.Text = "Your result will show here!";
            // 
            // kbCheckBox
            // 
            this.kbCheckBox.AutoSize = true;
            this.kbCheckBox.Checked = true;
            this.kbCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kbCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbCheckBox.Location = new System.Drawing.Point(315, 21);
            this.kbCheckBox.Name = "kbCheckBox";
            this.kbCheckBox.Size = new System.Drawing.Size(49, 24);
            this.kbCheckBox.TabIndex = 12;
            this.kbCheckBox.TabStop = false;
            this.kbCheckBox.Text = "KB";
            this.kbCheckBox.UseVisualStyleBackColor = true;
            // 
            // mbCheckBox
            // 
            this.mbCheckBox.AutoSize = true;
            this.mbCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbCheckBox.Location = new System.Drawing.Point(368, 21);
            this.mbCheckBox.Name = "mbCheckBox";
            this.mbCheckBox.Size = new System.Drawing.Size(52, 24);
            this.mbCheckBox.TabIndex = 13;
            this.mbCheckBox.TabStop = false;
            this.mbCheckBox.Text = "MB";
            this.mbCheckBox.UseVisualStyleBackColor = true;
            // 
            // gbCheckBox
            // 
            this.gbCheckBox.AutoSize = true;
            this.gbCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCheckBox.Location = new System.Drawing.Point(422, 21);
            this.gbCheckBox.Name = "gbCheckBox";
            this.gbCheckBox.Size = new System.Drawing.Size(52, 24);
            this.gbCheckBox.TabIndex = 14;
            this.gbCheckBox.TabStop = false;
            this.gbCheckBox.Text = "GB";
            this.gbCheckBox.UseVisualStyleBackColor = true;
            // 
            // kbpsCheckBox
            // 
            this.kbpsCheckBox.AutoSize = true;
            this.kbpsCheckBox.Checked = true;
            this.kbpsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kbpsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbpsCheckBox.Location = new System.Drawing.Point(263, 67);
            this.kbpsCheckBox.Name = "kbpsCheckBox";
            this.kbpsCheckBox.Size = new System.Drawing.Size(64, 24);
            this.kbpsCheckBox.TabIndex = 15;
            this.kbpsCheckBox.TabStop = false;
            this.kbpsCheckBox.Text = "Kbps";
            this.kbpsCheckBox.UseVisualStyleBackColor = true;
            // 
            // mbpsCheckBox
            // 
            this.mbpsCheckBox.AutoSize = true;
            this.mbpsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbpsCheckBox.Location = new System.Drawing.Point(332, 67);
            this.mbpsCheckBox.Name = "mbpsCheckBox";
            this.mbpsCheckBox.Size = new System.Drawing.Size(67, 24);
            this.mbpsCheckBox.TabIndex = 16;
            this.mbpsCheckBox.TabStop = false;
            this.mbpsCheckBox.Text = "Mbps";
            this.mbpsCheckBox.UseVisualStyleBackColor = true;
            // 
            // gbpsCheckBox
            // 
            this.gbpsCheckBox.AutoSize = true;
            this.gbpsCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbpsCheckBox.Location = new System.Drawing.Point(405, 67);
            this.gbpsCheckBox.Name = "gbpsCheckBox";
            this.gbpsCheckBox.Size = new System.Drawing.Size(67, 24);
            this.gbpsCheckBox.TabIndex = 17;
            this.gbpsCheckBox.TabStop = false;
            this.gbpsCheckBox.Text = "Gbps";
            this.gbpsCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 226);
            this.Controls.Add(this.gbpsCheckBox);
            this.Controls.Add(this.mbpsCheckBox);
            this.Controls.Add(this.kbpsCheckBox);
            this.Controls.Add(this.gbCheckBox);
            this.Controls.Add(this.mbCheckBox);
            this.Controls.Add(this.kbCheckBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yourSpeedLabel);
            this.Controls.Add(this.fileSizeTextBox);
            this.Controls.Add(this.fileSizeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Download Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.TextBox fileSizeTextBox;
        private System.Windows.Forms.Label yourSpeedLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.CheckBox kbCheckBox;
        private System.Windows.Forms.CheckBox mbCheckBox;
        private System.Windows.Forms.CheckBox gbCheckBox;
        private System.Windows.Forms.CheckBox kbpsCheckBox;
        private System.Windows.Forms.CheckBox mbpsCheckBox;
        private System.Windows.Forms.CheckBox gbpsCheckBox;
    }
}

