using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyszukiwanie_mostu
{
    public class AnalizaGrafu
    {
        private int licznik;
        private Stack<Wierzchołek> stos;
        public List<Krawędź> drzewoDFS;
        public List<Wierzchołek> wierzDrzewa;
        public List<Wierzchołek> wierzcholki;
        public AnalizaGrafu()
        {
            licznik = 1;
            stos = new Stack<Wierzchołek>();
            drzewoDFS = new List<Krawędź>();
            wierzDrzewa = new List<Wierzchołek>();
            wierzcholki = new List<Wierzchołek>();
        }
    }
}
