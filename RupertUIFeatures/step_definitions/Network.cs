using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace RupertUIFeatures.step_definitions
{
    [Binding]
    public class Network
    {
        public class StepDefinitions
        {
            [Given(@"I have entered opened the configuration screen")]
            public void GivenIHaveEnteredOpenedTheConfigurationScreen()
            {
                ScenarioContext.Current.Pending();
            }
     
            [When(@"I click 'View Network'")]
            public void WhenIClickViewNetwork()
            {
                ScenarioContext.Current.Pending();
            }
       
            [Then(@"a list of machines on the network should appear")]
            public void ThenAListOfMachinesOnTheNetworkShouldAppear()
            {
                ScenarioContext.Current.Pending();
            }
     
            [Then(@"an indicator wether each machine is a Murdoch should be shown")]
            public void ThenAnIndicatorWetherEachMachineIsAMurdochShouldBeShown()
            {
                ScenarioContext.Current.Pending();
            }
        }

    }
}
