﻿using NUnit.Framework;
using Problem_4___HashTableImplementation;

namespace HashTableImplementation.Tests
{
    [TestFixture]
    public class ContainsKey_Should
    {
        [Test]
        public void ReturnFalseIfTheSearchedKeyDoesNotExistInTheHashTable()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var firstKey = "hello";
            var firstValue = 1;
            var secondKey = "good morning";

            table.Add(firstKey, firstValue);

            //Act
            var actualResult = table.ContainsKey(secondKey);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void ReturnTrueIfTheSearchedKeyIsValid()
        {
            //Arrange
            var table = new HashTable<string, int>();
            var firstKey = "hello";
            var firstValue = 1;

            table.Add(firstKey, firstValue);

            //Act
            var actualResult = table.ContainsKey(firstKey);

            //Assert
            Assert.IsTrue(actualResult);
        }
    }
}