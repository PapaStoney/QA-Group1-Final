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
        public static IWebElement SiteUsername(IWebDriver driver)
        {
            IWebElement txtName = driver.FindElement(By.Id("username"));
            return txtName;
        }
        public static IWebElement SitePassword(IWebDriver driver)
        {
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            return txtPassword;
        }





        //CONNOR'S BLOCK
        //SIGNUP TEST
        public static IWebElement txtFirstName(IWebDriver driver)
        {
            IWebElement txtFirstName = driver.FindElement(By.Id("firstname"));
            return txtFirstName;
        }
    }
}
