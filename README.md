# Ngôn ngữ lập trình C# - Bài tập thực hành (Bài 1 -> Bài 17)

Dự án tổng hợp bài giải và thực hành môn **Ngôn ngữ lập trình C#** bao gồm 17 bài tập từ cơ bản đến nâng cao.

---

## 📑 Danh mục bài tập

### 1. Nhập xuất dữ liệu cơ bản
- **Bài 1:** Chương trình nhập họ tên và xuất họ tên. Hướng dẫn sử dụng `ildasm.exe` và `ilasm.exe` để xem và dịch mã MSIL.
- **Bài 2:** Xuất và nhập chuỗi theo định dạng mẫu.
- **Bài 3:** Nhập 2 số nguyên $x, y$, tính $x^y$.
- **Bài 4:** Nhập số nguyên $x, y$ có kiểm tra lỗi hợp lệ (xử lý exception / `TryParse`).
- **Bài 5:** Menu chức năng tính toán số thực (nhập $x, y$, tính $x^y$, tính căn bậc 2 của $x$ và $y$).

### 2. Tham số phương thức (Tham trị, Tham chiếu `ref`, `out`)
- **Bài 6:** Tìm giá trị lớn nhất của 3 số nguyên (phương thức return giá trị).
- **Bài 7:** Kiểm tra số nguyên tố (phương thức trả về kiểu `bool`).
- **Bài 8:** Hoán vị 2 số thực sử dụng từ khóa `ref`.
- **Bài 9:** Tìm giá trị lớn nhất và nhỏ nhất của 3 số thực sử dụng từ khóa `out`.

### 3. Xử lý Chuỗi (`string`, `StringBuilder`)
- **Bài 10:** Kiểm tra chuỗi đối xứng (Palindrome).
- **Bài 11:** Trả về chuỗi đảo ngược (sử dụng `StringBuilder`).
- **Bài 12:** Chuyển chuỗi sang chữ thường, chữ hoa và đếm số từ.

### 4. Xây dựng Lớp cơ bản (OOP)
- **Bài 13:** Lớp `SinhVien` (Mã SV, Họ tên, Địa chỉ, Năm thứ mấy) có phương thức Nhập và Xuất.
- **Bài 14:** Lớp `NhanVien` (Họ tên, Mức lương, Số ngày vắng) và phương thức tính lương (trừ 100.000 VNĐ / ngày vắng).

### 5. Mảng & ArrayList
- **Bài 15:** Mảng 1 chiều (Nhập mảng $n$ phần tử, In mảng, Tìm Max/Min, Trả về mảng các số nguyên tố).
- **Bài 16:** Nhập mảng họ tên của $n$ người và sắp xếp tăng dần theo bảng chữ cái.
- **Bài 17:** Mảng 2 chiều (Sinh ngẫu nhiên ma trận $A[n \times m]$ trong đoạn $[10, 100]$, in ma trận, tách ra 2 mảng số chẵn và số lẻ).

---

## 🛠️ Hướng dẫn cài đặt & Chạy chương trình

### Yêu cầu môi trường
- [.NET SDK](https://dotnet.microsoft.com/download) (phiên bản .NET 6.0, 7.0, 8.0 hoặc .NET 10.0+)
- Visual Studio / Visual Studio Code / JetBrains Rider

### Cách chạy chương trình
1. Mở terminal tại thư mục dự án:
```bash
dotnet build
dotnet run
```
2. Màn hình console sẽ hiển thị menu tổng hợp từ Bài 1 đến Bài 17. Nhập số tương ứng để chạy từng bài tập.

---

## 🔍 Hướng dẫn Bài 1: MSIL Disassembler (`ildasm`) & Assembler (`ilasm`)

1. Mở **Developer Command Prompt for Visual Studio**.
2. Di chuyển đến thư mục chứa file PE output (`bin/Debug/net.../`):
3. **Disassemble (Trích xuất MSIL từ file .dll/.exe sang .il):**
   ```bash
   ildasm NNLTC.dll /out=NNLTC.il
   ```
4. **Assemble (Biên dịch ngược lại từ mã MSIL .il sang .dll/.exe):**
   ```bash
   ilasm NNLTC.il /dll /output=NNLTC_rebuilt.dll
   ```
