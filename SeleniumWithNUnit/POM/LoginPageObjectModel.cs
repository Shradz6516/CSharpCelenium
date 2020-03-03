using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumWithNUnit.POM
{
    class LoginPageObjectModel
    {
        public LoginPageObjectModel()
        {
            PageFactory.InitElements(GenericCollection.driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement UserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement LoginButton { get; set; }

        public PageObjectModel Login(string username, string password)
        {
            UserName.SendKeys(username);
            Password.SendKeys(password);
            LoginButton.Submit();
            //return the Page Object
            return new PageObjectModel();
        }
    }
}
