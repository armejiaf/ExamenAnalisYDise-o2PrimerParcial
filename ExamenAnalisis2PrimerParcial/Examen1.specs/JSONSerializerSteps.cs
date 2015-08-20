using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using ExamenAnalisis2PrimerParcial;

namespace Examen1.specs
{
    [Binding]
    public class JsonSerializerSteps
    {
        JsonSerializer jsonserializer = new JsonSerializer();
        string result;

      

        [Given(@"I have an empty Class")]
        public void GivenIHaveAnEmptyClass()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I press serialize")]
        public void WhenIPressSerialize()
        {
            result=jsonserializer.Serialize(new People());
        }
        
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            Assert.AreEqual(p0,result);
        }

    }
}
