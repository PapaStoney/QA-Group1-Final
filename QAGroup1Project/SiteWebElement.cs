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
        public static IWebElement SignUpButton(IWebDriver driver)
        {
            IWebElement txtSignup = driver.FindElement(By.LinkText("Click Here"));
            return txtSignup;
        }
        public static IWebElement LikeButton(IWebDriver driver)
        {
            IWebElement btnLike = driver.FindElement(By.Name("likeClick"));
            return btnLike;
        }

        public static IWebElement RetweetButton(IWebDriver driver)
        {
            IWebElement btnRetweet = driver.FindElement(By.Name("retweetClick"));
            return btnRetweet;
        }

        public static IWebElement ReplyButton(IWebDriver driver)
        {
            IWebElement btnReply = driver.FindElement(By.Name("replyClick"));
            return btnReply;
        }

        public static IWebElement searchButton(IWebDriver driver)
        {
            IWebElement btnSearch = driver.FindElement(By.XPath("//button[@type ='submit' and text()='Search']"));
            return btnSearch;
        }

        public static IWebElement searchBox(IWebDriver driver)
        {
            IWebElement txtSearch = driver.FindElement(By.Name("text"));
            return txtSearch;
        }

        public static IWebElement profileLink(IWebDriver driver)
        {
            IWebElement lnkProfile = driver.FindElement(By.LinkText("nick taggart"));
            return lnkProfile;
        }
        public static IWebElement replyText(IWebDriver driver)
        {
            IWebElement replyTextBox = driver.FindElement(By.Id("replyText"));
            return replyTextBox;
        }

        public static IWebElement submitButton(IWebDriver driver)
        {
            IWebElement btnSubmit = driver.FindElement(By.Name("submit"));
            return btnSubmit;
        }

    }
}
