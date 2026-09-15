using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
    /// <summary>
    /// BÀI 5: MENU TÍNH TOÁN VỚI SỐ THỰC
    /// Yêu cầu:
    /// Viết chương trình in ra menu sau lên màn hình và xử lý các lựa chọn tương ứng:
    /// MENU
    /// 1. Nhap hai gia tri so thuc cho x, y
    /// 2. Tinh x^y
    /// 3. Tinh can bac 2 cua x va y
    /// 4. Thoat
    /// Chon chuc nang: 
    /// </summary>
    public static class Bai05_MenuSoThuc
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 5
        /// </summary>
        public static void Chay()
        {
            double x = 0;
            double y = 0;
            bool daNhap = false; // Cờ kiểm tra người dùng đã nhập x, y ở chức năng 1 chưa
            bool dangChay = true; // Cờ điều khiển vòng lặp của Menu

            while (dangChay)
            {
                // In menu theo đúng chuẩn định dạng đề bài yêu cầu
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
                Console.WriteLine("2. Tinh x^y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Chon chuc nang: ");

                string? luaChon = Console.ReadLine();
                Console.WriteLine();

                switch (luaChon?.Trim())
                {
                    case "1":
                        // Chức năng 1: Nhập 2 số thực x, y
                        x = NhapSoThuc("Nhap so thuc x: ");
                        y = NhapSoThuc("Nhap so thuc y: ");
                        daNhap = true;
                        Console.WriteLine($"=> Đã nhập thành công: x = {x}, y = {y}");
                        break;

                    case "2":
                        // Chức năng 2: Tính lũy thừa x^y
                        if (!daNhap)
                        {
                            Console.WriteLine("(!) Vui lòng chọn chức năng 1 để nhập giá trị cho x và y trước!");
                            break;
                        }

                        // Kiểm tra tính hợp lệ của phép lũy thừa (ví dụ cơ số âm với số mũ không nguyên)
                        double luyThua = Math.Pow(x, y);
                        if (double.IsNaN(luyThua))
                        {
                            Console.WriteLine($"Khong the tinh {x}^{y} trong tap so thuc (ket qua la so phuc/khong xac dinh).");
                        }
                        else
                        {
                            Console.WriteLine($"Ket qua {x}^{y} = {luyThua}");
                        }
                        break;

                    case "3":
                        // Chức năng 3: Tính căn bậc 2 của x và y
                        if (!daNhap)
                        {
                            Console.WriteLine("(!) Vui lòng chọn chức năng 1 để nhập giá trị cho x và y trước!");
                            break;
                        }

                        // Tính căn bậc 2 của x (chỉ tính khi x >= 0)
                        if (x < 0)
                        {
                            Console.WriteLine($"Khong the tinh can bac 2 cua x vi x = {x} < 0");
                        }
                        else
                        {
                            Console.WriteLine($"Can bac 2 cua x ({x}) la: {Math.Sqrt(x)}");
                        }

                        // Tính căn bậc 2 của y (chỉ tính khi y >= 0)
                        if (y < 0)
                        {
                            Console.WriteLine($"Khong the tinh can bac 2 cua y vi y = {y} < 0");
                        }
                        else
                        {
                            Console.WriteLine($"Can bac 2 cua y ({y}) la: {Math.Sqrt(y)}");
                        }
                        break;

                    case "4":
                        // Chức năng 4: Thoát khỏi Menu bài 5
                        Console.WriteLine("Da thoat khoi chuong trinh Menu Bai 5.");
                        dangChay = false;
                        break;

                    default:
                        Console.WriteLine("Lua chon khong hop le! Vui long nhap tu 1 den 4.");
                        break;
                }
            }
        }

        /// <summary>
        /// Hàm hỗ trợ nhập số thực an toàn từ bàn phím
        /// </summary>
        /// <param name="thongBao">Chuỗi nhắc người dùng nhập</param>
        /// <returns>Số thực double hợp lệ</returns>
        private static double NhapSoThuc(string thongBao)
        {
            double giaTri;
            while (true)
            {
                Console.Write(thongBao);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out giaTri))
                {
                    return giaTri;
                }
                Console.WriteLine("Gia tri khong hop le! Vui long nhap mot so thuc hop le.");
            }
        }
    }
}
