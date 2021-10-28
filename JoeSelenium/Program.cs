using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace JoeSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\11035902\source\repos\Phase4_Project");
            string url = "http://localhost:20784/Home/PizzaSelection";

            driver.Navigate().GoToUrl(url);
            Thread.Sleep(2000);

            //IWebElement element = driver.FindElement(By.Id("PizzaList"));
            //element.Click();
            //Thread.Sleep(2000);

            IWebElement order = driver.FindElement(By.Id("1001"));
            order.Click();
            Thread.Sleep(2000);
            IWebElement purchase = driver.FindElement(By.Id("purchase"));
            purchase.Click();

            Thread.Sleep(2000);
            IWebElement back = driver.FindElement(By.Id("back"));
            back.Click();
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
