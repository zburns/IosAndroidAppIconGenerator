using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IosAndroidAppIconGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string splash = String.Empty;
        string icon = String.Empty;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.DefaultExt = ".png";
            of.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (of.ShowDialog() == DialogResult.OK)
            {
                splash = of.FileName;
                pictureBox1.Image = System.Drawing.Bitmap.FromFile(of.FileName);
            }
            else
            {
                splash = String.Empty;
                pictureBox1.Image = null;
            }
            of.Dispose();
            of = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.DefaultExt = ".png";
            of.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (of.ShowDialog() == DialogResult.OK)
            {
                icon = of.FileName;
                pictureBox2.Image = System.Drawing.Bitmap.FromFile(of.FileName);
            }
            else
            {
                icon = String.Empty;
                pictureBox2.Image = null;
            }
            of.Dispose();
            of = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //generate splashes - iPhone
            FixedSize(pictureBox1.Image, 320, 480).Save("iPhone_Launch_Image_320_480.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 640, 960).Save("iPhone_Launch_Image_640_960.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 640, 1136).Save("iPhone_Launch_Image_640_1136.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 750, 1334).Save("iPhone_Launch_Image_750_1334.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1242, 2208).Save("iPhone_Launch_Image_1242_2208.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2208, 1242).Save("iPhone_Launch_Image_2208_1242.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate splashes - Android
            FixedSize(pictureBox1.Image, 426, 320).Save("Android_Splash_Image_426_320.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 470, 320).Save("Android_Splash_Image_470_320.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 640, 480).Save("Android_Splash_Image_640_480.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 960, 720).Save("Android_Splash_Image_960_720.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate splashes - iPad
            FixedSize(pictureBox1.Image, 768, 1004).Save("iPad_Launch_Image_768_1004.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 768, 1024).Save("iPad_Launch_Image_768_1024.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1024, 748).Save("iPad_Launch_Image_1024_748.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1024, 768).Save("iPad_Launch_Image_1024_768.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1536, 2008).Save("iPad_Launch_Image_1536_2008.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1536, 2048).Save("iPad_Launch_Image_1536_2048.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2048, 1496).Save("iPad_Launch_Image_2048_1496.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2048, 1536).Save("iPad_Launch_Image_2048_1536.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private static Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;

            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width - (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height - (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            grPhoto.Clear(Color.FromArgb(0, 0, 0, 0));
            grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, destWidth, destHeight), new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //generate application icons
            FixedSize(pictureBox2.Image, 57, 57).Save("iPhone_Application_Icon_57_57.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 60, 60).Save("iPhone_Application_Icon_60_60.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 87, 87).Save("iPhone_Application_Icon_87_87.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 114, 114).Save("iPhone_Application_Icon_114_114.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 120, 120).Save("iPhone_Application_Icon_120_120.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 180, 180).Save("iPhone_Application_Icon_180_180.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate spotlight search icons
            FixedSize(pictureBox2.Image, 29, 29).Save("iPhone_Spotlight_Icon_29_29.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 40, 40).Save("iPhone_Spotlight_Icon_40_40.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 58, 58).Save("iPhone_Spotlight_Icon_58_58.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 80, 80).Save("iPhone_Spotlight_Icon_80_80.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate android launch icons
            FixedSize(pictureBox2.Image, 36, 36).Save("Android_Launcher_Icon_36_36.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 48, 48).Save("Android_Launcher_Icon_48_48.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 72, 72).Save("Android_Launcher_Icon_72_72.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 96, 96).Save("Android_Launcher_Icon_96_96.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 144, 144).Save("Android_Launcher_Icon_144_144.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate iPad application icons
            FixedSize(pictureBox2.Image, 72, 72).Save("iPad_Application_Icon_72_72.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 76, 76).Save("iPad_Application_Icon_76_76.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 144, 144).Save("iPad_Application_Icon_144_144.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 152, 152).Save("iPad_Application_Icon_152_152.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate iPad spotlight search icons
            FixedSize(pictureBox2.Image, 40, 40).Save("iPad_Spotlight_Icon_40_40.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 50, 50).Save("iPad_Spotlight_Icon_50_50.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 80, 80).Save("iPad_Spotlight_Icon_80_80.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 100, 100).Save("iPad_Spotlight_Icon_100_100.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate iPad spotlight search icons
            FixedSize(pictureBox2.Image, 29, 29).Save("iPad_Setting_Icon_29_29.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 58, 58).Save("iPad_Setting_Icon_58_58.png", System.Drawing.Imaging.ImageFormat.Png);

            //generate website icons for Apple Self Hosted Enterprise Applications
            FixedSize(pictureBox2.Image, 57, 57).Save("Website_Icon_57_57.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 512, 512).Save("Website_Icon_512_512.png", System.Drawing.Imaging.ImageFormat.Png);

            //generate traditional windows 32x32, etc icon
            FixedSize(pictureBox2.Image, 16, 16).Save("Microsoft_Windows_Icon_16_16.ico", System.Drawing.Imaging.ImageFormat.Icon);
            FixedSize(pictureBox2.Image, 24, 24).Save("Microsoft_Windows_Icon_24_24.ico", System.Drawing.Imaging.ImageFormat.Icon);
            FixedSize(pictureBox2.Image, 32, 32).Save("Microsoft_Windows_Icon_32_32.ico", System.Drawing.Imaging.ImageFormat.Icon);
            FixedSize(pictureBox2.Image, 96, 96).Save("Microsoft_Windows_Icon_96_96.ico", System.Drawing.Imaging.ImageFormat.Icon);
        }
    }
}
