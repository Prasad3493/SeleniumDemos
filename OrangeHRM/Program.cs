using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrangeHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.Name("q")).SendKeys("Orangehrm Demo");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.FindElement(By.Name("btnK")).Click();


            Driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div[1]/div/a/h3")).Click();

            Driver.FindElement(By.Name("username")).SendKeys("Admin");
            Driver.FindElement(By.Name("password")).SendKeys("admin123");
            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div/div[1]/div/div[2]/div[2]/form/div[3]/button")).Click();//Login

            /*Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a")).Click(); //Accessing PIM
            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[2]/div/div[2]/input")).SendKeys("0007");
            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]")).Click();
            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[3]/div/div/div/div/div/div[1]/div[2]/div/div/button[2]")).Click();

            IWebElement FirstName = Driver.FindElement(By.XPath("//input[@Placeholder = 'First Name'"));
            FirstName.SendKeys("Prasad");
            IWebElement MiddleName = Driver.FindElement(By.XPath("//input[@Placeholder = 'Middle Name'"));
            MiddleName.SendKeys("Maruti");
            IWebElement LastName = Driver.FindElement(By.XPath("//input[@Placeholder = 'Last Name'"));
            LastName.SendKeys("Makar");
            IWebElement Dob = Driver.FindElement(By.XPath("//input[@Placeholder = 'yyyy-mm-dd'"));
                Dob.SendKeys("1997-10-09");

            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[5]/button")).Click();*/

            //  Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[2]/a")).Click();

            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/span/p")).Click();//DropDown Menu
            Thread.Sleep(1000);
            Driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/header/div[1]/div[2]/ul/li/ul/li[4]/a")).Click();//Logout

        }
    }
}
