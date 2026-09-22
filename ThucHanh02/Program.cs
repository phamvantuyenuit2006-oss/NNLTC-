using System;
using System.Text;
using ThucHanh02.Phan1_ThietKeLopCoBan;
using ThucHanh02.Phan2_ThietKeLopNangCao;
using ThucHanh02.Phan3_KeThuaDaHinh;

namespace ThucHanh02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.Clear();
                Console.WriteLine("==========================================================================");
                Console.WriteLine("    THỰC HÀNH 02: LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG TRONG C# (OOP)               ");
                Console.WriteLine("==========================================================================");
                Console.WriteLine(" [PHẦN 1: THIẾT KẾ LỚP CƠ BẢN]");
                Console.WriteLine("   1.  Bài 1.1: Lớp SinhVien (tính tuổi sinh viên)");
                Console.WriteLine("   2.  Bài 1.2: Lớp Point (toán tử, khoảng cách, trung điểm)");
                Console.WriteLine("   3.  Bài 1.3: Lớp Person (quản lý người, IsLiving)");
                Console.WriteLine("   4.  Bài 1.4: Lớp PhanSo (Constructor, rút gọn, overload toán tử)");
                Console.WriteLine("   5.  Bài 1.5: Lớp DonThuc (tính giá trị, tính đạo hàm)");
                Console.WriteLine(" ------------------------------------------------------------------------");
                Console.WriteLine(" [PHẦN 2: THIẾT KẾ LỚP NÂNG CAO - MẢNG, LIST, INDEXER]");
                Console.WriteLine("   6.  Bài 2.1: Lớp ArrayPoint (ArrayList + Indexer)");
                Console.WriteLine("   7.  Bài 2.2: Lớp PersonList (quản lý nhân khẩu, LivingPeople)");
                Console.WriteLine("   8.  Bài 2.3: Lớp DaySo (mảng 1 chiều, indexer, tìm số chẵn)");
                Console.WriteLine("   9.  Bài 2.4: Lớp MangHaiChieu (mảng 2 chiều, indexer, tìm SNT)");
                Console.WriteLine("   10. Bài 2.3b: Lớp DaThuc (n+1 đơn thức, indexer, tính giá trị)");
                Console.WriteLine("   11. Bài 2.4b: Lớp DayPhanSo (tính tổng n phân số)");
                Console.WriteLine("   12. Bài 2.5: Lớp PhongBan (tính tổng lương nhân viên phòng ban)");
                Console.WriteLine(" ------------------------------------------------------------------------");
                Console.WriteLine(" [PHẦN 3: KẾ THỪA, ĐA HÌNH, INTERFACE, DELEGATE, EVENT]");
                Console.WriteLine("   13. Bài 3.1: Sắp xếp bằng Array.Sort (IComparable)");
                Console.WriteLine("   14. Bài 3.2: Sắp xếp mảng tổng quát bằng Interface (IMyComparer)");
                Console.WriteLine("   15. Bài 3.3: Sắp xếp mảng tổng quát bằng Delegate");
                Console.WriteLine("   16. Bài 3.4: Lớp ConsoleMenu tổng quát (kế thừa giải PT bậc 2)");
                Console.WriteLine("   17. Bài 3.5: Tính lương nhân viên công ty (Kế thừa & Đa hình)");
                Console.WriteLine("   18. Bài 3.6: Tính điểm thí sinh cuộc thi Tin học (Chuyên, Siêu Cúp)");
                Console.WriteLine(" ========================================================================");
                Console.WriteLine("   0.  Thoát chương trình");
                Console.WriteLine("==========================================================================");
                Console.Write(" >> Nhập lựa chọn của bạn (0 - 18): ");

                string? chon = Console.ReadLine()?.Trim();
                Console.WriteLine();

                switch (chon)
                {
                    case "1":
                        ChayBai1_1();
                        break;
                    case "2":
                        ChayBai1_2();
                        break;
                    case "3":
                        ChayBai1_3();
                        break;
                    case "4":
                        ChayBai1_4();
                        break;
                    case "5":
                        ChayBai1_5();
                        break;
                    case "6":
                        ChayBai2_1();
                        break;
                    case "7":
                        ChayBai2_2();
                        break;
                    case "8":
                        ChayBai2_3();
                        break;
                    case "9":
                        ChayBai2_4();
                        break;
                    case "10":
                        ChayBai2_3b();
                        break;
                    case "11":
                        ChayBai2_4b();
                        break;
                    case "12":
                        ChayBai2_5();
                        break;
                    case "13":
                        Bai3_1_Demo.ChayDemo();
                        break;
                    case "14":
                        ChayBai3_2();
                        break;
                    case "15":
                        ChayBai3_3();
                        break;
                    case "16":
                        ChayBai3_4();
                        break;
                    case "17":
                        ChayBai3_5();
                        break;
                    case "18":
                        ChayBai3_6();
                        break;
                    case "0":
                        tiepTuc = false;
                        Console.WriteLine("Tạm biệt! Cảm ơn bạn đã sử dụng chương trình.");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }

                if (tiepTuc)
                {
                    Console.WriteLine("\n--------------------------------------------------------------------------");
                    Console.Write("Nhấn Enter để quay lại Menu...");
                    Console.ReadLine();
                }
            }
        }

        static void ChayBai1_1()
        {
            Console.WriteLine("=== BÀI 1.1: TÍNH TUỔI SINH VIÊN ===");
            SinhVien sv = new SinhVien();
            sv.Input();
            Console.WriteLine("\nThông tin sinh viên:");
            sv.Output();
        }

        static void ChayBai1_2()
        {
            Console.WriteLine("=== BÀI 1.2: LỚP POINT ===");
            Point a = new Point(3, 4);
            Point b = new Point(0, 0);
            Console.WriteLine($"Điểm A = {a}, Điểm B = {b}");
            Console.WriteLine($"A + B = {a + b}");
            Console.WriteLine($"A - B = {a - b}");
            Console.WriteLine($"-A = {-a}");
            Console.WriteLine($"Khoảng cách AB (thành viên): {a.KhoangCach(b)}");
            Console.WriteLine($"Khoảng cách AB (tĩnh):       {Point.KhoangCach(a, b)}");
            Console.WriteLine($"Trung điểm AB (thành viên):  {a.TrungDiem(b)}");
            Console.WriteLine($"Trung điểm AB (tĩnh):        {Point.TrungDiem(a, b)}");
        }

        static void ChayBai1_3()
        {
            Console.WriteLine("=== BÀI 1.3: LỚP PERSON ===");
            Person p1 = new Person("001", "Nguyen Van A", 1995, 0);
            Person p2 = new Person("002", "Tran Van B", 1920, 2005);
            p1.Output();
            p2.Output();
        }

        static void ChayBai1_4()
        {
            Console.WriteLine("=== BÀI 1.4: LỚP PHÂN SỐ ===");
            PhanSo ps1 = new PhanSo(2, 4);
            PhanSo ps2 = new PhanSo(3, 5);
            Console.WriteLine($"Phân số 1: {ps1}");
            Console.WriteLine($"Phân số 2: {ps2}");
            Console.WriteLine($"ps1 + ps2 = {ps1 + ps2}");
            Console.WriteLine($"ps1 - ps2 = {ps1 - ps2}");
            Console.WriteLine($"ps1 * ps2 = {ps1 * ps2}");
            Console.WriteLine($"ps1 / ps2 = {ps1 / ps2}");
            Console.WriteLine($"ps1 > ps2 : {ps1 > ps2}");
            Console.WriteLine($"ps1 == ps2: {ps1 == ps2}");
        }

        static void ChayBai1_5()
        {
            Console.WriteLine("=== BÀI 1.5: LỚP ĐƠN THỨC P(x) = a*x^n ===");
            DonThuc dt = new DonThuc(3, 2); // 3x^2
            Console.WriteLine($"Đơn thức P(x) = {dt}");
            double x = 2;
            Console.WriteLine($"Giá trị P({x}) = {dt.TinhGiaTri(x)}");
            DonThuc dh = dt.DaoHam();
            Console.WriteLine($"Đạo hàm P'(x) = {dh}");
        }

        static void ChayBai2_1()
        {
            Console.WriteLine("=== BÀI 2.1: LỚP ARRAYPOINT ===");
            ArrayPoint ap = new ArrayPoint();
            ap.Add(new Point(1, 2));
            ap.Add(new Point(3, 4));
            ap.Add(new Point(5, 6));
            ap.Output();
            Console.WriteLine($"Điểm thứ 1 truy cập bằng Indexer ap[1]: {ap[1]}");
        }

        static void ChayBai2_2()
        {
            Console.WriteLine("=== BÀI 2.2: LỚP PERSONLIST ===");
            PersonList plist = new PersonList();
            plist.Add(new Person("01", "Pham Van Tuyen", 2000, 0));
            plist.Add(new Person("02", "Nguyen Van An", 1950, 2020));
            plist.Add(new Person("03", "Le Thi Hoa", 2002, 0));
            plist.Output();
            Console.WriteLine("\n--- Danh sách những người còn sống (LivingPeople) ---");
            plist.LivingPeople().Output();
        }

        static void ChayBai2_3()
        {
            Console.WriteLine("=== BÀI 2.3: LỚP CHỨA MẢNG 1 CHIỀU (DÃY SỐ) ===");
            DaySo ds = new DaySo(new int[] { 1, 2, 4, 7, 8, 11, 14 });
            ds.Output();
            Console.WriteLine($"Phần tử ds[3] qua Indexer: {ds[3]}");
            Console.WriteLine($"Các số chẵn trong dãy: {ds.TimCacSoChan()}");
        }

        static void ChayBai2_4()
        {
            Console.WriteLine("=== BÀI 2.4: LỚP CHỨA MẢNG 2 CHIỀU ===");
            MangHaiChieu m2 = new MangHaiChieu(2, 3);
            m2[0, 0] = 2; m2[0, 1] = 4; m2[0, 2] = 5;
            m2[1, 0] = 7; m2[1, 1] = 9; m2[1, 2] = 11;
            m2.Output();
            Console.WriteLine("Các số nguyên tố trong ma trận: " + string.Join(", ", m2.TimCacSoNguyenTo()));
        }

        static void ChayBai2_3b()
        {
            Console.WriteLine("=== BÀI 2.3b: LỚP ĐA THỨC ===");
            // P(x) = 1 + 2x + 3x^2
            DaThuc dt = new DaThuc(new double[] { 1, 2, 3 });
            dt.Output();
            double x = 2;
            Console.WriteLine($"P({x}) = {dt.TinhGiaTri(x)}");
        }

        static void ChayBai2_4b()
        {
            Console.WriteLine("=== BÀI 2.4b: DÃY PHÂN SỐ ===");
            DayPhanSo dps = new DayPhanSo();
            dps.Add(new PhanSo(1, 2));
            dps.Add(new PhanSo(1, 3));
            dps.Add(new PhanSo(1, 6));
            dps.Output();
        }

        static void ChayBai2_5()
        {
            Console.WriteLine("=== BÀI 2.5: TÍNH LƯƠNG NHÂN VIÊN PHÒNG BAN ===");
            PhongBan pb = new PhongBan("Phong Ky Thuat");
            pb.Add(new NhanVienPhongBan("Nguyen Van A", 10000000, 2)); // 10tr - 200k = 9.8tr
            pb.Add(new NhanVienPhongBan("Tran Thi B", 12000000, 0));  // 12tr
            pb.Add(new NhanVienPhongBan("Le Van C", 8000000, 5));   // 8tr - 500k = 7.5tr
            pb.Output();
        }

        static void ChayBai3_2()
        {
            Console.WriteLine("=== BÀI 3.2: SẮP XẾP MẢNG TỔNG QUÁT BẰNG INTERFACE ===");
            SinhVienSortable[] ds = new SinhVienSortable[]
            {
                new SinhVienSortable("SV01", "Nguyen Van An", 7.5),
                new SinhVienSortable("SV02", "Tran Thi Binh", 8.8),
                new SinhVienSortable("SV03", "Le Van Cuong", 6.2)
            };

            Console.WriteLine("--- Danh sách ban đầu ---");
            foreach (var sv in ds) Console.WriteLine(sv);

            // Sắp xếp giảm dần theo điểm bằng SoSanhDiemGiamDan
            ThuatToanSapXepInterface.SapXep(ds, new SoSanhDiemGiamDan());
            Console.WriteLine("\n--- Sau khi sắp xếp Điểm TB giảm dần ---");
            foreach (var sv in ds) Console.WriteLine(sv);
        }

        static void ChayBai3_3()
        {
            Console.WriteLine("=== BÀI 3.3: SẮP XẾP MẢNG TỔNG QUÁT BẰNG DELEGATE ===");
            int[] numbers = new int[] { 29, 10, 14, 37, 13 };
            Console.WriteLine("Mảng ban đầu: " + string.Join(", ", numbers));

            // Sắp xếp tăng dần bằng delegate
            ThuatToanSapXepDelegate.SapXep(numbers, (a, b) => a.CompareTo(b));
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần: " + string.Join(", ", numbers));
        }

        static void ChayBai3_4()
        {
            Console.WriteLine("=== BÀI 3.4: CONSOLEMENU TỔNG QUÁT (PT BẬC 2) ===");
            PTBac2Console app = new PTBac2Console();
            app.Run();
        }

        static void ChayBai3_5()
        {
            Console.WriteLine("=== BÀI 3.5: TÍNH LƯƠNG NHÂN VIÊN (KẾ THỪA & ĐA HÌNH) ===");
            CongTy cty = new CongTy();
            cty.Add(new NhanVienKinhDoanh("KD01", "Pham Van Tuyen", 8000000, 3)); // 8tr + 3*500k = 9.5tr
            cty.Add(new NhanVienSanXuat("SX01", "Tran Van Hung", 2500));        // 2500 * 1000 = 2.5tr
            cty.Add(new NhanVienSanXuat("SX02", "Nguyen Thi Mai", 4000));       // 4000 * 1000 * 1.05 = 4.2tr
            cty.Output();
        }

        static void ChayBai3_6()
        {
            Console.WriteLine("=== BÀI 3.6: TÍNH ĐIỂM THÍ SINH CUỘC THI TIN HỌC ===");
            CuocThiTinHoc ct = new CuocThiTinHoc();
            ct.TenCuocThi = "Olympic Tin Hoc Sinh Vien 2026";
            // Chuyên: b1=8, b2=9, b3=8, Tiếng Anh = 9.5 (+2 điểm thưởng) -> 8+9+8+2 = 27
            ct.Add(new ThiSinhChuyen("C01", "Pham Van Tuyen", 8.0, 9.0, 8.0, 9.5));
            // Chuyên: b1=7, b2=7, b3=8, Tiếng Anh = 7.5 (+1 điểm thưởng) -> 7+7+8+1 = 23
            ct.Add(new ThiSinhChuyen("C02", "Nguyen Van An", 7.0, 7.0, 8.0, 7.5));
            // Siêu Cúp: b1=9, b2=9, b3=9.5, CSDL = 8.5 -> 9+9+9.5+8.5 = 36
            ct.Add(new ThiSinhSieuCup("SC01", "Le Van Cuong", 9.0, 9.0, 9.5, 8.5));
            ct.Output();
        }
    }
}
