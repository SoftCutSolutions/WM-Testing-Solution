using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;

namespace WM.TestCases
{
    [TestFixture]
    public class Hooks :_Base
    {
        public string remote = "http://localhost:4446/wd/hub";
        public Hooks(Browser browser, Mode mode)
        {
            if (browser == Browser.Chrome) { 
                if (mode == Mode.Local)
                    driver = new ChromeDriver();
                else if (mode == Mode.Docker)
                {
                    DesiredCapabilities cap =  DesiredCapabilities.Chrome();
                    cap.SetCapability("version", "");
                    cap.SetCapability("platform", "LINUX");

                    driver = new RemoteWebDriver(new Uri(remote), cap);
                }
            }
            else if (browser == Browser.FireFox) { 
                    if (mode == Mode.Local)
                    {
                        driver = new FirefoxDriver();
                    }
                    else if (mode==Mode.Docker)
                    {
                        DesiredCapabilities cap = DesiredCapabilities.Firefox();
                        cap.SetCapability("version", "");
                        cap.SetCapability("platform", "LINUX");

                        driver = new RemoteWebDriver(new Uri(remote), cap);
                    }
            }
            else if (browser == Browser.IE)
                    driver = new InternetExplorerDriver();
        }
        public enum Browser
        {
            Chrome,
            IE,
            FireFox
        }

        public enum Mode
        {
            Local,
            Docker
        }

        [SetUp]
        public void Init()
        {
            driver.Navigate().GoToUrl("http://ate.azurewebsites.net");
        }

        [TearDown]
        public void CleanUp()
        {
            //driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
