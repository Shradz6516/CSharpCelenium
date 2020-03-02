using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWithNUnit.POM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithNUnit
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
        }

        [Test]
        public void Execute()
        {
            PageObjectModel page = new PageObjectModel();
            page.InitialText.SendKeys("executeAutomation");

            //driver.FindElement(By.Name("q")).SendKeys("Learn Automation");
            
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Close();
        }
    }
}
