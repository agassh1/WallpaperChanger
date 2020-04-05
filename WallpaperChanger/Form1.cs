using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using System.IO;

using System.Timers;
using System.Text.RegularExpressions;

namespace WallpaperChanger
{
    using TMR = System.Timers.Timer;
    public partial class MainForm : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int SystemParametersInfo(int uAction, int uParam, IntPtr lpvParam, int fuWinIni);
        public const int SPI_SETDESKWALLPAPER = 20;
            public const int SPIF_UPDATEINIFILE = 0x1;
            public const int SPIF_SENDWININICHANGE = 0x2;

        string folderPath = "";
        string currentImageFilePath = "";

        List<string> imageFiles = new List<string>();

        static int Seed = DateTime.Now.Minute * DateTime.Now.Second;

        TMR timer = new TMR(1000);

        Random randomTimer = new Random(Seed * DateTime.Now.Hour);
        Random randomImaging = new Random(Seed);

        void TimerFunc(object sender, EventArgs e)
        {
            CheckFolder();
            int currID = randomImaging.Next(0, imageFiles.Count());
            int nextDelay = randomTimer.Next(10000, 60000);

            string imageFile = imageFiles[currID];
            
            ChangeWallpaper(imageFile);
            timer.Interval = nextDelay;

            call.Text = $"Delay = {nextDelay} ID = {currID} : {imageFile}";
        }

        int ChangeWallpaper(string currImagePath)
        {
            
            if (File.Exists(currImagePath))
            {
                return SystemParametersInfo(
                        SPI_SETDESKWALLPAPER, 
                        1, 
                        Marshal.StringToBSTR(currImagePath), 
                        SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE
                    );
            }
            return 0x02;
        }

        public MainForm()
        {
            InitializeComponent();

            notifyIcon1.Visible = false;
            notifyIcon1.Text = this.Text;

            timer.Elapsed += TimerFunc;
            this.Resize += MainForm_Resized;
        }

        private void MainForm_Minimized()
        {
            this.Hide();
            notifyIcon1.Visible = true;

        }

        private void MainForm_Resized(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                MainForm_Minimized();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            textLine.Text = folderPath = folderBrowserDialog1.SelectedPath;
        }

        void CheckFolder()
        {
            if (!Directory.Exists(folderPath))
            {
                timer.Enabled = false;
                MessageBox.Show("Папки не сущевствует, гнидосина!", "Чмо");
                textLine.Text = "";
            } else
            {
                DirectoryInfo dir = new DirectoryInfo(folderPath);

                FileInfo[] files = dir.GetFiles();

                string outFilesList = "";

                foreach (FileInfo file in files)
                {
                    string fileFullName = file.FullName;
                    if (Regex.IsMatch(fileFullName, @"\.(jpg|png|bmp)$"))
                    {
                        outFilesList += fileFullName + "\n";
                        imageFiles.Add(fileFullName);
                    }

                }

                //MessageBox.Show(outFilesList);
            }
        }

        private void startChangerButton_Click(object sender, EventArgs e)
        {
            if(folderPath.Length == 0)
            {
                MessageBox.Show("Ты че даун, папка не выбрана!", "Ну ты дибил!");
                return;
            }
            timer.Enabled = !timer.Enabled;
            MessageBox.Show(timer.Enabled ? "таймер активирован!" : "таймер выключен!");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
