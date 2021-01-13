using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace Alura.LeilaoOnline.Selenium
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            IWebDriver driver = new ChromeDriver(".");

            //act
            driver.Navigate().GoToUrl("https://localhost:5001/");

            //assert
            Assert.Contains("Leilões", driver.Title);
        }
    }
}
