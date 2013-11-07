using HMIS.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTests
{
    
    
    /// <summary>
    ///This is a test class for DoctorRepositoryTest and is intended
    ///to contain all DoctorRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DoctorRepositoryTest
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
        ///A test for AddDoctor
        ///</summary>
        [TestMethod()]
        public void AddDoctorTest()
        {
            DoctorRepository_Accessor target = new DoctorRepository_Accessor(); 
            int ID = 4520; 
            string name = "Mirko Katić"; 
            string address = "Kopernikova 4"; 
            string username = "mirkokatić"; 
            int password = 5135; 
            target.AddDoctor(ID, name, address, username, password);
            Assert.AreEqual(ID, target._listDoctors[0].ID);
            Assert.AreEqual(name, target._listDoctors[0].Name);
            Assert.AreEqual(address, target._listDoctors[0].Address);
            Assert.AreEqual(username, target._listDoctors[0].Username);
            Assert.AreEqual(password, target._listDoctors[0].Password);
        }

        /// <summary>
        ///A test for RemoveDoctor
        ///</summary>
        [TestMethod()]
        public void RemoveDoctorTest()
        {
            DoctorRepository_Accessor target = new DoctorRepository_Accessor(); 
            int ID = 4520; 
            string name = "Mirko Katić"; 
            string address = "Kopernikova 4"; 
            string username = "mirkokatić"; 
            int password = 2132;
            target.AddDoctor(ID, name, address, username, password);
            target.RemoveDoctor(ID, name);
            Assert.AreEqual(0, target._listDoctors.Count);
        }

        /// <summary>
        ///A test for GetDoctorByID
        ///</summary>
        [TestMethod()]
        public void GetDoctorByIDTest()
        {
            DoctorRepository_Accessor target = new DoctorRepository_Accessor();
            int ID = 4520;
            string name = "Mirko Katić";
            string address = "Kopernikova 4";
            string username = "mirkokatić";
            int password = 2132;
            Doctor expected = new Doctor(ID, name, address, username, password);
            target._listDoctors.Add(expected);
            Doctor actual;
            actual = target.GetDoctorByID(ID);
            Assert.AreEqual(expected, actual);        
        }

        /// <summary>
        ///A test for wrong ID
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidIDException))]
        public void AddDoctorExceptionIDTest()
        {
            DoctorRepository_Accessor target = new DoctorRepository_Accessor();
            int ID = 0;
            string name = "Mirko Katić";
            string address = "Kopernikova 4";
            string username = "mirkokatić";
            int password = 2132;
            target.AddDoctor(ID, name, address, username, password);
        }

        /// <summary>
        ///A test for wrong Name
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidNameException))]
        public void AddDoctorExceptionNameTest()
        {
            DoctorRepository_Accessor target = new DoctorRepository_Accessor();
            int ID = 3102;
            string name = null;
            string address = "Kopernikova 4";
            string username = "mirkokatić";
            int password = 2132;
            target.AddDoctor(ID, name, address, username, password);
        }

        /// <summary>
        ///A test for wrong address
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidAddressException))]
        public void AddDoctorExceptionAddressTest()
        {
            DoctorRepository_Accessor target = new DoctorRepository_Accessor();
            int ID = 3102;
            string name = "Mirako Maric";
            string address = null;
            string username = "mirkokatić";
            int password = 2132;
            target.AddDoctor(ID, name, address, username, password);
        }

        /// <summary>
        ///A test for wrong username
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidUsernameException))]
        public void AddDoctorExceptionUsernameTest()
        {
            DoctorRepository_Accessor target = new DoctorRepository_Accessor();
            int ID = 3102;
            string name = "Mirako Vali";
            string address = "Kopernikova 4";
            string username = null;
            int password = 2132;
            target.AddDoctor(ID, name, address, username, password);
        }

        /// <summary>
        ///A test for wrong password
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(InvalidPasswordException))]
        public void AddDoctorExceptionPasswordTest()
        {
            DoctorRepository_Accessor target = new DoctorRepository_Accessor();
            int ID = 3102;
            string name = "Mirako Maric";
            string address = "Kopernikova 4";
            string username = "mirkokatić";
            int password = 0;
            target.AddDoctor(ID, name, address, username, password);
        }
    }
}
