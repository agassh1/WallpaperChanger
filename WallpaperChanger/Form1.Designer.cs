﻿namespace WallpaperChanger
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.textLine = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.call = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.startchargedelay = new System.Windows.Forms.Button();
            this.startChangerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 58);
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
            this.textLine.Location = new System.Drawing.Point(72, 60);
            this.textLine.Name = "textLine";
            this.textLine.Size = new System.Drawing.Size(239, 20);
            this.textLine.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // call
            // 
            this.call.Enabled = false;
            this.call.Location = new System.Drawing.Point(72, 89);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(339, 20);
            this.call.TabIndex = 3;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // startchargedelay
            // 
            this.startchargedelay.Location = new System.Drawing.Point(72, 429);
            this.startchargedelay.Name = "startchargedelay";
            this.startchargedelay.Size = new System.Drawing.Size(339, 54);
            this.startchargedelay.TabIndex = 4;
            this.startchargedelay.Text = "ChangeDef";
            this.startchargedelay.UseVisualStyleBackColor = true;
            this.startchargedelay.Click += new System.EventHandler(this.startchargedelay_Click);
            // 
            // startChangerButton
            // 
            this.startChangerButton.BackgroundImage = global::WallpaperChanger.Properties.Resources.бабуин;
            this.startChangerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startChangerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.startChangerButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startChangerButton.Location = new System.Drawing.Point(72, 115);
            this.startChangerButton.Name = "startChangerButton";
            this.startChangerButton.Size = new System.Drawing.Size(339, 308);
            this.startChangerButton.TabIndex = 2;
            this.startChangerButton.Text = "button2";
            this.startChangerButton.UseVisualStyleBackColor = true;
            this.startChangerButton.Click += new System.EventHandler(this.startChangerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 495);
            this.Controls.Add(this.startchargedelay);
            this.Controls.Add(this.call);
            this.Controls.Add(this.startChangerButton);
            this.Controls.Add(this.textLine);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(484, 533);
            this.MinimumSize = new System.Drawing.Size(484, 533);
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
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button startchargedelay;
    }
}

