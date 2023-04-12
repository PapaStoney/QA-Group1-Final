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
using System.Drawing.Text;

namespace QAGroup1Project
{
    internal class Program
    {
        
        private static MySqlConnection connection;
        static void Main(string[] args)
        {// in here goes the code that will run the tests
            SiteReset();
            
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");
            driver.Manage().Window.Maximize();

            bool SignUpTest01 = SiteTest.SignUp01(driver);
            if (SignUpTest01)
            {
                Console.WriteLine("Test 24: Sign Up with valid data passed");
            }
            else
            {
                Console.WriteLine("Test 24: Sign Up with valid data failed");
            }
            
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

            bool testMessage01 = SiteTest.TestMessage01(driver);
            if (testMessage01)
            {
                Console.WriteLine("Test 9: Message with valid data passed");
            } else
            {
                Console.WriteLine("Test 9: Message with valid data failed");
            }

            bool testMessage02 = SiteTest.TestMessage02(driver);
            if (testMessage02) 
            {
                Console.WriteLine("Test 10: Message with empty data passed");
            }
            else
            {
                Console.WriteLine("Test 10: Message with empty data failed");
            }

            bool testMessage03 = SiteTest.TestMessage03(driver);
            if (testMessage03)
            {
                Console.WriteLine("Test 11: Message with no data passed");
            } else
            {
                Console.WriteLine("Test 11: Message with no data failed");
            }

            bool profile01 = SiteTest.Profile01(driver);
            if (profile01)
            {
                Console.WriteLine("Test 12: Navigate to profile passed");
            }
            else
            {
                Console.WriteLine("Test 12: Navigate to profile failed");
            }


            bool profile02 = SiteTest.Profile02(driver);
            //Thread.Sleep(10000);

            if (profile02)
            {
                Console.WriteLine("Test 13: Navigate to trending profile passed");
            }
            else
            {
                Console.WriteLine("Test 13: Navigate to trending profile failed");
            }

            bool BrokenNav = SiteTest.BorkenProfile(driver);
            if (BrokenNav)
            {
                Console.WriteLine("Test 14: Successfully broke the profile page");
            } else
            {
                Console.WriteLine("Test 14: Did not break the profile page");
            }

            bool post01 = SiteTest.Post01(driver);
            if (post01)
            {
                Console.WriteLine("Test 15: Successfully posted tweet with valid entry");
            } else
            {
                Console.WriteLine("Test 15: Did not posted tweet with valid entry");
            }

            bool post02 = SiteTest.Post02(driver);
            if (post02)
            {
                Console.WriteLine("Test 16: Sent tweet with empty entry passed");
            } else
            {
                Console.WriteLine("Test 16: Sent tweet with empty entry failed");
            }

            bool post03 = SiteTest.Post03(driver);
            if (post03)
            {
                Console.WriteLine("Test 17: Sent tweet with special characters passed");
            } else
            {
                Console.WriteLine("Test 17: Sent tweet with special characters failed");
            }
            //Anthony Moments
            bool moments01 = SiteTest.Moments01(driver);
            if (moments01)
            {
                Console.WriteLine("Test 18: Moments click success");
            }
            else
            {
                Console.WriteLine("Test 18: Moments click failed");
            }
            //Anthony Notifications Click 
            bool notifications01 = SiteTest.Notifications01(driver);
            if (notifications01)
            {
                Console.WriteLine("Test 19: Notifications click success");
            }
            else
            {
                Console.WriteLine("Test 19: Notifications click failed");
            }

            //Anthong Messages Click
            bool messages01 = SiteTest.Messages01(driver);
            if (messages01)
            {
                Console.WriteLine("Test 20: Messages click success");
            }
            else
            {
                Console.WriteLine("Test 20: Messages click failed");
            }

            //Anthony Logo Click 
            bool logo01 = SiteTest.Logo01(driver);
            if (logo01)
            {
                Console.WriteLine("Test 21: Logo click success");
            }
            else
            {
                Console.WriteLine("Test 21: Logo click failed");
            }

            //Anthony Contact Us Test
            bool contactUs01 = SiteTest.ContactUs01(driver);
            if (contactUs01)
            {
                Console.WriteLine("Test 22: Contact Us click success");
            }
            else
            {
                Console.WriteLine("Test 22: Contact Us click failed");
            }
            //Anthony Contactus Email
            bool contactUs02 = SiteTest.ContactUs02(driver);
            if (contactUs02)
            {
                Console.WriteLine("Test 23:Real email sent");
            }
            else
            {
                Console.WriteLine("Test 23: realemail failed");
            }
            //Anthony Tweet as new user
            bool tweetAsNewUser01 = SiteTest.TweetNewUser(driver);
            if (tweetAsNewUser01)
            {
                Console.WriteLine("Test 24: Tweet as new user success");
            }
            else
            {
                Console.WriteLine("Test 24: Tweet as new user failed");
            }


            Thread.Sleep(10000);
            driver.Quit();
        }
        public static void SiteReset()
        {
            // You'll need to modify the database, uid, and pwd fields of myConnectionString to use your own database.
            string myConnectionString = "server=remote.faedine.com;database=bitter-site1;uid=site1;pwd=ASMfoo34b3CdZoss;";
            connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand();

            command.Connection = connection;
            command.CommandText = "reset";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
