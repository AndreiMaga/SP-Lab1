using MyBook.Interfaces;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;

namespace MyBook.Classes.Printable
{
    public class Image : IPrintable, IPicture
    {
        readonly string mImage;

        private const int mWidth = 80;

        private readonly string[] mSupportedChars = { "#", "#", "@", "%", "=", "+", "*", ":", "-", ".", " " };

        public Image(string image)
        {
            Thread.Sleep(1000);
            mImage = image;
        }
        public void Print()
        {
            Console.WriteLine($"Image with name : {mImage}");

            if (File.Exists(mImage))
            {
                PrintImage();
                return;
            }
        }

        private void PrintImage()
        {
            Console.WriteLine(ConvertToAscii(GetReSizedImage((Bitmap)Bitmap.FromFile(mImage), mWidth)));
        }

        private Bitmap GetReSizedImage(Bitmap inputBitmap, int asciiWidth)
        {
            int asciiHeight = (int)Math.Ceiling((double)inputBitmap.Height * asciiWidth / inputBitmap.Width);
            Bitmap result = new Bitmap(asciiWidth, asciiHeight);
            Graphics g = Graphics.FromImage(result);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            g.DrawImage(inputBitmap, 0, 0, asciiWidth, asciiHeight);
            g.Dispose();
            return result;
        }

        private string ConvertToAscii(Bitmap image)
        {
            bool toggle = false;
            StringBuilder sb = new StringBuilder();
            for (int h = 0; h < image.Height; h++)
            {
                for (int w = 0; w < image.Width; w++)
                {
                    Color pixelColor = image.GetPixel(w, h);
                    int red = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int green = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    int blue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color grayColor = Color.FromArgb(red, green, blue);
                    if (!toggle)
                    {
                        int index = (grayColor.R * 10) / 255;
                        sb.Append(mSupportedChars[index]);
                    }
                }

                if (!toggle)
                {
                    sb.Append(Environment.NewLine);
                    toggle = true;
                }
                else
                {
                    toggle = false;
                }
            }

            return sb.ToString();
        }

        public IPrintable Add(IPrintable printable)
        {
            throw new NotImplementedException();
        }

        public void Remove(IPrintable printable)
        {
            throw new NotImplementedException();
        }

        public IPrintable Get(int index)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            return new Image(mImage);
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Render()
        {
            Print(); // nothing different, Image has no "childs"
        }
    }
}
