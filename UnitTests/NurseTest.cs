using HMIS.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for NurseTest and is intended
    ///to contain all NurseTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NurseTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Username
        ///</summary>
        [TestMethod()]
        public void UsernameTest()
        {
            Nurse target = new Nurse();
            string actual;
            actual = target.Username;
        }

        /// <summary>
        ///A test for Password
        ///</summary>
        [TestMethod()]
        public void PasswordTest()
        {
            Nurse target = new Nurse(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.Password;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Name
        ///</summary>
        [TestMethod()]
        public void NameTest()
        {
            Nurse target = new Nurse(); // TODO: Initialize to an appropriate value
            string actual;
            actual = target.Name;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MainNurse
        ///</summary>
        [TestMethod()]
        public void MainNurseTest()
        {
            Nurse target = new Nurse(); // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.MainNurse;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ID
        ///</summary>
        [TestMethod()]
        public void IDTest()
        {
            Nurse target = new Nurse(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.ID;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Address
        ///</summary>
        [TestMethod()]
        public void AddressTest()
        {
            Nurse target = new Nurse(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Address = expected;
            actual = target.Address;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Nurse Constructor
        ///</summary>
        [TestMethod()]
        public void NurseConstructorTest2()
        {
            Nurse target = new Nurse();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Nurse Constructor
        ///</summary>
        [TestMethod()]
        public void NurseConstructorTest1()
        {
            int ID = 0; // TODO: Initialize to an appropriate value
            string name = string.Empty; // TODO: Initialize to an appropriate value
            Nurse target = new Nurse(ID, name);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Nurse Constructor
        ///</summary>
        [TestMethod()]
        public void NurseConstructorTest()
        {
            int ID = 5123;
            string name = "Ivo Ivic";
            string address = "Kopernikova 2";
            string username = "ivoivic";
            int password = 2210;
            bool mainNurse = false;
            Nurse target = new Nurse(ID, name, address, username, password, mainNurse);
            Assert.AreEqual(ID, target.ID);
            Assert.AreEqual(name, target.Name);
            Assert.AreEqual(address, target.Address);
            Assert.AreEqual(username, target.Username);
            Assert.AreEqual(password, target.Password);
        }
    }
}
