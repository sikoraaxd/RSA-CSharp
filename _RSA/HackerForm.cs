using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace _RSA
{
    public partial class HackeForm : Form
    {
        public HackeForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public BigInteger ExtendedEuclidean(BigInteger e, BigInteger n)
        {
            BigInteger i = n, d = 0, v = 1;
            while (e > 0)
            {
                BigInteger t = i / e, x = e;
                e = i % x;
                i = x;
                x = v;
                v = d - t * x;
                d = x;
            }
            d %= n;
            if (d < 0)
                d = (d + n) % n;
            return d;
        }

        //Факторизация Ферма
        private void FactorizeNum_Click(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(SecretN.Text, out BigInteger num1))
                return;
            if (!BigInteger.TryParse(SecretE.Text, out BigInteger num2))
                return;


            BigInteger a, b;
            BigInteger secretN = BigInteger.Parse(SecretN.Text);
            BigInteger secretE = BigInteger.Parse(SecretE.Text);
            double n = (double)(secretN);
            a = (BigInteger)Math.Ceiling(Math.Sqrt(n));
            if (a * a == secretN)
            {
                PNum.Text = a.ToString();
                QNum.Text = a.ToString();
                return;
            }

            while(true)
            {
                BigInteger tmp = a * a - secretN;
                b = (BigInteger)Math.Sqrt((double)tmp);

                if (b * b == tmp)
                    break;
                a++;
            }

            BigInteger p = a - b;
            BigInteger q = a + b;

            PNum.Text = p.ToString();
            QNum.Text = q.ToString();

            BigInteger Ef = (p - 1) * (q - 1);
            BigInteger d = ExtendedEuclidean(secretE, Ef);
            SecretD.Text = d.ToString();
        }
    }
}
