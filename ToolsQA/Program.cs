using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsQA
{
    internal class Program
    {
        static IWebDriver Driver = new ChromeDriver();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello selenium with C#");
            Driver = new ChromeDriver();
            /*Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();

            IWebElement SearchBox = Driver.FindElement(By.Name("q"));
            SearchBox.SendKeys("Tools QA");//Entering Tools QA in Google Search box
            Driver.FindElement(By.Name("btnK")).Click();//Selecting Google Search Button
            Driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div/div[1]/a/div/cite")).Click();//Entering Tools QA site
            Driver.FindElement(By.XPath("/html/body/header/nav/div/div/div[3]/div/div[1]/ul/li[3]/a")).Click();//Selecting Demo Site
            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[2]/div/div[3]/h5")).Click();//CLicking on Forms
            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div[2]/div/div[2]")).Click();*/

            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();
            IWebElement FirstName = Driver.FindElement(By.XPath("//input[@Placeholder = 'First Name']"));
            FirstName.SendKeys("Prasad");
            IWebElement LastName = Driver.FindElement(By.Id("//input[@Placeholder = 'Last Name']"));
            LastName.SendKeys("Makar");



        }
    }
}
