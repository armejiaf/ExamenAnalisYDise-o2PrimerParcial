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

        [When(@"I serialize")]
        public void WhenISerialize()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with a string  Name with value ""(.*)""")]
        public void GivenIHaveAClassWithAStringNameWithValue(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an int ID with value (.*)")]
        public void GivenIHaveAClassWithAnIntIDWithValue(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with a float Salary with value (.*)")]
        public void GivenIHaveAClassWithAFloatSalaryWithValue(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with a Date Birthday with value ""(.*)""")]
        public void GivenIHaveAClassWithADateBirthdayWithValue(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an empty class MyClass")]
        public void GivenIHaveAClassWithAnEmptyClassMyClass()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an empty class array MyClassArray")]
        public void GivenIHaveAClassWithAnEmptyClassArrayMyClassArray()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an inner class that contains a String array MyStringArray")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAStringArrayMyStringArray()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an inner class that contains an int array MyIntArray")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAnIntArrayMyIntArray()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
