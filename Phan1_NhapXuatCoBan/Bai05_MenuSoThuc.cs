using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
    /// <summary>
    /// BÀI 5: MENU TÍNH TOÁN VỚI SỐ THỰC
    /// </summary>
    public static class Bai05_MenuSoThuc
    {
        public static void Chay()
        {
            double x = 0, y = 0;
            bool daNhap = false;
            int chon;

            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                if (!int.TryParse(Console.ReadLine(), out chon))
                {
                    Console.WriteLine("Vui long nhap mot so tu 1 den 4!");
                    continue;
                }

                switch (chon)
                {
                    case 1:
                        Console.Write("Nhap so thuc x: ");
                        x = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Nhap so thuc y: ");
                        y = Convert.ToDouble(Console.ReadLine());
                        daNhap = true;
                        Console.WriteLine($"=> Da nhap thanh cong: x = {x}, y = {y}");
                        break;

                    case 2:
                        if (!daNhap)
                        {
                            Console.WriteLine("Ban chua nhap x va y! Vui long chon chuc nang 1 truoc.");
                        }
                        else
                        {
                            Console.WriteLine($"Ket qua {x}^{y} = {Math.Pow(x, y)}");
                        }
                        break;

                    case 3:
                        if (!daNhap)
                        {
                            Console.WriteLine("Ban chua nhap x va y! Vui long chon chuc nang 1 truoc.");
                        }
                        else
                        {
                            if (x >= 0)
                                Console.WriteLine($"Can bac 2 cua x ({x}) = {Math.Sqrt(x)}");
                            else
                                Console.WriteLine($"Khong the tinh can bac 2 cua x vi {x} < 0");

                            if (y >= 0)
                                Console.WriteLine($"Can bac 2 cua y ({y}) = {Math.Sqrt(y)}");
                            else
                                Console.WriteLine($"Khong the tinh can bac 2 cua y vi {y} < 0");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Da thoat khoi Menu Bai 5.");
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le! Vui long nhap tu 1 den 4.");
                        break;
                }
            } while (chon != 4);
        }
    }
}
