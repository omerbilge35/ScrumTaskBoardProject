using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrumTaskBoardProject;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 frm = new Form1();
            int result = frm.Login("omer", "omer123");
            Assert.AreEqual(1, result);

        }
    }
}
