using System;

namespace ThucHanh02.Phan1_ThietKeLopCoBan
{
    /// <summary>
    /// BÀI 1.1: TÍNH TUỔI 1 SINH VIÊN
    /// Xây dựng lớp có đầy đủ: Field, Constructor, Property, Method
    /// </summary>
    public class SinhVien
    {
        // 1. Fields
        private string _hoTen;
        private int _namSinh;

        // 2. Properties
        public string HoTen
        {
            get => _hoTen;
            set => _hoTen = value ?? "";
        }

        public int NamSinh
        {
            get => _namSinh;
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    _namSinh = value;
                else
                    _namSinh = DateTime.Now.Year;
            }
        }

        // 3. Constructors
        // Default Constructor
        public SinhVien()
        {
            _hoTen = "Chua co ten";
            _namSinh = DateTime.Now.Year;
        }

        // Parameter Constructor
        public SinhVien(string hoTen, int namSinh)
        {
            _hoTen = hoTen ?? "";
            NamSinh = namSinh;
        }

        // Copy Constructor
        public SinhVien(SinhVien other)
        {
            if (other != null)
            {
                _hoTen = other._hoTen;
                _namSinh = other._namSinh;
            }
            else
            {
                _hoTen = "Chua co ten";
                _namSinh = DateTime.Now.Year;
            }
        }

        // 4. Methods
        // Tính tuổi sinh viên
        public int TinhTuoi()
        {
            return DateTime.Now.Year - _namSinh;
        }

        // Nhập thông tin sinh viên từ bàn phím
        public void Input()
        {
            Console.Write("Nhap ho ten sinh vien: ");
            _hoTen = Console.ReadLine() ?? "";

            Console.Write("Nhap nam sinh: ");
            if (int.TryParse(Console.ReadLine(), out int ns))
            {
                NamSinh = ns;
            }
        }

        // Xuất thông tin sinh viên và tuổi
        public void Output()
        {
            Console.WriteLine($"Ho ten: {_hoTen}, Nam sinh: {_namSinh}, Tuoi: {TinhTuoi()}");
        }

        public override string ToString()
        {
            return $"[SinhVien] Ho ten: {_hoTen}, Nam sinh: {_namSinh}, Tuoi: {TinhTuoi()}";
        }
    }
}
