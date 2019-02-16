using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonsaiServer.Models
{
    public class BColor
    {
        static char[] chars = new char[] { '1', '3', '5', '7', '9', 'b', 'd', 'f' };

        public static double[] ColorToHSV(Color color)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            double hue = color.GetHue();
            double saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            double value = max / 255d;
            return new double[] { hue, saturation, value };
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        public static int[] RgbFromHex(string hex)
        {
            if (!ValidColor(hex)) return null;
            int r = Convert.ToInt32(new string(new char[] { hex[0], 'f' }), 16);
            int g = Convert.ToInt32(new string(new char[] { hex[1], 'f' }), 16);
            int b = Convert.ToInt32(new string(new char[] { hex[2], 'f' }), 16);
            return new int[] {r,g,b};
        }

        public static bool ValidColor(string hex)
        {
            if (hex == null || hex.Length != 3) return false;
            hex = hex.ToLower();
            foreach(char ch in hex)
            {
                if (!chars.Contains(ch)) return false;
            }
            return true;
        }

        public static string RandomColor()
        {
            var rand = new Random();
            string color = "";
            for (int i = 0; i<3; i++)
            {
                color += chars[rand.Next(0, chars.Length)];
            }
            return color;
        }
    }
}
