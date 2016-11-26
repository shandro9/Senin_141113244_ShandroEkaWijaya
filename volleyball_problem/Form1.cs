using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace volleyball_problem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int Mod = 1000000007;

        static long Hitung(int a, int b)
        {
            if (a > b) return Hitung(b, a);
            if (b < 25) return 0;
            if (b > 25 && b != a + 2) return 0;
            if (b == 25 && b - a < 2) return 0;

            int max = 25;
            long[,] x = new long[max, max];

            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < max; j++)
                {
                    if (i == 0 || j == 0)
                        x[i, j] = 1;
                    else
                        x[i, j] = (x[i - 1, j] + x[i, j - 1]) % Mod;
                }
            }

            if (b == 25)
                return x[24, a];

            return x[24, 24] % Mod * Modd(2, (a - 24), Mod) % Mod;
        }

        static long Modd(long a, long y, long n)
        {
            long mod = 1;

            while (y != 0)
            {
                if ((y & 1) == 1)
                    mod = mod * a % n;

                a = (a * a) % n;
                y >>= 1;
            }

            return mod;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a, b;
            a = Convert.ToInt32(Txt1.Text);
            b = Convert.ToInt32(Txt2.Text);
            TxtHasil.Text = Hitung(a, b).ToString();

        }

        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Txt2.Focus();
            }

        }

        private void Txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonhitung.Focus();
            }
        }

        private void buttonhitung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonhitung.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


