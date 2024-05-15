using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project1.pages;
using project1.utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Tests

{
    [Parallelizable]
    [TestFixture]
    public class EmployeeTest : CommonDriver
    {
        EmployeePage employeepageobj = new EmployeePage();
        [SetUp]
        public void Setup()
        {
            //open chromedriver
            driver = new ChromeDriver();

            //loginpage object initialization
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginActions(driver, "hari", "123123");

            //homepage object intialization
            HomePage homePageobj = new HomePage();
            homePageobj.VerifyUserLoggedin(driver);
            homePageobj.NavigateToEmployee(driver);
        }
        [Test, Order(1), Description("this test is to create new employee record")]
        public void TestCreateEmployee()
        {

            employeepageobj.CreateEmployeeRecord(driver);
        }

        [Test, Order(2), Description("this test edit the employee record")]
        public void TestEditEmployee()
        {
            employeepageobj.EditEmployeeRecord(driver);
        }
        [Test, Order(3), Description("this test delete the employee record")]
        public void TestDeleteEmployee()
        {
            employeepageobj.DeleteEmployeeRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}