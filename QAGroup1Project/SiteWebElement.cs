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
        
        //JULIE'S BLOCK
        //LOGIN
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
        public static IWebElement ctxtFirstName(IWebDriver driver)
        {
            IWebElement ctxtFirstName = driver.FindElement(By.Id("firstname"));
            return ctxtFirstName;
        }
        public static IWebElement ctxtLastName(IWebDriver driver)
        {
            IWebElement ctxtLastName = driver.FindElement(By.Id("lastname"));
            return ctxtLastName;
        }
        public static IWebElement ctxtEmail(IWebDriver driver)
        {
            IWebElement ctxtEmail = driver.FindElement(By.Id("email"));
            return ctxtEmail;
        }
        public static IWebElement ctxtScreenName(IWebDriver driver)
        {
            IWebElement ctxtScreenName = driver.FindElement(By.Id("screenname"));
            return ctxtScreenName;
        }
        public static IWebElement ctxtPassword(IWebDriver driver)
        {
            IWebElement ctxtPassword = driver.FindElement(By.Id("password"));
            return ctxtPassword;
        }
        public static IWebElement ctxtConfirmPassword(IWebDriver driver)
        {
            IWebElement ctxtConfirmPassword = driver.FindElement(By.Id("confirm"));
            return ctxtConfirmPassword;
        }
        public static IWebElement ctxtPhoneNumber(IWebDriver driver)
        {
            IWebElement ctxtPhoneNumber = driver.FindElement(By.Id("phone"));
            return ctxtPhoneNumber;
        }
        public static IWebElement ctxtAddress(IWebDriver driver)
        {
            IWebElement ctxtAddress = driver.FindElement(By.Id("address"));
            return ctxtAddress;
        }
        public static IWebElement cdrpProvince(IWebDriver driver)
        {
            IWebElement cdrpProvince = driver.FindElement(By.Id("province"));
            return cdrpProvince;
        }
        public static IWebElement ctxtPostalCode(IWebDriver driver)
        {
            IWebElement ctxtPostalCode = driver.FindElement(By.Id("postalcode"));
            return ctxtPostalCode;
        }
        public static IWebElement ctxtURL(IWebDriver driver)
        {
            IWebElement ctxtURL = driver.FindElement(By.Id("url"));
            return ctxtURL;
        }
        public static IWebElement ctxtDescription(IWebDriver driver)
        {
            IWebElement ctxtDesciption = driver.FindElement(By.Id("desc"));
            return ctxtDesciption;
        }
        public static IWebElement ctxtLocation(IWebDriver driver)
        {
            IWebElement ctxtLocation = driver.FindElement(By.Id("location"));
            return ctxtLocation;
        }

    }
}
