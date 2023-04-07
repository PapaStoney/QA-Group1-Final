using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Bogus;

namespace QAGroup1Project
{
    internal class SiteWebElement
    {// in here goes the element grabbing
        public static IWebElement Username(IWebDriver driver)
        {
            IWebElement txtUsername = driver.FindElement(By.Id("username"));
            return txtUsername;
        }
        public static IWebElement Password(IWebDriver driver)
        {
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            return txtPassword;
        }
        public static IWebElement placeholder3(IWebDriver driver)
        {

        }
        public static IWebElement placeholder4(IWebDriver driver)
        {

        }
    }
}
