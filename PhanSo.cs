class PhanSo
    {
        private int tu;
        private int mau;
        public PhanSo(int a, int b)
        {
            tu = a;
            mau = b;
        }
        public PhanSo()
        {
        }
        public void input()
        {
            Console.Write("Tu = ");
            tu = int.Parse(Console.ReadLine());
            Console.Write("Mau = ");
            mau = int.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine("{0}/{1}",tu/UCLN(tu,mau),mau/UCLN(tu,mau));
        }
        public static int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }
        public static PhanSo operator +(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.tu = a.tu*b.mau + b.tu*a.mau;
            c.mau = a.mau * b.mau;
            return c;
        }
        public static PhanSo operator -(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.tu = a.tu * b.mau - b.tu * a.mau;
            c.mau = a.mau * b.mau;
            return c;
        }
        public static PhanSo operator *(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.tu = a.tu*b.tu ;
            c.mau = a.mau * b.mau;
            return c;
        }
        public static PhanSo operator /(PhanSo a, PhanSo b)
        {
            PhanSo c = new PhanSo();
            c.tu = a.tu * b.mau;
            c.mau = a.mau * b.tu;
            return c;
        }
    }
