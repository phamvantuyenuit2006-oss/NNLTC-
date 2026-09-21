# CÂU HỎI ÔN TẬP VÀ GIẢI THÍCH CHI TIẾT
## Môn học: Ngôn ngữ lập trình C# (Thực hành 01)

---

### Câu 1: Class Library khác Console Application ở điểm nào?
| Tiêu chí | Class Library (Thư viện lớp) | Console Application (Ứng dụng dòng lệnh) |
| :--- | :--- | :--- |
| **Định dạng đầu ra** | File `.dll` (Dynamic Link Library) | File `.exe` (Executable) và `.dll` |
| **Điểm nhập (Entry Point)** | **Không có** hàm `static void Main()` | **Bắt buộc có** hàm `Main()` (hoặc Top-level statements) |
| **Khả năng chạy độc lập**| **Không thể chạy trực tiếp** từ Terminal/HĐH | **Chạy trực tiếp** được từ Terminal/Console |
| **Mục đích sử dụng** | Đóng gói logic, thuật toán, mô hình dữ liệu để nhiều project khác tái sử dụng thông qua `ProjectReference` | Giao tiếp với người dùng (nhập/xuất bàn phím, màn hình), điều phối luồng thực thi |

---

### Câu 2: `ProjectReference` khác với `using` như thế nào?
* **`ProjectReference` (Cấu hình ở mức độ Project/Build):**
  * Được khai báo trong file cấu hình `.csproj` (hoặc lệnh `dotnet add reference`).
  * Nhiệm vụ: Báo cho trình biên dịch (MSBuild) biết project hiện tại phụ thuộc vào assembly `.dll` nào để nạp thư viện đó vào quá trình biên dịch và đóng gói output.
  * Ví dụ trong `.csproj`:
    ```xml
    <ItemGroup>
      <ProjectReference Include="..\MyLib\MyLib.csproj" />
    </ItemGroup>
    ```
* **`using` (Chỉ thị ở mức độ Mã nguồn - Code):**
  * Được viết ở đầu file mã nguồn `.cs`.
  * Nhiệm vụ: Giúp trình biên dịch nhận diện không gian tên (namespace), cho phép lập trình viên gọi trực tiếp tên lớp (ví dụ `LibBaiTap`) mà không cần phải gõ tên đầy đủ kèm namespace (`MyLib.LibBaiTap`).

---

### Câu 3: Tại sao có `using MyLib;` nhưng vẫn có thể bị lỗi nếu chưa `ProjectReference`?
* **Nguyên nhân:**
  * `using MyLib;` chỉ đơn thuần là chỉ dẫn cú pháp trong phạm vi file `.cs`.
  * Nếu chưa khai báo `ProjectReference`, trình biên dịch hoàn toàn **không biết mã nhị phân/assembly `MyLib.dll` nằm ở đâu** trong hệ thống tập tin.
* **Lỗi Compiler phát sinh:**
  ```text
  error CS0246: The type or namespace name 'MyLib' could not be found (are you missing a using directive or an assembly reference?)
  ```
* **Cách khắc phục:** Chạy lệnh dotnet CLI:
  ```bash
  dotnet add Buoi01Prj/Buoi01Prj.csproj reference MyLib/MyLib.csproj
  ```

---

### Câu 4: Từ khóa `public` có ý nghĩa gì khi class nằm trong thư viện được project khác sử dụng?
* Trong C#, mức độ truy cập mặc định của một `class` là `internal` (chỉ có thể truy cập bên trong cùng một Assembly/Project).
* Khi đặt từ khóa **`public`** trước `class` hoặc `method` trong Class Library (`MyLib`), nó mở rộng phạm vi truy cập ra ngoài Assembly, cho phép bất kỳ project nào có tham chiếu (`ProjectReference`) đến `MyLib` đều có thể nhìn thấy, khởi tạo và gọi phương thức đó.

---

### Câu 5: Khi một project có nhiều `Main()`, `StartupObject` dùng để làm gì?
* **Vấn đề:** Khi một project có từ 2 class trở lên cùng chứa hàm `public static void Main()`, trình biên dịch sẽ gặp xung đột Entry Point và báo lỗi:
  ```text
  error CS0017: Program has more than one entry point defined.
  ```
* **Ý nghĩa của `StartupObject`:**
  * Dùng để chỉ định tường minh class nào (kèm đầy đủ Namespace) sẽ chứa hàm `Main()` chính thức được thực thi khi chạy ứng dụng.
  * Cấu hình trong file `.csproj`:
    ```xml
    <PropertyGroup>
      <StartupObject>Buoi01Prj.GiaiPTBac2</StartupObject>
    </PropertyGroup>
    ```

---

### Câu 6: `[Fact]` trong xUnit có ý nghĩa gì?
* **`[Fact]`** là một Attribute (thuộc tính metadata) trong thư viện **xUnit**.
* Nó đánh dấu một phương thức là một **Test Case đơn lẻ, độc lập**.
* Một phương thức được gán `[Fact]` sẽ được Test Runner (như `dotnet test` hoặc Test Explorer trong Visual Studio/VS Code) tự động phát hiện, thực thi và kiểm tra kết quả qua các lệnh `Assert`.
* `[Fact]` dùng cho các trường hợp kiểm thử luôn có dữ liệu cố định (khác với `[Theory]` dùng cho kiểm thử tham số hóa).

---

### Câu 7: Test nào kiểm tra nhánh `x1 > x2` trong hàm `GiaiPTBac2`?
* **Tên Test Case:** `GiaiPTBac2_HaiNghiem_LuonDuocSapXepTangDan()`
* **Bộ dữ liệu kiểm thử:** $a = -1, b = 3, c = -2$.
* **Giải thích:**
  * Phương trình: $-x^2 + 3x - 2 = 0 \Leftrightarrow x^2 - 3x + 2 = 0 \Rightarrow x \in \{1, 2\}$.
  * Áp dụng công thức nghiệm đại số chuẩn:
    $$x_1 = \frac{-b - \sqrt{\Delta}}{2a} = \frac{-3 - 1}{2 \times (-1)} = \frac{-4}{-2} = 2$$
    $$x_2 = \frac{-b + \sqrt{\Delta}}{2a} = \frac{-3 + 1}{2 \times (-1)} = \frac{-2}{-2} = 1$$
  * Ban đầu, $x_1 = 2 > x_2 = 1$. Nhánh lệnh `if (x1 > x2)` sẽ kích hoạt việc hoán đổi giá trị (`swap`) để kết quả trả về luôn đảm bảo $x_1 = 1, x_2 = 2$ ($x_1 \le x_2$).

---

### Câu 8: Tại sao không nên phụ thuộc hoàn toàn vào phép so sánh `delta == 0` với kiểu `double`?
* **Bản chất kỹ thuật:**
  * Kiểu `double` (chuẩn IEEE 754) biểu diễn số thực dưới dạng nhị phân dấu phẩy động.
  * Do hữu hạn số bit, các phép toán số thực (`*`, `-`, `+`, `/`) thường phát sinh **sai số làm tròn (precision issues)**.
  * Một giá trị lý thuyết bằng $0$ khi tính bằng máy tính có thể trở thành $0.000000000000000055$ hoặc $-0.000000000000000021$.
  * Phép so sánh tuyệt đối `delta == 0.0` sẽ trả về `false`, khiến phương trình có nghiệm kép bị nhận diện sai thành 2 nghiệm phân biệt hoặc vô nghiệm.
* **Giải pháp chuẩn xác:**
  * Sử dụng hằng số sai số nhỏ (Epsilon): `const double EPS = 1e-9;`
  * So sánh thông qua khoảng cách tuyệt đối:
    ```csharp
    if (Math.Abs(delta) <= EPS)
    {
        // Coi như delta == 0 (Nghiệm kép)
    }
    ```
