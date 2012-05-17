using System;
using NUnit.Framework;
using RupertUIFeatures.step_definitions.PageObjects;

namespace RupertUIFeatures.step_definitions
{
    public class NetworkPage :PageObject
    {
         public NetworkPage()
        {
            PageUrl = "/Rupert/Network";
        }

        public override void is_displayed_in_browser()
        {
            Assert.That(Browser.HasContent("Rupert"));
        }

        public int MachineCount
        {
            get
            {
                int machineCount;
                int.TryParse(Browser.FindId("MachineCount").Value, out machineCount);
                return machineCount;
            }
           
        }
    }
}