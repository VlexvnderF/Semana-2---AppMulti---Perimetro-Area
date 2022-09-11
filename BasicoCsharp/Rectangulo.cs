using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Rectangulo
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
        public int x4 { get; set; }
        public int y4 { get; set; }

        public double s()
        {
            double altura = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            double baseee = Math.Sqrt((Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2)));
            return altura + baseee;
        }

        public double p()
        {
            double alt = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            double bs = Math.Sqrt((Math.Pow(x2 - x3, 2) + Math.Pow(y1 - y3, 2)));
            double sumtot = 2 * alt + 2 * bs;
            return sumtot;
        }
    }

}
