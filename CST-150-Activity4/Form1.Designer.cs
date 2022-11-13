namespace CST_150_Activity4
{
    partial class TimeCalculator
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
            this.TimeInSecondsLabel = new System.Windows.Forms.Label();
            this.elapsedSeconds = new System.Windows.Forms.TextBox();
            this.conversionLabel = new System.Windows.Forms.Label();
            this.conversionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeInSecondsLabel
            // 
            this.TimeInSecondsLabel.AutoSize = true;
            this.TimeInSecondsLabel.Location = new System.Drawing.Point(40, 64);
            this.TimeInSecondsLabel.Name = "TimeInSecondsLabel";
            this.TimeInSecondsLabel.Size = new System.Drawing.Size(250, 25);
            this.TimeInSecondsLabel.TabIndex = 0;
            this.TimeInSecondsLabel.Text = "Elapsed Time (seconds):";
            // 
            // elapsedSeconds
            // 
            this.elapsedSeconds.Location = new System.Drawing.Point(296, 61);
            this.elapsedSeconds.Name = "elapsedSeconds";
            this.elapsedSeconds.Size = new System.Drawing.Size(137, 31);
            this.elapsedSeconds.TabIndex = 1;
            // 
            // conversionLabel
            // 
            this.conversionLabel.AutoSize = true;
            this.conversionLabel.Location = new System.Drawing.Point(40, 200);
            this.conversionLabel.Name = "conversionLabel";
            this.conversionLabel.Size = new System.Drawing.Size(18, 25);
            this.conversionLabel.TabIndex = 2;
            this.conversionLabel.Text = " ";
            this.conversionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conversionButton
            // 
            this.conversionButton.Location = new System.Drawing.Point(174, 131);
            this.conversionButton.Name = "conversionButton";
            this.conversionButton.Size = new System.Drawing.Size(116, 48);
            this.conversionButton.TabIndex = 3;
            this.conversionButton.Text = "Convert";
            this.conversionButton.UseVisualStyleBackColor = true;
            this.conversionButton.Click += new System.EventHandler(this.conversionButton_Click);
            // 
            // TimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 245);
            this.Controls.Add(this.conversionButton);
            this.Controls.Add(this.conversionLabel);
            this.Controls.Add(this.elapsedSeconds);
            this.Controls.Add(this.TimeInSecondsLabel);
            this.Name = "TimeCalculator";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeInSecondsLabel;
        private System.Windows.Forms.TextBox elapsedSeconds;
        private System.Windows.Forms.Label conversionLabel;
        private System.Windows.Forms.Button conversionButton;
    }
}

