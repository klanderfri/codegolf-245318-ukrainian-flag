using System.Drawing;

namespace UkrainianFlag
{
    internal class Program
    {
        //See https://codegolf.stackexchange.com/questions/245318/draw-the-ukrainian-flag for more information.
        static void Main(string[] args)
        {
            SetColour(new Bitmap(78, 52), 0, 0).Save("flag.bmp");
        }

        private static Bitmap SetColour(Bitmap flag, int x, int y)
        {
            if (x > 77)
            {
                x = 0;
                y++;
            }
            if (y > 51) return flag;
            flag.SetPixel(x, y, Color.FromArgb(255, 215, 0));
            if (y < 26)
            {
                flag.SetPixel(x, y, Color.FromArgb(0, 87, 183));
            }
            return SetColour(flag, x + 1, y);
        }
    }
}
