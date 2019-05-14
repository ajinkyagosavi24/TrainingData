using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;


namespace Tests
{
    public class Tests
    {
        IWebDriver driver;
        string url= "https://www.google.com/";

 
        [Test]
        public void SetupChromeLaunch()
        {
            driver = new ChromeDriver(@"E:\SolutionDemo\demo\NunitTest\Drivers\");
            driver.Navigate().GoToUrl(url);

/*         
        //Title Name
            String title=driver.Title;  
            Console.WriteLine("Title of the page is : \n" + title);

        //Title Length
            int StrLength = driver.Title.Length;
            Console.WriteLine("Length of the Title is : \n" + StrLength);


        //Title URL
            String title_url=driver.Url;
            Console.WriteLine("Title URL of the page is : \n" + title_url);

        //Title URL Length
            int title_url_len = driver.Url.Length;
            Console.WriteLine("Length of the URL is : \n" + title_url_len);


        //Page Source
            String Page_source = driver.PageSource;

        //Page Source Length
            int Page_source_len = driver.PageSource.Length;
            Console.WriteLine("Length of the Page source is : \n" + Page_source_len);
 */       

          IWebElement element = driver.FindElement(By.XPath("//div[@class='FPdoLc VlcLAe']//input[@name='btnI']"));
          element.Click();
          driver.Navigate().Back();
          driver.Navigate().Forward();
          //driver.Navigate().To("https://www.google.com/");
          driver.Navigate().Refresh();
          driver.Close();
        }

    }
}