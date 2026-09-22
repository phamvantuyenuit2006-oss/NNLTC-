using System;
using System.Collections.Generic;
using ThucHanh02.Phan1_ThietKeLopCoBan;

namespace ThucHanh02.Phan2_ThietKeLopNangCao
{
    /// <summary>
    /// BÀI 2.2: LỚP PERSONLIST QUẢN LÝ NHÂN KHẨU
    /// </summary>
    public class PersonList
    {
        // 1. Field
        private List<Person> _list;

        // 2. Properties & Indexer
        public int Count => _list.Count;

        public Person this[int index]
        {
            get
            {
                if (index < 0 || index >= _list.Count)
                    throw new IndexOutOfRangeException("Chi so index vuot qua so luong nguoi trong danh sach.");
                return _list[index];
            }
            set
            {
                if (index < 0 || index >= _list.Count)
                    throw new IndexOutOfRangeException("Chi so index vuot qua so luong nguoi trong danh sach.");
                _list[index] = value;
            }
        }

        // 3. Constructors
        // Default Constructor
        public PersonList()
        {
            _list = new List<Person>();
        }

        // Copy Constructor
        public PersonList(PersonList other)
        {
            _list = new List<Person>();
            if (other != null)
            {
                for (int i = 0; i < other.Count; i++)
                {
                    _list.Add(new Person(other[i]));
                }
            }
        }

        // 4. Methods
        // Thêm một Person vào danh sách
        public void Add(Person x)
        {
            if (x != null)
            {
                _list.Add(x);
            }
        }

        // Trả về một PersonList những người còn sống (yod == 0)
        public PersonList LivingPeople()
        {
            PersonList living = new PersonList();
            foreach (var p in _list)
            {
                if (p.IsLiving())
                {
                    living.Add(new Person(p));
                }
            }
            return living;
        }

        // Nhập danh sách nhân khẩu
        public void Input()
        {
            Console.Write("Nhap so luong nguoi trong danh sach: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                _list.Clear();
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"\n--- Nhap thong tin nguoi thu {i + 1} ---");
                    Person p = new Person();
                    p.Input();
                    _list.Add(p);
                }
            }
        }

        // Xuất danh sách nhân khẩu
        public void Output()
        {
            if (_list.Count == 0)
            {
                Console.WriteLine("Danh sach trong.");
                return;
            }

            Console.WriteLine($"=== DANH SACH NHAN KHAU ({_list.Count} nguoi) ===");
            for (int i = 0; i < _list.Count; i++)
            {
                Console.Write($"[{i + 1}] ");
                _list[i].Output();
            }
        }

        public override string ToString()
        {
            return $"PersonList[Total={Count}, Living={LivingPeople().Count}]";
        }
    }
}
