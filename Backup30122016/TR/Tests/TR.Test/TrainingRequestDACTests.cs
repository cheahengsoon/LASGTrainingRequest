using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.Services;
using TR.Entities;

namespace TR.Data.Tests
{
    [TestClass()]
    public class TrainingRequestDACTests
    {
        [TestMethod()]
        public void Create()
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

            TrainingRequestDAC tr = new TrainingRequestDAC();
            
            Assert.IsNotNull(tr);
        }

        [TestMethod()]
        public void UpdateById()
        {
            TrainingRequestDAC tr = new TrainingRequestDAC();
            TrainingRequest trq = new TrainingRequest();
            trq.CorrelationID = Guid.NewGuid();
            trq.TRequestID = "TR10011";
            trq.StartDate = Convert.ToDateTime("2017-04-01");
            trq.EndDate = Convert.ToDateTime("2017-07-01");
            trq.RequestStatus = "Cancelled";
            trq.SubmitDate = DateTime.Now;
            trq.TrainingName = "MCSD";
            trq.UserName = "Cheah";
            Assert.IsNotNull(tr, "TR10011");
        }

        [TestMethod()]
        public void SelectById()
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

            TrainingRequestDAC tr = new TrainingRequestDAC();

            Assert.IsNotNull(tr, "TR10011");
        }

        [TestMethod()]
        public void SelectPage()
        {
            TrainingRequestDAC tr = new TrainingRequestDAC();
            Assert.IsNotNull(tr);

        }

     
    }
}