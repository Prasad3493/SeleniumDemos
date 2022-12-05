using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AmazonTest
{
    internal class Program
    {
        static IWebDriver Driver;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello Selenium with C# How R U???");
            Driver = new ChromeDriver();//Opening a chrome browser
            Driver.Navigate().GoToUrl("https://www.amazon.in/"); //Navigating to amazon site
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(9);
            Driver.Manage().Window.Maximize();//Maximizing the window
            Driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("Mobile");//Entering Mobile in amazon Searchbox
            Thread.Sleep(4000);
            Driver.FindElement(By.Id("nav-search-submit-button")).Click();//Clicking on search button













            /*Console.WriteLine("Hello Selenium with C# How R U???");
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();











            Driver.FindElement(By.Name("q")).SendKeys("Amazon");//Entering Amazon in Google Search box
            Driver.FindElement(By.Name("btnK")).Click();//Selecting Google Search Button

            Driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div/div/div[1]/a/div/cite")).Click();//Clicking on amazon.in
            
            //Your Account
            IWebElement Acc_List = Driver.FindElement(By.Id("nav-link-accountList")); //Clicking on Account and List DropDown
            IWebElement Your_Account = Driver.FindElement(By.XPath("//*[@id=\"nav-al-your-account\"]/a[1]/span")); //Clicking on Your Account
            Actions Act = new Actions(Driver);
            Act.MoveToElement(Acc_List).MoveToElement(Your_Account).Click().Build().Perform();
            string str = Driver.FindElement(By.XPath("//*[@id=\"a-page\"]/div[2]/div/div[1]/h1")).Text;
            Console.WriteLine($"Message on Your Account Page : {str}");

            *//* IWebElement Language = Driver.FindElement(By.XPath("//*[@id=\"icp-nav-flyout\"]/span/span[2]/span[2]"));
             IWebElement Hindi = Driver.FindElement(By.XPath("//*[@id=\"nav-flyout-icp\"]/div[2]/a[1]/span"));
             Act.MoveToElement(Language).MoveToElement(Hindi).Click().Build().Perform(); *//*

            //Your WishList
            Driver.FindElement(By.Id("nav-logo-sprites")).Click(); //Clicking on home icon
            IWebElement Acc_List1 = Driver.FindElement(By.XPath("//*[@id=\"nav-link-accountList\"]"));//Clicking on Account and List DropDown
            IWebElement WishList = Driver.FindElement(By.XPath("//*[@id=\"nav-al-wishlist\"]/a[1]/span"));//Clicking on Your WishList
            Actions Act1 = new Actions(Driver);
            Act1.MoveToElement(Acc_List1).MoveToElement(WishList).Click().Build().Perform();
            string str3 = Driver.FindElement(By.XPath("//*[@id=\"al-intro-feature-1\"]/div/div/div[1]/a")).Text;
            Console.WriteLine($"Message on Your Wishlist Page : {str3}");*/
            


        }
    }
}
