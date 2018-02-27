using System;
using NUnit.Framework;

namespace Appium.UITests
{
    [TestFixture(FormsTizenGalleryUtils.Platform)]
    public class ScrollViewTest3
    {
        string PlatformName;
        AppiumDriver Driver;

        public ScrollViewTest3(string platform)
        {
            PlatformName = platform;
        }

        [TestFixtureSetUp]
        public void Setup()
        {
            Driver = new AppiumDriver(PlatformName);
            FormsTizenGalleryUtils.FindTC(Driver, this.GetType().Name);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void VerticalScrollTest()
        {
            var scrollViewId = "scrollView";
            var remoteTouch = new RemoteTouchScreenUtils(Driver);
            var yBefore = WebElementUtils.GetAttribute(Driver, scrollViewId, "ScrollY");

            remoteTouch.Flick(0, -3);

            var yAfter = WebElementUtils.GetAttribute(Driver, scrollViewId, "ScrollY");

            //screenshot

            Assert.True((Convert.ToDouble(yBefore) < Convert.ToDouble(yAfter)), "y value should be increased, but got before: " + yBefore + ", after: " + yAfter);
        }

        [Test]
        public void HorizontalScrollTest()
        {
            var scrollViewId = "scrollView";
            var remoteTouch = new RemoteTouchScreenUtils(Driver);

            var xBefore = WebElementUtils.GetAttribute(Driver, scrollViewId, "ScrollX");

            remoteTouch.Flick(-3, 0);

            var xAfter = WebElementUtils.GetAttribute(Driver, scrollViewId, "ScrollX");
            //screenshot

            Assert.True((Convert.ToDouble(xBefore) < Convert.ToDouble(xAfter)), "x value should be increased, but got before: " + xBefore + ", after: " + xAfter);
        }
    }
}
