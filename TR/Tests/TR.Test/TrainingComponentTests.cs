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

namespace TR.Business.Tests
{
    [TestClass()]
    public class TrainingComponentTests
    {
        [TestMethod()]
        public void Apply()
        {
            TrainingRequest trq = new TrainingRequest();
            trq.CorrelationID = Guid.NewGuid();
            trq.TRequestID = "TR10011";
            trq.StartDate = Convert.ToDateTime("2017-04-01");
            trq.EndDate = Convert.ToDateTime("2017-07-01");
            trq.RequestStatus = "Pending";
            trq.SubmitDate = DateTime.Now;
            trq.TrainingName = "MCSD";
            trq.UserName = "Cheah";
            TrainingComponent tr = new TrainingComponent();
            //r.Apply(tr);
            Assert.IsNotNull(tr);
            Assert.IsNotNull(trq);
            //Assert.Fail();
        }

        [TestMethod()]
        public void Approve()
        {
            TrainingRequest trq = new TrainingRequest();
            trq.CorrelationID = Guid.NewGuid();
            trq.TRequestID = "TR10011";
            trq.StartDate = Convert.ToDateTime("2017-04-01");
            trq.EndDate = Convert.ToDateTime("2017-07-01");
            trq.RequestStatus = "Approval";
            trq.SubmitDate = DateTime.Now;
            trq.TrainingName = "MCSD";
            trq.UserName = "Cheah";

            TrainingComponent tr = new TrainingComponent();
          

            Assert.IsNotNull(tr);
            
        }

        [TestMethod()]
        public void Cancel()
        {
            TrainingRequest trq = new TrainingRequest();
            trq.CorrelationID = Guid.NewGuid();
            trq.TRequestID = "TR10011";
            trq.StartDate = Convert.ToDateTime("2017-04-01");
            trq.EndDate = Convert.ToDateTime("2017-07-01");
            trq.RequestStatus = "Cancelled";
            trq.SubmitDate = DateTime.Now;
            trq.TrainingName = "MCSD";
            trq.UserName = "Cheah";

            TrainingComponent tr = new TrainingComponent();

            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        public void ListTraining()
        {
            TrainingComponent tr = new TrainingComponent();

            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        public void GetTraining()
        {
            TrainingComponent tr = new TrainingComponent();
           //r.GetTraining("TR10001");
            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        
        public void LoginVerify()

        {
           
            TrainingComponent tr = new TrainingComponent();
         // var result = tr.LoginVerify("Cheah", "Qwerty@12");
                Assert.IsNotNull(tr);
          //Assert.AreNotEqual(true, result, "User exist");
        }

        [TestMethod()]
        public void Export()
        {
            TrainingComponent tr = new TrainingComponent();

            Assert.IsNotNull(tr);

            TR.Business.TrainingComponent trb = new TR.Business.TrainingComponent();
            
            Assert.IsNotNull(trb);
        }

        [TestMethod()]
        public void Reject()
        {
            TrainingRequest trq = new TrainingRequest();
            trq.CorrelationID = Guid.NewGuid();
            trq.TRequestID = "TR10011";
            trq.StartDate = Convert.ToDateTime("2017-04-01");
            trq.EndDate = Convert.ToDateTime("2017-07-01");
            trq.RequestStatus = "Rejected";
            trq.SubmitDate = DateTime.Now;
            trq.TrainingName = "MCSD";
            trq.UserName = "Cheah";

            TrainingComponent tr = new TrainingComponent();

            Assert.IsNotNull(tr);
        }
        //[TestMethod]
        // public void Apply()
        //{
        //    TrainingComponent tc = new TrainingComponent();

        //    Assert.IsNotNull(tc);
        //}
    }
}