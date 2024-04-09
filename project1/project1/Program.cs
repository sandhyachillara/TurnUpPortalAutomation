
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.WebRequestMethods;
//open chrome browser

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch TurnUp Portal and navigate to the login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");


// identify the username text box and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// identify the password textbox and enter valid password

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// identify login button

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

// check weather user has logged in

IWebElement helloharilink = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if (helloharilink.Text == "Hello hari!")
{
    Console.WriteLine("user loggedin sucsessfully");
}
else
{
    Console.WriteLine("user hasn't loggedin successfully");
}