using System;
using TechTalk.SpecFlow;

namespace Pruefung
{
    [Binding]
    public class TrigonometricalCalculatorSteps
    {
        [Given(@"an (.*)")]
        public void GivenAn(string p0)
        {
            var i = 1;
        }
        
        [When(@"user calculates (.*)")]
        public void WhenUserCalculates(string p0)
        {
            var i = Convert.ToInt32(p0);
            var result = Math.Sin(i);
        }
        
        [When(@"user calculates")]
        public void WhenUserCalculates()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the sinus should be calculated")]
        public void ThenTheSinusShouldBeCalculated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the cosinus should be calculated")]
        public void ThenTheCosinusShouldBeCalculated()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the tanges should be calculated")]
        public void ThenTheTangesShouldBeCalculated()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
