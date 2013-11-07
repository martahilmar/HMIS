using HMIS.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTests
{    
    /// <summary>
    ///This is a test class for DoctorTest and is intended
    ///to contain all DoctorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoctorTest
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
        ///A test for PacientList
        ///</summary>
        [TestMethod()]
        public void PacientListTest()
        {
            int DoctorID = 5123;
            string Doctorname = "Ivo Ivic";
            string Doctoraddress = "Kopernikova 2";
            string Doctorusername = "ivoivic";
            int Doctorpassword = 5051;
            Doctor target = new Doctor(DoctorID, Doctorname, Doctoraddress, Doctorusername, Doctorpassword);

            List<Patient> expected = new List<Patient>(); 
            List<Patient> actual;

            string name1 = "Ivo Matić";
            string name2 = "Karlo Vukić";
            int ID1 = 2345;
            int ID2 = 4356;
            string address1 = "Mujeva 4";
            string address2 = "Mujeva 5";

            Patient patient1 = new Patient(ID1, name1, address1, Doctorname, DoctorID);
            Patient patient2 = new Patient(ID2, name2, address2, Doctorname, DoctorID);

            target.PacientList.Add(patient1);
            target.PacientList.Add(patient2);

            expected.Add(patient1);
            expected.Add(patient2);
            actual = target.PacientList;
            Assert.AreEqual(expected, actual);    
        }

        /// <summary>
        ///A test for Doctor Constructor
        ///</summary>
        [TestMethod()]
        public void DoctorConstructorTest()
        {
            int ID = 5123;
            string name = "Ivo Ivic";
            string address = "Kopernikova 2";
            string username = "ivoivic";
            int password = 5051;
            Doctor target = new Doctor(ID, name, address, username, password);
            Assert.AreEqual(ID, target.ID);
            Assert.AreEqual(name, target.Name);
            Assert.AreEqual(address, target.Address);
            Assert.AreEqual(username, target.Username);
            Assert.AreEqual(password, target.Password);
        }
    }
}