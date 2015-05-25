using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyszukiwanie_mostu
{
    public class Wierzchołek
    {
        public Point punkt;
        public List<Wierzchołek> sąsiedzi = new List<Wierzchołek>();
        public List<Wierzchołek> synowie = new List<Wierzchołek>();
        public Wierzchołek ojciec;
        public bool odwiedzony = false;
        public int numer;
        public int nr_DFS = 0;
        public int low = 0;
        public Wierzchołek(Point punkt, int numer)
        {
            this.punkt = punkt;
            this.numer = numer;
            ojciec = this;
        }
        public Wierzchołek(Wierzchołek w)
        {
            punkt = w.punkt;
            numer = w.numer;
        }
        public override string ToString()
        {
            return punkt.ToString() + " nr " + numer + " nr_dfs " + nr_DFS + " low " + low;
        }
    }
}
