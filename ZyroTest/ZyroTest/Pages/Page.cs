using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZyroTest.Pages
{
    class Page : BasePages
    {
        public Page(IWebDriver driver) : base(driver) { }

        private IWebElement Slapukai => driver.FindElement(By.CssSelector(".medium-up:nth-child(4)"));

        private IWebElement Saltiniai => driver.FindElement(By.XPath("//span[contains(.,'Šaltiniai')]"));

        private IWebElement Pagalba => driver.FindElement(By.XPath("//span[contains(.,'Pagalba')]"));

        private IWebElement KalbosPaspaudimas => driver.FindElement(By.Id("locale-picker"));
      
        private IWebElement Tinklaraštis => driver.FindElement(By.CssSelector(".g__space:nth-child(4) .t__h3"));

        private IWebElement Tekstas=> driver.FindElement(By.XPath("//span[contains(.,'Paskelbk tinkrašačio įrašus pasirinktu laiku')]"));



        
            public Page paspaustSutinku()
        {
                Slapukai.Click();
                return this;
            
        }

        public Page saltinis()
        {
            Saltiniai.Click();
            return this;

        }

        public Page paspaustiPagalba()
        {
            Pagalba.Click();
            return this;

        }

        public Page paspaustiKalba()
        {
            KalbosPaspaudimas.Click();
            return this;
        }

        public Page LTkalbosPasirinkimas()
        {
            SelectElement se = new SelectElement(KalbosPaspaudimas);
            se.SelectByValue("/lt/");
           
            return this;
        }
        public Page paspaustiTinklarastis()
        { 
            Tinklaraštis.Click();
            return this;

        }

        public Page arGerastekstas()
        {
            Assert.AreEqual("Paskelbk tinklaraščio įrašus pasirinktu laiku", Tekstas.Text);
            return this;

        }

    }
}
