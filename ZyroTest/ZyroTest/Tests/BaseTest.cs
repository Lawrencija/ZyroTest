using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZyroTest.Tests
{
    class BaseTest
    {
        public IWebDriver driver;


        [SetUp]
        public void priesKiekvienaTesta()
        {
            PerduotiDriveri("chrome");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://zyro.com/lt";
        }

        public void PerduotiDriveri(string driverPavadinimas)
        {
            if (driverPavadinimas == "chrome")
            {
                driver = new ChromeDriver(padidintiChromeLanga());
            }

        }

        public ChromeOptions padidintiChromeLanga()
        {
            ChromeOptions langas = new ChromeOptions();
            langas.AddArgument("start-maximized");
            return langas;
        }


        [TearDown]
        public void poKiekvienoTesto()
        {
            driver.Quit();
        }
    }
}
