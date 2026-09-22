using System;
using System.Collections.Generic;
using ThucHanh02.Phan1_ThietKeLopCoBan;
using ThucHanh02.Phan2_ThietKeLopNangCao;
using ThucHanh02.Phan3_KeThuaDaHinh;
using Xunit;

namespace ThucHanh02.Tests
{
    public class ThucHanh02Tests
    {
        // ==========================================
        // PHẦN 1: THIẾT KẾ LỚP CƠ BẢN
        // ==========================================

        [Fact]
        public void Bai1_1_SinhVien_TinhTuoiChinhXac()
        {
            var sv = new SinhVien("Nguyen Van A", 2000);
            int expectedAge = DateTime.Now.Year - 2000;
            Assert.Equal(expectedAge, sv.TinhTuoi());
        }

        [Fact]
        public void Bai1_2_Point_ToanTuVaKhoangCachTrungDiem()
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);

            // Khoảng cách
            Assert.Equal(5.0, p1.KhoangCach(p2), precision: 4);
            Assert.Equal(5.0, Point.KhoangCach(p1, p2), precision: 4);

            // Trung điểm
            Point mid = Point.TrungDiem(p1, p2);
            Assert.Equal(1.5, mid.X);
            Assert.Equal(2.0, mid.Y);

            // Toán tử +, -, -
            Point pAdd = p1 + p2;
            Assert.Equal(3.0, pAdd.X);
            Assert.Equal(4.0, pAdd.Y);

            Point pNeg = -p2;
            Assert.Equal(-3.0, pNeg.X);
            Assert.Equal(-4.0, pNeg.Y);
        }

        [Fact]
        public void Bai1_3_Person_IsLiving()
        {
            var living = new Person("01", "A", 1990, 0);
            var deceased = new Person("02", "B", 1920, 2000);

            Assert.True(living.IsLiving());
            Assert.False(deceased.IsLiving());
        }

        [Fact]
        public void Bai1_4_PhanSo_ToanTuVaRutGon()
        {
            PhanSo ps1 = new PhanSo(1, 2);
            PhanSo ps2 = new PhanSo(1, 3);

            // Cộng: 1/2 + 1/3 = 5/6
            PhanSo sum = ps1 + ps2;
            Assert.Equal(5, sum.TuSo);
            Assert.Equal(6, sum.MauSo);

            // Trừ: 1/2 - 1/3 = 1/6
            PhanSo sub = ps1 - ps2;
            Assert.Equal(1, sub.TuSo);
            Assert.Equal(6, sub.MauSo);

            // Nhân: 1/2 * 1/3 = 1/6
            PhanSo mul = ps1 * ps2;
            Assert.Equal(1, mul.TuSo);
            Assert.Equal(6, mul.MauSo);

            // Chia: (1/2) / (1/3) = 3/2
            PhanSo div = ps1 / ps2;
            Assert.Equal(3, div.TuSo);
            Assert.Equal(2, div.MauSo);

            // So sánh
            Assert.True(ps1 > ps2);
            Assert.True(ps2 < ps1);
            Assert.True(new PhanSo(2, 4) == new PhanSo(1, 2));
        }

        [Fact]
        public void Bai1_5_DonThuc_TinhGiaTriVaDaoHam()
        {
            // P(x) = 3 * x^2
            DonThuc p = new DonThuc(3, 2);

            // P(2) = 3 * 4 = 12
            Assert.Equal(12.0, p.TinhGiaTri(2));

            // P'(x) = 6 * x^1
            DonThuc dp = p.DaoHam();
            Assert.Equal(6.0, dp.HeSo);
            Assert.Equal(1, dp.SoMu);
        }

        // ==========================================
        // PHẦN 2: THIẾT KẾ LỚP NÂNG CAO
        // ==========================================

        [Fact]
        public void Bai2_1_ArrayPoint_IndexerHoatDongDung()
        {
            ArrayPoint ap = new ArrayPoint();
            ap.Add(new Point(1, 1));
            ap.Add(new Point(2, 2));

            Assert.Equal(2, ap.Count);
            Assert.Equal(1.0, ap[0].X);
            Assert.Equal(2.0, ap[1].Y);

            ap[0] = new Point(10, 20);
            Assert.Equal(10.0, ap[0].X);
        }

        [Fact]
        public void Bai2_2_PersonList_LivingPeopleLocDung()
        {
            PersonList plist = new PersonList();
            plist.Add(new Person("01", "A", 1990, 0));
            plist.Add(new Person("02", "B", 1920, 1999));
            plist.Add(new Person("03", "C", 2000, 0));

            PersonList living = plist.LivingPeople();
            Assert.Equal(2, living.Count);
            Assert.Equal("01", living[0].Id);
            Assert.Equal("03", living[1].Id);
        }

        [Fact]
        public void Bai2_3_DaySo_IndexerVaTimSoChan()
        {
            DaySo ds = new DaySo(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.Equal(6, ds.Length);
            Assert.Equal(3, ds[2]);

            DaySo chan = ds.TimCacSoChan();
            Assert.Equal(3, chan.Length);
            Assert.Equal(2, chan[0]);
            Assert.Equal(4, chan[1]);
            Assert.Equal(6, chan[2]);
        }

        [Fact]
        public void Bai2_4_MangHaiChieu_IndexerVaTimSNT()
        {
            MangHaiChieu m2 = new MangHaiChieu(2, 2);
            m2[0, 0] = 4; m2[0, 1] = 5;
            m2[1, 0] = 7; m2[1, 1] = 9;

            List<int> snt = m2.TimCacSoNguyenTo();
            Assert.Contains(5, snt);
            Assert.Contains(7, snt);
            Assert.DoesNotContain(4, snt);
            Assert.DoesNotContain(9, snt);
        }

        [Fact]
        public void Bai2_3b_DaThuc_TinhGiaTriChinhXac()
        {
            // P(x) = 1 + 2x + 3x^2
            DaThuc dt = new DaThuc(new double[] { 1, 2, 3 });
            // P(2) = 1 + 2(2) + 3(4) = 1 + 4 + 12 = 17
            Assert.Equal(17.0, dt.TinhGiaTri(2));
        }

        [Fact]
        public void Bai2_4b_DayPhanSo_TinhTongChinhXac()
        {
            DayPhanSo dps = new DayPhanSo();
            dps.Add(new PhanSo(1, 2)); // 1/2
            dps.Add(new PhanSo(1, 3)); // 1/3
            dps.Add(new PhanSo(1, 6)); // 1/6

            // 1/2 + 1/3 + 1/6 = 1/1 = 1
            PhanSo tong = dps.TinhTong();
            Assert.Equal(1, tong.TuSo);
            Assert.Equal(1, tong.MauSo);
        }

        [Fact]
        public void Bai2_5_PhongBan_TinhLuongTruNgayVang()
        {
            var pb = new PhongBan("Phong IT");
            // 10tr - 2 * 100k = 9.8tr
            pb.Add(new NhanVienPhongBan("A", 10000000, 2));
            // 8tr - 0 = 8tr
            pb.Add(new NhanVienPhongBan("B", 8000000, 0));

            Assert.Equal(17800000.0, pb.TinhTongLuong());
        }

        // ==========================================
        // PHẦN 3: KẾ THỪA VÀ ĐA HÌNH
        // ==========================================

        [Fact]
        public void Bai3_1_3_2_3_3_SapXepInterfaceVaDelegate()
        {
            SinhVienSortable[] ds = new SinhVienSortable[]
            {
                new SinhVienSortable("01", "B", 7.0),
                new SinhVienSortable("02", "A", 9.0),
                new SinhVienSortable("03", "C", 8.0)
            };

            // Sắp xếp bằng Interface (Giảm dần theo điểm)
            ThuatToanSapXepInterface.SapXep(ds, new SoSanhDiemGiamDan());
            Assert.Equal("02", ds[0].MaSV); // 9.0
            Assert.Equal("03", ds[1].MaSV); // 8.0
            Assert.Equal("01", ds[2].MaSV); // 7.0

            // Sắp xếp bằng Delegate (Tăng dần theo điểm)
            ThuatToanSapXepDelegate.SapXep(ds, (x, y) => x.DiemTB.CompareTo(y.DiemTB));
            Assert.Equal("01", ds[0].MaSV); // 7.0
            Assert.Equal("03", ds[1].MaSV); // 8.0
            Assert.Equal("02", ds[2].MaSV); // 9.0
        }

        [Fact]
        public void Bai3_5_TinhLuongNhanVien_DaHinh()
        {
            // KD: 8tr + 2 * 500k = 9tr
            NhanVien nvKD = new NhanVienKinhDoanh("KD01", "A", 8000000, 2);
            Assert.Equal(9000000.0, nvKD.TinhLuong());

            // SX <= 3000: 2000 * 1000 = 2tr
            NhanVien nvSX1 = new NhanVienSanXuat("SX01", "B", 2000);
            Assert.Equal(2000000.0, nvSX1.TinhLuong());

            // SX > 3000: 4000 * 1000 * 1.05 = 4.2tr
            NhanVien nvSX2 = new NhanVienSanXuat("SX02", "C", 4000);
            Assert.Equal(4200000.0, nvSX2.TinhLuong());
        }

        [Fact]
        public void Bai3_6_TinhDiemThiSinh_ChuyenVaSieuCup()
        {
            // Chuyên: 8 + 8 + 8 + 2 (TA 9.5 >= 9) = 26
            ThiSinh tsChuyen = new ThiSinhChuyen("C01", "A", 8.0, 8.0, 8.0, 9.5);
            Assert.Equal(26.0, tsChuyen.TinhTongDiem());

            // Chuyên: 7 + 7 + 7 + 1 (TA 7.5 trong [7, 8]) = 22
            ThiSinh tsChuyen2 = new ThiSinhChuyen("C02", "B", 7.0, 7.0, 7.0, 7.5);
            Assert.Equal(22.0, tsChuyen2.TinhTongDiem());

            // Siêu Cúp: 8 + 9 + 9 + 9.5 = 35.5
            ThiSinh tsSieuCup = new ThiSinhSieuCup("SC01", "C", 8.0, 9.0, 9.0, 9.5);
            Assert.Equal(35.5, tsSieuCup.TinhTongDiem());
        }
    }
}
