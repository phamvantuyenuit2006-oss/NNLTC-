# Ngôn ngữ lập trình C# - Bài tập & Thực hành

Kho lưu trữ tổng hợp toàn bộ mã nguồn, tài liệu thực hành và bài tập môn **Ngôn ngữ lập trình C#**, bao gồm:
1. 🚀 **Thực hành 01:** Class Library – Project Reference – Unit Test với xUnit (`MyLib`, `Buoi01Prj`, `MyLib.Tests`).
2. 🎯 **Thực hành 02:** Lập trình hướng đối tượng trong C# (OOP: Thiết kế lớp cơ bản, Lớp nâng cao, Mảng/List/Indexer, Interface, Delegate/Event, Kế thừa & Đa hình) (`ThucHanh02`, `ThucHanh02.Tests`).
3. 🏆 **Demo OOP Generic Comparable:** Thuật toán sắp xếp & tìm kiếm Generic (SelectionSort, InsertionSort, LinearSearch, BinarySearch) trên các lớp `Contact`, `Car`, `Circle`, `Human` (`Demo_GenericComparable`, `Demo_GenericComparable.Tests`).
4. 📑 **Tổng hợp 17 bài tập thực hành C# cơ bản đến nâng cao** (`NNLTC.csproj`).

---

## 🚀 1. THỰC HÀNH 01: CLASS LIBRARY – PROJECT REFERENCE – UNIT TEST (XUNIT)
* 📂 **`MyLib`:** Thư viện lớp giải phương trình bậc hai `GiaiPTBac2` xử lý chính xác sai số số thực với $\text{EPS} = 10^{-9}$.
* 📂 **`Buoi01Prj`:** Console App tham chiếu `MyLib`, minh họa cấu hình `<StartupObject>` khi có nhiều hàm `Main()`.
* 📂 **`MyLib.Tests`:** Bộ 9 Unit Test xUnit tự động kiểm thử toàn bộ các nhánh rẽ.

📄 **Xem chi tiết:** [BAITAP_THUCHANH_01.md](BAITAP_THUCHANH_01.md) | [CAU_HOI_ON_TAP.md](CAU_HOI_ON_TAP.md)

```bash
dotnet test MyLib.Tests/MyLib.Tests.csproj
dotnet run --project Buoi01Prj/Buoi01Prj.csproj
```

---

## 🎯 2. THỰC HÀNH 02: LẬP TRÌNH HƯỚNG ĐỐI TƯỢNG TRONG C# (OOP)
Dự án hoàn chỉnh gồm 18 bài tập chia theo 3 phần trọng tâm:
* 🔹 **Phần 1: Thiết kế lớp cơ bản:** Lớp `SinhVien`, `Point` (toán tử +, -, lấy âm, khoảng cách, trung điểm theo cả 2 cách thành viên & tĩnh), `Person` (`IsLiving`), `PhanSo` (Overload toán tử 1 ngôi, 2 ngôi, so sánh, tự động rút gọn), `DonThuc` (tính giá trị $P(x)$, đạo hàm).
* 🔹 **Phần 2: Thiết kế lớp nâng cao:** Lớp `ArrayPoint` (ArrayList + Indexer), `PersonList` (`LivingPeople`), `DaySo` (mảng 1 chiều, tìm số chẵn), `MangHaiChieu` (mảng 2 chiều, tìm số nguyên tố), `DaThuc` (n+1 đơn thức), `DayPhanSo` (tổng phân số), `PhongBan` (tính lương phòng ban trừ ngày vắng).
* 🔹 **Phần 3: Kế thừa & Đa hình, Interface, Delegate, Event:** Sắp xếp bằng `Array.Sort` (`IComparable`), Sắp xếp mảng tổng quát bằng `Interface` (`IMyComparer`), Sắp xếp bằng `Delegate`, Lớp `ConsoleMenu` tổng quát (kế thừa giải PT bậc 2), Lương nhân viên kinh doanh & sản xuất (`NhanVien`), Điểm thi tin học thí sinh chuyên & siêu cúp (`ThiSinh`).
* 📂 **`ThucHanh02.Tests`:** Bộ 15 Unit Test tự động kiểm thử toàn diện các lớp OOP.

📄 **Xem chi tiết:** [BAITAP_THUCHANH_02.md](BAITAP_THUCHANH_02.md)

```bash
# Chạy Menu tương tác Thực hành 02 (Chọn bài từ 1 đến 18)
dotnet run --project ThucHanh02/ThucHanh02.csproj

# Chạy Unit Tests Thực hành 02
dotnet test ThucHanh02.Tests/ThucHanh02.Tests.csproj
```

---

## 🏆 3. DEMO OOP GENERIC SORTING & SEARCHING (COMPARABLE)
* 📂 **`Demo_GenericComparable`:** Triển khai SelectionSort, InsertionSort, LinearSearch, BinarySearch cho các lớp `Contact` (Slide bài giảng), `Car`, `Circle`, `Human` (Bài tập 4).
* 📂 **`Demo_GenericComparable.Tests`:** 4 Unit Test tự động kiểm thử giải thuật Generic.

```bash
# Chạy Demo Sorting & Searching
dotnet run --project Demo_GenericComparable/GenericSortSearch.csproj

# Chạy Unit Tests Generic
dotnet test Demo_GenericComparable.Tests/GenericSortSearch.Tests.csproj
```

---

## ⚡ 4. CHẠY TOÀN BỘ 28 UNIT TESTS TRÊN SOLUTION
```bash
dotnet test NNLTCSharp.sln
```
*(Kết quả: 28/28 tests passed 100%)*
