using System;
using System.Collections.Generic;
using MyLib;

namespace ThucHanh02.Phan3_KeThuaDaHinh
{
    /// <summary>
    /// BÀI 3.4: XÂY DỰNG LỚP CONSOLEMENU TỔNG QUÁT HỖ TRỢ SỰ KIỆN VÀ KẾ THỪA
    /// </summary>
    public class ConsoleMenu
    {
        public string Title { get; set; } = "MENU CHUC NANG";
        protected List<string> _menuItems = new List<string>();

        // Sự kiện khi người dùng chọn một mục menu
        public event Action<int>? Choose;

        public void AddMenuItem(string itemText)
        {
            _menuItems.Add(itemText);
        }

        public virtual void Display()
        {
            Console.WriteLine("\n=======================================================");
            Console.WriteLine($"  {Title.ToUpper()}");
            Console.WriteLine("=======================================================");
            for (int i = 0; i < _menuItems.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {_menuItems[i]}");
            }
            Console.WriteLine("  0. Thoat chuong trinh");
            Console.WriteLine("=======================================================");
            Console.Write(" >> Thuc hien: ");
        }

        public virtual void Run()
        {
            bool running = true;
            while (running)
            {
                Display();
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    if (choice == 0)
                    {
                        running = false;
                        Console.WriteLine("Ban da thoat chuong trinh.");
                        break;
                    }

                    Console.WriteLine($"Ban thuc hien chuc nang {choice}");
                    OnChoose(choice);
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le! Vui long nhap so.");
                }
            }
        }

        protected virtual void OnChoose(int choice)
        {
            // Kích hoạt sự kiện Choose nếu có đăng ký
            Choose?.Invoke(choice);
        }
    }

    /// <summary>
    /// Ứng dụng menu cho bài toán Giải Phương Trình Bậc 2 qua kế thừa ConsoleMenu
    /// </summary>
    public class PTBac2Console : ConsoleMenu
    {
        public PTBac2Console()
        {
            Title = "CHUONG TRINH GIAI PHUONG TRINH BAC 2";
            AddMenuItem("Chay vi du mau (a = 1, b = -3, c = 2)");
            AddMenuItem("Nhap he so a, b, c tu ban phim va giai");
            AddMenuItem("Kiem tra truong hop vo so nghiem (a = 0, b = 0, c = 0)");
            AddMenuItem("Kiem tra truong hop nghiem kep (a = 1, b = -2, c = 1)");
        }

        protected override void OnChoose(int choice)
        {
            base.OnChoose(choice);

            double x1 = 0, x2 = 0;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("\n--- GIAI MAU: a = 1, b = -3, c = 2 ---");
                    int sn1 = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);
                    InKetQua(sn1, x1, x2);
                    break;

                case 2:
                    Console.WriteLine("\n--- NHAP HE SO a, b, c ---");
                    Console.Write("Nhap a: "); double.TryParse(Console.ReadLine(), out double a);
                    Console.Write("Nhap b: "); double.TryParse(Console.ReadLine(), out double b);
                    Console.Write("Nhap c: "); double.TryParse(Console.ReadLine(), out double c);
                    int sn2 = LibBaiTap.GiaiPTBac2(a, b, c, ref x1, ref x2);
                    InKetQua(sn2, x1, x2);
                    break;

                case 3:
                    Console.WriteLine("\n--- TEST: a = 0, b = 0, c = 0 ---");
                    int sn3 = LibBaiTap.GiaiPTBac2(0, 0, 0, ref x1, ref x2);
                    InKetQua(sn3, x1, x2);
                    break;

                case 4:
                    Console.WriteLine("\n--- TEST: a = 1, b = -2, c = 1 ---");
                    int sn4 = LibBaiTap.GiaiPTBac2(1, -2, 1, ref x1, ref x2);
                    InKetQua(sn4, x1, x2);
                    break;
            }
        }

        private void InKetQua(int soNghiem, double x1, double x2)
        {
            switch (soNghiem)
            {
                case -1: Console.WriteLine(">> Ket qua: Vo so nghiem."); break;
                case 0: Console.WriteLine(">> Ket qua: Vo nghiem."); break;
                case 1: Console.WriteLine($">> Ket qua: 1 nghiem (nghiem kep): x = {x1}"); break;
                case 2: Console.WriteLine($">> Ket qua: 2 nghiem phan biet: x1 = {x1}, x2 = {x2}"); break;
            }
        }
    }
}
