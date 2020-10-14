using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Selenium_Tarkvara_testimine.classes
{
    public class Browser
    {
        private IWebDriver _driver;
        IList<IWebElement> _listOfLinks;

        public Browser(string pathToChromeExeDir = @"C:\Users\localhost\AppData\Local\Google\Chrome\Application")
        {
            Msg.printl("Driver: " + pathToChromeExeDir, ConsoleColor.DarkCyan);
            _driver = new ChromeDriver(pathToChromeExeDir);

        }

        public void Load(string URL)
        {
            Msg.printl("URL: " + URL, ConsoleColor.DarkCyan);
            _driver.Url = URL;
            _listOfLinks = _driver.FindElements(By.XPath("//a"));
        }

        public IList<IWebElement> GetLinks() => _listOfLinks;
    }
}
