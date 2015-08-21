﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Examen1.specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class JSONSerializerFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "JSONSerializer.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "JSONSerializer", "      In Order to get JSON objects\r\n      As a programmer\r\n      I want to be abl" +
                    "e to parse classes", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "JSONSerializer")))
            {
                Examen1.specs.JSONSerializerFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return Empty JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("mytag")]
        public virtual void ReturnEmptyJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return Empty JSON", new string[] {
                        "mytag"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
        testRunner.Given("I have an empty Class", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
        testRunner.Then("the result should be \"{}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return String Attribute JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnStringAttributeJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return String Attribute JSON", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 14
        testRunner.Given("I have a class with a string  Name with value \"Allan\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
        testRunner.Then("the result should be \"{\'Name\':\'Allan\'}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return int Attribute JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnIntAttributeJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return int Attribute JSON", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
        testRunner.Given("I have a class with an int ID with value 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
        testRunner.Then("the result should be \"{\'ID\':3}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return float Attribute JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnFloatAttributeJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return float Attribute JSON", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
        testRunner.Given("I have a class with a float Salary with value 10000.32", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
  testRunner.Then("the result should be \"{\'Salary\':10000.32}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return DateTime Attribute JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnDateTimeAttributeJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return DateTime Attribute JSON", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
        testRunner.Given("I have a class with a Date Birthday with value \"1335205592410\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 30
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
        testRunner.Then("the result should be \"{\'Birthday\':\'2012-04-23T18:25:43.511Z\'}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return String, int, float and TimeDate Attributes JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnStringIntFloatAndTimeDateAttributesJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return String, int, float and TimeDate Attributes JSON", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
        testRunner.Given("I have a class with a string  Name with value \"Allan\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
        testRunner.And("I have a class with an int ID with value 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
        testRunner.And("I have a class with a float Salary with value 10000.32", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
        testRunner.And("I have a class with a Date Birthday with value \"1335205592410\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
        testRunner.Then("the result should be \"{\'Name\':\'Allan\', \'ID\':3, \'Salary\':10000.32, \'Birthday\':\'201" +
                    "2-04-23T18:25:43.511Z\'}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return Empty inner class JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnEmptyInnerClassJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return Empty inner class JSON", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 44
        testRunner.Given("I have a class with an empty class MyClass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
        testRunner.Then("the result should be \"{{}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return Empty inner class\' class array JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnEmptyInnerClassClassArrayJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return Empty inner class\' class array JSON", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
        testRunner.Given("I have a class with an empty class array MyClassArray", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
        testRunner.Then("the result should be \"{\'MyClassArray\':[{},{}]}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return inner class\' string array JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnInnerClassStringArrayJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return inner class\' string array JSON", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 54
        testRunner.Given("I have a class with an inner class that contains a String array MyStringArray", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
        testRunner.Then("the result should be \"{{\'MyStringArray\':[\'1\',\'2\',\'3\']}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return inner class\' int array JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnInnerClassIntArrayJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return inner class\' int array JSON", ((string[])(null)));
#line 58
this.ScenarioSetup(scenarioInfo);
#line 59
        testRunner.Given("I have a class with an inner class that contains an int array MyIntArray", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
        testRunner.Then("the result should be \"{{\'MyStringArray\':[1,2,3]}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
