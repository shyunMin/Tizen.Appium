using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System.Drawing;

namespace Appium.UITests
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
            int X = element.Location.X;
            int Y = element.Location.Y;
            touch.Down(X, Y);
            touch.Up(X, Y);
            System.Threading.Thread.Sleep(3000);
            return;
        }

        public static void ClickWithoutSleep(AppiumDriver driver, string automationId)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            var touch = new RemoteTouchScreen(driver.Driver);
            int X = element.Location.X;
            int Y = element.Location.Y;
            touch.Down(X, Y);
            touch.Up(X, Y);
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
            //AppiumWebElement element = driver.GetWebElement(automationId);
            //element.SetImmediateValue(inputText);
            AppiumWebElement element = driver.GetWebElement(automationId);
            var touch = new RemoteTouchScreen(driver.Driver);
            int X = element.Location.X;
            int Y = element.Location.Y;
            touch.Down(X, Y);
            touch.Up(X, Y);
            driver.Driver.Keyboard.SendKeys(inputText);
            return;
        }

        public static void ClearText(AppiumDriver driver, string automationId)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            element.Clear();
            return;
        }

        public static string GetText(AppiumDriver driver, string automationId)
        {
            System.Threading.Thread.Sleep(2000);
            AppiumWebElement element = driver.GetWebElement(automationId);
            return element.Text;
        }

        public static string GetAttribute(AppiumDriver driver, string automationId, string attribute)
        {
            System.Threading.Thread.Sleep(2000);
            AppiumWebElement element = driver.GetWebElement(automationId);
            return element.GetAttribute(attribute);
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

        public static void Tap(AppiumDriver driver, string automationId, int fingers, int duration)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            element.Tap(fingers, duration);
        }

        public static bool GetSelected(AppiumDriver driver, string automationId)
        {
            AppiumWebElement element = driver.GetWebElement(automationId);
            return element.Selected;
        }
    }
}