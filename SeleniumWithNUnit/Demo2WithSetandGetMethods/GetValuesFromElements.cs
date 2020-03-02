using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithNUnit
{
    class GetValuesFromElements
    {
        public static string GetText(IWebDriver driver, string elementValue, string attributeType)
        {
            if (attributeType == "Id")
                return driver.FindElement(By.Id(elementValue)).GetAttribute("value");
            else return string.Empty;
        }
                
        public static string GetSelectedDropDownValue(IWebDriver driver, string elementValue,string attributeType)
        {
            if (attributeType == "Id")
                return new SelectElement(driver.FindElement(By.Id(elementValue))).SelectedOption.Text;
            else return string.Empty;
        }
    }
}
