using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AT
{
    [TestFixture]
    public class UnitTest1
    {
        private static ChromeDriver drivers = new ChromeDriver();
        [OneTimeTearDown]
        public static void ClassCleanup()
        {
            drivers.Quit();
        }

        [SetUp]
        public void TestInit()
        {
            drivers.Navigate().GoToUrl("file:///E:/CalcWebClient/CalcWebClient/WebCalculator.html");
        }
        [TestCase("btn7")]
        [TestCase("btn8")]
        [TestCase("btn9")]
        [TestCase("btnPlus")]
        [TestCase("btn4")]
        [TestCase("btn5")]
        [TestCase("btn6")]
        [TestCase("btnMinus")]
        [TestCase("btn1")]
        [TestCase("btn2")]
        [TestCase("btn3")]
        [TestCase("btnMult")]
        [TestCase("btnDot")]
        [TestCase("btn0")]
        [TestCase("btnEq")]
        [TestCase("btnDiv")]
        [Test]
        public void SimpleCheckBtn(string id)
        {
            IWebElement chromeWebElement = drivers.FindElementById(id);
            Assert.AreEqual(true, chromeWebElement.Displayed);
        }
        [TestCase("btn7", "7")]
        [TestCase("btn8", "8")]
        [TestCase("btn9", "9")]
        [TestCase("btn4", "4")]
        [TestCase("btn5", "5")]
        [TestCase("btn6", "6")]
        [TestCase("btn1", "1")]
        [TestCase("btn2", "2")]
        [TestCase("btn3", "3")]
        [TestCase("btnDot", ",")]
        [TestCase("btn0" , "0")]
        [Test]
        public void SimpleClicBtn(string id, string exp)
        {
            drivers.FindElementById(id).Click();
            Assert.AreEqual(exp, drivers.FindElementById("aTxt").GetAttribute("value"));
        }
        [TestCase("btn7", "777")]
        [TestCase("btn8", "888")]
        [TestCase("btn9", "999")]
        [TestCase("btn4", "444")]
        [TestCase("btn5", "555")]
        [TestCase("btn6", "666")]
        [TestCase("btn2", "222")]
        [TestCase("btn3", "333")]
        [TestCase("btnDot", ",,,")]
        [TestCase("btn0", "000")]
        [Test]
        public void CoblexClicBtn(string id, string exp)
        {
            for (int i = 0; i < 3; i++)
            {
                drivers.FindElementById(id).Click();
            }
            Assert.AreEqual(exp, drivers.FindElementById("aTxt").GetAttribute("value"));
        }
    }
}
