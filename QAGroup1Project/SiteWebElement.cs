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

    }
}
