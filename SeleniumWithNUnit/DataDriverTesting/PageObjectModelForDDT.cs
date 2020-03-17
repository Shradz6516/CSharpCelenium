using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
namespace SeleniumWithNUnit.POM
{
    class PageObjectModelForDDT
    {
        By TitleId = By.Id("TitleId");
        By InitialText = By.Id("Initial");
        By FirstName = By.Id("FirstName");
        By MiddleName = By.Id("MiddleName");
        By SaveButton = By.Name("Save");

        internal void FillUserForm(string initial, string firstName, string middleName)
        {
            Sendkey(InitialText, initial);
            Thread.Sleep(2000);
            Sendkey(FirstName, firstName);
            Thread.Sleep(2000);
            Sendkey(MiddleName, middleName);
            Thread.Sleep(2000);
            Click(SaveButton);
        }

        public void Sendkey(By by, string elementvalue )
        {
            GenericCollection.driver.FindElement(by).SendKeys(elementvalue);
        }

        public void Click(By by)
        {
            GenericCollection.driver.FindElement(by).Click();
        }


    }
}
