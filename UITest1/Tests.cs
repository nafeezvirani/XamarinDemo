using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        //[Test]
        public void WelcomeTextIsDisplayed()
        {
            AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");

            Assert.IsTrue(results.Any());
        }

        [Test]
        public void XamarinTest()
        {
            //app.Repl();

            app.Tap(x => x.Text("Add"));
            app.ClearText(x => x.Id("NoResourceEntry-28"));
            app.EnterText(x => x.Id("NoResourceEntry-28"), "SpriteTalk");
            app.ClearText(x => x.Id("NoResourceEntry-30"));
            app.EnterText(x => x.Id("NoResourceEntry-30"), "Universe helps you, Dedication is the KEY");
            app.Tap(x => x.Text("Save"));
            app.SwipeRightToLeft();
            app.SwipeLeftToRight();


            // app.Tap(x => x.Marked("More options"));
            //app.Tap(x => x.Text("Add"));
            //app.EnterText(x => x.Id("txtTitle"), "EA");
            //app.DismissKeyboard();
            //app.EnterText(x => x.Id("txtDesc"), "Description");
            //app.DismissKeyboard();
            //app.Tap(x => x.Id("save_button"));
            //app.WaitForElement(x => x.Text("EA"));
            //app.ScrollDownTo(x => x.Text("EA"));
            //var elementCount = app.Query(x => x.Id("recyclerView").All().Text("EA")).Count();
            //Assert.That(elementCount, Is.EqualTo(1), "There is no such element being added in app list");
            //app.SwipeRightToLeft();
            //app.SwipeLeftToRight();


        }
    }
}
