using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Proccessing_BAsic
{
    class Method
    {
        public Method()
        {

        }

        public static bool ConvertToGray(Bitmap b)
        {

            for (int i = 0; i < b.Width; i++)
                for (int j = 0; j < b.Height; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (byte)(.299 * r1 + .587 * g1 + .114 * b1);
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));

                }
            return true;
        }

        public static bool ConvertToNegative(Bitmap b)
        {

            for (int i = 0; i < b.Width; i++)    // Loop for Width
                for (int j = 0; j < b.Height; j++)    // Loo for Height
                {

                    Color c1 = b.GetPixel(i, j);    // Get Pixel from colour
                    int a = c1.A;    // Extracting ARGB from pixel colour
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;

                    // For negative values

                    r1 = 255 - r1;
                    g1 = 255 - g1;
                    b1 = 255 - b1;

                    b.SetPixel(i, j, Color.FromArgb(a, r1, g1, b1));   // Setting new colour for negative processed image
                }
            return true;
        }
    }
}
