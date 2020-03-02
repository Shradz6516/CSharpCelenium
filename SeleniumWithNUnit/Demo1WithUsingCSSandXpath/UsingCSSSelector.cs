﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWithNUnit
{
    class UsingCSSSelector
    {
        IWebDriver m_driver;

        [Test]
        public void cssDemo()
        {
            m_driver = new ChromeDriver();
            m_driver.Url = "http://demo.guru99.com/test/guru99home/";
            m_driver.Manage().Window.Maximize();


            // Store locator values of email text box and sign up button				
            IWebElement emailTextBox = m_driver.FindElement(By.CssSelector("input[id=philadelphia-field-email]"));
            IWebElement signUpButton = m_driver.FindElement(By.CssSelector("input[id=philadelphia-field-submit]"));

            emailTextBox.SendKeys("test123@gmail.com");
            signUpButton.Click();
        }
    }
}
