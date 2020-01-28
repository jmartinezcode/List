using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CList;

namespace CustomListTest
{
    [TestClass]
    public class ListTest
    {
        //ADD TESTS
        [TestMethod]
        public void Add_VerifyZeroIndex()
        {
            CustomList<int> list = new CustomList<int>();
            int value = 77;

            list.Add(value);

            Assert.AreEqual(value, list[0]);
        }
        [TestMethod]
        public void Add_VerifyLastIndex()
        {
            CustomList<int> list = new CustomList<int>();
            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;
            
            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);

            Assert.AreEqual(valueThree, list[2]);
        }
        [TestMethod]
        public void Add_VerifyCountAfterInitialAdd()
        {
            CustomList<int> list = new CustomList<int>();
            int value = 77;
            int expected = 1;

            list.Add(value);

            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Add_VerifyCountAfterThreeAddCalls()
        {
            CustomList<int> list = new CustomList<int>();
            int valueOne = 2;
            int valueTwo = 4;
            int valueThree = 6;
            int expected = 3;

            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);

            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Add_VerifyInitialCapacity()
        {
            //verify initial capacity logic
            CustomList<int> list = new CustomList<int>();
            int expected = 0;

            Assert.AreEqual(expected, list.Capacity);
        }
        public void Add_VerifyFirstItemCapacity()
        {
            CustomList<int> list = new CustomList<int>();
            int expected = 4;

            list.Add(4);

            Assert.AreEqual(expected, list.Capacity);
        }
        [TestMethod]
        public void Add_VerifyCapacityIncrements()
        {
            //Add more values than initial capacity: confirm capacity increments
            CustomList<int> list = new CustomList<int>();
            int valueOne = 1;
            int valueTwo = 3;
            int valueThree = 5;
            int valueFour = 7;
            int valueFive = 9;
            int expected = 8;

            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Add(valueFour);
            list.Add(valueFive);

            Assert.AreEqual(expected, list.Capacity);
        }
        [TestMethod]
        public void Add_VerifyCountWhenInitialCapacityExceeded()
        {
            //Add more values than initial capacity: confirm count
            CustomList<int> list = new CustomList<int>();
            int valueOne = 12;
            int valueTwo = 13;
            int valueThree = 14;
            int valueFour = 15;
            int valueFive = 16;
            int expected = 5;

            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Add(valueFour);
            list.Add(valueFive);

            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void Add_VerifyHighIndexValueWhenInitialCapacityExceeded()
        {
            CustomList<int> list = new CustomList<int>();
            int valueOne = 31;
            int valueTwo = 37;
            int valueThree = 41;
            int valueFour = 43;
            int valueFive = 47;

            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Add(valueFour);
            list.Add(valueFive);

            Assert.AreEqual(valueFive, list[4]);
        }

        // REMOVE TESTS
        [TestMethod]
        public void Remove_VerifyZeroIndexAfterRemove()
        {
            CustomList<int> list = new CustomList<int>();
            int valueOne = 11;
            int valueTwo = 77;
            int valueThree = 99;
            
            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Remove(valueOne);

            Assert.AreEqual(valueTwo, list[0]);
        }
        [TestMethod]
        public void Remove_VerifyFirstIndexAfterRemove()
        {
            CustomList<int> list = new CustomList<int>();
            int valueOne = 11;
            int valueTwo = 77;
            int valueThree = 99;

            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Remove(valueOne);

            Assert.AreEqual(valueThree, list[1]);
        }
        [TestMethod]
        public void Remove_VerifyOnlyFirstValueRemoved()
        {
            CustomList<int> list = new CustomList<int>();
            int valueOne = 11;
            int valueTwo = 77;
            int valueThree = 99;

            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Add(valueOne);
            list.Remove(valueOne);

            Assert.AreEqual(valueOne, list[2]);
        }
        [TestMethod]
        public void Remove_VerifyCountAfterRemove()
        {
            CustomList<int> list = new CustomList<int>();
            int valueOne = 11;
            int valueTwo = 77;
            int valueThree = 99;
            int expected = 2;

            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.Remove(valueTwo);

            Assert.AreEqual(expected, list.Count);
        }
        [TestMethod]
        public void ToString_VerifyIntNowString()
        {
            CustomList<int> list = new CustomList<int>();
            int valueOne = 1;
            int valueTwo = 2;
            int valueThree = 3;
            string expected = "1, 2, 3";

            list.Add(valueOne);
            list.Add(valueTwo);
            list.Add(valueThree);
            list.ToString();

            Assert.AreEqual(expected, list.ToString());
        }
        [TestMethod]
        public void ToString_VerifyStringNowString()
        {
            CustomList<string> list = new CustomList<string>();
            string david = "David";
            string brett = "Brett";
            string mike = "Mike";
            string expected = "David, Brett, Mike";

            list.Add(david);
            list.Add(brett);
            list.Add(mike);
            list.ToString();

            Assert.AreEqual(expected, list.ToString());
        }
        [TestMethod]
        public void OverloadPlusOperator_VerifyInt()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 2, 3 };            
            CustomList<int> listTwo = new CustomList<int>() { 4, 5, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> result = new CustomList<int>();

            result = listOne + listTwo;

            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void OverloadPlusOperator_VerifyString()
        {
            CustomList<string> listOne = new CustomList<string>() { "Ewan", "McGregor" , "is" };
            CustomList<string> listTwo = new CustomList<string>() { "the", "best" , "Obi-Wan" };
            CustomList<string> expected = new CustomList<string>() { "Ewan", "McGregor", "is", "the", "best", "Obi-Wan" };
            CustomList<string> result = new CustomList<string>();

            result = listOne + listTwo;

            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void OverloadMinusOperator_VerifyInt()
        {
            CustomList<int> listOne = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> listTwo = new CustomList<int>() { 2, 1, 6 };
            CustomList<int> expected = new CustomList<int>() { 3, 5 };
            CustomList<int> result = new CustomList<int>();
            
            result = listOne - listTwo;

            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void OverloadMinusOperator_VerifyString()
        {
            CustomList<string> listOne = new CustomList<string>() { "Hello", "Hi", "Welcome" };
            CustomList<string> listTwo = new CustomList<string>() { "Hola", "Hello", "Hey" };
            CustomList<string> expected = new CustomList<string>() { "Hi", "Welcome" };
            CustomList<string> result = new CustomList<string>();

            result = listOne - listTwo;

            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void Zip_VerifyZeroIndex()
        {
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            int expected = 1;
            CustomList<int> result = new CustomList<int>();

            result = result.Zip(odd, even);

            Assert.AreEqual(expected, result[0]);
        }
        
        [TestMethod]
        public void Zip_VerifyAlternateNumbers()
        {
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = new CustomList<int> { 1, 2, 3, 4, 5, 6 };
            CustomList<int> result = new CustomList<int>();

            result = result.Zip(odd, even);

            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void Zip_VerifyCountFirstListLonger()
        {
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> result = new CustomList<int>();
            int expected = 6;

            result = result.Zip(odd, even);

            Assert.AreEqual(expected, result.Count);
        }
        [TestMethod]
        public void Zip_VerifyCountFirstListShorter()
        {
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6, 8, 10 };
            CustomList<int> result = new CustomList<int>();
            int expected = 6;

            result = result.Zip(odd, even);

            Assert.AreEqual(expected, result.Count);
        }
        [TestMethod]
        public void Zip_VerifyCapacity()
        {
            CustomList<int> odd = new CustomList<int>() { 1, 3, 5, 7 };
            CustomList<int> even = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> result = new CustomList<int>();
            int expected = 8;

            result = result.Zip(odd, even);

            Assert.AreEqual(expected, result.Capacity);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Indexer_OutOfBounds_ExceptionThrown()
        {
            CustomList<int> list = new CustomList<int>() { 1, 2, 3, 4 };
            
            int result = list[-1];
        }
        [TestMethod]
        public void Sort_VerifyIntOrder()
        {
            CustomList<int> list = new CustomList<int>() { 17, 3, 37, 29, 47, 71, 23 };
            CustomList<int> expected = new CustomList<int>() { 3, 17, 23, 29, 37, 47, 71 };
            CustomList<int> result = new CustomList<int>();

            result = list.Sort();

            Assert.AreEqual(expected.ToString(), result.ToString());
        }        
        [TestMethod]
        public void Sort_VerifyStringOrder()
        {
            CustomList<string> list = new CustomList<string>() { "c", "f", "a", "d", "e", "g", "b" };
            CustomList<string> expected = new CustomList<string>() { "a", "b", "c", "d", "e", "f", "g" };
            CustomList<string> result = new CustomList<string>();

            result = list.Sort();

            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}
