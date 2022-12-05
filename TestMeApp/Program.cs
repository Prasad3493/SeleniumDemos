using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMeApp
{
    internal class Program
    {
        static IWebDriver Driver;
        static void Main(string[] args)
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://localhost:8083/TestMeApp");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();
        }
    }
}
