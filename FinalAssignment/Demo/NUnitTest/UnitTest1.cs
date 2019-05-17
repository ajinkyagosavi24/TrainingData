using NUnit.Framework;
using System.Collections.Generic;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Linq;
using System.Threading;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;
        private DefaultWait<IWebDriver> fluentWait;
        string url= "https://www.idempiere.org/test-sites";

        [Test]
        public void Test()
        {
            driver = new ChromeDriver(@"E:\FinalAssignment\Demo\NUnitTest\Drivers\");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);

            // Find the element that's ID attribute is 'account'(My Account) 
            driver.FindElement(By.ClassName("dhtgD")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            ///ancestor::div//input
            driver.FindElement(By.XPath("//*[@autocomplete='username']")).SendKeys("admin @ gardenworld.com");
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[3]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/div[1]/div[1]/form[1]/table[1]/tbody[1]/tr[3]/td[2]/input[1]")).SendKeys("GardenAdmin");
    
            //Rember me - Radio button   
  	        IList<IWebElement> oRadioButton = driver.FindElements(By.ClassName("z-checkbox-content"));
		    oRadioButton.ElementAt(1).Click();

            //Ok button click
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[3]/div[1]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/div[1]/div[1]/div[1]/form[1]/div[2]/div[1]/div[3]/div[1]/button[1]")).Click();

            //Business Partner - Page 2
            //Thread.Sleep(20000);
            //driver.FindElement(By.XPath("//*[@title='Maintain Business Partners")).Click();
            //driver.SwitchTo().Window(driver.WindowHandles.Last());

            Thread.Sleep(2000);
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromMinutes(1);
            fluentWait.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement businesspartner = fluentWait.Until(x => x.FindElement(By.XPath("//*[@title='Maintain Business Partners']")));
            businesspartner.Click();
            
            //Click on "Cross" icon
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/table[1]/tbody[1]/tr[1]/td[3]/div[1]/button[2]/img[1]")).Click();

            //Business Partner - Page 2
            Thread.Sleep(2000);
             DefaultWait<IWebDriver> fluentWait1 = new DefaultWait<IWebDriver>(driver);
            fluentWait1.Timeout = TimeSpan.FromMinutes(1);
            fluentWait1.PollingInterval = TimeSpan.FromSeconds(1);
            fluentWait1.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement businesspartner1 = fluentWait1.Until(x => x.FindElement(By.XPath("//*[@title='Maintain Business Partners']")));
            businesspartner1.Click();

            //Search key
            Thread.Sleep(200);
            IWebElement SearchKey = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[2]/div[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/div[3]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[1]/input[1]"));
            SearchKey.SendKeys("This");

            //Name
            driver.FindElement(By.XPath("//*[@title='Alphanumeric identifier of the entity']")).SendKeys("is");

            //Name 2
            driver.FindElement(By.XPath("//*[@title='Additional Name']")).SendKeys("My");

            //Description
            driver.FindElement(By.XPath("//*[@title='Optional short description of the record']")).SendKeys("First");

            //Reset button
            driver.FindElement(By.XPath("//*[@title='Сброс']")).Click();


           //Name
            driver.FindElement(By.XPath("//*[@title='Alphanumeric identifier of the entity']")).SendKeys("is");

            //Name 2
            driver.FindElement(By.XPath("//*[@title='Additional Name']")).SendKeys("My");

            //Description
            driver.FindElement(By.XPath("//*[@title='Optional short description of the record']")).SendKeys("First");

            //Ok button
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[3]/span[1]/img[1]")).Click();

            //Business partner - New icon
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[4]/div[1]/div[4]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/div[1]/div[1]/div[1]/a[3]/span[1]/img[1]")).Click();

            //Business partner - New icon -> Name 
            driver.FindElement(By.XPath("//*[@instancename = 'C_BPartner0Name']")).SendKeys("ABC XYZ");

            //Save button
            driver.FindElement(By.XPath("//span[@id='eSAQe-cnt']//img")).Click();

            //Close the driver
            driver.Close();
        }    

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}