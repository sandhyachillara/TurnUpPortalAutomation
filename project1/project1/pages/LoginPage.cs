using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.pages
{
    public class LoginPage
    {
        private readonly By usernameTextboxlocator = By.Id("UserName");
        IWebElement usernameTextbox;
        

        private readonly By passwordlocator = By.Id("Password");
        IWebElement passwordTextbox;

        private readonly By loginButtonlocator = By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]");
        IWebElement loginButton;

        public void LoginActions(IWebDriver driver,String username,String password)
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

            string baseurl = "http://horse.industryconnect.io/Account/Login";

            // launch TurnUp Portal and navigate to the login page
            driver.Navigate().GoToUrl(baseurl);


            // identify the username text box and enter valid username
             usernameTextbox = driver.FindElement(usernameTextboxlocator);
            usernameTextbox.SendKeys(username);

            // identify the password textbox and enter valid password

            passwordTextbox = driver.FindElement(passwordlocator);
            passwordTextbox.SendKeys(password);

            // identify login button

            loginButton = driver.FindElement(loginButtonlocator);
            loginButton.Click();
        }
    }
}
