using System;
using System.Runtime.InteropServices;
using Examen1.specs.TestClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using ExamenAnalisis2PrimerParcial;

namespace Examen1.specs
{
    [Binding]
    public class JsonSerializerSteps
    {
        readonly JsonSerializer _jsonserializer = new JsonSerializer();
        string _result;
        private Object _elementToSerialize;
        [Given(@"I have an empty Class")]
        public void GivenIHaveAnEmptyClass()
        {
            _elementToSerialize = new EmptyClass();
        }

        [Given(@"I have a class with a string  Name with value ""(.*)""")]
        public void GivenIHaveAClassWithAStringNameWithValue(string p0)
        {
            _elementToSerialize = new People { Name = p0 };
        }

        [Given(@"I have a class with an int ID with value (.*)")]
        public void GivenIHaveAClassWithAnIntIDWithValue(int p0)
        {
            _elementToSerialize = new ClassWithId {ID = p0};
        }

        [Given(@"I have a class with a float Salary with value (.*)")]
        public void GivenIHaveAClassWithAFloatSalaryWithValue(Decimal p0)
        {
            _elementToSerialize = new ClassWithSalary {Salary = (float)p0};
        }

        [Given(@"I have a class with a Date Birthday with value ""(.*)""")]
        public void GivenIHaveAClassWithADateBirthdayWithValue(Decimal p0)
        {
            _elementToSerialize = new ClassWithBirthday {Birthday = new DateTime(1970,1,1)};
            ((ClassWithBirthday)_elementToSerialize).Birthday = ((ClassWithBirthday)_elementToSerialize).Birthday.AddMilliseconds((double)p0);
        }

        [Given(@"I have a class with the following values")]
        public void GivenIHaveAClassWithTheFollowingValues(Table table)
        {
            _elementToSerialize = new ClassWithBasicTypes
            {
                Name = "Allan",
                ID = 3,
                Salary = 10000.32f,
                Birthday = new DateTime(1970, 1, 1)
            };
            ((ClassWithBasicTypes)_elementToSerialize).Birthday = ((ClassWithBasicTypes)_elementToSerialize).Birthday.AddMilliseconds(1335205592410);
        }

        [Given(@"I have a class with an empty class MyClass")]
        public void GivenIHaveAClassWithAnEmptyClassMyClass()
        {
            _elementToSerialize = new ClassWithEmptyClass{MyClass = new EmptyClass()};
        }

        [Given(@"I have a class with an empty class array MyClassArray")]
        public void GivenIHaveAClassWithAnEmptyClassArrayMyClassArray()
        {
            ScenarioContext.Current.Pending();
            //_elementToSerialize = new ClassWithEmptyClassArray {MyClassArray = new[] {new EmptyClass(), new EmptyClass()}};
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
        [Given(@"I have a class with a String array MyStringArray with values ""(.*)"", ""(.*)"", ""(.*)""""")]
        public void GivenIHaveAClassWithAStringArrayMyStringArrayWithValues(int p0, int p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an int array MyIntArray with value (.*), (.*), (.*)""")]
        public void GivenIHaveAClassWithAnIntArrayMyIntArrayWithValue(int p0, int p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an inner class that contains a String MyString with value '(.*)'")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAStringMyStringWithValue(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an inner class that contains an int MyInt with value (.*)")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAnIntMyIntWithValue(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an inner class that contains an int MyFloat with value (.*)")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAnIntMyFloatWithValue(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an inner class that contains an int MyTimeDate with value (.*)")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAnIntMyTimeDateWithValue(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have an inner class with a string  Name with value ""(.*)""")]
        public void GivenIHaveAnInnerClassWithAStringNameWithValue(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have an inner class with an int ID with value (.*)")]
        public void GivenIHaveAnInnerClassWithAnIntIDWithValue(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have an inner class with a float Salary with value (.*)")]
        public void GivenIHaveAnInnerClassWithAFloatSalaryWithValue(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have an inner class with a Date Birthday with value ""(.*)""")]
        public void GivenIHaveAnInnerClassWithADateBirthdayWithValue(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an inner class that contains a String array MyStringArray with value ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAStringArrayMyStringArrayWithValue(int p0, int p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a class with an inner class that contains an int array MyIntArray with value (.*), (.*), (.*)")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAnIntArrayMyIntArrayWithValue(int p0, int p1, int p2)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I serialize")]
        public void WhenISerialize()
        {
            _result = _jsonserializer.Serialize(_elementToSerialize);
        }

        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string p0)
        {
            Assert.AreEqual(p0, _result);
        }
    }
}
