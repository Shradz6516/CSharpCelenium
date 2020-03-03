using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWithNUnit.POM
{
    static class CustomLibrary
    {
        public static void EnterText(IWebElement element,string value)
        {
            element.SendKeys(value);
        }

        public static void Click(IWebElement element)
        {
            element.Click();
        }

        public static void SelectDropDownValue(IWebElement element,string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
