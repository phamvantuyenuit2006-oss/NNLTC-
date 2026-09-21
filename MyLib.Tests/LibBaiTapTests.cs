using System;
using MyLib;
using Xunit;

namespace MyLib.Tests
{
    public class LibBaiTapTests
    {
        // 1. a = 0, b = 0, c = 0 -> Vo so nghiem (-1)
        [Fact]
        public void GiaiPTBac2_A0_B0_C0_VoSoNghiem()
        {
            double x1 = 0, x2 = 0;
            int result = LibBaiTap.GiaiPTBac2(0, 0, 0, ref x1, ref x2);
            Assert.Equal(-1, result);
        }

        // 2. a = 0, b = 0, c = 5 -> Vo nghiem (0)
        [Fact]
        public void GiaiPTBac2_A0_B0_CKhac0_VoNghiem()
        {
            double x1 = 0, x2 = 0;
            int result = LibBaiTap.GiaiPTBac2(0, 0, 5, ref x1, ref x2);
            Assert.Equal(0, result);
        }

        // 3. a = 0, b = 2, c = -4 -> Phuong trinh bac nhat: 1 nghiem (1, x1 = 2)
        [Fact]
        public void GiaiPTBac2_PhuongTrinhBac1_CoMotNghiem()
        {
            double x1 = 0, x2 = 0;
            int result = LibBaiTap.GiaiPTBac2(0, 2, -4, ref x1, ref x2);
            Assert.Equal(1, result);
            Assert.Equal(2, x1);
        }

        // 4. a = 1, b = 0, c = 1 -> Delta < 0: Vo nghiem (0)
        [Fact]
        public void GiaiPTBac2_DeltaNhoHon0_VoNghiem()
        {
            double x1 = 0, x2 = 0;
            int result = LibBaiTap.GiaiPTBac2(1, 0, 1, ref x1, ref x2);
            Assert.Equal(0, result);
        }

        // 5. a = 1, b = -2, c = 1 -> Delta = 0: Nghiem kep (1, x1 = 1)
        [Fact]
        public void GiaiPTBac2_DeltaBang0_CoNghiemKep()
        {
            double x1 = 0, x2 = 0;
            int result = LibBaiTap.GiaiPTBac2(1, -2, 1, ref x1, ref x2);
            Assert.Equal(1, result);
            Assert.Equal(1, x1);
        }

        // 6. a = 1, b = -3, c = 2 -> Delta > 0: 2 nghiem (2, x1 = 1, x2 = 2)
        [Fact]
        public void GiaiPTBac2_DeltaLonHon0_CoHaiNghiem()
        {
            double x1 = 0, x2 = 0;
            int result = LibBaiTap.GiaiPTBac2(1, -3, 2, ref x1, ref x2);
            Assert.Equal(2, result);
            Assert.Equal(1, x1);
            Assert.Equal(2, x2);
        }

        // 7. a = -1, b = 3, c = -2 -> 2 nghiem luon duoc sap xep tang dan (x1 <= x2)
        [Fact]
        public void GiaiPTBac2_HaiNghiem_LuonDuocSapXepTangDan()
        {
            double x1 = 0, x2 = 0;
            int result = LibBaiTap.GiaiPTBac2(-1, 3, -2, ref x1, ref x2);
            Assert.Equal(2, result);
            Assert.Equal(1, x1);
            Assert.Equal(2, x2);
            Assert.True(x1 <= x2);
        }

        // 8. Test bo sung cho so thuc voi Epsilon (a gan 0 nho hon 1e-9 duoc xem nhu bang 0)
        [Fact]
        public void GiaiPTBac2_HeSoAGanBang0_DungEpsilon()
        {
            double x1 = 0, x2 = 0;
            // a = 1e-12 (< 1e-9) -> coi nhu a = 0 -> phuong trinh bac nhat: 2x - 4 = 0 -> x = 2
            int result = LibBaiTap.GiaiPTBac2(1e-12, 2, -4, ref x1, ref x2);
            Assert.Equal(1, result);
            Assert.Equal(2, x1, precision: 5);
        }

        // 9. Test bo sung cho Delta gan bang 0 voi Epsilon
        [Fact]
        public void GiaiPTBac2_DeltaGanBang0_DungEpsilon_CoNghiemKep()
        {
            double x1 = 0, x2 = 0;
            // x^2 - 2x + 1 = 0
            int result = LibBaiTap.GiaiPTBac2(1.0, -2.0, 1.0, ref x1, ref x2);
            Assert.Equal(1, result);
            Assert.Equal(1.0, x1, precision: 5);
        }
    }
}
