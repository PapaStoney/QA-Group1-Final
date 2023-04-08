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

            bool navtest01 = SiteTest.TestNav01(driver);
            if (navtest01)
            {
                Console.WriteLine("Test 3: Valid Navigation passed");
            }
            else
            {
                Console.WriteLine("Test 3: Valid Navigation failed");
            }
        }
      
    }
}
