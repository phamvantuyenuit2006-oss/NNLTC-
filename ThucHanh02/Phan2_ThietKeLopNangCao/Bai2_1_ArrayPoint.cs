using System;
using System.Collections;
using System.Collections.Generic;
using ThucHanh02.Phan1_ThietKeLopCoBan;

namespace ThucHanh02.Phan2_ThietKeLopNangCao
{
    /// <summary>
    /// BÀI 2.1: THIẾT KẾ LỚP ARRAYPOINT
    /// - Field: Một ArrayList các Point
    /// - Indexer: Truy cập Point thứ i của ArrayList
    /// </summary>
    public class ArrayPoint
    {
        // 1. Field
        private ArrayList _points;

        // 2. Properties
        public int Count => _points.Count;

        // 3. Indexer cho phép truy cập Point thứ i
        public Point this[int index]
        {
            get
            {
                if (index < 0 || index >= _points.Count)
                    throw new IndexOutOfRangeException($"Chi so index {index} nam ngoai pham vi [0, {_points.Count - 1}].");
                return (Point)_points[index]!;
            }
            set
            {
                if (index < 0 || index >= _points.Count)
                    throw new IndexOutOfRangeException($"Chi so index {index} nam ngoai pham vi [0, {_points.Count - 1}].");
                _points[index] = value;
            }
        }

        // 4. Constructors
        public ArrayPoint()
        {
            _points = new ArrayList();
        }

        public ArrayPoint(int capacity)
        {
            _points = new ArrayList(capacity);
        }

        // Copy Constructor
        public ArrayPoint(ArrayPoint other)
        {
            _points = new ArrayList();
            if (other != null)
            {
                for (int i = 0; i < other.Count; i++)
                {
                    _points.Add(new Point(other[i]));
                }
            }
        }

        // 5. Methods
        public void Add(Point p)
        {
            if (p != null)
            {
                _points.Add(p);
            }
        }

        public void Input()
        {
            Console.Write("Nhap so luong diem: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                _points.Clear();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"--- Nhap toa do diem thu {i + 1} ---");
                    Point p = new Point();
                    p.Input();
                    _points.Add(p);
                }
            }
        }

        public void Output()
        {
            Console.WriteLine($"Danh sach {Count} diem:");
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine($"Point[{i}] = {this[i]}");
            }
        }

        public override string ToString()
        {
            List<string> pts = new List<string>();
            for (int i = 0; i < Count; i++)
            {
                pts.Add(this[i].ToString());
            }
            return $"ArrayPoint[{string.Join(", ", pts)}]";
        }
    }
}
