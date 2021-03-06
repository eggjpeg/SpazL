using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpazlUT
{
    [TestClass]
    public class UnitTest1
    {

        private string FS(string s)
        {
            return s.Replace("\r", "").Replace("\n", "");
        }

        [TestMethod]
        public void Bubble()
        {
            SpazL.Spizl spaz = new SpazL.Spizl("Tests/bubble.spaz");
            spaz.Run();

            string expected = "0123451098";
            Assert.AreEqual(expected, FS(spaz.Result), "Fail. spaz.");
        }

        [TestMethod]
        public void String()
        {
            SpazL.Spizl spaz = new SpazL.Spizl("Tests/string.spaz");
            spaz.Run();
            string expected = "spz123assspaz";
            Assert.AreEqual(expected, FS(spaz.Result), "Fail. spaz.");
        }
        //2368912161761886911219608
        [TestMethod]
        public void QuickSort()
        {
            SpazL.Spizl spaz = new SpazL.Spizl("Tests/QuickSort.spaz");
            spaz.Run();
            string expected = "22368912161761886911219608";
            Assert.AreEqual(expected, FS(spaz.Result), "Fail. spaz.");
        }
        [TestMethod]

        public void Factorial()
        {
            SpazL.Spizl spaz = new SpazL.Spizl("Tests/factorial.spaz");
            spaz.Run();
            string expected = "3628800";
            Assert.AreEqual(expected, FS(spaz.Result), "Fail. spaz.");
        }

        [TestMethod]

        public void Foreach()
        {
            SpazL.Spizl spaz = new SpazL.Spizl("Tests/foreach.spaz");
            spaz.Run();
            string expected = "56788";
            Assert.AreEqual(expected, FS(spaz.Result), "Fail. spaz.");
        }

        [TestMethod]

        public void Spazout()
        {
            SpazL.Spizl spaz = new SpazL.Spizl("Tests/spazout.spaz");
            spaz.Run();
            string expected = "161820101";
            Assert.AreEqual(expected, FS(spaz.Result), "Fail. spaz.");
        }

        [TestMethod]
        public void Infinite()
        {
            SpazL.Spizl spaz = new SpazL.Spizl("Tests/infinite.spaz");
            spaz.Run();
            string expected = "1000001";
            Assert.AreEqual(expected, FS(spaz.Result), "Fail. spaz.");
        }

        [TestMethod]
        public void Spif()
        {
            SpazL.Spizl spaz = new SpazL.Spizl("Tests/spif.spaz");
            spaz.Run();
            string expected = "0spz";
            Assert.AreEqual(expected, FS(spaz.Result), "Fail. spaz.");
        }

    }
}
