using System;
using System.Drawing;
using System.IO;

namespace UkrainianFlag
{
    internal class Program
    {
        //See https://codegolf.stackexchange.com/questions/245318/draw-the-ukrainian-flag for more information.
        static void Main(string[] args)
        {
            var blue = Color.FromArgb(0, 87, 183);
            var yellow = Color.FromArgb(255, 215, 0);

            var flag = new Bitmap(78, 52);
            for (int y = 0; y < flag.Height; y++)
            {
                for (int x = 0; x < flag.Width; x++)
                {
                    if (y >= flag.Height / 2)
                    {
                        flag.SetPixel(x, y, blue);
                    }
                    else
                    {
                        flag.SetPixel(x, y, yellow);
                    }
                }
            }

            var saveDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "codegolf", "245318");
            Directory.CreateDirectory(saveDir);

            var file = Path.Combine(saveDir, "flag.bmp");
            flag.Save(file);
        }
    }
}
