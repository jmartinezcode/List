### List

This is a [devCodeCamp](https://devcodecamp.com) project to create a custom list class in C#

### Background
The built-in `List<T>` class is a generic class that acts as a wrapper over the array class. This project will not use built-in `List` or `Array` methods or properties. Please refer to the C# `List<T>` class [documentation](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1?view=netframework-4.8).

### Features (To Do Still)
Use Test Driven Development (TDD), so that I can write tests for my methods to pass to ensure proper functionality within my application. There needs to be several tests per method.  

Use a custom-built list class that stores its values in an array, so that I can store any data type in my collection.

Read-only Count property implemented on the custom-built list class, so that I can get a count of the number of elements in my custom list class instance.

A Capacity property implemented on the custom-built list class, so that I can publicly see the size of my private array.

Create a C# indexer so that I can make the objects in my list accessible via index. I want to properly ensure that a user cannot access an out-of-bounds index.

The ability to add an object to an instance of my custom-built list class by imitating the C# [`Add()` method](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.add?view=netframework-4.8).

The ability to remove an object from an instance of my custom-built list class by imitating the C# [`Remove()` method](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=netframework-4.8).

Able to override the `ToString` method that converts the contents of the custom list to a string.   

Able to overload the `+` operator, so that I can add two instances of the custom list class together.
-	```List<int> one = new List<int>() {1,3,5};``` and ```List<int> two = new List<int>() {2,4,6};```
-	```List<int> result = one + two;```
-	`result` has `1,3,5,2,4,6`

Able to overload the `–` operator, so that I can subtract one instance of a custom list class from another instance of a custom list class.  
* `List<int> one = new List<int>() {1,3,5};` and `List<int> two = new List<int>() {2,1,6};`  
* `List<int> result = one - two;`
* `result` has `3,5`  

Write documentation in a `.txt` file that describes the details and functionality of my `–` operator overload. Including details such as “syntax”, “parameters”, “return type”, and an example of it being used, with the output. I want to use [this documentation](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=netframework-4.8) as a guideline.

The ability to zip two custom list class instances together in the form of a zipper. An example:
-	I have `List<int> odd = new List<int>() {1,3,5};` and `List<int> even = new List<int>() {2,4,6};`
-	`odd.Zip(even);`
-	When lists odd and even are zipped together, your new list will contain values `1,2,3,4,5,6`

The custom list class to be iterable.

Use C# best practices, SOLID design principles, and good naming conventions on the project.

### Future
The ability to sort an instance of my custom-built list class without using `Array.Sort()` that is already built in.
