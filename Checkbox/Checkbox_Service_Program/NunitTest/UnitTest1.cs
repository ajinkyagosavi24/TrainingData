using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;
 
            [Test]
            public void SetupChromeLaunch()
            {
                string url= "https://www.toolsqa.com/automation-practice-form/";
                driver = new ChromeDriver(@"E:\Checkbox\Checkbox_Service_Program\NunitTest\Drivers");
                driver.Navigate().GoToUrl(url);
            }

            /* [SetUp]
            public void startBrowser()
            {
                //Open the specified URL in browser
                driver.Url = "https://www.toolsqa.com/automation-practice-form/";
                driver.Manage().Window.Maximize();
            }*/

            [Test]
            public void test()
            {

                IList<IWebElement> RButton = driver.FindElements(By.Name("sex"));
                RButton.ElementAt(0);

                bool b = false;

                b = RButton.ElementAt(0).Selected;

                if (b == true)

                {
                    RButton.ElementAt(1).Click();

                    Console.WriteLine("Selected gender is " + RButton.ElementAt(1).GetAttribute("Value"));
                }
                else
                RButton.ElementAt(0).Click();
                Console.WriteLine("Selected gender is " + RButton.ElementAt(0).GetAttribute("Value"));

            }   

/*Checkbox assignment :

Identify the selected checkbox and display the name and value of the checkbox

Identify the unselected checkbox and check the unselected one and display the name and value of newly selected button*/

            [Test]
            public void checkbox()
            {

                IList<IWebElement> CButton = driver.FindElements(By.Name("profession"));
                CButton.ElementAt(0);

                bool b = false;

                b = CButton.ElementAt(0).Selected;

                if (b == true)
                {
                    CButton.ElementAt(1).Click();

                    Console.WriteLine("Selected profession is " + CButton.ElementAt(1).GetAttribute("Value"));
                }
                else
                CButton.ElementAt(0).Click();
                Console.WriteLine("Selected profession is " + CButton.ElementAt(0).GetAttribute("Value"));


            } 
        }   

    public class AlertDemo
    {
        IWebDriver driver1;
        string url= "http://demo.guru99.com/test/delete_customer.php";

        [Test]
        public void AlertDemo_new()
        {
            driver1 = new ChromeDriver(@"E:\Checkbox\Checkbox_Service_Program\NunitTest\Drivers");
            driver1.Navigate().GoToUrl(url);

            //driver.get("URL link");
            driver1.FindElement(By.Name("cusid")).SendKeys("53920");
            driver1.FindElement(By.Name("submit")).Submit();
            IAlert alert = driver1.SwitchTo().Alert();
            String alertMessage = alert.Text;
            Console.WriteLine("Alert message is " + alertMessage);
           // Thread.sleep(5000);

            alert.Accept();
            driver1.Close();
        }
    } 
} 



