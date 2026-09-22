# BÀI THỰC HÀNH 02: LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG TRONG C# (OOP)

Kho tài liệu và mã nguồn hoàn chỉnh môn **Lập trình hướng đối tượng trong C#** theo đề cương thực hành Lab 02.

---

## 📌 1. Tổng quan Cấu trúc Dự án
```text
ThucHanh02/
├── ThucHanh02.csproj
├── Program.cs                                  # Menu Console tương tác toàn bộ 18 bài tập
├── Phan1_ThietKeLopCoBan/                      # 1. THIẾT KẾ LỚP CƠ BẢN
│   ├── Bai1_1_SinhVien.cs                      # Bài 1.1: Lớp SinhVien tính tuổi
│   ├── Bai1_2_Point.cs                         # Bài 1.2: Lớp Point (khoảng cách, trung điểm, toán tử +, -, -)
│   ├── Bai1_3_Person.cs                        # Bài 1.3: Lớp Person (quản lý nhân khẩu, IsLiving)
│   ├── Bai1_4_PhanSo.cs                        # Bài 1.4: Lớp PhanSo (Overload +, -, *, /, >, <, ==, !=, rút gọn)
│   └── Bai1_5_DonThuc.cs                       # Bài 1.5: Lớp Đơn thức P(x) = a*x^n (tính giá trị, đạo hàm)
├── Phan2_ThietKeLopNangCao/                    # 2. THIẾT KẾ LỚP NÂNG CAO (MẢNG, LIST, INDEXER)
│   ├── Bai2_1_ArrayPoint.cs                    # Bài 2.1: Lớp ArrayPoint (ArrayList + Indexer)
│   ├── Bai2_2_PersonList.cs                    # Bài 2.2: Lớp PersonList (quản lý nhân khẩu, LivingPeople)
│   ├── Bai2_3_DaySo.cs                         # Bài 2.3: Lớp Dãy số (Mảng 1 chiều, Indexer, tìm số chẵn)
│   ├── Bai2_4_MangHaiChieu.cs                  # Bài 2.4: Lớp Mảng 2 chiều (Indexer (i, j), tìm số nguyên tố)
│   ├── Bai2_3b_DaThuc.cs                       # Bài 2.3b: Lớp Đa thức P(x) (Indexer đơn thức, tính giá trị P(x))
│   ├── Bai2_4b_DayPhanSo.cs                    # Bài 2.4b: Lớp Dãy phân số (tính tổng n phân số)
│   └── Bai2_5_PhongBan.cs                      # Bài 2.5: Lớp Phòng ban (tính tổng lương, trừ 100k/ngày vắng)
└── Phan3_KeThuaDaHinh/                         # 3. KẾ THỪA, ĐA HÌNH, INTERFACE, DELEGATE & EVENT
    ├── Bai3_1_ArraySortIComparable.cs          # Bài 3.1: Sắp xếp Array.Sort với IComparable
    ├── Bai3_2_SapXepInterface.cs               # Bài 3.2: Sắp xếp mảng tổng quát bằng Interface (IMyComparer)
    ├── Bai3_3_SapXepDelegate.cs                # Bài 3.3: Sắp xếp mảng tổng quát bằng Delegate
    ├── Bai3_4_ConsoleMenu.cs                   # Bài 3.4: Lớp ConsoleMenu tổng quát (Kế thừa giải PT bậc 2)
    ├── Bai3_5_TinhLuongNhanVien.cs             # Bài 3.5: Lương NV Kinh doanh & Sản xuất (Kế thừa & Đa hình)
    └── Bai3_6_TinhDiemThiSinh.cs               # Bài 3.6: Điểm thi Tin học (Thí sinh Chuyên & Siêu Cúp)
```

---

## 🛠️ 2. Chi tiết các Bài Tập Thực Hành

### PHẦN 1: THIẾT KẾ LỚP CƠ BẢN
1. **Bài 1.1: Lớp SinhVien:**
   - Field: `_hoTen`, `_namSinh`.
   - Property: `HoTen`, `NamSinh`.
   - Constructors: Default, Parameter, Copy Constructor.
   - Method: `TinhTuoi() = DateTime.Now.Year - NamSinh`, `Input()`, `Output()`.

2. **Bài 1.2: Lớp Point:**
   - Field: `_x`, `_y`; Property: `X`, `Y`.
   - Overload toán tử 2 ngôi: `+`, `-`; toán tử 1 ngôi: lấy âm `-Point`.
   - Tính khoảng cách 2 điểm $A(x_1, y_1)$ và $B(x_2, y_2)$:
     $$d = \sqrt{(x_2 - x_1)^2 + (y_2 - y_1)^2}$$
     Hỗ trợ cả phương thức thành viên `a.KhoangCach(b)` và phương thức tĩnh `Point.KhoangCach(a, b)`.
   - Tính trung điểm $I = \left(\frac{x_1 + x_2}{2}, \frac{y_1 + y_2}{2}\right)$ (thành viên & tĩnh).

3. **Bài 1.3: Lớp Person:**
   - Dữ liệu: `id`, `name`, `yob` (năm sinh), `yod` (năm mất, 0 nếu còn sống).
   - Method `IsLiving()`: trả về `true` nếu `yod == 0`, `false` nếu `yod != 0`.

4. **Bài 1.4: Lớp PhanSo:**
   - Constructors (mặc nhiên, tham số, sao chép).
   - Hàm `RutGon()` dựa trên ước chung lớn nhất (UCLN).
   - Overload toán tử: `+`, `-` (1 ngôi & 2 ngôi), `*`, `/`.
   - Overload so sánh: `>`, `<`, `>=`, `<=`, `==`, `!=`, `Equals()`, `GetHashCode()`.

5. **Bài 1.5: Lớp DonThuc:**
   - $P(x) = a \cdot x^n$ ($a$ là số thực, $n \ge 0$).
   - `TinhGiaTri(double x)`: $P(x) = a \cdot x^n$.
   - `DaoHam()`: $Q(x) = P'(x) = a \cdot n \cdot x^{n - 1}$.

---

### PHẦN 2: THIẾT KẾ LỚP NÂNG CAO (MẢNG, LIST, INDEXER)
1. **Bài 2.1: Lớp ArrayPoint:**
   - Chứa `ArrayList` các `Point`.
   - Cài đặt Indexer `this[int index]` để truy cập điểm thứ $i$.
2. **Bài 2.2: Lớp PersonList:**
   - Quản lý danh sách nhiều `Person`.
   - Phương thức `LivingPeople()`: trả về `PersonList` lọc những người còn sống.
3. **Bài 2.3: Lớp DaySo (Mảng 1 chiều):**
   - Indexer `this[int i]`.
   - Phương thức `TimCacSoChan()`: lọc và trả về dãy các số chẵn.
4. **Bài 2.4: Lớp MangHaiChieu (Mảng 2 chiều $n \times m$):**
   - Indexer 2 chiều `this[int i, int j]`.
   - Phương thức `TimCacSoNguyenTo()`: tìm và trả về danh sách các số nguyên tố trong ma trận.
5. **Bài 2.3b: Lớp DaThuc:**
   - Đa thức gồm $n+1$ đơn thức: $P(x) = a_0 x^0 + a_1 x^1 + \dots + a_n x^n$.
   - Indexer `this[int i]` truy cập đơn thức bậc $i$.
   - `TinhGiaTri(double x)`: tính tổng giá trị của các đơn thức với giá trị $x$.
6. **Bài 2.4b: Lớp DayPhanSo:**
   - Chứa $n$ phân số.
   - `TinhTong()`: tính và rút gọn tổng của $n$ phân số.
7. **Bài 2.5: Lớp PhongBan (Tính lương nhân viên):**
   - Lương thực lãnh = $\max(0, \text{MucLuong} - \text{SoNgayVang} \times 100.000)$.
   - `TinhTongLuong()`: tính tổng tiền lương toàn phòng ban.

---

### PHẦN 3: KẾ THỪA, ĐA HÌNH, INTERFACE, DELEGATE & EVENT
1. **Bài 3.1: Sắp xếp bằng `Array.Sort` với `IComparable<T>`:**
   - Lớp `SinhVienSortable` cài đặt `IComparable<SinhVienSortable>` so sánh Điểm TB tăng dần.
2. **Bài 3.2: Sắp xếp mảng tổng quát bằng Interface:**
   - Định nghĩa `IMyComparer<T>`.
   - Cài đặt `SoSanhDiemGiamDan` và `SoSanhTheoTen`.
   - Thuật toán `ThuatToanSapXepInterface.SapXep(arr, comparer)`.
3. **Bài 3.3: Sắp xếp mảng tổng quát bằng Delegate:**
   - Định nghĩa delegate `HamSoSanh<T>(T a, T b)`.
   - Thuật toán `ThuatToanSapXepDelegate.SapXep(arr, soSanh)` cho phép truyền biểu thức Lambda.
4. **Bài 3.4: Lớp `ConsoleMenu` tổng quát:**
   - Hỗ trợ sự kiện `Choose` và cho phép lớp con kế thừa (`PTBac2Console : ConsoleMenu`) áp dụng giải phương trình bậc hai.
5. **Bài 3.5: Tính lương nhân viên công ty (Đa hình):**
   - Lớp trừu tượng `NhanVien` với phương thức trừu tượng `abstract double TinhLuong()`.
   - `NhanVienKinhDoanh`: $\text{Luong} = \text{LCB} + \text{SoHopDong} \times 500.000$.
   - `NhanVienSanXuat`: $\text{Luong} = \text{SoSanPham} \times 1.000$ (nếu $\text{SoSanPham} > 3000$ thì thưởng thêm 5%: $\text{Luong} \times 1.05$).
6. **Bài 3.6: Tính điểm thí sinh cuộc thi Tin học:**
   - Lớp cơ sở `ThiSinh`: sbd, hoten, bai1, bai2, bai3.
   - `ThiSinhChuyen`: Điểm thưởng tiếng Anh ($7 \le TA < 9$: +1đ, $9 \le TA \le 10$: +2đ). Tổng điểm = 3 bài thi + điểm thưởng.
   - `ThiSinhSieuCup`: Tổng điểm = 3 bài thi lập trình + bài CSDL (tổng 4 bài).

---

## ⚡ 3. Hướng dẫn Chạy & Kiểm thử

```bash
# 1. Build toàn bộ Solution
dotnet build NNLTCSharp.sln

# 2. Chạy Menu tương tác Thực hành 02
dotnet run --project ThucHanh02/ThucHanh02.csproj

# 3. Chạy toàn bộ 24 Unit Test tự động (xUnit)
dotnet test NNLTCSharp.sln
```
