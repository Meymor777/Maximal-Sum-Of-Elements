using MaximalSumOfElements.UI;

namespace MaximalSumOfElements.Test
{
    public class Tests
    {
        private string directoryWithTestFiles { get; set; }

        [SetUp]
        public void Setup()
        {
            var currentDirectory = Environment.CurrentDirectory;
            var workingDirectory = Directory.GetParent(currentDirectory).Parent.FullName;
            directoryWithTestFiles = Directory.GetParent(workingDirectory).Parent.FullName + "\\MaximalSumOfElements.Test\\TestFiles";
        }

        [Test]
        public void TestFile1()
        {
            var lineMaxValue = new int[2] { 8, 9 };
            var result = BL.MaximalSumOfElements.ProcessFile(directoryWithTestFiles + "\\TextFile1.txt");
            Program.PaintResultInConsole(result);
            Assert.AreEqual(59431, result.MaximalSumOfElements);
            for (int i = 0; i < lineMaxValue.Length; i++)
            {
                Assert.AreEqual(lineMaxValue[i], result.ListNumbersOfMaximalSumLines[i]);
            }
            Assert.AreEqual(false, result.HaveError);
        }

        [Test]
        public void TestFile2()
        {
            var lineMaxValue = new int[1] { 4 };
            var result = BL.MaximalSumOfElements.ProcessFile(directoryWithTestFiles + "\\TextFile2.txt");
            Program.PaintResultInConsole(result);
            Assert.AreEqual(63670, result.MaximalSumOfElements);
            for (int i = 0; i < lineMaxValue.Length; i++)
            {
                Assert.AreEqual(lineMaxValue[i], result.ListNumbersOfMaximalSumLines[i]);
            }
            Assert.AreEqual(false, result.HaveError);
        }

        [Test]
        public void TestFile3()
        {
            var lineMaxValue = new int[0];
            var result = BL.MaximalSumOfElements.ProcessFile(directoryWithTestFiles + "\\TextFile3.txt");
            Program.PaintResultInConsole(result);
            Assert.AreEqual(0, result.MaximalSumOfElements);
            Assert.AreEqual(lineMaxValue.Length, result.ListNumbersOfMaximalSumLines.Count);
            Assert.AreEqual(false, result.HaveError);
        }

        [Test]
        public void TestFile4()
        {
            var lineMaxValue = new int[1] { 9 };
            var result = BL.MaximalSumOfElements.ProcessFile(directoryWithTestFiles + "\\TextFile4.txt");
            Program.PaintResultInConsole(result);
            Assert.AreEqual(83477, result.MaximalSumOfElements);
            for (int i = 0; i < lineMaxValue.Length; i++)
            {
                Assert.AreEqual(lineMaxValue[i], result.ListNumbersOfMaximalSumLines[i]);
            }
            Assert.AreEqual(false, result.HaveError);
        }

        [Test]
        public void TestFile5()
        {
            var lineMaxValue = new int[0];
            var result = BL.MaximalSumOfElements.ProcessFile(directoryWithTestFiles + "\\TextFile5.txt");
            Program.PaintResultInConsole(result);
            Assert.AreEqual(0, result.MaximalSumOfElements);
            Assert.AreEqual(lineMaxValue.Length, result.ListNumbersOfMaximalSumLines.Count);
            Assert.AreEqual(false, result.HaveError);
        }

        [Test]
        public void TestFile6()
        {
            var lineMaxValue = new int[3] { 2, 5, 11 };
            var result = BL.MaximalSumOfElements.ProcessFile(directoryWithTestFiles + "\\TextFile6.txt");
            Program.PaintResultInConsole(result);
            Assert.AreEqual(0, result.MaximalSumOfElements);
            for (int i = 0; i < lineMaxValue.Length; i++)
            {
                Assert.AreEqual(lineMaxValue[i], result.ListNumbersOfMaximalSumLines[i]);
            }
            Assert.AreEqual(false, result.HaveError);
        }

        [Test]
        public void TestEmptyFile()
        {
            var lineMaxValue = new int[0];
            var result = BL.MaximalSumOfElements.ProcessFile(directoryWithTestFiles + "\\TextFile7.txt");
            Program.PaintResultInConsole(result);
            Assert.AreEqual(0, result.MaximalSumOfElements);
            Assert.AreEqual(lineMaxValue.Length, result.ListNumbersOfMaximalSumLines.Count);
            Assert.AreEqual(true, result.HaveError);
        }

        [Test]
        public void TestNotExistFile()
        {
            var lineMaxValue = new int[0];
            var result = BL.MaximalSumOfElements.ProcessFile("NotExist");
            Program.PaintResultInConsole(result);
            Assert.AreEqual(0, result.MaximalSumOfElements);
            Assert.AreEqual(lineMaxValue.Length, result.ListNumbersOfMaximalSumLines.Count);
            Assert.AreEqual(true, result.HaveError);
        }

        [Test]
        public void TestNullFileName()
        {
            var lineMaxValue = new int[0];
            var result = BL.MaximalSumOfElements.ProcessFile(null);
            Program.PaintResultInConsole(result);
            Assert.AreEqual(0, result.MaximalSumOfElements);
            Assert.AreEqual(lineMaxValue.Length, result.ListNumbersOfMaximalSumLines.Count);
            Assert.AreEqual(true, result.HaveError);
        }
    }
}