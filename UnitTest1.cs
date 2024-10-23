using De2;

namespace ThiThuDe2Nuitr
{
    [TestFixture]
    public class Tests
    {


        [Test]
        public void Case1TBC()
        {
            int toan = 8;
            int ly = 7;
            int hoa = 6;

            double Resul = Program.TrungBinhCong(toan, ly, hoa);
            Assert.AreEqual(7, Resul);

        }
        [Test]
        public void Case2TBC()
        {
            int toan = -1;
            int ly = 7;
            int hoa = 9;

            Assert.Throws<ArgumentException>(() => Program.TrungBinhCong(toan, ly, hoa));

        }
        [Test]
        public void Case3TBC()
        {
            int toan = 6;
            int ly = 11;
            int hoa = 9;

            Assert.Throws<ArgumentException>(() => Program.TrungBinhCong(toan, ly, hoa));

        }
        [Test]
        public void Case4TBC()
        {
            int toan = 5;
            int ly = 7;
            int hoa = 9;
            double Rel = Program.TrungBinhCong(toan, ly, hoa);
            Assert.AreEqual(7, Rel);

        }
        [Test]
        public void Case5TBC()
        {
            int toan = 7;
            int ly = 15;
            int hoa = 6;

            Assert.Throws<ArgumentException>(() => Program.TrungBinhCong(toan, ly, hoa));

        }
        [Test]
        public void Tu1denN()
        {
            int n = 5;
            int Resul = Program.TinhTongTuMotDenN(n);
            Assert.AreEqual(15, Resul);
        }
        [Test]
        public void Tu2denN()
        {
            int n = -5;
            Assert.Throws<ArgumentException>(() => Program.TinhTongTuMotDenN(n));
        }
        [Test]
        public void Tu1denN1()
        {
            int n = 0;
            Assert.Throws<ArgumentException>(() => Program.TinhTongTuMotDenN(n));
        }

        [Test]
        public void Tu1denN2()
        {
            int n = 4;
            int Resul = Program.TinhTongTuMotDenN(n);
            Assert.AreEqual(10, Resul);
        }

        [Test]
        public void Tu1denN3()
        {
            int n = 6;
            int Resul = Program.TinhTongTuMotDenN(n);
            Assert.AreEqual(21, Resul);
        }
        [Test]
        public void TestThemSach()
        {
            SachService sachService = new SachService();
            Sach sach1 = new Sach("001", "Sach 1", 100, "Tac Gia 1", 1);
            Sach sach2 = new Sach("002", "Sach 2", 150, "Tac Gia 2", 2);
            Sach sach3 = new Sach("003", "Sach 3", 200, "Tac Gia 3", 1);
            Sach sach4 = new Sach("004", "Sach 4", 200, "Tac Gia 4", 1);
            Sach sach5 = new Sach("005", "Sach 5", 900, "Tac Gia 5", 1);

            // Act
            sachService.ThemSach(sach1);
            sachService.ThemSach(sach2);
            sachService.ThemSach(sach3);
            sachService.ThemSach(sach4);
            sachService.ThemSach(sach5);


            Assert.AreEqual(5, sachService.danhSachSach.Count);
        }
        [Test]
        public void TestTimSachTheoTacGia()
        {
          
            SachService sachService = new SachService();
            Sach sach1 = new Sach("001", "Sach 1", 100, "Tac Gia 1", 1);
            Sach sach2 = new Sach("002", "Sach 2", 150, "Tac Gia 2", 2);
            Sach sach3 = new Sach("003", "Sach 3", 200, "Tac Gia 1", 1);
            sachService.ThemSach(sach1);
            sachService.ThemSach(sach2);
            sachService.ThemSach(sach3);

         
            var sachTacGia1 = sachService.TimSachTheoTacGia("Tac Gia 1");
            var sachTacGia2 = sachService.TimSachTheoTacGia("Tac Gia 2");

     
            Assert.AreEqual(2, sachTacGia1.Count);
            Assert.AreEqual(1, sachTacGia2.Count);
        }
    }
}