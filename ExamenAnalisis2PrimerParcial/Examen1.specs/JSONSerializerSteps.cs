using System;
using TechTalk.SpecFlow;

namespace Examen1.specs
{
    [Binding]
    public class JSONSerializerSteps
    {
        [Given(@"I have an empty Class")]
        public void GivenIHaveAnEmptyClass()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press serialize")]
        public void WhenIPressSerialize()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be \{}")]
        public void ThenTheResultShouldBe()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
