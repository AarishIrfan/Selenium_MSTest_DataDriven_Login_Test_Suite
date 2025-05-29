using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Automation2
{
    internal class DataDriven
    {
        public static void Data(string url,  string name, string pass)
        {
            IWebDriver driver = new ChromeDriver();     // Driver//
            driver.Manage().Window.Maximize();
            driver.Url = url;
            driver.FindElement(By.Id("username")).SendKeys(name);
            driver.FindElement(By.Id("password")).SendKeys(pass);
            driver.FindElement(By.Id("login")).Click();           
            string newurl = driver.Url; 
            Assert.AreEqual("http://adactinhotelapp.com/SearchHotel.php", newurl);
            driver.Close();
        }
    }

}
                                                