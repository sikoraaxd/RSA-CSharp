using System;
using System.Diagnostics;
using System.Numerics;
using System.Security.Cryptography;

namespace _RSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataClass.currentKeyLen = 0;
            for (BigInteger i = 3; i <= 2000; i++)
                DataClass.ePrimes.Add(i);
            for (BigInteger i = 2; i <= 2000; i++)
                for (int j = 0; j < DataClass.ePrimes.Count; j++)
                {
                    if (DataClass.ePrimes[j] % i == 0 && DataClass.ePrimes[j] != i)
                    {
                        DataClass.ePrimes.RemoveAt(j);
                        j--;
                    }
                }
        }

        public BigInteger NextBigInteger(Random random, BigInteger minValue, BigInteger maxValue)
        {
            if (minValue > maxValue) throw new ArgumentException();
            if (minValue == maxValue) return minValue;
            BigInteger zeroBasedUpperBound = maxValue - 1 - minValue; 
            Debug.Assert(zeroBasedUpperBound.Sign >= 0);
            byte[] bytes = zeroBasedUpperBound.ToByteArray();
            Debug.Assert(bytes.Length > 0);
            Debug.Assert((bytes[bytes.Length - 1] & 0b10000000) == 0);

            byte lastByteMask = 0b11111111;
            for (byte mask = 0b10000000; mask > 0; mask >>= 1, lastByteMask >>= 1)
            {
                if ((bytes[bytes.Length - 1] & mask) == mask) break; 
            }

            while (true)
            {
                random.NextBytes(bytes);
                bytes[bytes.Length - 1] &= lastByteMask;
                var result = new BigInteger(bytes);
                Debug.Assert(result.Sign >= 0);
                if (result <= zeroBasedUpperBound) return result + minValue;
            }
        }

        // modulo function to perform binary exponentiation
        private BigInteger modulo(BigInteger _base, BigInteger exponent, BigInteger mod)
        {
            BigInteger x = 1;
            BigInteger y = _base;
            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    x = (x * y) % mod;

                y = (y * y) % mod;
                exponent = exponent / 2;
            }

            return x % mod;
        }

        int calculateJacobian(BigInteger a, BigInteger n)
        {
            if (a == 0)
                return 0;

            int ans = 1;
            if (a < 0)
            {
                a = -a; 
                if (n % 4 == 3)
                    ans = -ans; 
            }

            if (a == 1)
                return ans;

            while (a != 0)
            {
                if (a < 0)
                {
                    a = -a;
                    if (n % 4 == 3)
                        ans = -ans;
                }

                while (a % 2 == 0)
                {
                    a = a / 2;
                    if (n % 8 == 3 || n % 8 == 5)
                        ans = -ans;

                }
                BigInteger tempA = a;
                a = n;
                n = tempA;

                if (a % 4 == 3 && n % 4 == 3)
                    ans = -ans;
                a = a % n;

                if (a > n / 2)
                    a = a - n;

            }
            if (n == 1)
                return ans;
            return 0;
        }

        bool solovoyStrassen(BigInteger p, BigInteger iterations)
        {
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.Ticks);
            if (p < 2)
                return false;
            if (p != 2 && p % 2 == 0)
                return false;

            for (int i = 0; i < iterations; i++)
            {
                BigInteger a = rnd.Next(0, 32767) % (p - 1) + 1;
                BigInteger jacobian = (p + calculateJacobian(a, p)) % p;
                BigInteger mod = modulo(a, (p - 1) / 2, p);

                if (jacobian == 0 || mod != jacobian)
                    return false;
            }
            return true;
        }

        private void GeneratePrimaries_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(KeyLen.Text, out int num))
                return;
            if (Convert.ToInt32(KeyLen.Text) < 7)
                return;
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.Ticks);

            int keyLen = Convert.ToInt32(KeyLen.Text);
            DataClass.currentKeyLen = keyLen;
            BigInteger minValue = BigInteger.Pow(2, keyLen - 1);
            BigInteger maxValue = BigInteger.Pow(2, keyLen) - 1;
            
            for(BigInteger i = 0; i < ((maxValue-minValue) > 5000 ? 5000: minValue); i++)
            {
                BigInteger tmpNum = maxValue;
                do
                {
                    tmpNum = NextBigInteger(rnd, minValue, maxValue);
                } while (tmpNum.IsEven);
                DataClass.primes.Add(tmpNum);
            }

            for (int i = 0; i < DataClass.ePrimes.Count; i++)
            {
                for(int j = 0; j < DataClass.primes.Count; j++)
                {
                    if(DataClass.primes[j] % DataClass.ePrimes[i] == 0 && 
                        DataClass.primes[j] != DataClass.ePrimes[i])
                    {
                        DataClass.primes.RemoveAt(j);
                        j--;
                    }
                }
            }

            for(int i = 0; i < DataClass.primes.Count; i++)
            {
                if (!solovoyStrassen(DataClass.primes[i], 5000))
                {
                    DataClass.primes.RemoveAt(i);
                    i--;
                }
            }

            DataClass.primes = DataClass.primes.Distinct().ToList();

            int indP = 0;
            int indQ = 0;

            do
            {
                indP = rnd.Next(0, DataClass.primes.Count);
                indQ = rnd.Next(0, DataClass.primes.Count);
            } while (indP == indQ);
            

            DataClass.p = DataClass.primes[indP];
            DataClass.q = DataClass.primes[indQ];

            PNum.Text = DataClass.p.ToString();
            QNum.Text = DataClass.q.ToString();
        }

        public BigInteger ExtendedEuclidean(BigInteger e, BigInteger n)
        {
            BigInteger i = n, d = 0, v = 1;
            while(e > 0)
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

        private BigInteger EulerFunc(BigInteger p, BigInteger q)
        {
            return (p - 1) * (q - 1);
        }

        private void SoluteDandN_Click(object sender, EventArgs e)
        {
            KeysGenerateOutput.Clear();
            Random rnd = new Random((int)DateTime.Now.TimeOfDay.Ticks);

            DataClass.n = DataClass.p * DataClass.q;
            SecretN.Text = DataClass.n.ToString();

            KeysGenerateOutput.Text += "Вычисляем модуль - n = P * Q:\r\n";
            KeysGenerateOutput.Text += "n = " + DataClass.p.ToString() + " + " + DataClass.q.ToString() + "\r\n";

            BigInteger Ef = EulerFunc(DataClass.p, DataClass.q);
            KeysGenerateOutput.Text += "Вычисляем значение функции Эйлера от числа n:\r\n";
            KeysGenerateOutput.Text += "φ(n) = (p-1)*(q-1) = " + Ef.ToString() + "\r\n";

            int eInd = 0;
            DataClass.e = 2;

            do
            {
                eInd = rnd.Next(0, DataClass.ePrimes.Count);
                DataClass.e = DataClass.ePrimes[eInd];
            } while (DataClass.e >= Ef);
            
            SecretE.Text = DataClass.e.ToString();
            KeysGenerateOutput.Text += "Выбираем целое число е (1 < e < φ(n)), взаимно простое с φ(n):\r\n";
            KeysGenerateOutput.Text += "e = " + DataClass.e.ToString() + "\r\n";


            DataClass.d = ExtendedEuclidean(DataClass.e, Ef);
            KeysGenerateOutput.Text += "C помощью расширенного алгоритма Евклида вычисляем число d, мультипликативно обратное числу e:\r\n";
            KeysGenerateOutput.Text += "d*e ≡ 1(mod φ(n))\r\n";
            KeysGenerateOutput.Text += "d = " + DataClass.d.ToString();
            SecretD.Text = DataClass.d.ToString();
        }

        private bool validateKeys(int actionType)
        {
            if (SecretN.Text.Length == 0)
                return false;
            BigInteger n = BigInteger.Parse(SecretN.Text);
            DataClass.n = n;

            if (actionType == 0)
            {
                if (SecretE.Text.Length == 0)
                    return false;
                BigInteger _e = BigInteger.Parse(SecretE.Text);
                DataClass.e = _e;
            }
            else if (actionType == 1)
            {
                if (SecretD.Text.Length == 0)
                    return false;
                BigInteger d = BigInteger.Parse(SecretD.Text);
                DataClass.d = d;
            }
            return true;
        }

        private void CipherText_Click(object sender, EventArgs e)
        {
            CipheredText.Clear();
            if(!validateKeys(0))
                return;
            List<char> chars = OriginalText.Text.ToCharArray().ToList();
            for (int i = 0; i < chars.Count; i++)
            {
                CipheredText.Text += (BigInteger.ModPow(Convert.ToInt32(chars[i]), DataClass.e, DataClass.n)).ToString();
                if(i < chars.Count - 1)
                    CipheredText.Text += " ";
            }
                
        }

        private void UncipherText_Click(object sender, EventArgs e)
        {
            UncipheredText.Clear();
            if (!validateKeys(1))
                return;
            List<BigInteger> encChars = CipheredText.Text.Split(' ').Select(x => BigInteger.Parse(x)).ToList();

            for (int i = 0; i < encChars.Count; i++)
            {
                UncipheredText.Text += Convert.ToChar((int)BigInteger.ModPow(encChars[i], DataClass.d, DataClass.n));
            }
        }

        private void HackerForm_Click(object sender, EventArgs e)
        {
            HackeForm hf = new HackeForm();
            hf.Show();
        }

        private void FromFile_Click(object sender, EventArgs e)
        {
            CipheredText.Text = File.ReadAllText("in.txt");
        }

        private void InFile_Click(object sender, EventArgs e)
        {
            File.WriteAllText("out.txt", CipheredText.Text);
        }

        private void KeysGenerateOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}