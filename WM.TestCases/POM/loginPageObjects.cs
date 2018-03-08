using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    class loginPageObjects
    {
        private IWebDriver _driver;


        public loginPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "UserName")]
        public IWebElement txtUsername { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        public IWebElement txtPassword { get; set; }


        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public IWebElement btnLogin { get; set; }

        public dashboardPageObjects login(string username, string password)
        {

            txtUsername.SendCheckKeys(username);
            txtPassword.SendCheckKeys(password);

            btnLogin.Submit();

            return new dashboardPageObjects(_driver);

        }


    }
}
