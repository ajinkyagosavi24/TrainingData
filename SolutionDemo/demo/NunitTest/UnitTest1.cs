using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace Tests
{
public class AutomationTester
{
IWebDriver driver;
string url="http://shop.demoqa.com/";
string url1="https://www.google.com//";

[Test]
public void SetupChromeLaunch()
{
driver = new ChromeDriver(@"E:\SolutionDemo\demo\NunitTest\Drivers\");
driver.Navigate().GoToUrl(url);
//driver.Close();
//driver.FindElement(By.ClassName("noo-search")).Click();

//driver.FindElement(By.ClassName("form-control")).SendKeys("Hello !!");

//driver.FindElement(By.PartialLinkText("My")).Click();

//driver.FindElement(By.XPath("//a[contains(text(),'My Wishlist')]".Click()));

//driver.FindElement(By.Id("yith-wcwl-popup-message")).Click();

//driver.FindElement(By.TagName("a")).Click();

//absolute xpath
//IWebElement element=driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/header[1]/div[1]/div[1]/ul[2]/li[2]/a[1]"));
//element.Click();

//Relative path
//IWebElement element2=driver.FindElement(By.XPath("//a[contains(text(),'Checkout')]"));
//element2.Click();


}

/*
[Test]
public void SetupIeBrowser()
{
driver = new InternetExplorerDriver(@"E:\SolutionDemo\demo\NunitTest\Drivers\");
driver.Navigate().GoToUrl(url1);
//driver.Close();
//_driver.FindElement(By.ClassName("noo-search")).click();
}*/
/* 
 [Test]
public void SetUpMozillaFireFox()
{
FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"E:\SolutionDemo\demo\NunitTest\Drivers\");
// service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
driver = new FirefoxDriver(service);
driver.Navigate().GoToUrl(url);
driver.FindElement(By.id(""))
//driver.Close();
}*/
}
}