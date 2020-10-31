using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;

namespace Pi
{
    class Pi
    {
        private double pi;
        private string temp;
        private string digits;

        public void PiCalc()
        {
            pi = Math.PI;
            temp = pi.ToString();
            digits = temp.Substring(2);
        }

        public void Display()
        {
            Console.WriteLine("Pi: " + pi);
            Console.WriteLine("Digits (after decimal point): " + (digits.Length));
        }

        public void SaveImage()
        {
            string text = temp.Trim();

            Bitmap bmp = new Bitmap(1, 1);

            Font font = new Font("Free 3 of 9", 25, FontStyle.Regular, GraphicsUnit.Pixel);

            Graphics graphics = Graphics.FromImage(bmp);

            int width = (int)graphics.MeasureString(text, font).Width;
            int height = (int)graphics.MeasureString(text, font).Height;

            bmp = new Bitmap(bmp, new Size(width, height));
            graphics = Graphics.FromImage(bmp);

            graphics.Clear(Color.Cyan);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            graphics.DrawString(text, font, new SolidBrush(Color.Black), 0, 0);

            graphics.Flush();
            graphics.Dispose();

            //if you want to save the image  uncomment the below line.
            bmp.Save(@"C:\pi.jpg", ImageFormat.Jpeg);
        }
    }
}
