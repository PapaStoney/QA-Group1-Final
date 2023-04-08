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
using OpenQA.Selenium.Support.UI;

namespace QAGroup1Project
{
    internal class SiteTest
    {// in here goes each individual test's code
        //JULIE
        public static bool TestLogin01(IWebDriver driver)
        {
            try
            {
                firstPage(driver, "nick", "asdf");
                //wait for the URL to change 
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                // Check if the URL contains the expected URL
                if (driver.Url.Contains("http://10.157.123.12/site1/index.php"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool TestLogin02(IWebDriver driver)
        {
            try
            {
                firstPage(driver, "julie", "julie1234");
                //wait for the URL to change 
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                // Check if the URL contains the expected URL
                if (driver.Url.Contains("http://10.157.123.12/site1/index.php"))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool TestNav01(IWebDriver driver)
        {
            try
            {
                firstPage(driver, "nick", "asdf");

                //get the profile link 
                IWebElement lnkProfile = SiteWebElement.profileLink(driver);
                //click the profile link 
                lnkProfile.Click();
                //wait for the link to change 
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //check if the url contains the expected url 
                if (driver.Url.Contains("http://10.157.123.12/site1/userpage.php?user_id=1025"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static void firstPage(IWebDriver driver, String strName, string strPassword)
        {//in here goes the code for the clickies and sendkeys
            //load login page
            driver.Url = ("http://10.157.123.12/site1/login.php"); //MAKE SURE YOU'RE LOGGED INTO FORTICLIENT

            //get elements for the page
            IWebElement txtName = SiteWebElement.SiteUsername(driver);
            IWebElement txtPassword = SiteWebElement.SitePassword(driver);
            //what gets typed, what gets clicked
            txtName.SendKeys(strName);
            txtPassword.SendKeys(strPassword);

            //click login button 
            IWebElement btnLogin = driver.FindElement(By.Id("button"));
            btnLogin.Click();
        }
    }
}
