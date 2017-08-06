using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace DatabaseProject.Tests
{

    [TestFixture]
    public class Class1
    {


        [Test]
        public static void CheckDatabaseConstructorCapacity()
        {
            //Arrange
            //Act
            Database db = new Database("1 2 3 4 5");

            //Assert
            Assert.AreEqual(16, db.Capacity());
        }

        [Test]
        public static void AddNewIntegerToTheDatabase()
        {
            //Arrange
            Database db = new Database("1 2 3 4 5");

            //Act
            db.Add(6);

            //Assert
            Assert.AreEqual(6, db.Count());
        }

        [Test]
        public static void RemoveTheLastElementFromTheDatabase()
        {
            //Arrange
            Database db = new Database("1 2 3 4 5");

            //Act
            db.Remove();

            //Assert
            Assert.AreEqual(4, db.Count());
        }

        [Test]
        public static void CannotAddMoreThenSixteenElementsToDatabase()
        {
            //Arrange
            Database db = new Database("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16");

            //Act
            //Assert
            Assert.Throws<InvalidOperationException>(() => db.Add(17), "Cannod add more elements!");
        }

        [Test]
        public static void CannotRemoveElementsFromEmptyDatabase()
        {
            //Arrange
            Database db = new Database(" ");

            //Act
            //Assert
            Assert.Throws<InvalidOperationException>(() => db.Remove(), "Database is empty!");
        }

    }
}
