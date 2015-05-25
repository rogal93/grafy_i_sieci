using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Wyszukiwanie_mostu
{
    public class Krawędź
    {
        public Wierzchołek w1;
        public Wierzchołek w2;
        public Krawędź(Wierzchołek pierwszy, Wierzchołek drugi)
        {
            w1 = pierwszy;
            w2 = drugi;
        }
        public override string ToString()
        {
            return w1.ToString() + " - " + w2.ToString();
        }
    }
}
