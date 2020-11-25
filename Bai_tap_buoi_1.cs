//code by ~Wind
//61HT

using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace buoi1
{
    class Program
    {
        public static void baiMot()
        {
            Console.WriteLine("**Tro choi tinh nhanh**");
            Console.WriteLine("** +: Phep tinh cong **");
            Console.WriteLine("** -: Phep tinh tru  **");
            Console.WriteLine("** *: Phep tinh nhan **");
            Console.WriteLine("** /: Phep tinh chia **");
            int a, b;
            string tt;
            string result = "y";
            while (result == "y")
            {
                Console.Write("a = ");
                a = int.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = int.Parse(Console.ReadLine());
                Console.Write("tt = ");
                tt = Console.ReadLine();
                if (tt == "+")
                {
                    Console.WriteLine("a+b = {0}", a + b);
                }
                if (tt == "-")
                {
                    Console.WriteLine("a - b = {0}", a - b);
                }
                if (tt == "*")
                {
                    Console.WriteLine("a*b = {0}", a * b);
                }
                if (tt == "/")
                {
                    Console.WriteLine("a/b = {0}", a * 1.0 / b);
                }
                Console.WriteLine("Ban co muon tiep tuc choi khong? (y/n)");
                result = Console.ReadLine();
            }
        }
        public static bool check(int d, int m , int y)
        {
            if(m==2 && check_Year(y) == true)
            {
                if (d >= 1 && d <= 29)
                    return true;
            }
            if(m==2 && check_Year(y) == false)
            {
                if (d >= 1 && d <= 28)
                    return true;
            }
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                if (d >= 1 && d <= 31)
                    return true;
            if (m == 4 || m == 6 || m == 9 || m == 10)
                 if (d >= 1 && d <= 30)
                    return true;

            return false;
        }
        public  static bool check_Year(int y)
        {
            if (y % 400 == 0)
                return true;
            if (y % 4 == 0 && y % 100 != 0)
                return true;
            return false;
        }
        public static void baiHai()
        {
            int d, m, y;
            Console.Write("day = ");
            d = int.Parse(Console.ReadLine());
            Console.Write("month = ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Year = ");
            y = int.Parse(Console.ReadLine());
            if (check(d, m, y))
            {
                if (check_Year(y)) // nam nhuan
                {
                    {
                        Console.WriteLine("Nam Nhuan!!");
                        if (m == 2)
                        {
                            if (d == 29)
                            {
                                d = 1;
                                m += 1;
                            }
                            else
                            {
                                d++;
                            }
                        }
                        else
                        {
                            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                                if (d == 31)
                                {
                                    d = 1;
                                    m++;
                                }
                                else
                                {
                                    d++;
                                }
                            if (m == 4 || m == 6 || m==9 || m==11)
                            {
                                if(d==30)
                                {
                                    d = 1;
                                    m++;
                                }
                            }
                        }
                        if (m == 13)
                        {
                            m = 1;
                            y++;
                        }
                        Console.WriteLine("Ngay tiep theo la: {0}/{1}/{2}", d, m, y);
                    }
                }
                else //nam khong nhuan
                {
                    {
                        Console.WriteLine("Nam khong nhuan!!");
                        if (m == 2)
                        {
                            if (d == 28)
                            {
                                d = 1;
                                m += 1;
                            }
                            else
                            {
                                d++;
                            }
                        }
                        else
                        {
                            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                                if (d == 31)
                                {
                                    d = 1;
                                    m++;
                                }
                                else
                                {
                                    d++;
                                }
                            if (m == 4 || m == 6 || m == 9 || m == 11)
                            {
                                if (d == 30)
                                {
                                    d = 1;
                                    m++;
                                }
                            }
                        }
                        if (m == 13)
                        {
                            m = 1;
                            y++;
                        }
                        Console.WriteLine("Ngay tiep theo la: {0}/{1}/{2}", d, m, y);
                    }
                }
            }
            else
            {
                Console.WriteLine("Khong hop le!!");
            }
        }
        public static bool scp(int n)
        {
            if (Math.Sqrt(n) == (int)Math.Sqrt(n))
                return true;
            return false;
        }
        public static bool snt(int n)
        {
            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static bool sdx(int n)
        {
            int x = n;
            int sum = 0;
            while(x!=0)
            {
                sum = sum * 10 + x % 10;
                x /= 10;
            }
            if (sum == n)
                return true;
            return false;
        }
        public static bool Amstrong(int n)
        {
            int count = 0;
            int x = n;
            while(x!=0)
            {
                count++;
                x /= 10;
            }
            int k = n;
            double tong = 0;
            while(k!=0)
            {
                int y = k % 10;
                tong += Math.Pow(y, count);
                k /= 10;
            }
            if ((int)tong == n)
                return true;
            return false;
        }
        public static bool shc(int n)
        {
            int sum = 0;
            for(int i=1; i<n; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if (sum == n)
                return true;
            return false;
        }
        public static void baiBa()
        {
            int n;
            Console.WriteLine("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Cac so chinh phuong la: ");
            for (int i = 1; i < n; i++)
            {
                if (scp(i))
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("\nCac so nguyen to < {0} la: ", n);
            for (int i = 2; i < n; i++)
            {
                if (snt(i))
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("\nCac so doi xung la: ");
            for (int i = 0; i < n; i++)
            {
                if (sdx(i))
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("\nCac so Amstrong la: ");
            for (int i = 0; i < n; i++)
            {
                if(Amstrong(i))
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine("\nCac so hoan chinh la: ");
            for(int i=0; i<n; i++)
            {
                if(shc(i))
                {
                    Console.Write("{0} ", i);
                }
            }
        }
        static void Main(string[] args)
        {
            // baiMot();
            // baiHai();
            // baiBa();
        }
    }
}
