using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FreeCRM
{
    internal class Program
    {
        static IWebDriver Driver = new ChromeDriver();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello selenium with C#");
            Driver = new ChromeDriver();
           Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
            Driver.Manage().Window.Maximize();

            IWebElement SearchBox = Driver.FindElement(By.Name("q"));
            SearchBox.SendKeys("FreeCRM login");//Entering FreeCRM in Google Search box
            Driver.FindElement(By.Name("btnK")).Click();//Selecting Google Search Button
            Driver.FindElement(By.XPath("//*[@id=\"rso\"]/div[4]/div/div/div/div[1]/div/a/div/cite")).Click();//Clicking on FreeCRM demo site url
           
         //   Driver.FindElement(By.LinkText("Login")).Click(); //Entering Login Tab in FreeCRM
            IWebElement Username = Driver.FindElement(By.XPath("//input[@Placeholder = 'E-mail address']"));
            Username.SendKeys("shriprasadmakar@gmail.com");//Sending username/email
            IWebElement Pass = Driver.FindElement(By.Name("password"));
            Pass.SendKeys("Prasad3493");//Sending Password
            Driver.FindElement(By.XPath("//*[@id=\"ui\"]/div/div/form/div/div[3]")).Click();//Login button
                                                                                            //Driver.FindElement(By.LinkText("Forgot your password?")).Click(); //Incase you forgot password
                                                                                            // Driver.FindElement(By.LinkText("Sign Up")).Click(); //Signup Page 


            Driver.FindElement(By.XPath("//*[@id=\"main-nav\"]/div[3]/a")).Click(); //Select Contact
            Driver.FindElement(By.XPath("//*[@id=\"dashboard-toolbar\"]/div[2]/div/a/button")).Click();//Create contact
            IWebElement FirstName = Driver.FindElement(By.Name("first_name"));
            FirstName.SendKeys("prasad");//sending FirstName
            IWebElement LastName = Driver.FindElement(By.Name("last_name"));
            LastName.SendKeys("makar");//sending LastName
            IWebElement Company = Driver.FindElement(By.XPath("//*[@id=\"main-content\"]/div/div[2]/form/div[2]/div[2]/div/div/input"));
            Company.SendKeys("CG");//Entering CG in Company search bar

            /*IWebElement Day = Driver.FindElement(By.XPath("//*[@id=\"main-content\"]/div/div[2]/form/div[12]/div[2]/div/div/div[1]/input"));
            Day.SendKeys("9");
            IWebElement Month = Driver.FindElement(By.XPath("//*[@id=\"main-content\"]/div/div[2]/form/div[12]/div[2]/div/div/div[2]/i"));
            Month.Click();
            *//*Actions Act = new Actions(Driver);
            Act.MoveToElement(Month);
           // Driver.FindElement(By.XPath("//*[@id=\"main-content\"]/div/div[2]/form/div[12]/div[2]/div/div/div[2]/div[2]/div[11]")).Click();*//*

            IWebElement Year = Driver.FindElement(By.XPath("//*[@id=\"main-content\"]/div/div[2]/form/div[12]/div[2]/div/div/div[3]/input"));
            Year.SendKeys("1997");*/

            

            Driver.FindElement(By.XPath("//*[@id=\"main-content\"]/div/div[2]/form/div[5]/div[1]/div/div")).Click();//Clicking on status checkbox
            Driver.FindElement(By.XPath("//*[@id=\"main-content\"]/div/div[2]/form/div[5]/div[1]/div/div/div[2]/div[2]")).Click(); //Selecting status as New
            Driver.FindElement(By.XPath("//*[@id=\"dashboard-toolbar\"]/div[2]/div/button[2]")).Click(); //Save
                                                                                                         //  Driver.FindElement(By.XPath("//*[@id=\"dashboard-toolbar\"]/div[2]/div/button[1]")).Click(); //cancel

            Thread.Sleep(5000);
            Driver.FindElement(By.XPath("//*[@id=\"top-header-menu\"]/div[2]/div[2]/div")).Click(); //Accessing Menu bar options
            Driver.FindElement(By.XPath("//*[@id=\"top-header-menu\"]/div[2]/div[2]/div/div/a[5]")).Click(); //Logout

        }
    }
}
