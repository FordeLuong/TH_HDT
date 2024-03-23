using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pheptinh dt = new Pheptinh();
            //dt.Nhap();
            //string bienluan =null;
            //double kq = 0 ;
            //double b1 = 0, b2 =0;
            //Console.WriteLine("a + b = {0}", dt.cong());
            //Console.WriteLine("a - b = {0}", dt.tru());
            //Console.WriteLine("a * b = {0}", dt.tich());
            //Console.WriteLine("a / b = {0}", dt.chia());

            //Console.WriteLine("Phuong trinh bac 1 (ax + b = 0)");
            //dt.ptbac1(dt.a,dt.b,ref bienluan,ref kq);
            //Console.WriteLine(bienluan);
            //Console.WriteLine("Ket qua phuong trinh bac 1 = {0}", kq);


            //Console.WriteLine();
            //Console.WriteLine("Phuong trinh bac 2 (ax^2 + bx + c = 0)");
            //dt.ptbac2(dt.a, dt.b, dt.c,ref bienluan,ref b1,ref b2);

            //Console.WriteLine(bienluan);
            //Console.WriteLine("Ket qua phuong trinh bac 2 = {0} {0}", b1 , b2);

            ////SinhVien sv = new SinhVien();
            ////sv.nhap();
            ////Console.Write("Ket qua xep loai cua sinh vien nay la {0}", sv.xeploai());
            


            //Hinhtron dt = new Hinhtron();
            //dt.nhap();
            //dt.Xuat();

            Nhanvien dt = new Nhanvien();
            dt.nhap();
            dt.xuat();
            Console.WriteLine("Tien luong thang nay : {0}",dt.tinhluong());
            Console.WriteLine("Tien thuong thang nay : {0}", dt.tinhthuong());
            Console.ReadLine();
            
            
        }
    }
}
