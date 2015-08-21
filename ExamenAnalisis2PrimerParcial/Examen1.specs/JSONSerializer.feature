Feature: JSONSerializer
	In Order to get JSON objects
	As a programmer
	I want to be able to parse classes

@mytag

#string, int, float, datetime, enumerable
Scenario: Return Empty JSON
	Given I have an empty Class
	When I serialize
	Then the result should be "{}"

Scenario: Return String Attribute JSON
	Given I have a class with a string  Name with value "Allan"
	When I serialize
	Then the result should be "{"Name":"Allan"}"

Scenario: Return int Attribute JSON
	Given I have a class with an int ID with value 3
	When I serialize
	Then the result should be "{"ID":3}"
	
Scenario: Return float Attribute JSON
	Given I have a class with a float Salary with value 10000.32
	When I serialize
	Then the result should be "{"Salary":10000.32}"

Scenario: Return DateTime Attribute JSON
	Given I have a class with a Date Birthday with value "1335205592410"
	When I serialize
	Then the result should be ""{Birthday:"2012-04-23T18:25:43.511Z}"

#Test with all basic types
Scenario: Return String, int, float and TimeDate Attributes JSON
	Given I have a class with a string  Name with value "Allan"
	And I have a class with an int ID with value 3
	And I have a class with a float Salary with value 10000.32
	And I have a class with a Date Birthday with value "1335205592410"
	When I serialize
	Then the result should be "{"Name":"Allan", "ID":3, "Salary":10000.32, Birthday:"2012-04-23T18:25:43.511Z}"
	
#arrays, inner classes, inner classes with arrays
Scenario: Return Empty inner class JSON
	Given I have a class with an empty class MyClass
	When I serialize
	Then the result should be ""{{}}"

Scenario: Return Empty inner class' class array JSON
	Given I have a class with an empty class array MyClassArray
	When I serialize
	Then the result should be ""{"MyClassArray":[{},{}]}"

Scenario: Return inner class' string array JSON
	Given I have a class with an inner class that contains a String array MyStringArray
	When I serialize
	Then the result should be ""{{MyStringArray":["1","2","3"]}}"

Scenario: Return inner class' int array JSON
	Given I have a class with an inner class that contains an int array MyIntArray
	When I serialize
	Then the result should be ""{{MyStringArray":[1,2,3]}}"