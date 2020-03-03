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
        [SetUp]
        public void Initialize()
        {
            GenericCollection.driver = new ChromeDriver();
            GenericCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Test]
        public void Execute()
        {
            LoginPageObjectModel loginPage = new LoginPageObjectModel();
            PageObjectModel page = loginPage.Login("Shraddha", "Password");
            page.FillUserForm("Execute Automation", "Shraddha", "Amol");
                   
        }

        [TearDown]
        public void Cleanup()
        {
            GenericCollection.driver.Close();
        }
    }
}
