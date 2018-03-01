using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStudio
{
    static class ImageEffects
    {
        #region Strumenti

        // converte in bitmap argb a 32bit
        public static Bitmap GetBitmap(Image img)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bmp))
            {
                graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }

            return bmp;
        }

        #endregion

        #region Effetti

        public static Bitmap Grayscale(Image img)
        {
            Bitmap bmp = GetBitmap(img);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmp.Height];
            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            float rgb = 0;

            for (int i = 0; i < byteBuffer.Length; i += 4)
            {
                rgb = byteBuffer[i] * 0.11f;       
                rgb += byteBuffer[i + 1] * 0.59f;
                rgb += byteBuffer[i + 2] * 0.3f;

                byteBuffer[i] = (byte)rgb;
                byteBuffer[i + 1] = byteBuffer[i];
                byteBuffer[i + 2] = byteBuffer[i];

                byteBuffer[i + 3] = 255;
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmp.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmp;
        }

        public static Bitmap Negative(Image img)
        {
            Bitmap bmp = GetBitmap(img);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, img.Width, img.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmp.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);
            byte[] pixelBuffer = null;

            int pixel = 0;

            for (int i = 0; i < byteBuffer.Length; i += 4)
            {
                pixel = ~BitConverter.ToInt32(byteBuffer, i);
                pixelBuffer = BitConverter.GetBytes(pixel);

                byteBuffer[i] = pixelBuffer[0];
                byteBuffer[i + 1] = pixelBuffer[1];
                byteBuffer[i + 2] = pixelBuffer[2];
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmp.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmp;
        }

        public static Bitmap Contrast(Image img, int value)
        {
            Bitmap bmp = GetBitmap(img);
            BitmapData sourceData = bmp.LockBits(new Rectangle(0, 0,
                                        bmp.Width, bmp.Height),
                                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            bmp.UnlockBits(sourceData);

            double contrastLevel = Math.Pow((100.0 + value) / 100.0, 2);

            double red = 0;
            double green = 0;
            double blue = 0;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) * contrastLevel) + 0.5) * 255.0;

                green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) * contrastLevel) + 0.5) * 255.0;

                blue = ((((pixelBuffer[k] / 255.0) - 0.5) * contrastLevel) + 0.5) * 255.0;

                if (red > 255)
                    red = 255;
                else if (red < 0)
                    red = 0;

                if (green > 255)
                    green = 255;
                else if (green < 0)
                    green = 0;

                if (blue > 255)
                    blue = 255; 
                else if (blue < 0)
                    blue = 0; 
                
                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }

            Bitmap resultBitmap = new Bitmap(bmp.Width, bmp.Height);
            
            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        public static Bitmap Brightness(Image img, int value)
        {
            Bitmap bmp = GetBitmap(img);
            BitmapData sourceData = bmp.LockBits(new Rectangle(0, 0,
                                        bmp.Width, bmp.Height),
                                        ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

            bmp.UnlockBits(sourceData);

            double red;
            double green;
            double blue;

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                red = (pixelBuffer[k] * 100) / value;

                green = (pixelBuffer[k + 1] * 100) / value;

                blue = (pixelBuffer[k + 2] * value) / value;

                if (red > 255)
                    red = 255;
                else if (red < 0)
                    red = 0;

                if (green > 255)
                    green = 255;
                else if (green < 0)
                    green = 0;

                if (blue > 255)
                    blue = 255;
                else if (blue < 0)
                    blue = 0;

                pixelBuffer[k] = (byte)blue;
                pixelBuffer[k + 1] = (byte)green;
                pixelBuffer[k + 2] = (byte)red;
            }

            Bitmap resultBitmap = new Bitmap(bmp.Width, bmp.Height);

            BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                        resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(resultData);

            return resultBitmap;
        }

        #endregion
    }
}
