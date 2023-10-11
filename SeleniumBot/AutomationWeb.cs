using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBot
{
    public class AutomationWeb
    {
        public IWebDriver driver;

        public AutomationWeb()
        {
            driver = new ChromeDriver();
        }

        public void TestWeb()
        {
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.ClassName("gLFyf")).SendKeys("Hello, World!");
            driver.FindElement(By.ClassName("gNO89b")).Click();
        }
    }
}
