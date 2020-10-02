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
            string str = "iPhone_Launch_Image_";
            FixedSize(pictureBox1.Image, 320, 480).Save(str + "320_480.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 640, 960).Save(str + "640_960.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 640, 1136).Save(str + "640_1136.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 750, 1334).Save(str + "750_1334.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1242, 2208).Save(str + "1242_2208.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2208, 1242).Save(str + "2208_1242.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1136, 640).Save(str + "1136_640.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1134, 750).Save(str + "1134_750.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 828, 1792).Save(str + "828_1792.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1334, 750).Save(str + "1334_750.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1792, 828).Save(str + "1792_828.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1125, 2436).Save(str + "1125_2436.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2436, 1125).Save(str + "2436_1125.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1242, 2688).Save(str + "1242_2688.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2688, 1242).Save(str + "2688_1242.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate splashes - Android
            str = "Android_Splash_Image_";
            FixedSize(pictureBox1.Image, 426, 320).Save(str + "426_320.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 470, 320).Save(str + "470_320.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 640, 480).Save(str + "640_480.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 960, 720).Save(str + "960_720.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate splashes - iPad
            str = "iPad_Launch_Image_";
            FixedSize(pictureBox1.Image, 768, 1004).Save(str + "768_1004.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 768, 1024).Save(str + "768_1024.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1024, 748).Save(str + "1024_748.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1024, 768).Save(str + "1024_768.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1536, 2008).Save(str + "1536_2008.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1536, 2048).Save(str + "1536_2048.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1668, 2224).Save(str + "1668_2224.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 1668, 2388).Save(str + "1668_2388.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2048, 1496).Save(str + "2048_1496.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2048, 1536).Save(str + "2048_1536.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2048, 2732).Save(str + "2048_2732.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2224, 1668).Save(str + "2224_1668.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2388, 1668).Save(str + "2388_1668.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox1.Image, 2732, 2048).Save(str + "2732_2048.png", System.Drawing.Imaging.ImageFormat.Png);
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
            string str = "iPhone_Application_Icon_";
            FixedSize(pictureBox2.Image, 57, 57).Save(str + "57_57.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 60, 60).Save(str + "60_60.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 87, 87).Save(str + "87_87.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 114, 114).Save(str + "114_114.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 120, 120).Save(str + "120_120.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 180, 180).Save(str + "180_180.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 1024, 1024).Save(str + "1024_1024.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate launch image
            FixedSize(pictureBox2.Image, 120, 120).Save(str + "Any_2x.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 120, 120).Save(str + "Dark_2x.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 120, 120).Save(str + "Any_3x.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 120, 120).Save(str + "Dark_2x.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate spotlight search icons
            str = "iPhone_Spotlight_Icon_";
            FixedSize(pictureBox2.Image, 29, 29).Save(str + "29_29.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 40, 40).Save(str + "40_40.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 58, 58).Save(str + "58_58.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 80, 80).Save(str + "80_80.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 120, 120).Save(str + "120_120.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate android launch icons
            str = "Android_Launcher_Icon_";
            FixedSize(pictureBox2.Image, 36, 36).Save(str + "36_36.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 48, 48).Save(str + "48_48.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 72, 72).Save(str + "72_72.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 96, 96).Save(str + "96_96.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 144, 144).Save(str + "144_144.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate iPad application icons
            str = "iPad_Application_Icon_";
            FixedSize(pictureBox2.Image, 72, 72).Save(str + "72_72.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 76, 76).Save(str + "76_76.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 144, 144).Save(str + "144_144.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 152, 152).Save(str + "152_152.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 167, 167).Save(str + "167_167.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate iPad spotlight search icons
            str = "iPad_Spotlight_Icon_";
            FixedSize(pictureBox2.Image, 40, 40).Save(str + "40_40.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 50, 50).Save(str + "50_50.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 80, 80).Save(str + "80_80.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 100, 100).Save(str + "100_100.png", System.Drawing.Imaging.ImageFormat.Png);
            //generate iPad spotlight search icons
            str = "iPad_Setting_Icon_";
            FixedSize(pictureBox2.Image, 29, 29).Save(str + "29_29.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 58, 58).Save(str + "58_58.png", System.Drawing.Imaging.ImageFormat.Png);

            //generate website icons for Apple Self Hosted Enterprise Applications
            str = "Website_Icon_";
            FixedSize(pictureBox2.Image, 57, 57).Save(str + "57_57.png", System.Drawing.Imaging.ImageFormat.Png);
            FixedSize(pictureBox2.Image, 512, 512).Save(str + "512_512.png", System.Drawing.Imaging.ImageFormat.Png);

            //generate traditional windows 32x32, etc icon
            str = "Microsoft_Windows_Icon_";
            FixedSize(pictureBox2.Image, 16, 16).Save(str + "16_16.ico", System.Drawing.Imaging.ImageFormat.Icon);
            FixedSize(pictureBox2.Image, 24, 24).Save(str + "24_24.ico", System.Drawing.Imaging.ImageFormat.Icon);
            FixedSize(pictureBox2.Image, 32, 32).Save(str + "32_32.ico", System.Drawing.Imaging.ImageFormat.Icon);
            FixedSize(pictureBox2.Image, 96, 96).Save(str + "96_96.ico", System.Drawing.Imaging.ImageFormat.Icon);
        }
    }
}
