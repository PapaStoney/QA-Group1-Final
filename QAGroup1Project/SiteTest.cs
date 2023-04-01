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
        public static bool Test001(IWebDriver driver)
        {
            
        }
        public static bool Test002(IWebDriver driver)
        {

        }
        public static bool Test003(IWebDriver driver)
        {

        }
        public static bool Test004(IWebDriver driver)
        {

        }
        public static bool Test005(IWebDriver driver)
        {

        }

        public static void firstPage(IWebDriver driver)
        {//in here goes the code for the clickies and sendkeys
            //load login page
            driver.Url = ("http://10.157.123.12/site1/login.php"); //MAKE SURE YOU'RE LOGGED INTO FORTICLIENT

            //get elements for the page

            //what gets typed, what gets clicked
        }
    }
}
