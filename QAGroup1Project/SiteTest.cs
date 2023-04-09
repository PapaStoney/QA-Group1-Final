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
            driver.Url = ("http://10.157.123.12/site1/"); //MAKE SURE YOU'RE LOGGED INTO FORTICLIENT

            //get elements for the page
            IWebElement clnkClickHere = SiteWebElement.clnkClickHere(driver);
            IWebElement ctxtFirstName = SiteWebElement.ctxtFirstName(driver);
            IWebElement ctxtLastName = SiteWebElement.ctxtLastName(driver);
            IWebElement ctxtEmail = SiteWebElement.ctxtEmail(driver);
            IWebElement ctxtScreenName = SiteWebElement.ctxtScreenName(driver);
            IWebElement ctxtPassword = SiteWebElement.ctxtPassword(driver);
            IWebElement ctxtConfirmPassword = SiteWebElement.ctxtConfirmPassword(driver);
            IWebElement ctxtPhoneNumber = SiteWebElement.ctxtPhoneNumber(driver);
            IWebElement ctxtAddress = SiteWebElement.ctxtAddress(driver);
            IWebElement cdrpProvince = SiteWebElement.cdrpProvince(driver);
            IWebElement ctxtPostalCode = SiteWebElement.ctxtPostalCode(driver);
            IWebElement ctxtURL = SiteWebElement.ctxtURL(driver);
            IWebElement ctxtDescription = SiteWebElement.ctxtDescription(driver);
            IWebElement ctxtLocation = SiteWebElement.ctxtLocation(driver);
            IWebElement cbtnSubmit = SiteWebElement.cbtnSubmit(driver);

            //what gets typed, what gets clicked
            clnkClickHere.Click();
            ctxtFirstName.SendKeys(firstname);
            ctxtLastName.SendKeys(lastname);
            ctxtEmail.SendKeys(email);
            ctxtScreenName.SendKeys(screenname);
            ctxtPassword.SendKeys(password);
            ctxtConfirmPassword.SendKeys(confirmpassword);
            ctxtPhoneNumber.SendKeys(phonenumber);
            ctxtAddress.SendKeys(address);

            //select province
            cdrpProvince.Click();
            //cdrpProvince.selectByIndex("ANTARCTICA");

            ctxtPostalCode.SendKeys(postalcode);
            ctxtURL.SendKeys(url);
            ctxtDescription.SendKeys(description);
            ctxtLocation.SendKeys(location);
            

        }

        public static bool TestSignUp01(IWebDriver driver)
        {
            SignUp(driver, "Okabe", "Rintaro", "hhk@secretgadgetlabs.jp", "HouuinKiyoma", "ineedtherapyafterthis", "ineedtherapyafterthis", "555-555-555", "123 Any Street, Sendai, Izumi-ko, Japan", "C1A-1V7", "TheOraganizationIsWatching", "I'm something of a mad scientist myself", "Sendai, Japan");

            if (driver.Url == "http://10.157.123.12/site1/login.php")
            {
                return true;
            }
            else
            {
                return false;
            }



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
