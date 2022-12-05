using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RediffAlert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello selenium with c# how r u ? ");
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("https://mail.rediff.com/cgi-bin/login.cgi");
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);

            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.Name("proceed")).Click();
            IAlert al = Driver.SwitchTo().Alert();
            String alert_message_expected = "Please enter a valid user name";
            String alert_message_actual = al.Text;
            Console.WriteLine(alert_message_actual);
            if(alert_message_actual.Equals(alert_message_expected) )
            {
                Console.WriteLine("The test Case is Passed...");
            }
            else
            {
                Console.WriteLine("The test case is failed...");
            }

            Thread.Sleep(2000);
            al.Accept();
            //al.Dismiss();

            Driver.FindElement(By.LinkText("rediff.com")).Click() ;
          //  Driver.FindElement(By.LinkText("Create Account")).Click();
            Driver.FindElement(By.XPath("//*[@id=\"signin_info\"]/a[2]")).Click();
            Driver.FindElement(By.XPath("//*[@id=\"tblcrtac\"]/tbody/tr[3]/td[3]/input")).SendKeys("Prasad Maruti Makar");//FullName Field
           // Driver.FindElement(By.XPath("//*[@id=\"tblcrtac\"]/tbody/tr[7]/td[3]/input[1]")).SendKeys("shriprasad3493");//username field
            Driver.FindElement(By.XPath("//*[@id=\"tblcrtac\"]/tbody/tr[7]/td[3]/input[1]")).SendKeys("prasad3493");//username not available
            //Driver.FindElement(By.XPath("//input[@value = 'Check availability']")).Click();//checking username availability
            
            Driver.FindElement(By.XPath("//*[@id=\"tblcrtac\"]/tbody/tr[7]/td[3]/input[2]")).Click();
            Thread.Sleep(2000);
            string error_msg = Driver.FindElement(By.XPath("//*[@id=\"check_availability\"]/font[1]/b")).Text;//checking username suggestions if entered username is not available
            Console.WriteLine(error_msg);//By.XPath("//*[@id=\"check_availability\"]/font[1]/b"

            IList<IWebElement> available_usernames = Driver.FindElements(By.XPath("//*[@id=\"recommend_text\"]/table/tbody/tr"));
            int iSize = available_usernames.Count();
            Console.WriteLine(" total number of rows  ====> " + " " + iSize);

            for (int i = 1; i < iSize; i++)
            {
                String sValue = available_usernames.ElementAt(i).Text;
                Console.WriteLine(" available id's are====>  " + sValue);
            }

            Driver.FindElement(By.Id("newpasswd")).SendKeys("Prasad@3493");//Entering Password
            Driver.FindElement(By.Id("newpasswd1")).SendKeys("Prasad@3493");//Re-Entering Password
            Driver.FindElement(By.XPath("//*[@id=\"div_altemail\"]/table/tbody/tr[1]/td[3]/input")).SendKeys("shriprasadmakar143@gmail.com");//Alternative email
            Driver.FindElement(By.XPath("//*[@id=\"div_mob\"]/table/tbody/tr/td[3]/div[2]/div[2]/img")).Click();//Clicking mob no checkbox
            Driver.FindElement(By.XPath("//*[@id=\"country_id\"]/ul/li[1]")).Click();//Selecting +91
            /*IWebElement country_id = Driver.FindElement(By.Id("coutry_id"));
            SelectElement cid = new SelectElement(country_id);
            cid.SelectByValue("91");*/
            // Driver.FindElement(By.XPath("//*[@id=\"div_mob\"]/table/tbody/tr/td[3]/div[2]/div[2]/img")).SendKeys("1");
            Driver.FindElement(By.XPath("//*[@id=\"tblcrtac\"]/tbody/tr[22]/td[3]/select[1]")).Click();//Entered into day checkbox
            Driver.FindElement(By.XPath("//*[@id=\"tblcrtac\"]/tbody/tr[22]/td[3]/select[1]/option[10]")).Click(); //Selecting 9 As Date
            Driver.FindElement(By.XPath("//*[@id=\"tblcrtac\"]/tbody/tr[22]/td[3]/select[2]")).Click(); //Entered into Month Checkbox
            Driver.FindElement(By.XPath("//tr[22]/td[3]/select[2]/option[11]")).Click();//Selecting Month As October
            Driver.FindElement(By.XPath("//*[@id=\"tblcrtac\"]/tbody/tr[22]/td[3]/select[3]")).Click();//Entered into year checkbox
            Driver.FindElement(By.XPath("//*[@id=\"tblcrtac\"]/tbody/tr[22]/td[3]/select[3]/option[27]")).Click();//Selecting Year

            


            Driver.FindElement(By.Id("mobno")).SendKeys("9527966393");
            
            IWebElement Country_Field = Driver.FindElement(By.Id("country"));
            SelectElement s11 = new SelectElement(Country_Field);
            s11.SelectByValue("99");

            /*IList<IWebElement> countryCount = Driver.FindElements(By.XPath("country_id"));
            int cSize = countryCount.Count;
            Console.WriteLine(cSize);
            for (int i = 1; i < cSize; i++)
            {
                String sValue = countryCount.ElementAt(i).Text;
                Console.WriteLine(sValue);
            }*/

            IWebElement City_Field = Driver.FindElement(By.XPath("//*[@id=\"div_city\"]/table/tbody/tr[1]/td[3]/select"));
            SelectElement city = new SelectElement(City_Field);
            city.SelectByValue("Pune");

            /*IList<IWebElement> cityCount = Driver.FindElements(By.XPath("//*[@id=\"div_city\"]/table/tbody/tr[1]/td[3]/select"));
            int ciSize = cityCount.Count;
            Console.WriteLine(ciSize);
            for (int i = 1; i < ciSize; i++)
            {
                String sValue = cityCount.ElementAt(i).Text;
                Console.WriteLine(sValue);
            }*/


            // IWebElement City_Field = Driver.FindElement(By.XPath("//*[@id=\"div_city\"]/table/tbody/tr[1]/td[3]/select"));
            // SelectElement city = new SelectElement(City_Field);
            // city.SelectByValue("Pune");


        }
    }
}
