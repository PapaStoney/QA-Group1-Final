﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

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
                    logOut(driver);
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
        public static bool TestSearch01(IWebDriver driver)
        {
            //load login page
            firstPage(driver, "nick", "asdf");
            //get the search box

            IWebElement searchButton = SiteWebElement.searchButton(driver);
            searchButton.Click();
            //wait for the link to change
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //check if the url contains the expected url
            if (driver.Url.Contains("http://10.157.123.12/site1/index.php"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool TestSearch02(IWebDriver driver)
        {
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");

                IWebElement searchBox = SiteWebElement.searchBox(driver);
                IWebElement searchButton = SiteWebElement.searchButton(driver);

                searchBox.Click();
                searchBox.SendKeys("kevin");
                searchButton.Click();

                if (driver.Url.Contains("http://10.157.123.12/site1/search.php?text=kevin"))
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

        public static bool TestNav01(IWebDriver driver)
        {
            try
            {
                logOut(driver);
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

        public static bool TestTweet01(IWebDriver driver)
        {
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");

                IWebElement replyClick = SiteWebElement.ReplyButton(driver);
                replyClick.Click();

                if (driver.Url.Contains("http://10.157.123.12/site1/reply.php"))
                {
                    IWebElement replyTextbox = SiteWebElement.replyText(driver);
                    replyTextbox.Click();
                    replyTextbox.SendKeys("hello world");
                    IWebElement submitButton = SiteWebElement.submitButton(driver);
                    submitButton.Click();
                    if (driver.Url.Contains("http://10.157.123.12/site1/index.php"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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

        public static bool TestTweet02(IWebDriver driver)
        {
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");

                IWebElement replyClick = SiteWebElement.ReplyButton(driver);
                replyClick.Click();

                if (driver.Url.Contains("http://10.157.123.12/site1/reply.php"))
                {
                    IWebElement replyTextbox = SiteWebElement.replyText(driver);
                    replyTextbox.Click();
                    IWebElement submitButton = SiteWebElement.submitButton(driver);
                    submitButton.Click();
                    if (driver.Url.Contains("http://10.157.123.12/site1/index.php"))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
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

            //clear the elements 
            driver.FindElement(By.Id("username")).Clear();
            driver.FindElement(By.Id("password")).Clear();

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
        public static void logOut(IWebDriver driver)
        {
            //find the element 
            IWebElement dropDown = driver.FindElement(By.Id("dropdown01"));
            //click it
            dropDown.Click();

            IWebElement logoutLink = driver.FindElement(By.LinkText("Logout"));
            logoutLink.Click();
        }



        // nahum
        public static bool BorkenProfile(IWebDriver driver)
        {
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");
                driver.Url = "http://10.157.123.12/site1/userpage.php";

                return true;
            } catch (Exception e)
            {
                return false;
            }
        }



        public static bool Profile01(IWebDriver driver)
        {// navigate to profile
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");

                IWebElement profileTag = SiteWebElement.ProfileFinder(driver);
                profileTag.Click();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool Profile02(IWebDriver driver)
        {// navigate to top trending
            // this one doesnt work like it should - i need to rework th structure of TopTrending to find the right link because too many things have the class bold
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");

                IWebElement profileTag = SiteWebElement.ProfileFinder(driver);
                profileTag.Click();

                IWebElement trendingProfile = SiteWebElement.TopTrending(driver);
                trendingProfile.Click();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool TestMessage01(IWebDriver driver)
        {// valid data
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");
                driver.Url = "http://10.157.123.12/site1/DirectMessage.php";

                IWebElement msgbox = SiteWebElement.Message(driver);
                msgbox.SendKeys("Valid Message Data");

                IWebElement subbtn = SiteWebElement.SubBtn(driver);
                subbtn.Click();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool TestMessage02(IWebDriver driver)
        {// empty data
            try
            {

                logOut(driver);
                firstPage(driver, "nick", "asdf");
                driver.Url = "http://10.157.123.12/site1/DirectMessage.php";

                IWebElement msgbox = SiteWebElement.Message(driver);
                msgbox.SendKeys("");

                IWebElement subbtn = SiteWebElement.SubBtn(driver);
                subbtn.Click();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool TestMessage03(IWebDriver driver)
        {// special character
            try
            {

                logOut(driver);
                firstPage(driver, "nick", "asdf");
                driver.Url = "http://10.157.123.12/site1/DirectMessage.php";

                IWebElement msgbox = SiteWebElement.Message(driver);
                msgbox.SendKeys("!@#$%^&*?");

                IWebElement subbtn = SiteWebElement.SubBtn(driver);
                subbtn.Click();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Post01(IWebDriver driver)
        {// valid entry
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");
                driver.Url = "http://10.157.123.12/site1/index.php";

                IWebElement createTweet = SiteWebElement.TextArea(driver);
                createTweet.SendKeys("Is this thing on?");

                IWebElement btnTweet = SiteWebElement.btnTweet(driver);
                btnTweet.Click();

                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Post02(IWebDriver driver)
        { // empty entry
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");
                driver.Url = "http://10.157.123.12/site1/index.php";

                IWebElement createTweet = SiteWebElement.TextArea(driver);
                createTweet.SendKeys("");

                IWebElement btnTweet = SiteWebElement.btnTweet(driver);
                btnTweet.Click();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return false;
            }
        }

        public static bool Post03(IWebDriver driver)
        {// 'special' characters
            try
            {
                logOut(driver);
                firstPage(driver, "nick", "asdf");
                driver.Url = "http://10.157.123.12/site1/index.php";

                IWebElement createTweet = SiteWebElement.TextArea(driver);
                createTweet.SendKeys("!@#$%^&*()-_+=}{[]");

                IWebElement btnTweet = SiteWebElement.btnTweet(driver);
                btnTweet.Click();

                return true;
            }
            catch (Exception ex)
            {
                // how tf does this fail
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
