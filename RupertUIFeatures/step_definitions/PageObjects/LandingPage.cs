using NUnit.Framework;


namespace RupertUIFeatures.step_definitions.PageObjects
{
    public class LandingPage : PageObject
    {
        public LandingPage()
        {
            PageUrl = "/";
        }

        public override void is_displayed_in_browser()
        {
            Assert.That(Browser.HasContent("Rupert"));
        }

        public void Config()
        {
            Browser.FindLink("Configuration").Click();
        }
    }
}
