using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BoDi;
using Coypu;
using TechTalk.SpecFlow;

namespace RupertUIFeatures.step_definitions
{
    [Binding]
    public class BrowserManager
    {
        private readonly IObjectContainer _objectContainer;
        private BrowserSession _browser;

        public BrowserManager(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Start()
        {
          //   _browser = new BrowserSession(new SessionConfiguration{AppHost = "localhost", Port = 1974, Browser = Coypu.Drivers.Browser.HtmlUnit});
            _browser = new BrowserSession(new SessionConfiguration {AppHost = "localhost", Port = 1974});
            _objectContainer.RegisterInstanceAs(_browser);
        }

        [AfterScenario]
        public void End()
        {
            _browser.Dispose();
        }

    }
}
