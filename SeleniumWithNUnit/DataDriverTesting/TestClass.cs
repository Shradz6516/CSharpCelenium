using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SeleniumWithNUnit.DataDriverTesting;
using SeleniumWithNUnit.POM;

namespace SeleniumWithNUnit
{
    class TestClass
    {
        ExcelUtil excelUtil;
        [SetUp]
        public void Initialize()
        {
            GenericCollection.driver = new ChromeDriver();
            GenericCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            excelUtil = new ExcelUtil();
            excelUtil.DataTableToCollection(@"C:\Users\svyawahare\source\repos\SeleniumWithNUnit\SeleniumWithNUnit\AppData\DataStorage.xlsx");
            
        }

        [Test]
        public void Execute()
        {
            string username = excelUtil.ReadDataFromCollection(1, "UserName");
            LoginPageObjectModel loginPage = new LoginPageObjectModel();
            PageObjectModel page = loginPage.Login(username, "Password");
            page.FillUserForm("Execute Automation", "Shraddha", "Amol");
                   
        }

        [TearDown]
        public void Cleanup()
        {
            GenericCollection.driver.Close();
        }
    }
}
