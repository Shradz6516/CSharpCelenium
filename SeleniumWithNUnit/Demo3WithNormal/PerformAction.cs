using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithNUnit
{
    class PerformAction
    {
        public static void EnterText(IWebDriver driver, string elementValue, string value, string attributeType)
        {
            if (attributeType == "Id")
                driver.FindElement(By.Id(elementValue)).SendKeys(value);
        }

        public static void Click(IWebDriver driver, string elementValue, string attributeType)
        {
            if (attributeType == "Name")
                driver.FindElement(By.Name(elementValue)).Click();
        }

        public static void SelectDropDownValue(IWebDriver driver, string elementValue, string value, string attributeType)
        {
            if (attributeType == "Id")
                new SelectElement(driver.FindElement(By.Id(elementValue))).SelectByText(value);
        }
    }
}
