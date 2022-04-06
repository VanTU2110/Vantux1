using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_KT
{
    internal class Program
    {
        struct Cong_Nhan
        {
            public int ID;
            public string Name;
            public int Ngay_Cong;

        }
        static Cong_Nhan[] CN;
        static int n;
        static void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap so luong cong nhan cua cong xuong : ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 0);
            CN = new Cong_Nhan[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap ma cong nhan: ");
                CN[i].ID= int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap ten cua cong nhan: ");
                CN[i].Name= Console.ReadLine();
                do
                {
                    Console.WriteLine("Nhap so ngay cong cua cong nhan < 31ngay cong ");
                    CN[i].Ngay_Cong= int.Parse(Console.ReadLine());
                }
                while (n< 0 && n>32);
            }
            
        }
        static void Hien_Thi()
        {
            int i;
            Console.WriteLine("\n Danh sach cong nhan \n");
            Console.WriteLine("STT\tMa Cong Nhan\nHo Ten\tSo Ngay Cong");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}\t{1}\t{2}\t\t{3}\t",i+1,CN[i].ID,CN[i].Name,CN[i].Ngay_Cong);
            }
        }
        static void Cham_Chi()
        {
            int Max, i;
            Max = 0;
            for (i = 0; i < n; i++)
            {
                if (CN[i].Ngay_Cong > Max)
                    Max = CN[i].Ngay_Cong;
            }
            // In ra nhung cong nhan co so ngay cong cao nhat
            int j = 0;
            for (i = 0; i < n; i++)
            {
                if (CN[i].Ngay_Cong== Max)
                {
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}", ++j, CN[i].ID,CN[i].Name,CN[i].Ngay_Cong); ;
                }
            }
        }
        static void Tim_Kiem()
        {
            bool kt;
            string ten;
            Console.WriteLine("Nhap ten nguoi ban can tim kiem : ");
            ten = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                kt = CN[i].Name.Contains(ten);
                if (kt = true)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}", CN[i].ID, CN[i].Name, CN[i].Ngay_Cong);
                }
                else break;
            }

        }
        static int Menu()
        {
            Console.Write("\n\n\n\t\t\t1. Nhap danh sach cong nhan");
            Console.Write("\n\t\t\t2. Hien thi danh sach cong nhan");
            Console.Write("\n\t\t\t3. Danh sach cong nhan co so ngay cong nhieu nhat ");
            Console.Write("\n\t\t\t4. Tim kiem cong nhan ");
            Console.Write("\n\t\t\t5. Thoat khoi chuong trinh");
            Console.Write("\n\t\t\tBan hay chon mot muc (1->5): ");
            int Tam;
            Tam = int.Parse(Console.ReadLine());
            return Tam;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            do
            {
                switch (Menu())
                {
                    case 1: Nhap(); break;
                    case 2: Hien_Thi();Console.ReadKey() ;break;
                    case 3: Cham_Chi();Console.ReadKey();break;
                    case 4: Tim_Kiem();Console.ReadKey();break;
                    case 5 : Environment.Exit(0);break;// Thoat khoi chuong trinh
                }
                Console.Clear();
            }
            while (true);

        }
    }
}
