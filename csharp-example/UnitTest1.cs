using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace csharp_example
{
    [TestClass]
    public class MyFirstTest
    {
        private IWebDriver driver;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void FirstTest()
        {
            driver.Navigate().GoToUrl("https://www.amazon.com");
        }

        [TearDown]
        public void stop()
        {
            driver.Quit();
            driver = null;
            

        }
    }
}
