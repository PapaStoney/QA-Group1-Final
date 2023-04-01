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
        }
    }
}
