namespace WallpaperChanger
{
    partial class SettingsForm
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
            this.roller = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roller)).BeginInit();
            this.SuspendLayout();
            // 
            // roller
            // 
            this.roller.Location = new System.Drawing.Point(66, 29);
            this.roller.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.roller.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.roller.Name = "roller";
            this.roller.Size = new System.Drawing.Size(160, 20);
            this.roller.TabIndex = 0;
            this.roller.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(66, 166);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(160, 34);
            this.applyButton.TabIndex = 1;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // SettingsForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.roller);
            this.Name = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.roller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown roller;
        private System.Windows.Forms.Button applyButton;
    }
}