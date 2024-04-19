using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.pages
{
    public class HomePage
    {
        private readonly By helloharilinklocator = By.XPath("//*[@id=\"logoutForm\"]/ul/li/a");
        IWebElement helloharilink;
        private readonly By administrationtablocator = By.XPath("/html/body/div[3]/div/div/ul/li[5]/a");
        IWebElement administrationtab;
        private readonly By timeandmateriallocator = By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");
        IWebElement timeandmaterial;
        public void VerifyUserLoggedin(IWebDriver driver)
        {
            // check weather user has logged in

             helloharilink = driver.FindElement(helloharilinklocator);
            if (helloharilink.Text == "Hello hari!")
            {
                Console.WriteLine("user loggedin sucsessfully");
            }
            else
            {
                Console.WriteLine("user hasn't loggedin successfully");
            }
        }
        public void NavigateToTimenMaterial(IWebDriver driver)
        {
            //navigate to Time and Material module
            //navigate and click administration tab

            administrationtab = driver.FindElement(administrationtablocator);
            administrationtab.Click();
            WebDriverWait webDriverWait = new WebDriverWait(driver,TimeSpan.FromSeconds(5));
            webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(timeandmateriallocator));
            //navigate and click time and materials module 

            timeandmaterial = driver.FindElement(timeandmateriallocator);
            timeandmaterial.Click();
        }
    }
}
