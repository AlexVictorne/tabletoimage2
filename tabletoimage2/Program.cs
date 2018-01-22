using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace tabletoimage2
{
    class Program
    {
        static RectangleF GetRectangleF(int x, int y, int dx = 1, int dx2 = 1)
        {
            int row_height = 20;
            int column_width = 100;
            return new RectangleF(new PointF(column_width * x, row_height * y * dx), new SizeF(column_width, row_height * dx2));
        }

        static void Main(string[] args)
        {
            
            using (var input = File.OpenRead("far.jpg"))
            using (var output = File.OpenWrite("bar.jpg"))
            using (var image = Image.FromStream(input))
            {
                var g = Graphics.FromImage(image);

                var rectangles = new List<RectangleF>();
                rectangles.Add(GetRectangleF(0, 0));
                g.DrawString("1", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                rectangles.Add(GetRectangleF(1, 0));
                g.DrawString("Объем", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                rectangles.Add(GetRectangleF(2, 0));
                g.DrawString("Вчера", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                rectangles.Add(GetRectangleF(3, 0));
                g.DrawString("С начала месяца", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                rectangles.Add(GetRectangleF(4, 0));
                g.DrawString("С начала года", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                
                rectangles.Add(GetRectangleF(0, 1, 1, 2));
                g.DrawString("1", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                rectangles.Add(GetRectangleF(1, 1));
                g.DrawString("шт.", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                rectangles.Add(GetRectangleF(2, 1));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                rectangles.Add(GetRectangleF(3, 1));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                rectangles.Add(GetRectangleF(4, 1));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, rectangles.Last());
                rectangles.Add(GetRectangleF(1, 2));
                g.DrawString("руб.", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(1, 2));
                rectangles.Add(GetRectangleF(2, 2));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(2, 2));
                rectangles.Add(GetRectangleF(3, 2));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(3, 2));
                rectangles.Add(GetRectangleF(4, 2));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(4, 2));

                g.DrawString("1", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(0, 3, 1, 2));
                g.DrawString("шт.", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(1, 3));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(2, 3));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(3, 3));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(4, 3));
                g.DrawString("руб.", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(1, 4));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(2, 4));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(3, 4));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(4, 4));
               
                g.DrawString("1", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(0, 5, 1, 2));
                g.DrawString("руб.", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(1, 5));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(2, 5));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(3, 5));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(4, 5));

                g.DrawString("1", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(0, 7, 1, 2));
                g.DrawString("руб.", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(1, 7));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(2, 7));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(3, 7));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(4, 7));

                g.DrawString("1", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(0, 9, 1, 2));
                g.DrawString("руб.", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(1, 9));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(2, 9));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(3, 9));
                g.DrawString("%", SystemFonts.MenuFont, Brushes.Black, GetRectangleF(4, 9));

                g.DrawRectangles(Pens.Green, rectangles.ToArray());

                image.Save(output, ImageFormat.Jpeg);
                
                System.Diagnostics.Process.Start("bar.jpg");
            }
                
        }
    }
}
