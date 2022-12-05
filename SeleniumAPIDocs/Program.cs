using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SeleniumAPIDocs6
{
    internal class Program
    {
       static IWebDriver Driver;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello selenium with C#");
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Manage().Window.Maximize();

            Driver.FindElement(By.Name("q")).SendKeys("Selenium Api Docs");
            Driver.FindElement(By.Name("btnK")).Click();

            Driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div[1]/div/div/div[1]/div/a/h3")).Click();
            Driver.FindElement(By.XPath("/html/body/header/nav/div[1]/div[2]/ul[1]/li[1]/a")).Click();
            Driver.SwitchTo().Frame("classFrame");
                Driver.FindElement(By.LinkText("org.openqa.selenium")).Click();
            Thread.Sleep(4000);

            Driver.SwitchTo().DefaultContent();


            Driver.SwitchTo().Frame("packageFrame");
            Driver.FindElement(By.LinkText("AbstractAnnotations")).Click();
            Thread.Sleep(4000);


            Driver.SwitchTo().DefaultContent();

            Driver.SwitchTo().Frame("packageListFrame");
            Driver.FindElement(By.LinkText("org.openqa.selenium.chrome")).Click();

            Driver.SwitchTo().DefaultContent();





        }
    }
}
