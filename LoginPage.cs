using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Automation2
{
    internal class LoginPage
    {
       public static void Login(string a, string b)
        {
            IWebDriver driver = new ChromeDriver();     // Driver//
            driver.Manage().Window.Maximize();
            driver.Url = "http://adactinhotelapp.com/index.php";
            driver.FindElement(By.Id("username")).SendKeys(a);
            driver.FindElement(By.Id("password")).SendKeys(b);
            driver.FindElement(By.Id("login")).Click();
          
            driver.Close();

        }
    }
  
}
