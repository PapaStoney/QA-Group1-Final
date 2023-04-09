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
    internal class Program
    {

        static void Main(string[] args)
        {// in here goes the code that will run the tests

            IWebDriver driver = new ChromeDriver(@"C:\Selenium");
            driver.Manage().Window.Maximize();

            bool logintest01 = SiteTest.TestLogin01(driver);
            if(logintest01)
            {
                Console.WriteLine("Test 1: Valid Submission passed");
            }
            else
            {
                Console.WriteLine("Test 1: Valid Submission failed");
            }

            bool logintest02 = SiteTest.TestLogin02(driver); 
            if (logintest02)
            {
                Console.WriteLine("Test 2: Invalid Submission passed");
            }
            else
            {
                Console.WriteLine("Test 2: Invalid Submission failed");
            }

            bool logouttest01 = SiteTest.TestLogout01(driver);
            if (logouttest01)
            {
                Console.WriteLine("Test 3: Valid Logout passed");
            }
            else
            {
                Console.WriteLine("Test 3: Valid Logout failed");
            }

            bool searchtest01 = SiteTest.TestSearch01(driver);
            if (searchtest01)
            {
                Console.WriteLine("Test 4: Invalid Search passed");
            }
            else
            {
                Console.WriteLine("Test 4: Invalid Search failed");
            }

            bool searchtest02 = SiteTest.TestSearch02(driver);
            if (searchtest02)
            {
                Console.WriteLine("Test 5: Valid Search passed");
            }
            else
            {
                Console.WriteLine("Test 5: Valid Search failed");
            }

            bool navtest01 = SiteTest.TestNav01(driver);
            if (navtest01)
            {
                Console.WriteLine("Test 6: Valid Navigation passed");
            }
            else
            {
                Console.WriteLine("Test 6: Valid Navigation failed");
            }

            bool tweettest01 = SiteTest.TestTweet01(driver);
            if (tweettest01)
            {
                Console.WriteLine("Test 7: Valid Tweet reply passed");
            }
            else
            {
                Console.WriteLine("Test 7: Valid Tweet reply failed");
            }

            bool tweettest02 = SiteTest.TestTweet02(driver);
            if (tweettest02)
            {
                Console.WriteLine("Test 8: Invalid Tweet reply passed");
            }
            else
            {
                Console.WriteLine("Test 8: Invalid Tweet reply failed");
            }

            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
