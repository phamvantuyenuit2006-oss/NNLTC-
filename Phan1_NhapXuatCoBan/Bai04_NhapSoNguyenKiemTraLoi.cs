using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
    /// <summary>
    /// BÀI 4: NHẬP SỐ NGUYÊN CÓ KIỂM TRA LỖI (SỬ DỤNG TRYPARSE)
    /// </summary>
    public static class Bai04_NhapSoNguyenKiemTraLoi
    {
        public static void Chay()
        {
            Console.WriteLine("=== BÀI 4: NHẬP SỐ NGUYÊN (KIỂM TRA LỖI HỢP LỆ) ===");

            int x, y;

            // Nhập x và lặp lại nếu không phải số nguyên
            while (true)
            {
                Console.Write("Nhap so nguyen x: ");
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    break;
                }
                Console.WriteLine("Loi: Gia tri nhap vao khong phai la so nguyen! Vui long nhap lai.");
            }

            // Nhập y và lặp lại nếu không phải số nguyên
            while (true)
            {
                Console.Write("Nhap so nguyen y: ");
                if (int.TryParse(Console.ReadLine(), out y))
                {
                    break;
                }
                Console.WriteLine("Loi: Gia tri nhap vao khong phai la so nguyen! Vui long nhap lai.");
            }

            // Tính và in kết quả
            double ketQua = Math.Pow(x, y);
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
        }
    }
}
