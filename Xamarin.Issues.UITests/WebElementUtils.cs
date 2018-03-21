using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System.Drawing;

namespace Xamarin.Issues.UITests
{
    public class WebElementUtils
    {
        public static AppiumWebElement GetWebElement(AppiumDriver driver, string automationId)
        {
            return driver.GetWebElement(automationId);
        }

        public static void Click(AppiumDriver driver, string automationId)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            var touch = new RemoteTouchScreen(driver.Driver);
            touch.Down(element.Location.X, element.Location.Y);
            touch.Up(element.Location.X, element.Location.Y);
            System.Threading.Thread.Sleep(1000);
            return;
        }

        public static bool GetDisplayed(AppiumDriver driver, string automationId)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            bool result = element.Displayed;
            return result;
        }

        public static Size GetSize(AppiumDriver driver, string automationId)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            return element.Size;
        }

        public static void SetText(AppiumDriver driver, string automationId, string inputText)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            element.SetImmediateValue(inputText);
            System.Threading.Thread.Sleep(1000);
            return;
        }

        public static string GetText(AppiumDriver driver, string automationId)
        {
            System.Threading.Thread.Sleep(1000);
            AppiumWebElement element = driver.GetWebElement(automationId);
            return element.Text;
        }

        public static string GetAttribute(AppiumDriver driver, string automationId, string attribute)
        {
            System.Threading.Thread.Sleep(1000);
            AppiumWebElement element = driver.GetWebElement(automationId);
            return element.GetAttribute(attribute);
        }

        public static T GetAttribute<T>(AppiumDriver driver, string automationId, string attribute)
        {
            var stringValue = WebElementUtils.GetAttribute(driver, automationId, attribute);
            if (!String.IsNullOrEmpty(stringValue))
            {
                T value = (T)Convert.ChangeType(stringValue, typeof(T));
                return value;
            }
            return default(T);
        }

        public static bool GetEnabled(AppiumDriver driver, string automationId)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            return element.Enabled;
        }

        public static Point GetLocation(AppiumDriver driver, string automationId)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            return element.Location;
        }

        public static bool GetSelected(AppiumDriver driver, string automationId)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            return element.Selected;
        }
    }
}
