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
            //Add more values than initial capacity: confirm capacity doubles
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
        public void OverloadPlusOperator_Verify()
        {
            CustomList<int> listOne = new CustomList<int>();            
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();

            listOne.Add(1);
            listOne.Add(2);
            listOne.Add(3);
            listTwo.Add(4);
            listTwo.Add(5);
            listTwo.Add(6);
            expected.Add(1);
            expected.Add(2);
            expected.Add(3);
            expected.Add(4);
            expected.Add(5);
            expected.Add(6);
            result = listOne + listTwo;

            Assert.AreEqual(expected.ToString(), result.ToString());
        }
        [TestMethod]
        public void OverloadMinusOperator_Verify()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            CustomList<int> result = new CustomList<int>();

            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);
            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);
            expected.Add(3);
            expected.Add(5);
            result = listOne - listTwo;

            Assert.AreEqual(expected.ToString(), result.ToString());
        }
    }
}
