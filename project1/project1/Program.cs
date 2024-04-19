
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using project1.pages;
using static System.Net.WebRequestMethods;
//open chrome browser

public class Program
{
    private static void Main(string[] args)
    {
        //open chromedriver
        IWebDriver driver = new ChromeDriver();

       //loginpage object initialization
        LoginPage loginPageobj = new LoginPage();
        loginPageobj.LoginActions(driver,"hari","123123");

        //homepage object intialization
        HomePage homePageobj = new HomePage();
        homePageobj.VerifyUserLoggedin(driver);
        homePageobj.NavigateToTimenMaterial(driver);

        //TimeMaterial page object initialization
        TimenMaterialPage timeMaterialPageobj = new TimenMaterialPage();
        timeMaterialPageobj.CreateTimeRecord(driver);
        timeMaterialPageobj.UpdateCreatedRecord(driver);
        timeMaterialPageobj.DeleteCreatedRecord(driver);





        /* Thread.Sleep(1000);
         //edit last record
         //clicking on last record edit button
         IWebElement editbuttonlastrecord = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[5]/a[1]"));
         editbuttonlastrecord.Click();

         driver.FindElement(By.Id("code")).Clear();
         codetextbox.SendKeys("automation testing");
     }
 }
 //checking whether last record code column has edited or not
 //if (codelastitem.Text != "manual testing") ;
 //{
 //  Console.WriteLine("last record is edited");
 //}
 */
    }






}