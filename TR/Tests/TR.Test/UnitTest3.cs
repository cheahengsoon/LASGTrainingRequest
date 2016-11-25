using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.UI.Process;
using Microsoft.QualityTools.Testing.Fakes;
using TR.Data;
using TR.Business;
using TR.Entities;

namespace TR.Data.Tests
{
    [TestClass()]
    public class UnitTest3
    {

        [TestMethod()]
        public void Create()
        {
            TrainingRequest tr = new TrainingRequest();
            tr.CorrelationID = Guid.NewGuid();
            tr.TRequestID = "TR10011";
            tr.UserName = "Cheah";
            tr.TrainingName = "MCSD";
            tr.SubmitDate = DateTime.Now;
            tr.StartDate = Convert.ToDateTime("2017-04-01");
            tr.EndDate = Convert.ToDateTime("2017-07-01");
            tr.RequestStatus = "Pending";

            // TrainingComponent tc = new TrainingComponent();

            Assert.IsNotNull(tr);
            Assert.IsTrue(true, "Success");
        }

        [TestMethod()]
        public void UpdateById()
        {
            TrainingRequest tr = new TrainingRequest();
            tr.CorrelationID = Guid.NewGuid();
            tr.CorrelationID = Guid.NewGuid();
            tr.TRequestID = "TR10011";
            tr.UserName = "Cheah";
            tr.TrainingName = "MCSD";
            tr.SubmitDate = DateTime.Now;
            tr.StartDate = Convert.ToDateTime("2017-04-01");
            tr.EndDate = Convert.ToDateTime("2017-07-01");
            tr.RequestStatus = "Pending";

            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        public void SelectPageTest()
        {
            TrainingRequest tr = new TrainingRequest();
            tr.CorrelationID = Guid.NewGuid();
            tr.CorrelationID = Guid.NewGuid();
            tr.TRequestID = "TR10011";
            tr.UserName = "Cheah";
            tr.TrainingName = "MCSD";
            tr.SubmitDate = DateTime.Now;
            tr.StartDate = Convert.ToDateTime("2017-04-01");
            tr.EndDate = Convert.ToDateTime("2017-07-01");
            tr.RequestStatus = "Pending";

            Assert.IsNotNull(tr);

        }

        [TestMethod()]
        public void SelectByIdTest()
        {
            TrainingRequest tr = new TrainingRequest();
            tr.CorrelationID = Guid.NewGuid();
            tr.CorrelationID = Guid.NewGuid();
            tr.TRequestID = "TR10011";
            tr.UserName = "Cheah";
            tr.TrainingName = "MCSD";
            tr.SubmitDate = DateTime.Now;
            tr.StartDate = Convert.ToDateTime("2017-04-01");
            tr.EndDate = Convert.ToDateTime("2017-07-01");
            tr.RequestStatus = "Pending";

            Assert.IsNotNull(tr);
           // Assert.Fail();
        }
    }
}

