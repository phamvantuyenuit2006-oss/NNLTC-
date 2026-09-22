using System;

namespace ThucHanh02.Phan1_ThietKeLopCoBan
{
    /// <summary>
    /// BÀI 1.3: LỚP PERSON (QUẢN LÝ THÔNG TIN MỘT NGƯỜI)
    /// </summary>
    public class Person
    {
        // 1. Fields
        private string _id;
        private string _name;
        private int _yob; // Year of Birth (Nam sinh)
        private int _yod; // Year of Death (Nam mat, 0 neu con song)

        // 2. Properties
        public string Id
        {
            get => _id;
            set => _id = value ?? "";
        }

        public string Name
        {
            get => _name;
            set => _name = value ?? "";
        }

        public int Yob
        {
            get => _yob;
            set => _yob = value;
        }

        public int Yod
        {
            get => _yod;
            set => _yod = value < 0 ? 0 : value;
        }

        // 3. Constructors
        // Default Constructor
        public Person()
        {
            _id = "000";
            _name = "Chua dat ten";
            _yob = DateTime.Now.Year;
            _yod = 0; // 0 nghia la con song
        }

        // Parameter Constructor
        public Person(string id, string name, int yob, int yod = 0)
        {
            _id = id ?? "";
            _name = name ?? "";
            _yob = yob;
            _yod = yod < 0 ? 0 : yod;
        }

        // Copy Constructor
        public Person(Person other)
        {
            if (other != null)
            {
                _id = other._id;
                _name = other._name;
                _yob = other._yob;
                _yod = other._yod;
            }
            else
            {
                _id = "000";
                _name = "Chua dat ten";
                _yob = DateTime.Now.Year;
                _yod = 0;
            }
        }

        // 4. Methods
        // Kiem tra nguoi con song hay khong (yod == 0 la con song)
        public bool IsLiving()
        {
            return _yod == 0;
        }

        // Nhap du lieu
        public void Input()
        {
            Console.Write("Nhap ma dinh danh (ID): ");
            _id = Console.ReadLine() ?? "";

            Console.Write("Nhap ho ten (Name): ");
            _name = Console.ReadLine() ?? "";

            Console.Write("Nhap nam sinh (YOB): ");
            int.TryParse(Console.ReadLine(), out _yob);

            Console.Write("Nhap nam mat (YOD - nhap 0 neu con song): ");
            int.TryParse(Console.ReadLine(), out _yod);
            if (_yod < 0) _yod = 0;
        }

        // Xuat du lieu
        public void Output()
        {
            string trangThai = IsLiving() ? "Con song" : $"Da mat (nam {_yod})";
            Console.WriteLine($"ID: {_id}, Ten: {_name}, Nam sinh: {_yob}, Nam mat: {_yod} [{trangThai}]");
        }

        public override string ToString()
        {
            string trangThai = IsLiving() ? "Con song" : $"Da mat ({_yod})";
            return $"Person[ID={_id}, Name={_name}, YOB={_yob}, YOD={_yod}, Status={trangThai}]";
        }
    }
}
