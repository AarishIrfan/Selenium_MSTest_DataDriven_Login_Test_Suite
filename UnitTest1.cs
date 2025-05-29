using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Automation2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            DataDriven.Data("http://adactinhotelapp.com/", "AmirImam", "AmirImam");
            DataDriven.Data("http://adactinhotelapp.com/", "", "");
        }
           [TestMethod]
           public void TestMethod2()
               {
                      
                   LoginPage Login = new LoginPage();
                   LoginPage.Login("aaar", "4566");
               }
           [TestMethod]
           public void TestMethod3()
           {
                  
               LoginPage Login = new LoginPage();
               LoginPage.Login("@@@", "!!!");
           }
           [TestMethod]
           public void TestMethod4()
           {
                 
               LoginPage Login = new LoginPage();
               LoginPage.Login("", "");
           }
           [TestMethod]
           [Timeout(9000)]
           [DataRow("http://adactinhotelapp.com/index.php","AarishIrfan","123456")]
           public void TestMethodDataDriven(string url,string name, string pass)
           {
               DataDriven.Data(url, name, pass);
           }
           Selenium C# with Assertion and Data Driven XML//
           [TestMethod]
           [DataRow("http://adactinhotelapp.com/index.php", "AarishIrfan", "123456")]*/

    }

}
