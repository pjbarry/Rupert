using System;
using Coypu;
using TechTalk.SpecFlow;

namespace RupertUIFeatures.step_definitions.PageObjects
{
    [Binding]
    public abstract class PageFixture
    {
        protected readonly BrowserSession _browser;
        protected PageFixture(BrowserSession browser)
        {
            _browser = browser;
        }

        protected void on_page<T>(Action<T> action, bool visit = false) where T : PageObject, new()
        {
            try
            {
                var page = new T();
                page.Browser = _browser;
                if (visit) page.Visit();
                action(page);
            }
            catch (Exception)
            {
                Console.WriteLine((_browser.Native as OpenQA.Selenium.Remote.RemoteWebDriver).PageSource);
                throw;
            }
        }

        protected void visit_page<T>() where T : PageObject, new()
        {
            var page = new T();
            page.Browser = _browser;
            page.Visit();   
        }
    }
}
