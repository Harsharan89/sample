using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace sample
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            IWebDriver driver = new FirefoxDriver();

            driver.Navigate().GoToUrl("https://gaming.uefa.com/");

            driver.Manage().Window.Maximize();
        }
    }
}
