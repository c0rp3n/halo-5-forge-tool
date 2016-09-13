namespace H5_FOV_and_Resoulution_Tool
{
    partial class H5_Tool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H5_Tool));
            this.FovInput = new System.Windows.Forms.NumericUpDown();
            this.FovChange = new System.Windows.Forms.Button();
            this.FovToolBox = new System.Windows.Forms.GroupBox();
            this.FovTrackBar = new System.Windows.Forms.TrackBar();
            this.ResToolBox = new System.Windows.Forms.GroupBox();
            this.ResTrackBar = new System.Windows.Forms.TrackBar();
            this.ResChange = new System.Windows.Forms.Button();
            this.ResInput = new System.Windows.Forms.NumericUpDown();
            this.TutorialMapChangerBox = new System.Windows.Forms.GroupBox();
            this.TutorialMapChangerChange = new System.Windows.Forms.Button();
            this.TutorialMapChangerMaps = new System.Windows.Forms.ComboBox();
            this.FpsToolBox = new System.Windows.Forms.GroupBox();
            this.FPSInput = new System.Windows.Forms.NumericUpDown();
            this.FPSTrackBar = new System.Windows.Forms.TrackBar();
            this.FPSChange = new System.Windows.Forms.Button();
            this.H5Launcher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).BeginInit();
            this.FovToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FovTrackBar)).BeginInit();
            this.ResToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResInput)).BeginInit();
            this.TutorialMapChangerBox.SuspendLayout();
            this.FpsToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FPSInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPSTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // FovInput
            // 
            this.FovInput.DecimalPlaces = 8;
            this.FovInput.Location = new System.Drawing.Point(6, 19);
            this.FovInput.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.FovInput.Name = "FovInput";
            this.FovInput.Size = new System.Drawing.Size(122, 20);
            this.FovInput.TabIndex = 0;
            // 
            // FovChange
            // 
            this.FovChange.Location = new System.Drawing.Point(6, 45);
            this.FovChange.Name = "FovChange";
            this.FovChange.Size = new System.Drawing.Size(120, 23);
            this.FovChange.TabIndex = 1;
            this.FovChange.Text = "Change FOV";
            this.FovChange.UseVisualStyleBackColor = true;
            this.FovChange.Click += new System.EventHandler(this.FovChange_Click);
            // 
            // FovToolBox
            // 
            this.FovToolBox.Controls.Add(this.FovTrackBar);
            this.FovToolBox.Controls.Add(this.FovInput);
            this.FovToolBox.Controls.Add(this.FovChange);
            this.FovToolBox.Location = new System.Drawing.Point(12, 12);
            this.FovToolBox.Name = "FovToolBox";
            this.FovToolBox.Size = new System.Drawing.Size(367, 74);
            this.FovToolBox.TabIndex = 2;
            this.FovToolBox.TabStop = false;
            this.FovToolBox.Text = "FOV Tool";
            // 
            // FovTrackBar
            // 
            this.FovTrackBar.Location = new System.Drawing.Point(135, 19);
            this.FovTrackBar.Name = "FovTrackBar";
            this.FovTrackBar.Size = new System.Drawing.Size(226, 45);
            this.FovTrackBar.TabIndex = 2;
            this.FovTrackBar.Scroll += new System.EventHandler(this.FovTrackBarScroll);
            // 
            // ResToolBox
            // 
            this.ResToolBox.Controls.Add(this.ResTrackBar);
            this.ResToolBox.Controls.Add(this.ResChange);
            this.ResToolBox.Controls.Add(this.ResInput);
            this.ResToolBox.Location = new System.Drawing.Point(12, 93);
            this.ResToolBox.Name = "ResToolBox";
            this.ResToolBox.Size = new System.Drawing.Size(367, 80);
            this.ResToolBox.TabIndex = 3;
            this.ResToolBox.TabStop = false;
            this.ResToolBox.Text = "Res Tool";
            // 
            // ResTrackBar
            // 
            this.ResTrackBar.Location = new System.Drawing.Point(135, 20);
            this.ResTrackBar.Name = "ResTrackBar";
            this.ResTrackBar.Size = new System.Drawing.Size(226, 45);
            this.ResTrackBar.TabIndex = 2;
            this.ResTrackBar.MouseCaptureChanged += new System.EventHandler(this.ResTrackBarScroll);
            // 
            // ResChange
            // 
            this.ResChange.Location = new System.Drawing.Point(7, 47);
            this.ResChange.Name = "ResChange";
            this.ResChange.Size = new System.Drawing.Size(120, 23);
            this.ResChange.TabIndex = 1;
            this.ResChange.Text = "Change Res";
            this.ResChange.UseVisualStyleBackColor = true;
            this.ResChange.Click += new System.EventHandler(this.ResChange_Click);
            // 
            // ResInput
            // 
            this.ResInput.Increment = new decimal(new int[] {
            840,
            0,
            0,
            0});
            this.ResInput.Location = new System.Drawing.Point(7, 20);
            this.ResInput.Maximum = new decimal(new int[] {
            7680,
            0,
            0,
            0});
            this.ResInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ResInput.Name = "ResInput";
            this.ResInput.Size = new System.Drawing.Size(120, 20);
            this.ResInput.TabIndex = 0;
            this.ResInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TutorialMapChangerBox
            // 
            this.TutorialMapChangerBox.Controls.Add(this.TutorialMapChangerChange);
            this.TutorialMapChangerBox.Controls.Add(this.TutorialMapChangerMaps);
            this.TutorialMapChangerBox.Location = new System.Drawing.Point(12, 179);
            this.TutorialMapChangerBox.Name = "TutorialMapChangerBox";
            this.TutorialMapChangerBox.Size = new System.Drawing.Size(367, 81);
            this.TutorialMapChangerBox.TabIndex = 4;
            this.TutorialMapChangerBox.TabStop = false;
            this.TutorialMapChangerBox.Text = "Tutorial map changer";
            // 
            // TutorialMapChangerChange
            // 
            this.TutorialMapChangerChange.Location = new System.Drawing.Point(7, 48);
            this.TutorialMapChangerChange.Name = "TutorialMapChangerChange";
            this.TutorialMapChangerChange.Size = new System.Drawing.Size(121, 23);
            this.TutorialMapChangerChange.TabIndex = 1;
            this.TutorialMapChangerChange.Text = "Change Map";
            this.TutorialMapChangerChange.UseVisualStyleBackColor = true;
            this.TutorialMapChangerChange.Click += new System.EventHandler(this.TutorialMapChangerChange_Click);
            // 
            // TutorialMapChangerMaps
            // 
            this.TutorialMapChangerMaps.FormattingEnabled = true;
            this.TutorialMapChangerMaps.Location = new System.Drawing.Point(7, 20);
            this.TutorialMapChangerMaps.Name = "TutorialMapChangerMaps";
            this.TutorialMapChangerMaps.Size = new System.Drawing.Size(354, 21);
            this.TutorialMapChangerMaps.TabIndex = 0;
            // 
            // FpsToolBox
            // 
            this.FpsToolBox.Controls.Add(this.FPSChange);
            this.FpsToolBox.Controls.Add(this.FPSTrackBar);
            this.FpsToolBox.Controls.Add(this.FPSInput);
            this.FpsToolBox.Location = new System.Drawing.Point(386, 13);
            this.FpsToolBox.Name = "FpsToolBox";
            this.FpsToolBox.Size = new System.Drawing.Size(374, 73);
            this.FpsToolBox.TabIndex = 5;
            this.FpsToolBox.TabStop = false;
            this.FpsToolBox.Text = "FPS Tool";
            // 
            // FPSInput
            // 
            this.FPSInput.Location = new System.Drawing.Point(6, 19);
            this.FPSInput.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.FPSInput.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.FPSInput.Name = "FPSInput";
            this.FPSInput.Size = new System.Drawing.Size(120, 20);
            this.FPSInput.TabIndex = 6;
            this.FPSInput.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // FPSTrackBar
            // 
            this.FPSTrackBar.Location = new System.Drawing.Point(132, 19);
            this.FPSTrackBar.Name = "FPSTrackBar";
            this.FPSTrackBar.Size = new System.Drawing.Size(226, 45);
            this.FPSTrackBar.TabIndex = 3;
            // 
            // FPSChange
            // 
            this.FPSChange.Location = new System.Drawing.Point(6, 45);
            this.FPSChange.Name = "FPSChange";
            this.FPSChange.Size = new System.Drawing.Size(120, 23);
            this.FPSChange.TabIndex = 7;
            this.FPSChange.Text = "Change FPS";
            this.FPSChange.UseVisualStyleBackColor = true;
            this.FPSChange.Click += new System.EventHandler(this.FPSChange_Click);
            // 
            // H5Launcher
            // 
            this.H5Launcher.Location = new System.Drawing.Point(386, 237);
            this.H5Launcher.Name = "H5Launcher";
            this.H5Launcher.Size = new System.Drawing.Size(374, 23);
            this.H5Launcher.TabIndex = 6;
            this.H5Launcher.Text = "Launch Halo 5: Forge";
            this.H5Launcher.UseVisualStyleBackColor = true;
            this.H5Launcher.Click += new System.EventHandler(this.H5Launcher_Click);
            // 
            // H5_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 270);
            this.Controls.Add(this.H5Launcher);
            this.Controls.Add(this.FpsToolBox);
            this.Controls.Add(this.TutorialMapChangerBox);
            this.Controls.Add(this.ResToolBox);
            this.Controls.Add(this.FovToolBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "H5_Tool";
            this.Text = "FOV & RES Tool";
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).EndInit();
            this.FovToolBox.ResumeLayout(false);
            this.FovToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FovTrackBar)).EndInit();
            this.ResToolBox.ResumeLayout(false);
            this.ResToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResInput)).EndInit();
            this.TutorialMapChangerBox.ResumeLayout(false);
            this.FpsToolBox.ResumeLayout(false);
            this.FpsToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FPSInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FPSTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown FovInput;
        private System.Windows.Forms.Button FovChange;
        private System.Windows.Forms.GroupBox FovToolBox;
        private System.Windows.Forms.GroupBox ResToolBox;
        private System.Windows.Forms.Button ResChange;
        private System.Windows.Forms.NumericUpDown ResInput;
        private System.Windows.Forms.GroupBox TutorialMapChangerBox;
        private System.Windows.Forms.Button TutorialMapChangerChange;
        private System.Windows.Forms.ComboBox TutorialMapChangerMaps;
        private System.Windows.Forms.TrackBar FovTrackBar;
        private System.Windows.Forms.TrackBar ResTrackBar;
        private System.Windows.Forms.GroupBox FpsToolBox;
        private System.Windows.Forms.Button FPSChange;
        private System.Windows.Forms.TrackBar FPSTrackBar;
        private System.Windows.Forms.NumericUpDown FPSInput;
        private System.Windows.Forms.Button H5Launcher;
    }
}

