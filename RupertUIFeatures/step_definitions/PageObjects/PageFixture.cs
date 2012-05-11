using System;
using Coypu;
using TechTalk.SpecFlow;

namespace RupertUIFeatures.step_definitions.PageObjects
{
    [Binding]
    public abstract class PageFixture
    {
        protected PageFixture()
        {
            Configuration.Port = 1974;
            //Configuration.Browser = Coypu.Drivers.Browser.Chrome;
        }

        protected void on_page<T>(Action<T> action, bool visit = false) where T : PageObject, new()
        {
            var page = new T { Browser = Browser.Session };
            if (visit) page.Visit();
            action(page);
        }

        protected void visit_page<T>() where T : PageObject, new()
        {
            var page = new T { Browser = Browser.Session };
            page.Visit();
        }
    }
}
