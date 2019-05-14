using NUnit.Framework;
using ServiceProject;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.Internet

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        //private Class1 demo-new Class1();
        //private static IWebDriver = _driver; 
        private static IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        private void LaunchBrowser()
        {
            _driver = new ChromeDriver(@"E:\VS-code\Selenium_Demo\NunitTest\Drivers\");
            return;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
            //demo.IsPrime();
        }
    }
}