using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func
{
    class Program
    {
        static void Main(string[] args)
        {
            // int i = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(IsSimple(i));

            // string[] s = Console.ReadLine().Split(' ');
            // Console.WriteLine(SumOfSIN(Convert.ToInt32(s[0]),Convert.ToInt32(s[1])));

            //string[] ss = Console.ReadLine().Split(' ');
            //double a = Convert.ToDouble(ss[0]);
            //int n = Convert.ToInt32(ss[1]);

            //powDigit(a, n);

            //int n = Convert.ToInt32(Console.ReadLine());
            //int k = Convert.ToInt32(Console.ReadLine());

            //// n! / k! (n-k)!
            //int c = myfact(n) / (myfact(k) * myfact(n - k));
            //Console.WriteLine(c);

            // FoundNOD();

            // MultiplyDigits();

            // SumOfAVG();

            // SystemOfEquations();

            // FindSum();

            // SolveOfEquation();

            // SumOfReverseDigits();

            // DoubleFact();

            // CompareSumOfDigit();

            //CompareCntOfDigit();

            Count_B_InSentence();
            Console.ReadKey();

        }

        private static void Count_B_InSentence()
        {
            string sentenceOne = Console.ReadLine();
            string sentenceTwo = Console.ReadLine();

            int cnt = CntB(sentenceOne);
            cnt = CntB(sentenceTwo,cnt);

            Console.WriteLine(cnt);
        }

        static int CntB(string sentence, int startvalue = 0)
        {
            sentence = sentence.ToLower();
    
            const char TEST_Letter = 'b';
            for (int i = 0; i < sentence.Length; i++)
                if (sentence[i] == TEST_Letter)
                    startvalue++;

            return startvalue;


        }

        private static void CompareCntOfDigit()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            var sum_a = CountOfDigit(a);
            var sum_b = CountOfDigit(b);

            Console.WriteLine(CompareResult(sum_a, sum_b));
        }

        static int CountOfDigit(int x)
        {
            var cnt = 0;
            while (x / 10 > 0)
            {
                cnt++;
                x /= 10;
            }

            return cnt++;

        }

        private static void CompareSumOfDigit()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            var sum_a = SumOfDigit(a);
            var sum_b = SumOfDigit(b);

            Console.WriteLine(CompareResult(sum_a, sum_b));
        }


        static int SumOfDigit(int x)
        {
            var sum = 0;
            while (x / 10 > 0)
            {
                sum += (x % 10);
                x /= 10;
            }

            return sum+x;
            
        }

        static int CompareResult(int sum_a, int sum_b)
        {
            int res;

            if (sum_a > sum_b)
                res = 1;
            else if (sum_a == sum_b)
                res = 0;
            else
                res = 2;

            return res;
        }

        private static void DoubleFact()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Fact2(a) + " " + Fact2(b) + " " + Fact2(c));

        }

        private static int Fact2(int x)
        {
            int start_value;
            var sum = 1;

            if (x % 2 == 0)
                start_value = 2;
            else
                start_value = 1;

            for (int i = start_value; i <= x; i += 2)
                sum *= i;

            return sum;
        }

        private static void SumOfReverseDigits()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            a = ReverseDigit(a);
            b = ReverseDigit(b);

            Console.WriteLine(a + b);
        }

        static int ReverseDigit(int x)
        {
            // var k = 0;
            // while(n!=0)
            // {
            // k = k * 10 + n%10;
            // }

            int cnt = 1;
            int a = x;
            while (a / 10 > 0)
            {
                a /= 10;
                cnt++;
            }

            a = 0;
            int i = 1;
            while ((x / 10 >= 0) && (x != 0))
            {
                a += (x % 10) * (int)Math.Pow(10, cnt - i);
                x /= 10;
                i++;
            }

            return a;
        }
        private static void SolveOfEquation()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            for (double i = 1; i <= 5; i++)
                s += (-1) * i * ((double)x / fact(i));
            Console.WriteLine(s);
        }

        static int fact(double digit)
        {
            var s = 1;
            for (int i = 1; i <= digit; i++)
                s *= i;

            return s;
        }

        private static void FindSum()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int x = SumRange(a, b);

            int y = SumRange(b, c);

            Console.WriteLine(x + y);

        }

        static int SumRange(int x, int y)
        {
            var sum = 0;

            if (x > y) return sum;

            for (int i = x; i <= y; i++)
                sum += i;

            return sum;
        }

        private static void SystemOfEquations()
        {
            int y;
            var sum = 0;
            for (int x = -25; x <= 15; x++)
            {
                if ((x >= -5) && (x <= 5))
                    y = x;
                else if (x > 5)
                    y = 2 * x;
                else
                    y = 2 * Math.Abs(x) - 1;

                Console.WriteLine($"y = {y}");
                sum += y;
            }

            Console.WriteLine(sum);

        }

        private static void SumOfAVG()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            double AVG1 = getAVGOfSequence(n);
            double AVG2 = getAVGOfSequence(m);

            Console.WriteLine(AVG1 + AVG2);


        }

        static double getAVGOfSequence(int max_value)
        {
            int sum = 0;
            int cnt = 0;

            for (int i = 1; i <= max_value; i++)
            {
                sum += i;
                cnt++;
            }

            return sum / cnt;
        }


        static void MultiplyDigits()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CategoryOfNumber(n) * CategoryOfNumber(m));

        }

        private static int CategoryOfNumber(int n)
        {
            int cnt = 1;
            while (n / 10 > 0)
            {
                n /= 10;
                cnt++;
            }

            return cnt;
        }


        static void FoundNOD()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = new string[n];
            a = s.Split(' ');

            int res = 0;

            if (n == 1)

                res = Convert.ToInt32(a[0]);

            else if (n == 2)

                res = nod(Convert.ToInt32(a[0]), Convert.ToInt32(a[1]));

            else if (n > 2)
            {
                res = nod(Convert.ToInt32(a[0]), Convert.ToInt32(a[1]));

                for (int i = 2; i < n; i++)
                    res = nod(res, Convert.ToInt32(a[i]));
            }

            Console.WriteLine(res);
        }
        static int nod(int first_el, int second_el)
        {
            int res, a, b;

            if (first_el >= second_el)
            {
                a = first_el;
                b = second_el;
            }
            else
            {
                b = first_el;
                a = second_el;

            }

            if (a % b == 0)
                res = b;
            else
            {
                int ost, ost2;
                ost = b % a;
                ost2 = a % ost;

                while (ost2 != 0)
                {
                    ost = ost % ost2;
                    if (ost == 0)
                    {
                        ost = ost2;
                        break;
                    }
                    ost2 = ost2 % ost;
                }
                res = ost;
            }
            return res;
        }

        static int myfact(int digit)
        {
            int res = 1;
            for (int i = 1; i <= digit; i++)
                res *= i;

            return res;
        }

        static void powDigit(double a, int n)
        {
            if (n == 0)
                a = 1;
            else if (n > 0)
                a = powAtoN(a, n);
            else
                a = 1 / powAtoN(a, -n);


            Console.WriteLine(a);
            return;
        }

        static double powAtoN(double a, int n)
        {
            var inc = a;

            for (int j = 2; j <= n; j++)
                a *= inc;

            return a;
        }

        static int SumOfSIN(int a, int b)
        {
            return MySin(a) + MySin(b);
        }

        static int MySin(int a)
        {
            int res;

            if (a < 0)
                res = -1;
            else if (a == 0)
                res = 0;
            else
                res = 1;

            return res;

        }
        static string IsSimple(int number)
        {
            string res = "prime";

            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    res = "composite";

            return res;
        }
    }
}
