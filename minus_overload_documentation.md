## CustomList\<T> - operator overload
Removes the first occurrence of each item in a second `CustomList<T>` from the initial `CustomList<T>` object.

```cs  
public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)

```
#### Parameters
`CustomList<T> firstList`  
The initial list that is potentially having items removed.   

`CustomList<T> secondList`  
The list of items to remove from the initial list.  

#### Returns
`CustomList<T>`  
Removes the first occurrence of each item in the `secondList` from the `firstList`. If no items exist, will return `firstList`.

#### Example:
The following example demonstrates how to subtract two `CustomList<T>` objects.

```cs
// For integers
CustomList<int> listOne = new CustomList<int>() { 1, 3, 5 };  
CustomList<int> listTwo = new CustomList<int>() { 2, 1, 6 };  
CustomList<int> result = new CustomList<int>();  

result = listOne - listTwo;
//This removes only the 1 from listOne
foreach (int item in result)
{
  Console.Write("{0} ", item);  
}
/* Outputs the following:
3 5
*/

//For strings
CustomList<string> greetingsOne = new CustomList<string>() { "Hello", "Hi", "Welcome", "Yo" };  
CustomList<string> greetingsTwo = new CustomList<string>() { "Welcome", "Hola", "Hello", "Hey" };  
CustomList<string> result = new CustomList<string>();  

result = greetingsOne - greetingsTwo;
//This removes the "Welcome" and "Hello"
foreach (string item in result)
{
  Console.Write("{0} ", item);  
}
/* Outputs the following:
Hi Yo
*/

//No matches:
CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };  
CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };  
CustomList<int> result = new CustomList<int>();  

result = listOne - listTwo;
//This removes nothing since complete mismatch
foreach (int item in result)
{
  Console.Write("{0} ", item);  
}
/* Outputs the initial list:
1 2 3
*/

```
