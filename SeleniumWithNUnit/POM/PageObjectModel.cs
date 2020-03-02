using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
