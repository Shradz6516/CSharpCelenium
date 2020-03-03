
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumWithNUnit.Demo3WithNormal
{
    class TestClass
    {
        [SetUp]
        public void Initialize()
        {
            GenericCollection.driver = new ChromeDriver();
            GenericCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
        }

        [Test]
        public void Execute()
        {
            PerformAction.EnterText(GenericCollection.driver, "Initial", "Mrs", "Id");
            Console.WriteLine("ExecutingMethod");

        }

        [TearDown]
        public void Cleanup()
        {
            GenericCollection.driver.Close();
        }
    }
}
