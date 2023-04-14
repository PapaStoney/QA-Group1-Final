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

        //SIGNUP TEST
        //public static IWebElement clnkClickHere(IWebDriver driver)
        //{
        //    IWebElement clnkClickHere = driver.FindElement(By.LinkText("Click Here"));
        //    return clnkClickHere;
        //}

        //CONNOR BLOCK
        public static IWebElement ctxtFirstName(IWebDriver driver)
        {
            IWebElement ctxtFirstName = driver.FindElement(By.Id("firstname"));
            return ctxtFirstName;
        }
        public static IWebElement ctxtLastName(IWebDriver driver)
        {
            IWebElement ctxtLastName = driver.FindElement(By.Id("lastname"));
            return ctxtLastName;
        }
        public static IWebElement ctxtEmail(IWebDriver driver)
        {
            IWebElement ctxtEmail = driver.FindElement(By.Id("email"));
            return ctxtEmail;
        }
        public static IWebElement ctxtScreenName(IWebDriver driver)
        {
            IWebElement ctxtScreenName = driver.FindElement(By.Id("username"));
            return ctxtScreenName;
        }
        public static IWebElement ctxtPassword(IWebDriver driver)
        {
            IWebElement ctxtPassword = driver.FindElement(By.Id("password"));
            return ctxtPassword;
        }
        public static IWebElement ctxtConfirmPassword(IWebDriver driver)
        {
            IWebElement ctxtConfirmPassword = driver.FindElement(By.Id("confirm"));
            return ctxtConfirmPassword;
        }
        public static IWebElement ctxtPhoneNumber(IWebDriver driver)
        {
            IWebElement ctxtPhoneNumber = driver.FindElement(By.Id("phone"));
            return ctxtPhoneNumber;
        }
        public static IWebElement ctxtAddress(IWebDriver driver)
        {
            IWebElement ctxtAddress = driver.FindElement(By.Id("address"));
            return ctxtAddress;
        }
        public static IWebElement cdrpProvince(IWebDriver driver)
        {
            IWebElement cdrpProvince = driver.FindElement(By.Id("province"));
            return cdrpProvince;
        }
        public static IWebElement cdrpProvinceOption(IWebDriver driver)
        {
            IWebElement cdrpProvinceOption = driver.FindElement(By.XPath("//option[@value='ON']"));
            return cdrpProvinceOption;
        }
        public static IWebElement cdrpProvinceOption2(IWebDriver driver)
        {
            IWebElement cdrpProvinceOption2 = driver.FindElement(By.XPath("//option[@value='PE']"));
            return cdrpProvinceOption2;
        }
        public static IWebElement ctxtPostalCode(IWebDriver driver)
        {
            IWebElement ctxtPostalCode = driver.FindElement(By.Id("postalCode"));
            return ctxtPostalCode;
        }
        public static IWebElement ctxtURL(IWebDriver driver)
        {
            IWebElement ctxtURL = driver.FindElement(By.Id("url"));
            return ctxtURL;
        }
        public static IWebElement ctxtDescription(IWebDriver driver)
        {
            IWebElement ctxtDesciption = driver.FindElement(By.Id("desc"));
            return ctxtDesciption;
        }
        public static IWebElement ctxtLocation(IWebDriver driver)
        {
            IWebElement ctxtLocation = driver.FindElement(By.Id("location"));
            return ctxtLocation;
        }
        public static IWebElement clnkSubmit(IWebDriver driver)
        {
            IWebElement clnkSubmit = driver.FindElement(By.Id("button"));
            return clnkSubmit;
        }
        public static IWebElement clnkHomeButton(IWebDriver driver)
        {
            IWebElement clnkHomeButton = driver.FindElement(By.XPath("/html/body/nav/div/ul/li[1]/a/text()"));
            return clnkHomeButton;
        }
        public static IWebElement clnkNickAccount(IWebDriver driver)
        {
            IWebElement clnkNickAccount = driver.FindElement(By.LinkText("userpage.php?user_id=1025"));
            return clnkNickAccount;
        }

        //END CONNOR BLOCK


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

        public static IWebElement SendToField(IWebDriver driver)
        {
            IWebElement send2 = driver.FindElement(By.Name("to"));
            return send2;
        }

        public static IWebElement Message(IWebDriver driver)
        {
            IWebElement msg = driver.FindElement(By.Name("message"));
            return msg;
        }

        public static IWebElement SubBtn(IWebDriver driver)
        {
            IWebElement subbtn = driver.FindElement(By.Name("btnMessage"));
            return subbtn;
        }

        public static IWebElement ProfileFinder(IWebDriver driver)
        {
            IWebElement parentDiv = driver.FindElement(By.ClassName("bold"));
            
            IWebElement aTag = parentDiv.FindElement(By.TagName("a"));
            return aTag;
        }

        public static IWebElement TopTrending(IWebDriver driver)
        {
            IWebElement grandParentDiv = driver.FindElement(By.ClassName("trending img-rounded"));

            IList<IWebElement> divs = grandParentDiv.FindElements(By.ClassName("bold"));

            IWebElement topTrending = divs[1].FindElement(By.TagName("a"));


            return topTrending;
            
        }

        public static IWebElement TextArea(IWebDriver driver)
        {
            IWebElement createTweet = driver.FindElement(By.Id("myTweet"));
            return createTweet;
        }

        public static IWebElement btnTweet(IWebDriver driver)
        {
            IWebElement btnTweet = driver.FindElement(By.Name("btnTweet"));
            return btnTweet;
        }

        //Anthony Moments click
        public static IWebElement Moments(IWebDriver driver)
        {
            IWebElement moments = driver.FindElement(By.LinkText("Moments"));//driver.FindElement(By.LinkText("Moments"));
            return moments;
        }

        //Anthony Notifications click
        public static IWebElement Notifications(IWebDriver driver)
        {
            IWebElement notifications = driver.FindElement(By.LinkText("Notifications"));
            return notifications;
        }

        //Anthony Messages click
        public static IWebElement Messages(IWebDriver driver)
        {
            IWebElement messages = driver.FindElement(By.LinkText("Messages"));
            return messages;
        }

        //Anthony Logo Click
        public static IWebElement Logo(IWebDriver driver)
        {
            IWebElement logo = driver.FindElement(By.CssSelector("li > a.navbar-brand > img.logo"));
            return logo;
        }

        //Anthony - Contact Us click 
        public static IWebElement ContactUs(IWebDriver driver)
        {
            IWebElement contactUs = driver.FindElement(By.LinkText("Contact Us"));
            return contactUs;

        }
        //Anthony Contact Us - Email
        public static IWebElement Email(IWebDriver driver)
        {
            IWebElement email = driver.FindElement(By.LinkText("realemail@gmail.ca"));
            return email;
        }
        //Anthony Tweet as new user Uses existing methods 
        
    }
}
