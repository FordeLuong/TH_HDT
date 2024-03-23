using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1
{
    class SinhVien
    {
        public string MaSV;
        public string Hoten;
        public double DTB;
        //public SinhVien(double pDTB)
        //{
        //    DTB = pDTB;
        //}
        public void nhap()
        {
            Console.Write("Moi ban nhap diem trung binh cua sinh vien ");
            DTB = Double.Parse(Console.ReadLine());
        }
        public string xeploai()
        {
            string temp = null;
            if (DTB >= 8)
            {
                temp = "gioi";
            }
            else if (DTB < 8 && DTB >= 6.5)
            {
                temp = "kha";
            }
                   
            else if (DTB < 6.5 && DTB >=5 )
            {
                temp = "trung binh";
            }

            else if (DTB < 5)
            {
                temp = "yeu";
            }
            return temp;
         }
    }
}
