namespace WallpaperChanger
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textLine = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.startChangerButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.call = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выбрать папку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textLine
            // 
            this.textLine.Enabled = false;
            this.textLine.Location = new System.Drawing.Point(67, 49);
            this.textLine.Name = "textLine";
            this.textLine.Size = new System.Drawing.Size(239, 20);
            this.textLine.TabIndex = 0;
            // 
            // startChangerButton
            // 
            this.startChangerButton.BackgroundImage = global::WallpaperChanger.Properties.Resources.бабуин;
            this.startChangerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startChangerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.startChangerButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startChangerButton.Location = new System.Drawing.Point(67, 104);
            this.startChangerButton.Name = "startChangerButton";
            this.startChangerButton.Size = new System.Drawing.Size(339, 308);
            this.startChangerButton.TabIndex = 2;
            this.startChangerButton.Text = "button2";
            this.startChangerButton.UseVisualStyleBackColor = true;
            this.startChangerButton.Click += new System.EventHandler(this.startChangerButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // call
            // 
            this.call.Enabled = false;
            this.call.Location = new System.Drawing.Point(67, 76);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(339, 20);
            this.call.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 483);
            this.Controls.Add(this.call);
            this.Controls.Add(this.startChangerButton);
            this.Controls.Add(this.textLine);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "WallpaperChanger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textLine;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button startChangerButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox call;
    }
}

