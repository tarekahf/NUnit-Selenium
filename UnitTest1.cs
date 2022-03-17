using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [TestCase]
        public void TestOpenGoogle()
        {
            driver.Url = "http://www.google.com";
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("hello world"+Keys.Enter);
            Assert.Pass();
        }
        [TestCase]
        public void Test2()
        {
            Assert.Pass();
        }

        [OneTimeTearDown]
        public void Close() {
            driver.Close();
        }
    }
}