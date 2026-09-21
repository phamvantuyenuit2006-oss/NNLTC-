# BÀI THỰC HÀNH 01: CLASS LIBRARY – PROJECT REFERENCE – UNIT TEST VỚI XUNIT

## 📌 1. Cấu trúc Dự án (Project Structure)
```text
NNLTCSharp/
├── NNLTCSharp.sln            # File Solution quản lý các project
├── MyLib/                    # Thư viện Class Library
│   ├── MyLib.csproj
│   └── LibBaiTap.cs          # Cài đặt hàm GiaiPTBac2 (xử lý chính xác số thực với EPS)
├── Buoi01Prj/                # Ứng dụng Console chạy thử và kiểm tra
│   ├── Buoi01Prj.csproj      # Cấu hình ProjectReference đến MyLib và StartupObject
│   └── GiaiPTBac2.cs         # Chứa hàm Main nhập xuất giải phương trình bậc 2
└── MyLib.Tests/              # Project Unit Test với xUnit
    ├── MyLib.Tests.csproj    # Tham chiếu đến MyLib
    └── LibBaiTapTests.cs     # Bộ 9 test case tự động kiểm thử toàn diện
```

---

## 🛠️ 2. Hướng dẫn Thao tác bằng dotnet CLI

### 1. Tạo Solution & Projects
```bash
# Tạo Solution
dotnet new sln -n NNLTCSharp

# Tạo Class Library
dotnet new classlib -n MyLib -o MyLib

# Tạo Console App
dotnet new console -n Buoi01Prj -o Buoi01Prj

# Tạo xUnit Test Project
dotnet new xunit -n MyLib.Tests -o MyLib.Tests
```

### 2. Thêm Project vào Solution & Cấu hình ProjectReference
```bash
# Thêm các project vào Solution
dotnet sln NNLTCSharp.sln add MyLib/MyLib.csproj Buoi01Prj/Buoi01Prj.csproj MyLib.Tests/MyLib.Tests.csproj

# Tham chiếu MyLib từ Buoi01Prj và MyLib.Tests
dotnet add Buoi01Prj/Buoi01Prj.csproj reference MyLib/MyLib.csproj
dotnet add MyLib.Tests/MyLib.Tests.csproj reference MyLib/MyLib.csproj
```

### 3. Build, Run & Chạy Unit Test
```bash
# Build toàn bộ Solution
dotnet build NNLTCSharp.sln

# Chạy chương trình Console
dotnet run --project Buoi01Prj/Buoi01Prj.csproj

# Chạy toàn bộ Unit Test xUnit
dotnet test NNLTCSharp.sln
```

---

## 📊 3. Bảng Kiểm Thử Unit Test (xUnit Test Suite)

| STT | Test Case Name | a | b | c | Kết quả mong đợi | Mục đích kiểm thử | Trạng thái |
|:---:|:---|:---:|:---:|:---:|:---|:---|:---:|
| 1 | `GiaiPTBac2_A0_B0_C0_VoSoNghiem` | 0 | 0 | 0 | `sn = -1` | Phương trình có vô số nghiệm ($0x^2 + 0x + 0 = 0$) | ✅ Passed |
| 2 | `GiaiPTBac2_A0_B0_CKhac0_VoNghiem` | 0 | 0 | 5 | `sn = 0` | Phương trình suy biến vô nghiệm ($0x = -5$) | ✅ Passed |
| 3 | `GiaiPTBac2_PhuongTrinhBac1_CoMotNghiem` | 0 | 2 | -4 | `sn = 1; x1 = 2` | Suy biến thành phương trình bậc nhất ($2x - 4 = 0$) | ✅ Passed |
| 4 | `GiaiPTBac2_DeltaNhoHon0_VoNghiem` | 1 | 0 | 1 | `sn = 0` | $\Delta < 0$ ($x^2 + 1 = 0$) -> Vô nghiệm | ✅ Passed |
| 5 | `GiaiPTBac2_DeltaBang0_CoNghiemKep` | 1 | -2 | 1 | `sn = 1; x1 = 1` | $\Delta = 0$ ($x^2 - 2x + 1 = 0$) -> Nghiệm kép | ✅ Passed |
| 6 | `GiaiPTBac2_DeltaLonHon0_CoHaiNghiem` | 1 | -3 | 2 | `sn = 2; x1 = 1, x2 = 2` | $\Delta > 0$ -> Hai nghiệm phân biệt | ✅ Passed |
| 7 | `GiaiPTBac2_HaiNghiem_LuonDuocSapXepTangDan` | -1 | 3 | -2 | `sn = 2; x1 = 1, x2 = 2` | Kiểm tra nghiệm luôn được hoán đổi tăng dần ($x_1 \le x_2$) | ✅ Passed |
| 8 | `GiaiPTBac2_HeSoAGanBang0_DungEpsilon` | 1e-12 | 2 | -4 | `sn = 1; x1 = 2` | Kiểm tra xử lý sai số số thực với `EPS = 1e-9` | ✅ Passed |
| 9 | `GiaiPTBac2_DeltaGanBang0_DungEpsilon_CoNghiemKep` | 1.0 | -2.0 | 1.0 | `sn = 1; x1 = 1` | Kiểm tra nghiệm kép với độ chính xác epsilon | ✅ Passed |

---

## 📝 4. Trả Lời Chi Tiết 8 Câu Hỏi Ôn Tập (Mục 3)

### Câu 1: Class Library khác Console Application ở điểm nào?
* **Class Library (`.dll`):** Không có điểm nhập thực thi (`Main()`), không chạy độc lập được. Mục đích là đóng gói các lớp, phương thức tái sử dụng để các ứng dụng khác tham chiếu đến.
* **Console Application (`.exe`):** Có hàm `Main()` (Entry point), có thể chạy độc lập trực tiếp từ hệ điều hành hoặc terminal.

### Câu 2: `ProjectReference` khác với `using` như thế nào?
* **`ProjectReference` (ở cấp độ Project/Build):** Khai báo cho trình biên dịch (MSBuild) biết project A phụ thuộc vào thư viện project B, giúp nạp file assembly `.dll` tương ứng vào khi build.
* **`using` (ở cấp độ Mã nguồn Code):** Chỉ thị giúp trình biên dịch nhận diện namespace trong code để không phải gõ tên đầy đủ (Fully Qualified Name), ví dụ viết `LibBaiTap` thay vì `MyLib.LibBaiTap`.

### Câu 3: Tại sao có `using MyLib` nhưng vẫn có thể bị lỗi nếu chưa `ProjectReference`?
* Vì `using MyLib` chỉ là chỉ thị tìm kiếm tên trong mã nguồn. Nếu project chưa có `ProjectReference` đến `MyLib.csproj`, trình biên dịch không hề biết assembly `MyLib.dll` nằm ở đâu để liên kết, dẫn đến lỗi: `error CS0246 / CS0234: The type or namespace name 'MyLib' could not be found`.

### Câu 4: Từ khóa `public` có ý nghĩa gì khi class nằm trong thư viện được project khác sử dụng?
* Từ khóa `public` thiết lập phạm vi truy cập (access modifier) rộng nhất, cho phép các assembly/project bên ngoài có thể nhìn thấy và khởi tạo/gọi các phương thức của class đó. Nếu không khai báo `public` (mặc định là `internal`), chỉ các file cùng project thư viện mới truy cập được.

### Câu 5: Khi một project có nhiều `Main()`, `StartupObject` dùng để làm gì?
* Khi một project chứa nhiều class có hàm `Main()`, trình biên dịch sẽ báo lỗi `error CS0017: Program has more than one entry point defined`.
* Thuộc tính `<StartupObject>Namespace.ClassName</StartupObject>` trong file `.csproj` dùng để chỉ định chính xác class nào chứa hàm `Main()` sẽ được làm Entry Point khi khởi chạy ứng dụng.

### Câu 6: `[Fact]` trong xUnit có ý nghĩa gì?
* `[Fact]` là một Attribute của xUnit dùng để đánh dấu một phương thức là **Test Case đơn lẻ** (luôn kiểm tra một điều kiện bất biến cố định mà không cần truyền tham số đầu vào từ bên ngoài).

### Câu 7: Test nào kiểm tra nhánh `x1 > x2` trong hàm `GiaiPTBac2`?
* Test case `GiaiPTBac2_HaiNghiem_LuonDuocSapXepTangDan` với bộ hệ số $a = -1, b = 3, c = -2$.
* Khi $a < 0$, công thức nghiệm thông thường sẽ cho nghiệm ban đầu $x_1 = 2$ và $x_2 = 1$ ($x_1 > x_2$), test case này kiểm tra logic hoán vị (swap) để nghiệm trả về luôn thỏa mãn $x_1 \le x_2$.

### Câu 8: Tại sao không nên phụ thuộc hoàn toàn vào phép so sánh `delta == 0` với kiểu `double`?
* Vì số thực dấu phẩy động (`float`, `double`) theo chuẩn IEEE 754 có **sai số biểu diễn và sai số làm tròn** trong quá trình tính toán số học. Ví dụ phép tính có thể cho ra kết quả `0.0000000000000001` thay vì `0.0`.
* Do đó, so sánh chuẩn cho số thực phải dùng khoảng sai số nhỏ (Epsilon):
  ```csharp
  const double EPS = 1e-9;
  if (Math.Abs(delta) <= EPS) { /* xem như delta == 0 */ }
  ```
