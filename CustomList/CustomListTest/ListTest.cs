using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

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
            int expected = 4;

            Assert.AreEqual(expected, list.Capacity);
        }
        [TestMethod]
        public void Add_VerifyCapacityDoubles()
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
    }
}
