using System.Drawing;

namespace UkrainianFlag
{
    internal class Program
    {
        //See https://codegolf.stackexchange.com/questions/245318/draw-the-ukrainian-flag for more information.
        static void Main(string[] args)
        {
            var f=new Bitmap(78,52);for(int y=0;y<52;y++)for(int x=0;x<78;x++)if(y>25)f.SetPixel(x,y,Color.FromArgb(255,215,0));else f.SetPixel(x,y,Color.FromArgb(0,87,183));f.Save("f.bmp");
        }
    }
}
