using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello selenium with C#");
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            Thread.Sleep(1000);
            Driver.FindElement(By.Name("btnK")).Click();
          //Driver.Close();
        }
    }
}
