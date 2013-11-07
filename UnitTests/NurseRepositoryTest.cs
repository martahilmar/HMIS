using HMIS.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for NurseRepositoryTest and is intended
    ///to contain all NurseRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NurseRepositoryTest
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
        ///A test for add nurse
        ///</summary>
        [TestMethod()]
        public void AddNurseTest()
        {
            NurseRepository_Accessor target = new NurseRepository_Accessor();
            int ID = 4520;
            string name = "Mirko Katić";
            string address = "Kopernikova 4";
            string username = "mirkokatić";
            bool mainnurse = true;
            int password = 5135;
            target.AddNurse(ID, name, address, username, password, mainnurse);
            Assert.AreEqual(ID, target._listNurses[0].ID);
            Assert.AreEqual(name, target._listNurses[0].Name);
            Assert.AreEqual(address, target._listNurses[0].Address);
            Assert.AreEqual(username, target._listNurses[0].Username);
            Assert.AreEqual(password, target._listNurses[0].Password);
            Assert.AreEqual(mainnurse, target._listNurses[0].MainNurse);
        }

        /// <summary>
        ///A test for remove nurse
        ///</summary>
        [TestMethod()]
        public void RemoveNurseTest()
        {
            NurseRepository_Accessor target = new NurseRepository_Accessor();
            int ID = 4520;
            string name = "Mirko Katić";
            string address = "Kopernikova 4";
            string username = "mirkokatić";
            bool mainnurse = true;
            int password = 5135;
            target.AddNurse(ID, name, address, username, password, mainnurse);
            target.RemoveNurse(ID, name);
            Assert.AreEqual(0, target._listNurses.Count);
        }

        /// <summary>
        ///A test for get nurse by ID
        ///</summary>
        [TestMethod()]
        public void GetNurseByIDTest()
        {
            NurseRepository_Accessor target = new NurseRepository_Accessor();
            int ID = 4520;
            string name = "Mirko Katić";
            string address = "Kopernikova 4";
            string username = "mirkokatić";
            bool mainnurse = true;
            int password = 5135;
            Nurse expected = new Nurse(ID, name, address, username, password, mainnurse);
            target._listNurses.Add(expected);
            Nurse actual;
            actual = target.GetNurseByID(ID);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for get wrong nurse ID exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidIDException))]
        public void AddNurseExceptionIDTest()
        {
            NurseRepository_Accessor target = new NurseRepository_Accessor();
            int ID = 0;
            string name = "Mirko Katić";
            string address = "Kopernikova 4";
            string username = "mirkokatić";
            bool mainnurse = true;
            int password = 5135;
            target.AddNurse(ID, name, address, username, password, mainnurse);
        }

        /// <summary>
        ///A test for get wrong nurse name exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidNameException))]
        public void AddNurseExceptionNameTest()
        {
            NurseRepository_Accessor target = new NurseRepository_Accessor();
            int ID = 4520;
            string name = null;
            string address = "Kopernikova 4";
            string username = "mirkokatić";
            bool mainnurse = true;
            int password = 5135;
            target.AddNurse(ID, name, address, username, password, mainnurse);
        }

        /// <summary>
        ///A test for get wrong nurse address exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidAddressException))]
        public void AddNurseExceptionAddressTest()
        {
            NurseRepository_Accessor target = new NurseRepository_Accessor();
            int ID = 4520;
            string name = "Mirko Katić";
            string address = null;
            string username = "mirkokatić";
            bool mainnurse = true;
            int password = 5135;
            target.AddNurse(ID, name, address, username, password, mainnurse);
        }

        /// <summary>
        ///A test for get wrong nurse username exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidUsernameException))]
        public void AddNurseExceptionUsernameTest()
        {
            NurseRepository_Accessor target = new NurseRepository_Accessor();
            int ID = 4520;
            string name = "Mirko Katić";
            string address = "Mateše Kuhačevića 5";
            string username = null;
            bool mainnurse = true;
            int password = 5135;
            target.AddNurse(ID, name, address, username, password, mainnurse);
        }

        /// <summary>
        ///A test for get wrong nurse password exception
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidPasswordException))]
        public void AddNurseExceptionPasswordTest()
        {
            NurseRepository_Accessor target = new NurseRepository_Accessor();
            int ID = 4520;
            string name = "Mirko Katić";
            string address = "Kopernikova 3";
            string username = "mirkokatić";
            bool mainnurse = true;
            int password = 0;
            target.AddNurse(ID, name, address, username, password, mainnurse);
        }
    }
}
