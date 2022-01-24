using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace csharp_example
{
    [TestClass]
    public class UnitTest2
    {
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
                driver.Navigate().GoToUrl("http://localhost/litecart/admin/");
                driver.FindElement(By.XPath("//*[@name='username']")).SendKeys("admin");
                driver.FindElement(By.XPath("//*[@name='password']")).SendKeys("admin");
                driver.FindElement(By.XPath("//*[@name='login']")).Click();
            }

            [TearDown]
            public void stop()
            {
                driver.Quit();
                driver = null;


            }
        }
    }
}
