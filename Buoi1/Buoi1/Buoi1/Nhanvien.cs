using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class Nhanvien
    {
        string ms, ht;
        int nc;
        char xl;


        public static int LuongNgay = 200000;

        public string Ms
        {
            get { return ms; }
            set { ms = value; }
        }

        public string Ht
        {
            get { return ht; }
            set { ht = value; }
        }
        public int Nc
        {
            get { return nc; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("Gia tri bi loi");
                    nc = 0;
                }
                else
                    {
                        nc = value; 
                    }
                }
        }
        public char Xl
        {
            get 
            {
                if (nc > 26)
                {
                    return xl = 'A';
                }
                else if (nc >= 26 && nc >= 22)
                {
                    return xl = 'B';
                }
                else
                {
                    return xl = 'C';
                }
            }
        }


        //Cac ham khoi tao
        //Khoi tao rong
        public Nhanvien()
        {
            this.ms = null;
            this.ht = null;
            this.nc = 0;
        }
        public Nhanvien(string maso , string hoten ,int ngaycong)
        {
            this.Ms = ms;
            this.Ht = hoten;
            this.Nc = ngaycong;
        }

        // Nhap xuat thong tin nhan vien
        public void nhap()
        {
            Console.Write("Nhap ma so nhan vien: ");
            this.Ms = Console.ReadLine();

            Console.Write("Nhap ho ten nhan vien: ");
            this.Ht = Console.ReadLine();

            Console.Write("Nhap ngay cong nhan vien: ");
            this.Nc = int.Parse(Console.ReadLine()) ;
        }


        public void xuat()
        {
            Console.WriteLine("Ma so nhan vien: " + this.Ms);

            Console.WriteLine("Ho ten nhan vien: " + this.Ht);

            Console.WriteLine("Ngay cong nhan vien: " + this.nc.ToString());
        }
        // Ham tinh luong 
        public int tinhluong()
        {
            return this.Nc * LuongNgay;
        }
        public Double tinhthuong()
        {
            if (Xl == 'A')
            {
                return tinhluong() * 0.05;
            }
            else if (Xl == 'B')
            {
                return tinhluong() * 0.02;
            }
            else
            {
                return 0;
            }
        }
        // Ham tinh thuong


    }
}
