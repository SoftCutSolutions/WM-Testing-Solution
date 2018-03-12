using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;

namespace WM.TestCases
{
    [TestFixture]
    public class Hooks :_base
    {
        public string remote = "http://localhost:4446/wd/hub";
        private dashboardPageObjects dash;
        public static Mode _g_Mode= Mode.Local;
        public static Browser _g_Browser = Browser.Chrome;

        internal dashboardPageObjects Dash { get => dash; set => dash = value; }

 
        public IWebDriver selectDriver()
        {

            Browser browser = _g_Browser;
            Mode mode = _g_Mode;

            if (browser == Browser.Chrome)
            {
                if (mode == Mode.Local)
                    driver = new ChromeDriver();
                else if (mode == Mode.Docker)
                {
                    DesiredCapabilities cap = DesiredCapabilities.Chrome();
                    cap.SetCapability("version", "");
                    cap.SetCapability("platform", "LINUX");
                    //cap.SetCapability("maxInstances", "100");

                    driver = new RemoteWebDriver(new Uri(remote), cap);
                }
            }
            else if (browser == Browser.FireFox)
            {
                if (mode == Mode.Local)
                {
                    driver = new FirefoxDriver();
                }
                else if (mode == Mode.Docker)
                {
                    DesiredCapabilities cap = DesiredCapabilities.Firefox();
                    cap.SetCapability("version", "");
                    cap.SetCapability("platform", "LINUX");

                    driver = new RemoteWebDriver(new Uri(remote), cap);
                }
            }
            else if (browser == Browser.IE)
                driver = new InternetExplorerDriver();
            return driver;
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
            string TestUser = "";
            string TestPassword = "";
            try
            {
                TestUser = TestContext.CurrentContext.Test.Properties.Get("user").ToString();
                TestPassword = TestContext.CurrentContext.Test.Properties.Get("password").ToString();

            }
            catch (Exception)
            {

            }
            if (string.IsNullOrEmpty(TestUser))
            {
                TestUser = testValues._g_UserName;
            }

            if (string.IsNullOrEmpty(TestPassword))
            {
                TestPassword = testValues._g_Password;
            }


            driver = selectDriver();
            driver.Navigate().GoToUrl("http://ate.azurewebsites.net");
            loginPageObjects login = new loginPageObjects(driver);
            dashboardPageObjects _dash = login.login(TestUser, TestPassword);
            dash = _dash;
            Assert.IsTrue(Dash.pnlJointsStats.Text.Contains("Joints Stats & Charts"));
        }

        [TearDown]
        public void CleanUp()
        {
            //driver.Close();
            driver.Dispose();
            driver.Quit();
        }
    }
}
