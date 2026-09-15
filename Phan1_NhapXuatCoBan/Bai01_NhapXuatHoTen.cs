using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
    /// <summary>
    /// BÀI 1: MÃ NGUỒN CHƯƠNG TRÌNH & THAO TÁC VỚI MSIL (ILDASM / ILASM)
    /// Yêu cầu:
    /// - B1: Dùng chương trình Visual Studio.Net viết chương trình nhập họ tên và xuất họ tên đã nhập ra màn hình console.
    /// - B2: Dùng chương trình MSIL Disassembler (ildasm.exe) để xem mã MSIL của file PE và lưu sang file *.IL.
    /// - B3: Dùng chương trình MSIL Assembler (ilasm.exe) để chuyển file *.IL sang lại file PE.
    /// </summary>
    public static class Bai01_NhapXuatHoTen
    {
        /// <summary>
        /// Phương thức thực thi chính của Bài 1
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("  BÀI 1: NHẬP XUẤT HỌ TÊN & TÌM HIỂU MÃ NGUỒN TRUNG GIAN (MSIL)  ");
            Console.WriteLine("==================================================================");

            // B1: Nhập họ tên từ bàn phím và in ra màn hình Console
            Console.Write("Nhập họ tên: ");
            // Console.ReadLine(): Đọc dòng văn bản từ bàn phím trả về kiểu string (hoặc null)
            string? hoTen = Console.ReadLine();

            // Console.WriteLine(): Xuất chuỗi văn bản và tự động xuống dòng
            Console.WriteLine($"Họ tên vừa nhập: {hoTen}");

            // B2 & B3: Hướng dẫn chi tiết cách sử dụng công cụ ILDASM và ILASM
            Console.WriteLine("\n------------------------------------------------------------------");
            Console.WriteLine("HƯỚNG DẪN THỰC HIỆN BƯỚC 2 & BƯỚC 3 (ILDASM & ILASM):");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("1. Mở 'Developer Command Prompt for Visual Studio' với quyền Administrator.");
            Console.WriteLine("2. Điều hướng đến thư mục chứa file PE (.dll hoặc .exe) sau khi build:");
            Console.WriteLine("   Ví dụ: bin\\Debug\\net10.0\\");
            Console.WriteLine("3. Bước 2 - Xem và trích xuất mã MSIL bằng ILDASM:");
            Console.WriteLine("   > ildasm NNLTC.dll /out=NNLTC.il");
            Console.WriteLine("   -> Thao tác này phân rã file thực thi PE thành file văn bản chứa mã IL (*.il).");
            Console.WriteLine("4. Bước 3 - Đóng gói lại từ file MSIL sang file PE bằng ILASM:");
            Console.WriteLine("   > ilasm NNLTC.il /dll /output=NNLTC_Rebuilt.dll");
            Console.WriteLine("   -> Thao tác này biên dịch ngược mã IL trở lại thành file PE nhị phân thực thi.");
            Console.WriteLine("==================================================================");
        }
    }
}
