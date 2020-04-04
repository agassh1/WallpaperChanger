using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HEIL21
{

    public partial class Form1 : Form
    {
        int i = 0;
        string zaza;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "я даун, потому что нажал кнопку!";
            Button button = (Button)sender;

            button.Enabled = false;

            button.Text = "Серега Гранд-Мастер-Бит";

            this.BackgroundImage = new Bitmap(@"E:\\13.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            button1.Text = "      " + i;
            ++i;
            button1.Enabled = true;

            if (i > 5)
            {
                var mb = MessageBox.Show("люблю бисквит от кровавой женщины", "заебал тварь курить в комнате");
                MessageBox.Show(mb.ToString());

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            var result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                zaza = folderBrowserDialog1.SelectedPath;

                MessageBox.Show(zaza);
            }
            else
            {
                MessageBox.Show("тебе руки отрубить нужно блядина");
            }
        }

        private void folderBrowserDialog1_HelpRequest_2(object sender, EventArgs e)
        {

        }
    }
}
