using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.utilities
{
    public class WaitUtils
    {
        public static void WaitToBeVisible(IWebDriver driver, String locatortype, By locatorvalue, int secs)
        {
            if (locatortype == "Xpath")
            {
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(secs));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locatorvalue));

            }
            if (locatortype == "Id")
            {
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(secs));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locatorvalue));

            }
            if (locatortype == "Name")
            {
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(secs));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locatorvalue));

            }

        }
        public static void WaitToBeClickable(IWebDriver driver, String locatortype, By locatorvalue, int secs)
        {
            if (locatortype == "Xpath")
            {
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(secs));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locatorvalue));

            }
            if (locatortype == "Id")
            {
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(secs));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locatorvalue));


            }
            if (locatortype == "Name")
            {
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(secs));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locatorvalue));


            }
        }
    }
}