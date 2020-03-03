using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithNUnit
{
    class CustomMethods
    {
        IWebDriver driver  = new ChromeDriver();
        [SetUp]
        public void Initialize()
        {
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        [Test]
        public void ExecuteTestForSetText()
        {
            SetValuesToElements.EnterText(driver, "Initial", "Mrs", "Id");
            Console.WriteLine("ExecutingMethod");
        }

        [Test]
        public void ExecuteTestForClick()
        {
            SetValuesToElements.Click(driver, "Save", "Name");
            Console.WriteLine("ExecutingMethod");
        }

        [Test]
        public void ExecuteTestForDropDown()
        {
            SetValuesToElements.SelectDropDownValue(driver, "TitleId","Ms.", "Id");
            Console.WriteLine("ExecutingMethod");
        }

        [Test]
        public void ExecuteTestForGetText()
        {            
            Console.WriteLine("ExecutingMethod " + GetValuesFromElements.GetText(driver, "Initial", "Id"));
        }

        [Test]
        public void ExecuteTestForGetDropDownValue()
        {
            Console.WriteLine("ExecutingMethod " + GetValuesFromElements.GetSelectedDropDownValue(driver, "TitleId", "Id"));
        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit();
        }
    }
}
