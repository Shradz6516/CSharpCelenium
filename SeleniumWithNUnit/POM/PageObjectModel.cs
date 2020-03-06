using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWithNUnit.POM
{
    class PageObjectModel
    {
        public PageObjectModel()
        {
            PageFactory.InitElements(GenericCollection.driver, this);
        }
        [FindsBy(How = How.Id,Using = "TitleId")]
        public IWebElement TitleId { get; set; }

        [FindsBy(How = How.Id, Using = "Initial")]
        public IWebElement InitialText { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement MiddleName { get; set; }

        internal void FillUserFormUsingCustomLibrary(string initial, string firstName, string middleName)
        {
            CustomLibrary.EnterText(InitialText, initial);
            CustomLibrary.EnterText(FirstName, firstName);
            CustomLibrary.EnterText(MiddleName, middleName);
            CustomLibrary.Click(SaveButton);
        }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement SaveButton { get; set; }
    }
}
