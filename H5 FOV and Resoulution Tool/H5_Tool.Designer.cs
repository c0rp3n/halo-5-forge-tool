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
            this.ResToolBox = new System.Windows.Forms.GroupBox();
            this.TutorialMapChangerBox = new System.Windows.Forms.GroupBox();
            this.ResInput = new System.Windows.Forms.NumericUpDown();
            this.ResChange = new System.Windows.Forms.Button();
            this.TutorialMapChangerMaps = new System.Windows.Forms.ComboBox();
            this.TutorialMapChangerChange = new System.Windows.Forms.Button();
            this.FovTrackBar = new System.Windows.Forms.TrackBar();
            this.ResTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).BeginInit();
            this.FovToolBox.SuspendLayout();
            this.ResToolBox.SuspendLayout();
            this.TutorialMapChangerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResTrackBar)).BeginInit();
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
            // TutorialMapChangerMaps
            // 
            this.TutorialMapChangerMaps.FormattingEnabled = true;
            this.TutorialMapChangerMaps.Location = new System.Drawing.Point(7, 20);
            this.TutorialMapChangerMaps.Name = "TutorialMapChangerMaps";
            this.TutorialMapChangerMaps.Size = new System.Drawing.Size(354, 21);
            this.TutorialMapChangerMaps.TabIndex = 0;
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
            // FovTrackBar
            // 
            this.FovTrackBar.Location = new System.Drawing.Point(135, 19);
            this.FovTrackBar.Name = "FovTrackBar";
            this.FovTrackBar.Size = new System.Drawing.Size(226, 45);
            this.FovTrackBar.TabIndex = 2;
            this.FovTrackBar.Scroll += new System.EventHandler(this.FovTrackBarScroll);
            // 
            // ResTrackBar
            // 
            this.ResTrackBar.Location = new System.Drawing.Point(135, 20);
            this.ResTrackBar.Name = "ResTrackBar";
            this.ResTrackBar.Size = new System.Drawing.Size(226, 45);
            this.ResTrackBar.TabIndex = 2;
            this.ResTrackBar.MouseCaptureChanged += new System.EventHandler(this.ResTrackBarScroll);
            // 
            // H5_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 270);
            this.Controls.Add(this.TutorialMapChangerBox);
            this.Controls.Add(this.ResToolBox);
            this.Controls.Add(this.FovToolBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "H5_Tool";
            this.Text = "FOV & RES Tool";
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).EndInit();
            this.FovToolBox.ResumeLayout(false);
            this.FovToolBox.PerformLayout();
            this.ResToolBox.ResumeLayout(false);
            this.ResToolBox.PerformLayout();
            this.TutorialMapChangerBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FovTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResTrackBar)).EndInit();
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
    }
}

