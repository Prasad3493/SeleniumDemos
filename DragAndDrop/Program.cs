using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragAndDrop
{
    internal class Program
    {
        static IWebDriver Driver;
        static void Main(string[] args)
        {
            Driver = new ChromeDriver();
        }
    }
}
