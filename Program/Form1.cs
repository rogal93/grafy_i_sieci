using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyszukiwanie_mostu
{
    public partial class Form1 : Form
    {
        private Pen pioro;
        private Graphics g;
        private Point p = Point.Empty;
        private Font czcionka = new Font("Arial", 20);

        private List<Krawędź> krawędzie = new List<Krawędź>();
        private AnalizaGrafu analiza;

        public Form1()
        {
            InitializeComponent();
            analiza = new AnalizaGrafu();
            image.Image = new Bitmap(776, 631);
            pioro = new Pen(Color.Black, 3);
            g = Graphics.FromImage(image.Image);
            g.DrawString("Kliknij, aby narysować wierzchołek", new Font("Arial", 25), Brushes.Black, new PointF(120, 260));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        { }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Location.X > 25 && e.Location.Y > 25 && e.Location.X < 756 && e.Location.Y < 611)
            {
                btnWyczysc.Enabled = true;
                if (analiza.wierzcholki.Count == 0) g.Clear(Color.White);
                if (analiza.wierzcholki.Count < 50)
                {
                    p = e.Location;
                    Wierzchołek tempW = new Wierzchołek(p, analiza.wierzcholki.Count + 1);
                    analiza.wierzcholki.Add(tempW);
                    krawedz1.Items.Add(analiza.wierzcholki.IndexOf(tempW) + 1);
                    krawedz2.Items.Add(analiza.wierzcholki.IndexOf(tempW) + 1);
                    g.DrawEllipse(pioro, p.X - 25, p.Y - 25, 40, 40);
                    if (analiza.wierzcholki.Count < 10)
                        g.DrawString(analiza.wierzcholki.Count.ToString(), czcionka, Brushes.Black, new PointF(p.X - 16, p.Y - 19));
                    else
                        g.DrawString(analiza.wierzcholki.Count.ToString(), czcionka, Brushes.Black, new PointF(p.X - 24, p.Y - 19));
                }
                else
                    MessageBox.Show("Maksymalna liczba wierzchołków grafu to 50. Nie rysuj już więcej.",
                        "Już wystarczy", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                image.Refresh();
            }
        }

        private void krawedz1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void krawedz2_SelectedIndexChanged(object sender, EventArgs e)
        {   btnRysujKrawedz.Enabled = true; }

        private void btnRysujKrawedz_Click(object sender, EventArgs e)
        {
            int k1 = krawedz1.SelectedIndex;
            int k2 = krawedz2.SelectedIndex;
            try
            {
                if (krawedz1.SelectedIndex != krawedz2.SelectedIndex)
                {
                    Krawędź tempK = new Krawędź(analiza.wierzcholki[k1],
                        analiza.wierzcholki[k2]);
                    foreach (Krawędź item in krawędzie)
                    {
                        if ((item.w1 == tempK.w1 && item.w2 == tempK.w2) || (item.w1 == tempK.w2 && item.w2 == tempK.w1))
                        {
                            MessageBox.Show("Już dodałeś tą krawędź!", "Już dodano.");
                            return;
                        }
                    }
                    krawędzie.Add(tempK);
                    g.DrawLine(pioro, tempK.w1.punkt, tempK.w2.punkt);
                    if (!analiza.wierzcholki[k1].sąsiedzi.Contains(tempK.w2))
                    {
                        analiza.wierzcholki[k1].sąsiedzi.Add(tempK.w2);
                        analiza.wierzcholki[k2].sąsiedzi.Add(tempK.w1);
                    }
                }
                else
                    MessageBox.Show("Nie można narysować krawędzi pomiędzy tym samym wierzchołkiem!",
                        "Źle wybrane wierzchołki");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Wybierz wierzchołki, pomiędzy którymi chcesz narysować krawędź",
                    "Brak wyboru wierzchołków");
            }
            image.Refresh();
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            krawedz1.Enabled = true;
            krawedz2.Enabled = true;
            krawedz1.ResetText();
            krawedz2.ResetText();
            krawedz1.Items.Clear();
            krawedz2.Items.Clear();
            krawędzie = new List<Krawędź>();
            analiza = new AnalizaGrafu();
            g.Clear(Color.White);
            btnRysujKrawedz.Enabled = false;
            btnWyczysc.Enabled = false;
            g.DrawString("Kliknij, aby narysować wierzchołek", new Font("Arial", 25), Brushes.Black, new PointF(120, 260));
            image.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnRysujKrawedz.Enabled = false;
            foreach (Wierzchołek item in analiza.wierzDrzewa)
            {
                Console.Write(item + " synowie: ");
                foreach (Wierzchołek syn in item.synowie)
                {
                    Console.Write(syn + ", ");
                }
                Console.WriteLine();
            }
            image.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
