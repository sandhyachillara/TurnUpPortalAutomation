using NUnit.Framework;
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
        IWebElement? helloharilink;
        private readonly By administrationtablocator = By.XPath("/html/body/div[3]/div/div/ul/li[5]/a");
        IWebElement? administrationtab;
        private readonly By timeandmateriallocator = By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a");
        IWebElement? timeandmaterial;
        private readonly By employeelocator = By.XPath("//a[normalize-space()='Employees']");
        private IWebElement? employee;
        public void VerifyUserLoggedin(IWebDriver driver)
        {
            // check weather user has logged in
            try
            {
                helloharilink = driver.FindElement(helloharilinklocator);

                Assert.That(helloharilink.Text == "Hello hari!", "user hasn't loggedin successfully");
            }
            catch(Exception ex) {
                Assert.Fail("user has not logged in"+ex.Message);
            }
        }
        public void NavigateToTimenMaterial(IWebDriver driver)
        {
            //navigate to Time and Material module
            //navigate and click administration tab
            try
            {

                administrationtab = driver.FindElement(administrationtablocator);
                administrationtab.Click();
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(timeandmateriallocator));
                //navigate and click time and materials module 

                timeandmaterial = driver.FindElement(timeandmateriallocator);
                timeandmaterial.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("time and material page is not displayed"+ex.Message);
            }
        }
        public void NavigateToEmployee(IWebDriver driver)
        {
            //navigate to Employee module
            //navigate and click administration tab
            try
            {

                administrationtab = driver.FindElement(administrationtablocator);
                administrationtab.Click();
                WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
                webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(employeelocator));
                //navigate and click Employee module 

                employee  = driver.FindElement(employeelocator);
                employee.Click();
            }
            catch (Exception ex)
            {
                Assert.Fail("employee page is not displayed" + ex.Message);
            }
        }
    }
}
