using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using project1.pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1.utilities;

namespace project1.Tests
{
    [Parallelizable]
    [TestFixture]
    public class TimeMaterialTests:CommonDriver
    {
        TimenMaterialPage timeMaterialPageobj = new TimenMaterialPage();
        [SetUp]
        public void SetupTimeMaterial()
        {
            //open chromedriver
             driver = new ChromeDriver();

            //loginpage object initialization
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginActions(driver, "hari", "123123");

            //homepage object intialization
            HomePage homePageobj = new HomePage();
            homePageobj.VerifyUserLoggedin(driver);
            homePageobj.NavigateToTimenMaterial(driver);

        }
        [Test,Order(1),Description("this test is to create new time and material record")]
        public void TestCreateTimeMaterial() 
        {
            
            timeMaterialPageobj.CreateTimeRecord(driver);
        }

        [Test,Order(2),Description("this test edit the time and material record")]
        public void TestUpdateTimeMaterial()
        {
            timeMaterialPageobj.UpdateCreatedRecord(driver);
        }
        [Test,Order(3),Description("this test delete the time and material record")]
        public void TestDeleteTimeMaterial()
        {
            timeMaterialPageobj.DeleteCreatedRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
