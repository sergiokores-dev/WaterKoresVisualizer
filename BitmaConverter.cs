using System;
using System.Collections.Generic;
using System.Text;
 using System.Drawing;
namespace WaterKoresVisualizer
{
    

    

public static class BitmapConverter
    {

        // ============================================
        // CONVERTE BITMAP PARA MATRIZ BYTE[][]
        // ============================================

        public static byte[][] ConvertBitmap(Bitmap bmp)
        {
            int width = 40;

            int height =
                (bmp.Height * width) / bmp.Width;

            Bitmap resized =
                new Bitmap(bmp, new Size(width, height));

            byte[][] result =
                new byte[height][];

            // percorre linhas
            for (int y = 0; y < height; y++)
            {
                // 5 bytes por linha
                result[y] = new byte[5];

                // percorre bytes
                for (int byteIndex = 0; byteIndex < 5; byteIndex++)
                {
                    byte value = 0;

                    // percorre bits
                    for (int bit = 0; bit < 8; bit++)
                    {
                        int x = byteIndex * 8 + bit;

                        Color pixel =
                            resized.GetPixel(x, y);

                        int brightness =
                            (pixel.R + pixel.G + pixel.B) / 3;

                        bool isOn =
                            brightness < 128;

                        if (isOn)
                        {
                            value |=
                                (byte)(1 << (7 - bit));
                        }
                    }

                    result[y][byteIndex] = value;
                }
            }

            return result;
        }
    }
}
