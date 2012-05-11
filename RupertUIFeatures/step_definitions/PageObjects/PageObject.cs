using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coypu;
using NUnit.Framework;
using OpenQA.Selenium.Remote;

namespace RupertUIFeatures.step_definitions.PageObjects
{
    public abstract class PageObject
    {
     
        public void Visit()
        {
            Browser.Visit(PageUrl);
            if (Browser.HasContent("HTTP 404")) Assert.Fail("Page {0} does not exist", PageUrl);
        }

        public void GoBack()
        {
            ((RemoteWebDriver)Browser.Native).Navigate().Back();
        }

        protected string PageUrl { get; set; }

        public BrowserSession Browser { get; set; }

        public abstract void is_displayed_in_browser();

    }
}
