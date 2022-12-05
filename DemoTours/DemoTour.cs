using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Selenium with C#");
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            Driver.Manage().Window.Maximize();
           // Driver.FindElement(By.LinkText("REGISTER")).Click();
           Driver.FindElement(By.LinkText("Flights")).Click();
            Driver.FindElement(By.XPath("//input[@Value ='oneway']")).Click();

            IWebElement Depart_Loc = Driver.FindElement(By.Name("fromPort"));
            SelectElement dl = new SelectElement(Depart_Loc);
            dl.SelectByValue("London"); 

            IWebElement Depart_Month = Driver.FindElement(By.Name("fromMonth"));
            SelectElement Month = new SelectElement(Depart_Month);
            Month.SelectByValue("11");

            IWebElement Depart_Day = Driver.FindElement(By.Name("fromDay"));
            SelectElement dd = new SelectElement(Depart_Day);
            dd.SelectByValue("10");

            IWebElement Return_Loc = Driver.FindElement(By.Name("toPort"));
            SelectElement rl = new SelectElement(Return_Loc);
            rl.SelectByValue("Paris");

            IWebElement Return_Month = Driver.FindElement(By.Name("toMonth"));
            SelectElement RMonth = new SelectElement(Return_Month);
            RMonth.SelectByValue("11");

            IWebElement Return_Day = Driver.FindElement(By.Name("fromDay"));
            SelectElement rd = new SelectElement(Return_Day);
            rd.SelectByValue("10");

            IWebElement Prefernce = Driver.FindElement(By.Name("airline"));
            SelectElement pf = new SelectElement(Prefernce);
            pf.SelectByText("Unified Airlines");

            Driver.FindElement(By.XPath("//input[@value = 'First']")).Click();

            Driver.FindElement(By.Name("findFlights")).Click();
        }
    }
}
