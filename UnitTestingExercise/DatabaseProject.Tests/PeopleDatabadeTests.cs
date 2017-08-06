using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace DatabaseProject.Tests
{
    [TestFixture]
    public class PeopleDatabadeTests
    {
        private static  PeopleDatabase pdb = new PeopleDatabase();

        [Test]
        public static void CreatePeopleDatabase()
        {
            //Arrange
            //Act
            //Assert

            Assert.AreEqual(typeof(PeopleDatabase).ToString() , pdb.GetType().ToString());
        }

        [Test]
        public static void AddPersonToDatabase()
        {
            //Arrange
            //Act
            pdb.Add(new Person("1", "DarthVader"));

            //Assert
            Assert.AreEqual(1, pdb.Count());
        }

        [Test]
        public static void FindPersonByUsername()
        {
            //Arrange
            pdb.Add(new Person("1", "DarthVader"));
            //Act

            string username = "DarthVader";
            Person checkPerson = pdb.FindByUsername("DarthVader");

            //Assert
            Assert.AreEqual(username, checkPerson.Username);
        }

        [Test]
        public static void FindPersonById()
        {
            //Arrange
            pdb.Add(new Person("1", "DarthVader"));
            //Act

            string id = "1";
            Person checkPerson = pdb.FindById("1");

            //Assert
            Assert.AreEqual(id, checkPerson.Id);
        }

        [Test]
        public static void CannotAddPersonWithTheSameId()
        {
            //Arrange
            pdb.Add(new Person("1", "DarthVader"));
            //Act
            //Assert
            Assert.Throws<InvalidOperationException>(() => pdb.Add(new Person("1", "MaceWindu")));
        }

        [Test]
        public static void CannotAddPersonWithTheSameUsername()
        {
            //Arrange
            pdb.Add(new Person("1", "DarthVader"));
            //Act
            //Assert
            Assert.Throws<InvalidOperationException>(() => pdb.Add(new Person("10", "DarthVader")));
        }
    }
}
