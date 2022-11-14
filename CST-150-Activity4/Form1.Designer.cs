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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeCalculator));
            this.TimeInSecondsLabel = new System.Windows.Forms.Label();
            this.elapsedSeconds = new System.Windows.Forms.TextBox();
            this.conversionLabel = new System.Windows.Forms.Label();
            this.conversionButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeInSecondsLabel
            // 
            this.TimeInSecondsLabel.AutoSize = true;
            this.TimeInSecondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TimeInSecondsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TimeInSecondsLabel.Location = new System.Drawing.Point(329, 350);
            this.TimeInSecondsLabel.Name = "TimeInSecondsLabel";
            this.TimeInSecondsLabel.Size = new System.Drawing.Size(461, 46);
            this.TimeInSecondsLabel.TabIndex = 0;
            this.TimeInSecondsLabel.Text = "Elapsed Time (seconds):";
            // 
            // elapsedSeconds
            // 
            this.elapsedSeconds.BackColor = System.Drawing.SystemColors.MenuBar;
            this.elapsedSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.elapsedSeconds.Location = new System.Drawing.Point(810, 347);
            this.elapsedSeconds.Name = "elapsedSeconds";
            this.elapsedSeconds.Size = new System.Drawing.Size(301, 53);
            this.elapsedSeconds.TabIndex = 1;
            // 
            // conversionLabel
            // 
            this.conversionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.conversionLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.conversionLabel.Location = new System.Drawing.Point(221, 699);
            this.conversionLabel.Name = "conversionLabel";
            this.conversionLabel.Size = new System.Drawing.Size(976, 182);
            this.conversionLabel.TabIndex = 2;
            this.conversionLabel.Text = " ";
            this.conversionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // conversionButton
            // 
            this.conversionButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.conversionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.conversionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.conversionButton.ForeColor = System.Drawing.SystemColors.MenuText;
            this.conversionButton.Location = new System.Drawing.Point(544, 566);
            this.conversionButton.Name = "conversionButton";
            this.conversionButton.Size = new System.Drawing.Size(339, 87);
            this.conversionButton.TabIndex = 3;
            this.conversionButton.Text = "CONVERT";
            this.conversionButton.UseVisualStyleBackColor = false;
            this.conversionButton.Click += new System.EventHandler(this.conversionButton_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Lucida Sans Unicode", 25.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.title.Location = new System.Drawing.Point(452, 139);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(559, 81);
            this.title.TabIndex = 4;
            this.title.Text = "Time Calculator";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1446, 956);
            this.Controls.Add(this.title);
            this.Controls.Add(this.conversionButton);
            this.Controls.Add(this.conversionLabel);
            this.Controls.Add(this.elapsedSeconds);
            this.Controls.Add(this.TimeInSecondsLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeInSecondsLabel;
        private System.Windows.Forms.TextBox elapsedSeconds;
        private System.Windows.Forms.Label conversionLabel;
        private System.Windows.Forms.Button conversionButton;
        private System.Windows.Forms.Label title;
    }
}

