using System;
using MyLib;

namespace Buoi01Prj
{
    public class GiaiPTBac2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=================================================");
            Console.WriteLine("  CHUONG TRINH GIAI PHUONG TRINH BAC HAI (PTB2)  ");
            Console.WriteLine("=================================================");

            // 1. Chay thu nghiem mau theo tai lieu (a = 1, b = -3, c = 2)
            Console.WriteLine("\n--- 1. CHAY TEST MAU: a = 1, b = -3, c = 2 ---");
            double x1 = 0, x2 = 0;
            int sn = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);
            Console.WriteLine($"So nghiem: {sn}");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");

            // 2. Cho phep nguoi dung nhap a, b, c tu ban phim
            Console.WriteLine("\n--- 2. NHAP HE SO TU BAN PHIM ---");
            try
            {
                Console.Write("Nhap he so a: ");
                double a = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Nhap he so b: ");
                double b = double.Parse(Console.ReadLine() ?? "0");

                Console.Write("Nhap he so c: ");
                double c = double.Parse(Console.ReadLine() ?? "0");

                double nghiem1 = 0, nghiem2 = 0;
                int soNghiem = LibBaiTap.GiaiPTBac2(a, b, c, ref nghiem1, ref nghiem2);

                Console.WriteLine("\n--- KET QUA GIAI PHUONG TRINH ---");
                switch (soNghiem)
                {
                    case -1:
                        Console.WriteLine("Ket luan: Phuong trinh co VO SO NGHIEM.");
                        break;
                    case 0:
                        Console.WriteLine("Ket luan: Phuong trinh VO NGHIEM.");
                        break;
                    case 1:
                        Console.WriteLine($"Ket luan: Phuong trinh co 1 NGHIEM (hoac nghiem kep): x = {nghiem1}");
                        break;
                    case 2:
                        Console.WriteLine($"Ket luan: Phuong trinh co 2 NGHIEM PHAN BIET:");
                        Console.WriteLine($"  x1 = {nghiem1}");
                        Console.WriteLine($"  x2 = {nghiem2}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Loi nhap lieu: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Minh hoa Bai 4: Xu ly khi project co nhieu ham Main() thong qua StartupObject
    /// </summary>
    public class Program1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main 1 - Program1");
        }
    }

    public class Program2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main 2 - Program2");
        }
    }
}
