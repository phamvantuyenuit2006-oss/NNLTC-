using System;
using System.Text;
using NNLTC.Phan1_NhapXuatCoBan;
using NNLTC.Phan2_ThamSoPhuongThuc;
using NNLTC.Phan3_Chuoi;
using NNLTC.Phan4_XayDungLop;
using NNLTC.Phan5_MangArrayList;

namespace NNLTC
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
                Console.WriteLine("==================================================================");
                Console.WriteLine("                CHUONG TRINH THUC HANH NGON NGU C#                ");
                Console.WriteLine("==================================================================");
                Console.WriteLine(" [PHAN 1: NHAP XUAT DU LIEU CO BAN]");
                Console.WriteLine("   1. Bai 1 : Nhap xuat ho ten & MSIL (ildasm/ilasm)");
                Console.WriteLine("   2. Bai 2 : Xuat va nhap chuoi (Tran Anh Minh)");
                Console.WriteLine("   3. Bai 3 : Nhap so nguyen tinh x^y");
                Console.WriteLine("   4. Bai 4 : Nhap so nguyen tinh x^y (kiem tra loi hop le)");
                Console.WriteLine("   5. Bai 5 : Menu tinh toan so thuc (x^y, can bac 2)");
                Console.WriteLine(" ----------------------------------------------------------------");
                Console.WriteLine(" [PHAN 2: THAM SO PHUONG THUC: THAM TRI, REF, OUT]");
                Console.WriteLine("   6. Bai 6 : Tim max 3 so nguyen (return gia tri)");
                Console.WriteLine("   7. Bai 7 : Kiem tra so nguyen to (phuong thuc bool)");
                Console.WriteLine("   8. Bai 8 : Hoan vi 2 so thuc (tham chieu ref)");
                Console.WriteLine("   9. Bai 9 : Tim max va min 3 so thuc (tham chieu out)");
                Console.WriteLine(" ----------------------------------------------------------------");
                Console.WriteLine(" [PHAN 3: CHUOI - STRING, STRINGBUILDER]");
                Console.WriteLine("  10. Bai 10: Kiem tra chuoi doi xung (Palindrome)");
                Console.WriteLine("  11. Bai 11: Dao nguoc chuoi (StringBuilder)");
                Console.WriteLine("  12. Bai 12: Xu ly chuoi (chu thuong, chu hoa, dem so tu)");
                Console.WriteLine(" ----------------------------------------------------------------");
                Console.WriteLine(" [PHAN 4: XAY DUNG LOP CO BAN]");
                Console.WriteLine("  13. Bai 13: Quan ly thong tin 1 Sinh Vien");
                Console.WriteLine("  14. Bai 14: Tinh luong 1 Nhan Vien (tru ngay vang)");
                Console.WriteLine(" ----------------------------------------------------------------");
                Console.WriteLine(" [PHAN 5: MANG, ARRAYLIST]");
                Console.WriteLine("  15. Bai 15: Mang 1 chieu (nhap, xuat, max/min, mang so nguyen to)");
                Console.WriteLine("  16. Bai 16: Sap xep mang ho ten n nguoi tang dan");
                Console.WriteLine("  17. Bai 17: Mang 2 chieu (ngau nhien [10, 100], tach mang chan le)");
                Console.WriteLine(" ================================================================");
                Console.WriteLine("   0. Thoat chuong trinh");
                Console.WriteLine("==================================================================");
                Console.Write(" >> Nhap lua chon cua ban (0 - 17): ");

                string? chon = Console.ReadLine();
                Console.WriteLine();

                switch (chon?.Trim())
                {
                    case "1":
                        Bai01_NhapXuatHoTen.Chay();
                        break;
                    case "2":
                        Bai02_XuatNhapChuoi.Chay();
                        break;
                    case "3":
                        Bai03_NhapSoNguyen.Chay();
                        break;
                    case "4":
                        Bai04_NhapSoNguyenKiemTraLoi.Chay();
                        break;
                    case "5":
                        Bai05_MenuSoThuc.Chay();
                        break;
                    case "6":
                        Bai06_TimMaxBaSo.Chay();
                        break;
                    case "7":
                        Bai07_KiemTraSoNguyenTo.Chay();
                        break;
                    case "8":
                        Bai08_HoanViSoThuc.Chay();
                        break;
                    case "9":
                        Bai09_TimMaxMinBaSoThuc.Chay();
                        break;
                    case "10":
                        Bai10_KiemTraChuoiDoiXung.Chay();
                        break;
                    case "11":
                        Bai11_DaoChuoi.Chay();
                        break;
                    case "12":
                        Bai12_XuLyChuoiKyTu.Chay();
                        break;
                    case "13":
                        Bai13_QuanLySinhVien.Chay();
                        break;
                    case "14":
                        Bai14_TinhLuongNhanVien.Chay();
                        break;
                    case "15":
                        Bai15_MangMotChieu.Chay();
                        break;
                    case "16":
                        Bai16_SapXepHoTen.Chay();
                        break;
                    case "17":
                        Bai17_MangHaiChieu.Chay();
                        break;
                    case "0":
                        tiepTuc = false;
                        Console.WriteLine("Cam on ban da su dung chuong trinh! Tam biet.");
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le! Nhan phim bat ky de tiep tuc...");
                        break;
                }

                if (tiepTuc)
                {
                    Console.WriteLine("\n==================================================================");
                    Console.Write("Nhan Enter de quay lai Menu chinh...");
                    Console.ReadLine();
                }
            }
        }
    }
}
