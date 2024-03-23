using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Pheptinh
    {
       public int a, b,c;

       //public Pheptinh(int pA, int pB)
       //{
       //    a = pA;
       //    b = pB;
       //}

        public void Nhap()
        {
            Console.Write("nhap a: ");
            a = int.Parse( Console.ReadLine());

            Console.Write("nhap b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("nhap c: ");
            c = int.Parse(Console.ReadLine());
        }
        public int cong()
        {
            return a + b;
        }
        public int cong(int pA, int pB)
        {
            return pA + pB;
        }
        public int tru()
        {
            return a - b;
        }

        public int tich()
        {
            return a * b;
        }
        public double chia()
        {
            return a / b;
        }
        public double chia_pt(int a, int b)
        {
            return (float) -b / a;
        }
        public void ptbac1(int a, int b, ref string bienluan , ref double b1)
        {
            string temp = null;
            if (a == 0 && b != 0)
            {
                temp = "Phuong trinh vo nghiem";
            }
            else if (a == 0 && b == 0)
            {
                temp = "Phuong trinh co vo so nghiem";
            }
            else 
            {
                b1 = chia_pt(a, b);
                temp = "Phuong trinh co 1 nghiem " + b1.ToString();
                 
            }
            bienluan = temp ;
        }
        public void ptbac2(int a, int b, int c,ref string bienluan , ref double b1 ,ref double b2)
        {
            if (a == 0)
            {
                ptbac1(b, c, ref bienluan, ref b1);
            }
            else
            {
                int delta = b * b - 4 * a * c;
                if (delta > 0)
                {
                    bienluan = "Phuong trinh co 2 nghiem";
                    b1 = -b - Math.Sqrt(delta) / (2 * a);
                    b2 = -b + Math.Sqrt(delta) / (2 * a);
                }
                else if (delta < 0)
                {
                    bienluan = "Phuong trinh vo nghiem" ;
                }
                else
                {
                    bienluan = "Phuong trinh co nghiem kep";
                    b1 = -b / (2 * a);
                }

            }
        }
    }
}
