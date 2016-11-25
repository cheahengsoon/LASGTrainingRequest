using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.UI.Process;
using TR.Entities;
using TR.Data;

namespace TR.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void get_RequestStatus()
        {
            TrainingRequest newtr = new TrainingRequest();
            newtr.CorrelationID = Guid.NewGuid();
            newtr.TRequestID = "TR10011";
            newtr.UserName = "Cheah";
            newtr.TrainingName = "MCSD";
            newtr.SubmitDate = DateTime.Now;
            newtr.StartDate = Convert.ToDateTime("2017-04-01");
            newtr.EndDate = Convert.ToDateTime("2017-07-01");
           
            newtr.RequestStatus = "Pending";
            Assert.AreEqual(newtr.RequestStatus, "Pending");

        }
        [TestMethod]
        public void get_CorrelationID()
        {
           
            TrainingRequest newtr = new TrainingRequest();
            newtr.CorrelationID = Guid.NewGuid();
            newtr.TRequestID = "TR10011";
            newtr.UserName = "Cheah";
            newtr.TrainingName = "MCSD";
            newtr.SubmitDate = DateTime.Now;
            newtr.StartDate = Convert.ToDateTime("2017-04-01");
            newtr.EndDate = Convert.ToDateTime("2017-07-01");
            newtr.RequestStatus = "Pending";
            Assert.IsNotNull(newtr.CorrelationID);
        }

        [TestMethod]
        public void get_EndDate()
        {
            TrainingRequest newtr = new TrainingRequest();
           
            newtr.CorrelationID = Guid.NewGuid();
            newtr.TRequestID = "TR10011";
            newtr.UserName = "Cheah";
            newtr.TrainingName = "MCSD";
            newtr.SubmitDate = DateTime.Now;
            newtr.StartDate = Convert.ToDateTime("2017-04-01");
            newtr.EndDate = Convert.ToDateTime("2017-07-01");

            newtr.RequestStatus = "Pending";
            Assert.AreEqual(newtr.EndDate, Convert.ToDateTime("2017-07-01"));
        }

        [TestMethod]
        public void get_SatrtDate()
        {
            TrainingRequest newtr = new TrainingRequest();
            
            newtr.CorrelationID = Guid.NewGuid();
            newtr.TRequestID = "TR10011";
            newtr.UserName = "Cheah";
            newtr.TrainingName = "MCSD";
            newtr.SubmitDate = DateTime.Now;
            newtr.StartDate = Convert.ToDateTime("2017-04-01");
            newtr.EndDate = Convert.ToDateTime("2017-07-01");

            newtr.RequestStatus = "Pending";
            Assert.AreEqual(newtr.StartDate, Convert.ToDateTime("2017-04-01"));
        }
        [TestMethod]
        public void get_SubmitDate()
        {
            TrainingRequest newtr = new TrainingRequest();
            newtr.CorrelationID = Guid.NewGuid();
            newtr.TRequestID = "TR10011";
            newtr.UserName = "Cheah";
            newtr.TrainingName = "MCSD";
            newtr.SubmitDate = DateTime.Now;
            newtr.StartDate = Convert.ToDateTime("2017-04-01");
            newtr.EndDate = Convert.ToDateTime("2017-07-01");

            newtr.RequestStatus = "Pending";

            Assert.IsNotNull(newtr.SubmitDate);
        }
        [TestMethod]
        public void get_TRequestID()
        {
            TrainingRequest newtr = new TrainingRequest();
            newtr.CorrelationID = Guid.NewGuid();
            newtr.TRequestID = "TR10011";
            newtr.UserName = "Cheah";
            newtr.TrainingName = "MCSD";
            newtr.SubmitDate = DateTime.Now;
            newtr.StartDate = Convert.ToDateTime("2017-04-01");
            newtr.EndDate = Convert.ToDateTime("2017-07-01");

            newtr.RequestStatus = "Pending";
            Assert.AreEqual(newtr.TRequestID, "TR10011");
        }
        [TestMethod]
        public void get_TrainingName()
        {
            TrainingRequest newtr = new TrainingRequest();
            newtr.CorrelationID = Guid.NewGuid();
            newtr.TRequestID = "TR10011";
            newtr.UserName = "Cheah";
            newtr.TrainingName = "MCSD";
            newtr.SubmitDate = DateTime.Now;
            newtr.StartDate = Convert.ToDateTime("2017-04-01");
            newtr.EndDate = Convert.ToDateTime("2017-07-01");

            newtr.RequestStatus = "Pending";
            Assert.AreEqual(newtr.TrainingName, "MCSD");
        }

        [TestMethod]
        public void get_UserName()
        {
            TrainingRequest newtr = new TrainingRequest();
            newtr.CorrelationID = Guid.NewGuid();
            newtr.TRequestID = "TR10011";
            newtr.UserName = "Cheah";
            newtr.TrainingName = "MCSD";
            newtr.SubmitDate = DateTime.Now;
            newtr.StartDate = Convert.ToDateTime("2017-04-01");
            newtr.EndDate = Convert.ToDateTime("2017-07-01");

            newtr.RequestStatus = "Pending";
            Assert.IsNotNull(newtr.UserName);

        }
        [TestMethod]
        public void set_SubmitDate()
        {
            TrainingRequest newtr = new TrainingRequest();
            newtr.CorrelationID = Guid.NewGuid();
            newtr.TRequestID = "TR10011";
            newtr.UserName = "Cheah";
            newtr.TrainingName = "MCSD";
            newtr.SubmitDate = DateTime.Now;
            newtr.StartDate = Convert.ToDateTime("2017-04-01");
            newtr.EndDate = Convert.ToDateTime("2017-07-01");

            newtr.RequestStatus = "Pending";

            Assert.IsNotNull(newtr.SubmitDate);
        }

   

    }
}
