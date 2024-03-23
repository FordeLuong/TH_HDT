using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Hinhtron
    {
        private double r;

        public double R
        {
            get { return r; }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Du lieu bi loi");
                    r = 0;
                }
                else 
                    r = value; 
            }
        }
        // Khoi tao rong
        public Hinhtron()
        {
            this.r = 0;
        }
        //Khoi tao co tham so
        public Hinhtron(Double r)
        {
            this.r = 0;
        }
        //nhap tu ban phim
        public void nhap()
        {
            Console.Write("Nhap ban kinh hinh tron: ");
            this.r = double.Parse(Console.ReadLine());
        }
        public Double tinhchuvi()
        {
            return this.r * 2 * Math.PI;
        }
        public Double tinhdientich()
        {
            return Math.Pow(this.r, 2) * Math.PI;
        }
        public void Xuat()
        {
            Console.WriteLine("Hinh tron co ban kinh: {0:0.00}, chu vi: {1:0.00}, dien tich: {2:0.00} ", this.r, tinhchuvi(), tinhdientich());
        }

    }
    
}
