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
        testRunner.Then("the result should be \"{\'Name\' : \'Allan\'}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
        testRunner.Then("the result should be \"{\'ID\' : 3}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
  testRunner.Then("the result should be \"{\'Salary\' : 10000.32}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
        testRunner.Then("the result should be \"{\'Birthday\' : \'4/23/2012 6:26:32 PM\'}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
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
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ID",
                        "Salary",
                        "Birthday"});
            table1.AddRow(new string[] {
                        "Allan",
                        "3",
                        "10000.32",
                        "1335205592410"});
#line 35
        testRunner.Given("I have a class with the following values", ((string)(null)), table1, "Given ");
#line 38
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
        testRunner.Then("the result should be \"{\'Name\' : \'Allan\', \'ID\' : 3, \'Salary\' : 10000.32, \'Birthday" +
                    "\' : \'4/23/2012 6:26:32 PM\'}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return string array JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnStringArrayJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return string array JSON", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
        testRunner.Given("I have a class with a String array MyStringArray with values \"1\", \"2\", \"3\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
        testRunner.Then("the result should be \"{\'MyStringArray\' : [\'1\', \'2\', \'3\']}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return int array JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnIntArrayJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return int array JSON", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
        testRunner.Given("I have a class with an int array MyIntArray with value 1, 2, 3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
        testRunner.Then("the result should be \"{\'MyIntArray\' : [1, 2, 3]}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return Empty inner class JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnEmptyInnerClassJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return Empty inner class JSON", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 54
        testRunner.Given("I have a class with an empty class MyClass", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 56
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
#line 58
this.ScenarioSetup(scenarioInfo);
#line 59
        testRunner.Given("I have a class with an empty class array MyClassArray", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
        testRunner.Then("the result should be \"{\'MyClassArray\' : [{}, {}]}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return inner class\' string JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnInnerClassStringJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return inner class\' string JSON", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 64
        testRunner.Given("I have a class with an inner class that contains a String Name with value \'Allan\'" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
        testRunner.Then("the result should be \"{{\'Name\' : \'Allan\'}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return inner class\' int JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnInnerClassIntJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return inner class\' int JSON", ((string[])(null)));
#line 68
this.ScenarioSetup(scenarioInfo);
#line 69
        testRunner.Given("I have a class with an inner class that contains an int ID with value 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
        testRunner.Then("the result should be \"{{\'ID\' : 4}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return inner class\' Float JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnInnerClassFloatJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return inner class\' Float JSON", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 74
        testRunner.Given("I have a class with an inner class that contains an int Salary with value 444.4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
        testRunner.Then("the result should be \"{{\'Salary\' : 444.4}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return inner class\' DateTime JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnInnerClassDateTimeJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return inner class\' DateTime JSON", ((string[])(null)));
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
        testRunner.Given("I have a class with an inner class that contains a Date Birthday with value 13352" +
                    "05592410", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
        testRunner.Then("the result should be \"{{\'Birthday\' : \'4/23/2012 6:26:32 PM\'}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return String, int, float and TimeDate Attributes of an inner class JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnStringIntFloatAndTimeDateAttributesOfAnInnerClassJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return String, int, float and TimeDate Attributes of an inner class JSON", ((string[])(null)));
#line 83
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ID",
                        "Salary",
                        "Birthday"});
            table2.AddRow(new string[] {
                        "Allan",
                        "3",
                        "10000.32",
                        "1335205592410"});
#line 84
         testRunner.Given("I have an inner class with the following values", ((string)(null)), table2, "Given ");
#line 87
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 88
        testRunner.Then("the result should be \"{{\'Name\' : \'Allan\', \'ID\' : 3, \'Salary\' : 10000.32, \'Birthda" +
                    "y\' : \'4/23/2012 6:26:32 PM\'}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return inner class\' string array JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnInnerClassStringArrayJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return inner class\' string array JSON", ((string[])(null)));
#line 90
this.ScenarioSetup(scenarioInfo);
#line 91
        testRunner.Given("I have a class with an inner class that contains a String array MyStringArray wit" +
                    "h value \"1\", \"2\", \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
        testRunner.Then("the result should be \"{{\'MyStringArray\' : [\'1\', \'2\', \'3\']}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return inner class\' int array JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnInnerClassIntArrayJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return inner class\' int array JSON", ((string[])(null)));
#line 95
this.ScenarioSetup(scenarioInfo);
#line 96
        testRunner.Given("I have a class with an inner class that contains an int array MyIntArray with val" +
                    "ue 1, 2, 3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 98
        testRunner.Then("the result should be \"{{\'MyIntArray\' : [1, 2, 3]}}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return Renamed String and Int Attributes JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnRenamedStringAndIntAttributesJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return Renamed String and Int Attributes JSON", ((string[])(null)));
#line 100
this.ScenarioSetup(scenarioInfo);
#line 101
        testRunner.Given("I have a class with a string Name with value \"Allan\" and an int ID with value 5", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 102
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 103
        testRunner.Then("the result should be \"{\'Nombre\' : \'Allan\', \'Identificacion\' : 5}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return class with all types and inner class with all types")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnClassWithAllTypesAndInnerClassWithAllTypes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return class with all types and inner class with all types", ((string[])(null)));
#line 105
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "ID",
                        "Salary",
                        "Birthday"});
            table3.AddRow(new string[] {
                        "Allan",
                        "3",
                        "10000.32",
                        "1335205592410"});
#line 106
        testRunner.Given("I have a class with all types and inner class with all types", ((string)(null)), table3, "Given ");
#line 109
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 110
        testRunner.Then("the result should be \"{\'Name\' : \'Allan\', \'ID\' : 3, \'Salary\' : 10000.32, \'Birthday" +
                    "\' : \'4/23/2012 6:26:32 PM\', \'MyClassArray\' : [{}, {\'ID\' : 4}, {\'Name\' : \'Allan\'," +
                    " \'ID\' : 3, \'Salary\' : 10000.32, \'Birthday\' : \'4/23/2012 6:26:32 PM\'}]}\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Return int JSON")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "JSONSerializer")]
        public virtual void ReturnIntJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Return int JSON", ((string[])(null)));
#line 112
this.ScenarioSetup(scenarioInfo);
#line 113
        testRunner.Given("I have a primitive data type int with value 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 114
        testRunner.When("I serialize", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 115
        testRunner.Then("the result should be \"4\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
