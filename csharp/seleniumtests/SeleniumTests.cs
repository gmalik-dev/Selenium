using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace seleniumtests;

public class SeleniumTests
{
[Test]
public void FirstTest() {
    IWebDriver driver = new ChromeDriver();
    driver.Navigate().GoToUrl("https://www.selenium.dev/");
    Assert.That(driver.Title, Is.EqualTo("Selenium"));
    driver.Quit();
}

}
