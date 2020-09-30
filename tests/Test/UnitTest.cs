using System.Linq;
using ITSS131;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest : TestBase
    {
        [TestMethod]
        [Points(25)]
        public void DefaultCase()
        {
            this.SetUpInput(5,4,9,16,25,36);

            Program.Main(null);

            Assert.IsTrue(this.OutputByLine.Last().Contains("18"),
                          "Average should be 18");
        }
        
        [TestMethod]
        [Points(25)]
        public void SecondCase()
        {
            this.SetUpInput(3, 7, 21, 29);
            
            Program.Main(null);

            Assert.IsTrue(this.OutputByLine.Last().Contains("19"),
                          "Average should be 19");
        }
        
        [TestMethod]
        [Points(25)]
        public void ThirdCase()
        {
            this.SetUpInput(7, 3, 37, 47, 16, 18, 37, 16);
            
            Program.Main(null);

            Assert.IsTrue(this.OutputByLine.Last().Contains("24.85714"),
                          "Average should be 24.85714");
        }
        
        [TestMethod]
        [Points(25)]
        public void FourthCase()
        {
            this.SetUpInput(1, 26);
            
            Program.Main(null);

            Assert.IsTrue(this.OutputByLine.Last().Contains("26"),
                          "Average should be 26");
        }
    }
}
