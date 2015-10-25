namespace minoanquest
{
    partial class Form1
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStepLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusPlayLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusSpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSpeed2 = new System.Windows.Forms.Button();
            this.btnSpeed3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStepLabel,
            this.statusPlayLabel,
            this.statusSpeedLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 240);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // statusStepLabel
            // 
            this.statusStepLabel.Name = "statusStepLabel";
            this.statusStepLabel.Size = new System.Drawing.Size(38, 17);
            this.statusStepLabel.Text = "Steps:";
            // 
            // statusPlayLabel
            // 
            this.statusPlayLabel.Name = "statusPlayLabel";
            this.statusPlayLabel.Size = new System.Drawing.Size(45, 17);
            this.statusPlayLabel.Text = "Paused";
            // 
            // statusSpeedLabel
            // 
            this.statusSpeedLabel.Name = "statusSpeedLabel";
            this.statusSpeedLabel.Size = new System.Drawing.Size(18, 17);
            this.statusSpeedLabel.Text = "x1";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(95, 214);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = ">";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSpeed2
            // 
            this.btnSpeed2.Location = new System.Drawing.Point(176, 214);
            this.btnSpeed2.Name = "btnSpeed2";
            this.btnSpeed2.Size = new System.Drawing.Size(45, 23);
            this.btnSpeed2.TabIndex = 2;
            this.btnSpeed2.Text = ">>";
            this.btnSpeed2.UseVisualStyleBackColor = true;
            this.btnSpeed2.Click += new System.EventHandler(this.btnSpeed2_Click);
            // 
            // btnSpeed3
            // 
            this.btnSpeed3.Location = new System.Drawing.Point(227, 214);
            this.btnSpeed3.Name = "btnSpeed3";
            this.btnSpeed3.Size = new System.Drawing.Size(45, 23);
            this.btnSpeed3.TabIndex = 3;
            this.btnSpeed3.Text = ">>>";
            this.btnSpeed3.UseVisualStyleBackColor = true;
            this.btnSpeed3.Click += new System.EventHandler(this.btnSpeed3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Birth Mob";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSpeed3);
            this.Controls.Add(this.btnSpeed2);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.statusStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.StatusStrip statusStrip;
        internal System.Windows.Forms.ToolStripStatusLabel statusStepLabel;
        internal System.Windows.Forms.ToolStripStatusLabel statusPlayLabel;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ToolStripStatusLabel statusSpeedLabel;
        private System.Windows.Forms.Button btnSpeed2;
        private System.Windows.Forms.Button btnSpeed3;
        private System.Windows.Forms.Button button1;
    }
}

