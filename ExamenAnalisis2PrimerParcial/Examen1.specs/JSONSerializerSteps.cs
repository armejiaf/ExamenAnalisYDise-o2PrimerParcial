﻿using System;
using System.Collections.Generic;
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
        public void GivenIHaveAClassWithAnIntIdWithValue(int p0)
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
            _elementToSerialize = new ClassWithBirthday {Birthday = new DateTime(1970,1,1).AddMilliseconds((double)p0)};
        }

        [Given(@"I have a class with the following values")]
        public void GivenIHaveAClassWithTheFollowingValues(Table table)
        {
            foreach (var tableRow in table.Rows)
            {
                _elementToSerialize = new ClassWithBasicTypes
                {
                    Name = tableRow["Name"],
                    ID = int.Parse(tableRow["ID"]),
                    Salary = float.Parse(tableRow["Salary"]),
                    Birthday = new DateTime(1970, 1, 1).AddMilliseconds(double.Parse(tableRow["Birthday"]))
                };
            }
        }

        [Given(@"I have a class with an empty class MyClass")]
        public void GivenIHaveAClassWithAnEmptyClassMyClass()
        {
            _elementToSerialize = new ClassWithInnerClass{MyClass = new EmptyClass()};
        }

        [Given(@"I have a class with an empty class array MyClassArray")]
        public void GivenIHaveAClassWithAnEmptyClassArrayMyClassArray()
        {
            _elementToSerialize = new ClassWithInnerClassArray {MyClassArray = new List <IClass> {new EmptyClass(), new EmptyClass()}};
        }

        [Given(@"I have a class with a String array MyStringArray with values ""(.*)"", ""(.*)"", ""(.*)""""")]
        public void GivenIHaveAClassWithAStringArrayMyStringArrayWithValues(int p0, int p1, int p2)
        {
            _elementToSerialize = new ClassWithStringArray {MyStringArray = new[] {p0+"", p1+"", p2+""}};
        }

        [Given(@"I have a class with an int array MyIntArray with value (.*), (.*), (.*)""")]
        public void GivenIHaveAClassWithAnIntArrayMyIntArrayWithValue(int p0, int p1, int p2)
        {
            _elementToSerialize = new ClassWithIntArray { MyIntArray = new[] { p0, p1, p2 } };
        }

        [Given(@"I have a class with an inner class that contains a String Name with value '(.*)'")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAStringMyStringWithValue(string p0)
        {
            _elementToSerialize = new ClassWithInnerClass { MyClass = new People{Name = p0} };
        }

        [Given(@"I have a class with an inner class that contains an int ID with value (.*)")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAnIntMyIntWithValue(int p0)
        {
            _elementToSerialize = new ClassWithInnerClass { MyClass = new ClassWithId{ ID = p0 } };
        }

        [Given(@"I have a class with an inner class that contains an int Salary with value (.*)")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAnIntMyFloatWithValue(Decimal p0)
        {
            _elementToSerialize = new ClassWithInnerClass { MyClass = new ClassWithSalary { Salary = (float) p0 } };
        }

        [Given(@"I have a class with an inner class that contains a Date Birthday with value (.*)")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAnIntMyTimeDateWithValue(Decimal p0)
        {
            _elementToSerialize = new ClassWithInnerClass{MyClass = new ClassWithBirthday {Birthday = new DateTime(1970, 1, 1).AddMilliseconds((double)p0)}};
        }

        [Given(@"I have an inner class with the following values")]
        public void GivenIHaveAnInnerClassWithTheFollowingValues(Table table)
        {
            foreach (var tableRow in table.Rows)
            {
                _elementToSerialize = new ClassWithInnerClass
                {
                    MyClass = new ClassWithBasicTypes
                    {
                        Name = tableRow["Name"],
                        ID = int.Parse(tableRow["ID"]),
                        Salary = float.Parse(tableRow["Salary"]),
                        Birthday = new DateTime(1970, 1, 1).AddMilliseconds(double.Parse(tableRow["Birthday"]))
                    }
                };
            }
        }

        [Given(@"I have a class with an inner class that contains a String array MyStringArray with value ""(.*)"", ""(.*)"", ""(.*)""")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAStringArrayMyStringArrayWithValue(int p0, int p1, int p2)
        {
            _elementToSerialize = new ClassWithInnerClass
            {
                MyClass = new ClassWithStringArray {MyStringArray = new[] {p0+"", p1+"", p2+""}}
            };
        }

        [Given(@"I have a class with an inner class that contains an int array MyIntArray with value (.*), (.*), (.*)")]
        public void GivenIHaveAClassWithAnInnerClassThatContainsAnIntArrayMyIntArrayWithValue(int p0, int p1, int p2)
        {
            _elementToSerialize = new ClassWithInnerClass
            {
                MyClass = new ClassWithIntArray { MyIntArray = new[] { p0, p1, p2 } }
            };
        }

        [Given(@"I have a class with a string Name with value ""(.*)"" and an int ID with value (.*)")]
        public void GivenIHaveAClassWithAStringNameWithValueAndAnIntIdWithValue(string p0, int p1)
        {
            _elementToSerialize = new ClassWithNamedProperties {ID = p1, Name = p0};
        }

        [Given(@"I have a class with all types and inner class with all types")]
        public void GivenIHaveAClassWithAllTypesAndInnerClassWithAllTypes(Table table)
        {
            foreach (var tableRow in table.Rows)
            {
                _elementToSerialize = new ClassWithBasicTypesAndClassArray()
                {   
                    Name = tableRow["Name"],
                    ID = int.Parse(tableRow["ID"]),
                    Salary = float.Parse(tableRow["Salary"]),
                    Birthday = new DateTime(1970, 1, 1).AddMilliseconds(double.Parse(tableRow["Birthday"])),
                    MyClassArray = new List<IClass> 
                    { 
                        new EmptyClass(),
                        new ClassWithId{ID = 4}, 
                        new ClassWithBasicTypes
                        {
                            Name = tableRow["Name"],
                            ID = int.Parse(tableRow["ID"]),
                            Salary = float.Parse(tableRow["Salary"]),
                            Birthday = new DateTime(1970, 1, 1).AddMilliseconds(double.Parse(tableRow["Birthday"]))
                        } 
                    }
                };
            }
        }

        [Given(@"I have a primitive data type int with value (.*)")]
        public void GivenIHaveAPrimitiveDataTypeIntWithValue(int p0)
        {
            _elementToSerialize = p0;
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
