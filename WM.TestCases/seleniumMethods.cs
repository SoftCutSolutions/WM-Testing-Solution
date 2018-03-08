using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WM.TestCases
{
    public static class seleniumMethods
    {
        public static void SendCheckKeys(this IWebElement element, string value)
        {
            element.SendKeys(value);

            string insertedValue = element.GetAttribute("value");

            if (insertedValue != value)
            {
                element.Clear();
                SendCheckKeys(element, value);
            }
        }

        public static void waitforElement(this IWebElement element)
        {
            if (!element.Displayed || !element.Enabled)
            {
                waitforElement(element);
            }
        }

        public static void ddlSelectByLabel(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
        public static void ddlSelectByValue(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByValue(value);
        }
        public static void ddlSelectByIndex(this IWebElement element, int index)
        {
            new SelectElement(element).SelectByIndex(index);
        }
    }
}
