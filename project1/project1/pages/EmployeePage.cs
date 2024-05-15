using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.pages
{
    public class EmployeePage
    {
        public void CreateEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("employee record created");

        }

        public void EditEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("employee record edited");
        }
        public void DeleteEmployeeRecord(IWebDriver driver)
        {
            Console.WriteLine("employee record deleted");
        }
    }
}
