using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZyroTest.Pages
{
    class BasePages
    {
        protected IWebDriver driver;
        public BasePages(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
