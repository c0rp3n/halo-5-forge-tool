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
            this.FovInput = new System.Windows.Forms.NumericUpDown();
            this.FovChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).BeginInit();
            this.SuspendLayout();
            // 
            // FovInput
            // 
            this.FovInput.DecimalPlaces = 8;
            this.FovInput.Location = new System.Drawing.Point(13, 13);
            this.FovInput.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.FovInput.Name = "FovInput";
            this.FovInput.Size = new System.Drawing.Size(120, 20);
            this.FovInput.TabIndex = 0;
            // 
            // FovChange
            // 
            this.FovChange.Location = new System.Drawing.Point(13, 40);
            this.FovChange.Name = "FovChange";
            this.FovChange.Size = new System.Drawing.Size(75, 23);
            this.FovChange.TabIndex = 1;
            this.FovChange.Text = "button1";
            this.FovChange.UseVisualStyleBackColor = true;
            this.FovChange.Click += new System.EventHandler(this.FovChange_Click);
            // 
            // H5_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 79);
            this.Controls.Add(this.FovChange);
            this.Controls.Add(this.FovInput);
            this.Name = "H5_Tool";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.FovInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown FovInput;
        private System.Windows.Forms.Button FovChange;
    }
}

