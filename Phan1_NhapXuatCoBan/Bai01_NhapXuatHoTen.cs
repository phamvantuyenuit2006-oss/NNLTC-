using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
 
    public static class Bai01_NhapXuatHoTen
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 1: NHẬP XUẤT HỌ TÊN & MSIL ===");

            // Bước 1: Nhập và in họ tên
            Console.Write("Nhap ho ten: ");
            string? hoTen = Console.ReadLine();
            Console.WriteLine($"Ho ten vua nhap: {hoTen}");

            // Hướng dẫn thao tác ildasm & ilasm
            Console.WriteLine("\n--- HUONG DAN ILDASM & ILASM ---");
            Console.WriteLine("1. Mo Developer Command Prompt for Visual Studio");
            Console.WriteLine("2. Xem ma MSIL: ildasm NNLTC.dll /out=NNLTC.il");
            Console.WriteLine("3. Bien dich nguoc sang PE: ilasm NNLTC.il /dll /output=NNLTC_Rebuilt.dll");
        }
    }
}
