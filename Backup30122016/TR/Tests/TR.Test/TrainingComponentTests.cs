using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.UI.Process;
using TR.Business.Tests;
using TR.Entities;
using System.Reflection;

namespace TR.Business.Tests
{
    [TestClass()]
    public class TrainingComponentTests
    {
        public TrainingComponentTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        [ClassInitialize()]
         public static void MyClassInitialize(TestContext testContext)
        {

            SetEntryAssembly(Assembly.GetCallingAssembly());
        }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


        public static void SetEntryAssembly(Assembly assembly)
        {
            AppDomainManager manager = new AppDomainManager();
            FieldInfo entryAssemblyfield = manager.GetType().GetField("m_entryAssembly", BindingFlags.Instance | BindingFlags.NonPublic);
            entryAssemblyfield.SetValue(manager, assembly);

            AppDomain domain = AppDomain.CurrentDomain;
            FieldInfo domainManagerField = domain.GetType().GetField("_domainManager", BindingFlags.Instance | BindingFlags.NonPublic);
            domainManagerField.SetValue(domain, manager);
        }
        [TestMethod()]
        public void Apply()
        {
            TrainingRequest trq = new TrainingRequest();
            trq.CorrelationID = Guid.NewGuid();
        
            trq.StartDate = Convert.ToDateTime("2017-04-01");
            trq.EndDate = Convert.ToDateTime("2017-07-01");
            trq.RequestStatus = "Pending";
            trq.SubmitDate = DateTime.Now;
            trq.TrainingName = "MCSD";
            trq.UserName = "Cheah";
            TrainingComponent tr = new TrainingComponent();
            tr.Apply(trq);
          
            Assert.IsNotNull(trq);

        }

        [TestMethod()]
        public void Approve()
        {
            TrainingRequest trq = new TrainingRequest();
            trq.CorrelationID = Guid.NewGuid();
            trq.RequestStatus = "Approval";

            TrainingComponent tr = new TrainingComponent();
            tr.Approve(trq);

            Assert.IsNotNull(tr);
            
        }

        [TestMethod()]
        public void Cancel()
        {
            TrainingRequest trq = new TrainingRequest();
            trq.CorrelationID = Guid.NewGuid();
            trq.RequestStatus = "Cancelled";

            TrainingComponent tr = new TrainingComponent();
            tr.Cancel(trq);
            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        public void ListTraining()
        {
            TrainingComponent tr = new TrainingComponent();
            tr.ListTraining(1);
            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        public void GetTraining()
        {
            TrainingComponent tr = new TrainingComponent();
            tr.GetTraining("TR10011");
            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        
        public void LoginVerify()

        {
           
            TrainingComponent tr = new TrainingComponent();
            tr.LoginVerify("Cheah", "Qwerty@12");
                Assert.IsNotNull(tr);

        }

        [TestMethod()]
        public void Export()
        {
            TrainingComponent tr = new TrainingComponent();
            tr.Export();
            Assert.IsNotNull(tr);

            TR.Business.TrainingComponent trb = new TR.Business.TrainingComponent();
            
            Assert.IsNotNull(trb);
        }

        [TestMethod()]
        public void Reject()
        {
            TrainingRequest trq = new TrainingRequest();
            trq.RequestStatus = "Rejected";

            TrainingComponent tr = new TrainingComponent();
            tr.Reject(trq);
            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        public void Delay()
        {
            TrainingRequest trq = new TrainingRequest();
            trq.RequestStatus = "Unattended";

            TrainingComponent tr = new TrainingComponent();
            tr.Delay(trq);

            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        public void GetUserPermission()
        {
            TrainingComponent tc = new TrainingComponent();

            tc.GetUserPermission(1, "DB676D6E-5CF5-42CA-850E-57ACF020865C");

            Assert.IsNotNull(tc);

                }
        [TestMethod()]
        public void SelectById()
        {
            TrainingRequest trq = new TrainingRequest();
            

        }

    }
}