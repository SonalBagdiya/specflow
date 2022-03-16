using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;
using System.Threading;

namespace SpecflowTest
{
    [Binding]
    public class UISteps
    {
        IWebDriver driver;
        [Given(@"I have started the chrome browser UI")]
        public void GivenIHaveStartedTheChromeBrowserUI()
        {
             ///driver = new ChromeDriver(@"D:\Chrome Driver 2.29\chromedriver_win32");
            //Console.WriteLine("I have started the chrome browser UI");
            String driverPath = "/opt/selenium/";
            String driverExecutableFileName = "chromedriver";
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("headless");
            options.AddArguments("no-sandbox");
            options.BinaryLocation = "/opt/google/chrome/chrome";
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(driverPath, driverExecutableFileName);
            driver = new ChromeDriver(service, options, TimeSpan.FromSeconds(120));
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            driver.Manage().Window.Maximize();

        }

        [Given(@"i am on the \.netcore website")]
        public void GivenIAmOnThe_NetcoreWebsite()
        {
            String url = "http://34.237.242.197:4444/";
            driver.Url = url;
            Console.WriteLine("I am on the .netcore website");
        }
        
//         [When(@"i click on the about page")]
//         public void WhenIClickOnTheAboutPage()
//         {
//             IWebElement aboutpage = driver.FindElement(By.LinkText("About"));
//             Thread.Sleep(200);
//             aboutpage.Click();
//         }
        
//         [When(@"i click on the contact page")]
//         public void WhenIClickOnTheContactPage()
//         {
//             //Console.WriteLine("i click on the contact page");
//             IWebElement contact = driver.FindElement(By.LinkText("Contact"));
//             contact.Click();
//         }
        
//         [Then(@"find the links count on home page")]
//         public void ThenFindTheLinksCountOnHomePage()
//         {
//             IReadOnlyList<IWebElement> links = driver.FindElements(By.TagName("a"));
//             int noOflinks = links.Count;
//             Console.WriteLine("Total no of links: " + links.Count);
//             //Console.WriteLine("find the links count on home page");
//             IWebElement element1 = driver.FindElement(By.LinkText("DotnetCoreWebProject"));
//             IWebElement element2 = driver.FindElement(By.LinkText("Home"));
//             IWebElement element3 = driver.FindElement(By.LinkText("About"));
//             IWebElement element4 = driver.FindElement(By.LinkText("Contact"));
//             if (element1.Displayed && element2.Displayed && element3.Displayed && element4.Displayed)
//             {
//                 Console.WriteLine("links are available");
//             }
//             IWebElement cookies = driver.FindElement(By.XPath("//*[@id=\"cookieConsent\"]/div/div[2]/div/button"));
//             cookies.Click();
//             Thread.Sleep(500);
//         }
        
//         [Then(@"display the about page title and print in console")]
//         public void ThenDisplayTheAboutPageTitleAndPrintInConsole()
//         {
//             // Console.WriteLine("display the about page title and print in console");
//             String Title = driver.Title;
//             Console.WriteLine(Title);
//         }
        
//         [Then(@"display the contact page title and content on the page and print in console")]
//         public void ThenDisplayTheContactPageTitleAndContentOnThePageAndPrintInConsole()
//         {
//             // Console.WriteLine("display the contact page title and content on the page and print in console");
//             String pagetilte = driver.Title;
//             Console.WriteLine(pagetilte);
//             driver.Close();
//         }
    }
}
