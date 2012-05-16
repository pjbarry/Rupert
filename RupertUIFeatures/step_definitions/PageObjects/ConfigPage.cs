using NUnit.Framework;
using RupertUIFeatures.step_definitions.PageObjects;

namespace RupertUIFeatures.step_definitions
{
    public class ConfigPage : PageObject
    {
        public ConfigPage()
        {
            PageUrl = "/Rupert/config";

        }
        public override void is_displayed_in_browser()
        {
            Assert.That(Browser.HasContent("Rupert Configuration"));
        }

        public void ViewNetwork()
        {
            Browser.FindLink("View Network").Click();
        }
    }
}