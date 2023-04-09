﻿using System;
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

            bool searchtest01 = SiteTest.TestSearch01(driver);
            if (searchtest01)
            {
                Console.WriteLine("Test 3: Invalid Search passed");
            }
            else
            {
                Console.WriteLine("Test 3: Invalid Search failed");
            }

            bool searchtest02 = SiteTest.TestSearch02(driver);
            if (searchtest02)
            {
                Console.WriteLine("Test 4: Valid Search passed");
            }
            else
            {
                Console.WriteLine("Test 4: Valid Search failed");
            }

            bool navtest01 = SiteTest.TestNav01(driver);
            if (navtest01)
            {
                Console.WriteLine("Test 5: Valid Navigation passed");
            }
            else
            {
                Console.WriteLine("Test 5: Valid Navigation failed");
            }

            bool tweettest01 = SiteTest.TestTweet01(driver);
            if (tweettest01)
            {
                Console.WriteLine("Test 6: Valid Tweet reply passed");
            }
            else
            {
                Console.WriteLine("Test 6: Valid Tweet reply failed");
            }

            bool tweettest02 = SiteTest.TestTweet02(driver);
            if (tweettest02)
            {
                Console.WriteLine("Test 7: Invalid Tweet reply passed");
            }
            else
            {
                Console.WriteLine("Test 7: Invalid Tweet reply failed");
            }

            bool testMessage01 = SiteTest.TestMessage01(driver);
            if (testMessage01)
            {
                Console.WriteLine("Test 8: Message with valid data passed");
            } else
            {
                Console.WriteLine("Test 8: Message with valid data failed");
            }

            bool testMessage02 = SiteTest.TestMessage02(driver);
            if (testMessage02) 
            {
                Console.WriteLine("Test 9: Message with empty data passed");
            }
            else
            {
                Console.WriteLine("Test 9: Message with empty data failed");
            }

            bool testMessage03 = SiteTest.TestMessage03(driver);
            if (testMessage03)
            {
                Console.WriteLine("Test 10: Message with no data passed");
            } else
            {
                Console.WriteLine("Test 10: Message with no data failed");
            }

            bool profile01 = SiteTest.Profile01(driver);
            if (profile01)
            {
                Console.WriteLine("Test 11: Navigate to profile passed");
            }
            else
            {
                Console.WriteLine("Test 11: Navigate to profile failed");
            }


            bool profile02 = SiteTest.Profile02(driver);
            //Thread.Sleep(10000);

            if (profile02)
            {
                Console.WriteLine("Test 12: Navigate to trending profile passed");
            }
            else
            {
                Console.WriteLine("Test 12: Navigate to trending profile failed");
            }

            bool BrokenNav = SiteTest.BorkenProfile(driver);
            if (BrokenNav)
            {
                Console.WriteLine("Test 13: Successfully broke the profile page");
            } else
            {
                Console.WriteLine("Test 13: Did not break the profile page");
            }

            bool post01 = SiteTest.Post01(driver);
            if (post01)
            {
                Console.WriteLine("Test 14: Successfully posted tweet with valid entry");
            } else
            {
                Console.WriteLine("Test 14: Did not posted tweet with valid entry");
            }

            bool post02 = SiteTest.Post02(driver);
            if (post02)
            {
                Console.WriteLine("Test 15: Sent tweet with empty entry passed");
            } else
            {
                Console.WriteLine("Test 15: Sent tweet with empty entry failed");
            }

            bool post03 = SiteTest.Post03(driver);
            if (post03)
            {
                Console.WriteLine("Test 16: Sent tweet with special characters passed");
            } else
            {
                Console.WriteLine("Test 16: Sent tweet with special characters failed");
            }










            Thread.Sleep(10000);
            driver.Quit();
        }
    }
}
