using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using project1.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project1.pages
{
    public class TimenMaterialPage
    {
        private readonly By createnewbuttonlocator = By.XPath("//*[@id=\"container\"]/p/a");
        IWebElement createnewbutton;
        private readonly By typecodelocator = By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]");
        IWebElement typecode;
        private readonly By timeoptionlocator = By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]");
        IWebElement timeoption;
        private readonly By codetextboxlocator = By.XPath("//*[@id=\"Code\"]");
        IWebElement codetextbox;
        private readonly By descriptiontextboxlocator = By.XPath("//*[@id=\"Description\"]");
        IWebElement descriptiontextbox;
        private readonly By savebuttonlocator = By.Id("SaveButton");
        IWebElement saveButton;
        private readonly By lastpagebuttonlocator = By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span");
        IWebElement lastpagebutton;
        private readonly By codelastitemlocator = By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]");
        IWebElement codelastitem;
        private readonly By pricetextboxlocator = By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]");
        IWebElement pricetextbox;
        public void CreateTimeRecord(IWebDriver driver)
        {
           

            //click the createnew button
             createnewbutton = driver.FindElement(createnewbuttonlocator);
            createnewbutton.Click();
            WaitUtils.WaitToBeVisible(driver, "Xpath ", "\"//*[@id=\\\"container\\\"]/p/a\"", 50);

            //click the typecode list button and select time option
            typecode = driver.FindElement(typecodelocator);
            typecode.Click();
            Thread.Sleep(1000);

            timeoption = driver.FindElement(timeoptionlocator);
            timeoption.Click();

            //enter the code text box
            codetextbox = driver.FindElement(codetextboxlocator);
            codetextbox.SendKeys("manual testing");

            //enter the description text box
             descriptiontextbox = driver.FindElement(descriptiontextboxlocator);
            descriptiontextbox.SendKeys("manual testing is easy");
            WaitUtils.WaitToBeVisible(driver,"Xpath ","//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]", 50);
            
            // WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(120));
            //webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(pricetextboxlocator));

            //enter price per unit 
            pricetextbox = driver.FindElement(pricetextboxlocator);
            pricetextbox.SendKeys("3.00");

            //click save button

             saveButton = driver.FindElement(savebuttonlocator);
            saveButton.Click();
            WaitUtils.WaitToBeVisible(driver, "Id", "SaveButton", 50);


            //view the last record that is added

            lastpagebutton = driver.FindElement(lastpagebuttonlocator);
            lastpagebutton.Click();

            VerifyRecordCreated (driver);



        }
        public void VerifyRecordCreated(IWebDriver driver)
        {
             codelastitem = driver.FindElement(codelastitemlocator);
            if (codelastitem.Text == "manual testing")
            {
                Console.WriteLine("record entered successfully");
            }
            else
            {
                Console.WriteLine("record has not entered successfully");
            }
        }
        public void UpdateCreatedRecord(IWebDriver driver)
        {
        }
        public void DeleteCreatedRecord(IWebDriver driver) 
        {

        }
        
        
       

        
    }
}
