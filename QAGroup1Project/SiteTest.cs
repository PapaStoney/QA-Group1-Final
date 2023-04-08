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
    internal class SiteTest
    {// in here goes each individual test's code

        
        //CONNOR'S BLOCK
        //SIGNUP TEST
        public static void SignUp(IWebDriver driver, string firstname, string lastname, string email, string screenname, string password, string confirmpassword, string phonenumber, string address, string postalcode, string url, string description, string location)
        {//in here goes the code for the clickies and sendkeys

            //load login page
            driver.Url = ("http://10.157.123.12/site1/signup.php"); //MAKE SURE YOU'RE LOGGED INTO FORTICLIENT

            //get elements for the page
            IWebElement txtFirstName = SiteWebElement.txtFirstName(driver);
            IWebElement txtLastName = SiteWebElement.txtLastName(driver);
            IWebElement txtEmail = SiteWebElement.txtEmail(driver);
            IWebElement txtScreenName = SiteWebElement.txtScreenName(driver);
            IWebElement txtPassword = SiteWebElement.txtPassword(driver);
            IWebElement txtConfirmPassword = SiteWebElement.txtConfirmPassword(driver);
            IWebElement txtPhoneNumber = SiteWebElement.txtPhoneNumber(driver);
            IWebElement txtAddress = SiteWebElement.txtAddress(driver);
            IWebElement drpProvince = SiteWebElement.drpProvince(driver);
            IWebElement txtPostalCode = SiteWebElement.txtPostalCode(driver);
            IWebElement txtURL = SiteWebElement.txtURL(driver);
            IWebElement txtDescription = SiteWebElement.txtDescription(driver);
            IWebElement txtLocation = SiteWebElement.txtLocation(driver);

            //what gets typed, what gets clicked
            txtFirstName.SendKeys(firstname);
            txtLastName.SendKeys(lastname);
            txtEmail.SendKeys(email);
            txtScreenName.SendKeys(screenname);
            txtPassword.SendKeys(password);
            txtConfirmPassword.SendKeys(confirmpassword);
            txtPhoneNumber.SendKeys(phonenumber);
            txtAddress.SendKeys(address);

            drpProvince.Click();

            txtPostalCode.SendKeys(postalcode);
            txtURL.SendKeys(url);
            txtDescription.SendKeys(description);
            txtLocation.SendKeys(location);

        }

        public static bool SignUp01(IWebDriver driver)
        {
            SignUp(driver, "Okabe", "Rintaro", "hhk@secretgadgetlabs.jp", "HouuinKiyoma", "ineedtherapyafterthis", "ineedtherapyafterthis", "555-555-555", "123 Any Street, Sendai, Izumi-ko, Japan", "C1A-1V7", "TheOraganizationIsWatching", "I'm something of a mad scientist myself", "Sendai, Japan");
        }







        public static bool TestLogin01(IWebDriver driver)
        {   
            try
            {
                firstPage(driver, "nick", "asdf");

                IWebElement divPage = driver.FindElement(By.TagName("title"));
                String strPage = divPage.Text;

                if (strPage.Contains("Bitter - Social Media for Trolls, Narcissits, Bullies and Presidents"))
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
