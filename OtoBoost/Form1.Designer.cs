namespace OtoBoost
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBar1 = new TrackBar();
            VolLevelLabel = new Label();
            MuteOrRunButton = new Button();
            ResetButton = new Button();
            AutoStartupButton = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 12);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(370, 56);
            trackBar1.TabIndex = 1;
            // 
            // VolLevelLabel
            // 
            VolLevelLabel.AutoSize = true;
            VolLevelLabel.Location = new Point(388, 12);
            VolLevelLabel.Name = "VolLevelLabel";
            VolLevelLabel.Size = new Size(64, 20);
            VolLevelLabel.TabIndex = 2;
            VolLevelLabel.Text = "VolLevel";
            // 
            // MuteOrRunButton
            // 
            MuteOrRunButton.Location = new Point(12, 60);
            MuteOrRunButton.Name = "MuteOrRunButton";
            MuteOrRunButton.Size = new Size(249, 29);
            MuteOrRunButton.TabIndex = 3;
            MuteOrRunButton.Text = "Play - Mute \"Sound\"";
            MuteOrRunButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(267, 60);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(185, 29);
            ResetButton.TabIndex = 4;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            // 
            // AutoStartupButton
            // 
            AutoStartupButton.Location = new Point(139, 95);
            AutoStartupButton.Name = "AutoStartupButton";
            AutoStartupButton.Size = new Size(196, 29);
            AutoStartupButton.TabIndex = 5;
            AutoStartupButton.Text = "Run - Stop Auto Startup";
            AutoStartupButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 148);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 6;
            label1.Text = "© 2025 -";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(212, 148);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Mostafa Mahmoud";
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 177);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(AutoStartupButton);
            Controls.Add(ResetButton);
            Controls.Add(MuteOrRunButton);
            Controls.Add(VolLevelLabel);
            Controls.Add(trackBar1);
            MaximizeBox = false;
            Name = "MainScreen";
            Text = "OutBoost";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TrackBar trackBar1;
        private Label VolLevelLabel;
        private Button MuteOrRunButton;
        private Button ResetButton;
        private Button AutoStartupButton;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
