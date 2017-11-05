using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AT
{
    [TestClass]
    public class UnitTest1
    {
        private static ChromeDriver drivers = new ChromeDriver();
        [ClassCleanup]
        public static void ClassCleanup()
        {
            drivers.Quit();
        }

        [TestInitialize]
        public void TestInit()
        {
            drivers.Navigate().GoToUrl("file:///D:/Client%20Web/CalcWebClient/CalcWebClient/WebCalculator.html");
        }
        [DataTestMethod]
        [DataRow("btn7")]
        [DataRow("btn8")]
        [DataRow("btn9")]
        [DataRow("btnPlus")]
        [DataRow("btn4")]
        [DataRow("btn5")]
        [DataRow("btn6")]
        [DataRow("btnMinus")]
        [DataRow("btn1")]
        [DataRow("btn2")]
        [DataRow("btn3")]
        [DataRow("btnMult")]
        [DataRow("btnDot")]
        [DataRow("btn0")]
        [DataRow("btnEq")]
        [DataRow("btnDiv")]
        public void SimpleCheckBtn(string id)
        {
            IWebElement chromeWebElement = drivers.FindElementById(id);
            Assert.AreEqual(true, chromeWebElement.Displayed);
        }
        [DataTestMethod]
        [DataRow("btn7", "7")]
        [DataRow("btn8", "8")]
        [DataRow("btn9", "9")]
        [DataRow("btn4", "4")]
        [DataRow("btn5", "5")]
        [DataRow("btn6", "6")]
        [DataRow("btn1", "1")]
        [DataRow("btn2", "2")]
        [DataRow("btn3", "3")]
        [DataRow("btnDot", ",")]
        [DataRow("btn0" , "0")]
        public void SimpleClicBtn(string id, string exp)
        {
            drivers.FindElementById(id).Click();
            Assert.AreEqual(exp, drivers.FindElementById("aTxt").GetAttribute("value"));
        }
        [DataTestMethod]
        [DataRow("btn7", "777")]
        [DataRow("btn8", "888")]
        [DataRow("btn9", "999")]
        [DataRow("btn4", "444")]
        [DataRow("btn5", "555")]
        [DataRow("btn6", "666")]
        [DataRow("btn1", "111")]
        [DataRow("btn2", "222")]
        [DataRow("btn3", "333")]
        [DataRow("btnDot", ",,,")]
        [DataRow("btn0", "000")]
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
