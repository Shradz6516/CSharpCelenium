using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithNUnit.Popup_traversing
{
    class PopUpWindowsTestClass
    {
        IWebDriver driver;
        
        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            string title = driver.Title;         //Browser Command
            System.Console.WriteLine(title);
        }

        [Test]
        public void Execute()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //Browse by Absolute path
            IWebElement element = driver.FindElement(By.XPath("/html/body/section/h1"));
            System.Console.WriteLine(element.Text);


            //Browse by Relative path
            IWebElement element1 = driver.FindElement(By.XPath("//section[@class ='hero homepage']//following ::h1 "));
            System.Console.WriteLine(element1.Text);


            //Webelement Commands:SendKeys/ Click
            driver.FindElement(By.Name("search")).SendKeys("Documentation" + Keys.Enter);

            IWebElement element2 = driver.FindElement(By.XPath("//a[@class ='gs-title']"));
            System.Console.WriteLine(element2.Text);

            //Store the ID of the original window
            string originalWindow = driver.CurrentWindowHandle;
            element2.Click();
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
            driver.Close();  //Browser Command
            driver.SwitchTo().Window(originalWindow);

            driver.Navigate().Back();    //Browser Command

            driver.FindElement(By.Name("search")).SendKeys("Documentation" + Keys.Enter);



        }

        [TearDown]
        public void Cleanup()
        {
            driver.Quit(); 
        }
    }
}
