using System;
using System.Diagnostics;
using System.Globalization;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void CZAS_TextChanged(object sender, EventArgs e)
        {

        }
        private void SB_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (checkBox.Checked)
            {
                int rnd = (int)NUD.Value;
                string napis = NSplit(rnd);
                int[] tab = Convert(napis);
                tab = SortB(tab);
                textBox2.Text = ToStr(tab);
            }
            else
            {
                int[] tab = Convert(textBox1.Text);
                tab = SortB(tab);
                textBox2.Text = ToStr(tab);
            }
            stopwatch.Stop();
            CZAS.Text = stopwatch.Elapsed.TotalSeconds.ToString() + "s";
        }
        private void SS_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (checkBox.Checked)
            {
                int rnd = (int)NUD.Value;
                string napis = NSplit(rnd);
                int[] tab = Convert(napis);
                tab = SortS(tab);
                textBox2.Text = ToStr(tab);
            }
            else
            {
                int[] tab = Convert(textBox1.Text);
                tab = SortS(tab);
                textBox2.Text = ToStr(tab);
            }
            stopwatch.Stop();
            CZAS.Text = stopwatch.Elapsed.TotalSeconds.ToString() + "s";
        }
        private void SI_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (checkBox.Checked)
            {
                int rnd = (int)NUD.Value;
                string napis = NSplit(rnd);
                int[] tab = Convert(napis);
                tab = SortI(tab);
                textBox2.Text = ToStr(tab);
            }
            else
            {
                int[] tab = Convert(textBox1.Text);
                tab = SortI(tab);
                textBox2.Text = ToStr(tab);
            }
            stopwatch.Stop();
            CZAS.Text = stopwatch.Elapsed.TotalSeconds.ToString() + "s";
        }
        private void SM_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (checkBox.Checked)
            {
                int rnd = (int)NUD.Value;
                string napis = NSplit(rnd);
                int[] tab = Convert(napis);
                tab = SortM(tab);
                textBox2.Text = ToStr(tab);
            }
            else
            {
                int[] tab = Convert(textBox1.Text);
                tab = SortM(tab);
                textBox2.Text = ToStr(tab);
            }
            stopwatch.Stop();
            CZAS.Text = stopwatch.Elapsed.TotalSeconds.ToString() + "s";
        }
        private void SQ_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            if (checkBox.Checked)
            {
                int rnd = (int)NUD.Value;
                string napis = NSplit(rnd);
                int[] tab = Convert(napis);
                tab = SortQ(tab);
                textBox2.Text = ToStr(tab);
            }
            else
            {
                int[] tab = Convert(textBox1.Text);
                tab = SortQ(tab);
                textBox2.Text = ToStr(tab);
            }
            stopwatch.Stop();
            CZAS.Text = stopwatch.Elapsed.TotalSeconds.ToString() + "s";
        }
        int[] Convert(String napis)
        {
            var LiczbyS = napis.Trim().Split(' ');
            var liczby = new int[LiczbyS.Length];
            for (int i = 0; i < LiczbyS.Length; i++)
            {
                liczby[i] = int.Parse(LiczbyS[i]);
            }
            return liczby;
        }
        string NSplit(int liczba)
        {
            string nbstr = liczba.ToString();
            string wynik = "";
            foreach(char cyfra in nbstr)
            {
                wynik += cyfra + " ";
            }
            wynik = wynik.Trim();
            return wynik;
        }
        String ToStr(int[] tab)
        {
            String re = " ";
            for (int i = 0; i < tab.Length; i++)
            {
                re += tab[i] + ", ";
            }
            return re;
        }
        int[] SortB(int[] tab)
        {
            bool cbz;
            do
            {
                cbz = false;
                int tmp;
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                        cbz = true;
                    }
                }
            } while (cbz);
            return tab;
        }
        int[] SortS(int[] tab)
        {
            for (int f = 0; f < tab.Length - 1; f++)
            {
                int min = f;
                for (int i = f + 1; i < tab.Length; i++)
                {
                    if (tab[i] < tab[min])
                    {
                        min = i;
                    }
                }
                int temp = tab[f];
                tab[f] = tab[min];
                tab[min] = temp;
            }
            return tab;
        }
        int[] SortI(int[] tab)
        {
            for(int i = 1; i < tab.Length;i++)
            {
                int temp = tab[i];
                int j = i - 1;
                while (j >= 0 && tab[j] > temp)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                tab[j + 1] = temp;
            }
            return tab;
        }
        int[] SortM(int[] tab)
        {
            if (tab.Length <= 1) return tab;

            int mid = tab.Length / 2;

            int[] left = Array.Empty<int>();
            int[] right = Array.Empty<int>();

            left = new int[mid];
            right = new int[tab.Length - mid];

            left = copyArray(tab, 0, mid);
            right = copyArray(tab, mid, tab.Length);

            SortM(left);
            SortM(right);

            merge(tab, left, right);

            return tab;
        }
        private void merge(int[] tab, int[] left, int[] right)
        {
            int l = 0;
            int r = 0;
            int i = 0;
            while (l < left.Length && r < right.Length)
            {
                if (left[l] < right[r])
                {
                    tab[i] = left[l];
                    l++;
                    i++;
                }
                else
                {
                    tab[i] = right[r];
                    r++;
                    i++;
                }
            }
            while (l < left.Length)
            {
                tab[i] = left[l];
                l++;
                i++;
            }
            while (r < right.Length)
            {
                tab[i] = right[r];
                r++;
                i++;
            }
            return;
        }
        private int[] copyArray(int[] src, int start, int stop)
        {
            int[] ret = new int[stop - start];
            for (int i = start; i < stop; i++)
                ret[i - start] = src[i];
            return ret;
        }
        int[] SortQ(int[] tab)
        {
            QSR(tab, 0, tab.Length - 1);
            return tab;
        }

        private static void QSR(int[] tab, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(tab, left, right);
                QSR(tab, left, pivotIndex - 1);
                QSR(tab, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] tab, int left, int right)
        {
            int pivot = tab[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (tab[j] < pivot)
                {
                    i++;
                    Swap(tab, i, j);
                }
            }

            Swap(tab, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] tab, int i, int j)
        {
            int temp = tab[i];
            tab[i] = tab[j];
            tab[j] = temp;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            NUD.Enabled = checkBox.Checked;
            GENERATE.Enabled = checkBox.Checked;
            textBox1.Enabled = !checkBox.Checked;
        }

        private void GENERATE_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rnd = random.Next(1, (int)NUD.Maximum + 1);
            NUD.Value = rnd;
        }
    }
}
