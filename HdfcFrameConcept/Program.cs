using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HdfcFrameConcept
{
    internal class Program
    {
        static IWebDriver Driver;
        static void Main(string[] args)
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://netbanking.hdfcbank.com/netbanking/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            Driver.Manage().Window.Maximize();
            int Number_Frames = Driver.FindElements(By.TagName("iframe")).Count();

            Driver.SwitchTo().Frame("login_page");
            Driver.FindElement(By.LinkText("Privacy Policy")).Click();
            Driver.SwitchTo().DefaultContent();
            Driver.SwitchTo().Frame("login_page");
            Driver.FindElement(By.Name("fldLoginUserId")).SendKeys("444333");

            
        }
    }
}
