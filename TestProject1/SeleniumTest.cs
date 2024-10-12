//Inside SeleniumTest.cs

using Allure.NUnit;
using Allure.NUnit.Attributes;
using NUnit.Framework;

using OpenQA.Selenium;

using OpenQA.Selenium.Chrome;

using OpenQA.Selenium.Firefox;

using System;

using System.Collections.ObjectModel;

using System.IO;

namespace SeleniumCsharp

{
    [AllureNUnit]
    public class Tests

    {
        private IWebDriver driver;

        [OneTimeSetUp]

        public void Setup()

        {

            //Below code is to get the drivers folder path dynamically.

            //You can also specify chromedriver.exe path dircly ex: C:/MyProject/Project/drivers

            driver = new ChromeDriver();
                 //If you want to Execute Tests on Firefox uncomment the below code

            // Specify Correct location of geckodriver.exe folder path. Ex: C:/Project/drivers

            //driver= new FirefoxDriver(path + @"\drivers\");

        }
        [AllureSuite("Verify Logo")]
        [Test]

        public void verifyLogo()

        {

            driver.Navigate().GoToUrl("https://www.browserstack.com/");

            Assert.That(driver.FindElement(By.XPath("/html/body/div[2]/header/div[1]/div/div/div/a/img")).Displayed);

        }


        [OneTimeTearDown]

        public void TearDown()

        {

            driver.Quit();
            driver.Dispose();

        }

    }

}
