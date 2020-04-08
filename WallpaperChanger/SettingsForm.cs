﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WallpaperChanger
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            var value = roller.Value;

            MainForm.SetDelay((int)value);

            var result = MessageBox.Show("Значение установлено!", "Оповещение еп");

            if(result == DialogResult.OK)
            {
                this.Hide();
            }
        }
    }
}
