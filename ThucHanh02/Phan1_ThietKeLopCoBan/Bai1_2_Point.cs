using System;

namespace ThucHanh02.Phan1_ThietKeLopCoBan
{
    /// <summary>
    /// BÀI 1.2: THIẾT KẾ LỚP POINT (ĐIỂM TRONG MẶT PHẲNG 2D)
    /// </summary>
    public class Point
    {
        // 1. Fields
        private double _x;
        private double _y;

        // 2. Properties
        public double X
        {
            get => _x;
            set => _x = value;
        }

        public double Y
        {
            get => _y;
            set => _y = value;
        }

        // 3. Constructors
        // Default Constructor: khoi tao x = 0, y = 0
        public Point()
        {
            _x = 0;
            _y = 0;
        }

        // Parameter Constructor
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        // Copy Constructor
        public Point(Point other)
        {
            if (other != null)
            {
                _x = other._x;
                _y = other._y;
            }
            else
            {
                _x = 0;
                _y = 0;
            }
        }

        // 4. Methods
        public void Input()
        {
            Console.Write("Nhap toa do x: ");
            double.TryParse(Console.ReadLine(), out _x);

            Console.Write("Nhap toa do y: ");
            double.TryParse(Console.ReadLine(), out _y);
        }

        public void Output()
        {
            Console.WriteLine($"({_x}, {_y})");
        }

        public override string ToString()
        {
            return $"({_x}, {_y})";
        }

        // 5. Operator Overloading
        // Cong 2 diem: A + B
        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        // Tru 2 diem: A - B
        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        // Lay am 1 diem: -A (toan tu 1 ngoi)
        public static Point operator -(Point a)
        {
            return new Point(-a.X, -a.Y);
        }

        // 6. Chức năng nâng cao
        // (a) Khoảng cách giữa 2 điểm
        // Cách 1: Phương thức thành viên
        public double KhoangCach(Point other)
        {
            if (other == null) return 0;
            double dx = _x - other._x;
            double dy = _y - other._y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        // Cách 2: Phương thức tĩnh
        public static double KhoangCach(Point a, Point b)
        {
            if (a == null || b == null) return 0;
            return a.KhoangCach(b);
        }

        // (b) Trung điểm của 2 điểm
        // Cách 1: Phương thức thành viên
        public Point TrungDiem(Point other)
        {
            if (other == null) return new Point(_x, _y);
            return new Point((_x + other._x) / 2.0, (_y + other._y) / 2.0);
        }

        // Cách 2: Phương thức tĩnh
        public static Point TrungDiem(Point a, Point b)
        {
            if (a == null) return b != null ? new Point(b) : new Point();
            if (b == null) return new Point(a);
            return a.TrungDiem(b);
        }
    }
}
