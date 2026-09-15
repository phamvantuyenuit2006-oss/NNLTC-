using System;

namespace NNLTC.Phan1_NhapXuatCoBan
{
    /// <summary>
    /// BÀI 4: NHẬP SỐ NGUYÊN CÓ KIỂM TRA LỖI
    /// Yêu cầu:
    /// Làm lại bài 3, nhưng thông báo lỗi khi x hay y không phải là số nguyên.
    /// Sử dụng int.TryParse() để kiểm tra tính hợp lệ và xử lý ngoại lệ an toàn.
    /// </summary>
    public static class Bai04_NhapSoNguyenKiemTraLoi
    {
        /// <summary>
        /// Hàm hỗ trợ nhập số nguyên an toàn, lặp lại cho đến khi người dùng nhập đúng số nguyên
        /// </summary>
        /// <param name="tenBien">Tên của biến cần nhập (x hoặc y) để hiển thị thông báo</param>
        /// <returns>Số nguyên hợp lệ đã được kiểm tra</returns>
        private static int NhapSoNguyenHopLe(string tenBien)
        {
            int giaTri;
            while (true)
            {
                Console.Write($"Nhap so nguyen {tenBien}: ");
                string? input = Console.ReadLine();

                // int.TryParse trả về true nếu chuỗi chuyển đổi thành công sang int, ngược lại trả về false
                if (int.TryParse(input, out giaTri))
                {
                    return giaTri; // Nhập đúng định dạng số nguyên -> trả về giá trị
                }

                // Thông báo lỗi rõ ràng theo yêu cầu đề bài
                Console.WriteLine($"[Lỗi]: Giá trị nhập vào '{input}' không phải là số nguyên hợp lệ! Vui lòng nhập lại.");
            }
        }

        /// <summary>
        /// Phương thức thực thi chính của Bài 4
        /// </summary>
        public static void Chay()
        {
            Console.WriteLine("==================================================================");
            Console.WriteLine("         BÀI 4: NHẬP SỐ NGUYÊN (BẮT LỖI KHI NHẬP SAI ĐỊNH DẠNG)   ");
            Console.WriteLine("==================================================================");

            // Nhập số nguyên x với cơ chế bắt lỗi an toàn
            int x = NhapSoNguyenHopLe("x");

            // Nhập số nguyên y với cơ chế bắt lỗi an toàn
            int y = NhapSoNguyenHopLe("y");

            // Tính x^y bằng hàm Math.Pow
            double ketQua = Math.Pow(x, y);

            // Xuất kết quả theo định dạng chuẩn
            Console.WriteLine($"Ket qua {x} mu {y} la: {ketQua}");
            Console.WriteLine("==================================================================");
        }
    }
}
