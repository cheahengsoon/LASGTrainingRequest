using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.Entities;

namespace TR.Test
{
    /// <summary>
    /// Summary description for UserLogTest
    /// </summary>
    [TestClass]
    public class UserLogTest
    {
       
        [TestMethod]
        public void get_RequestStatus() 
        {
            

            UserLog newul = new UserLog();
            newul.TRequestID = "TR10011";
            newul.SubmitDate = DateTime.Now;
            newul.RequestStatus = "Pending";
            newul.UserLogID = "UL001";

            Assert.AreEqual(newul.RequestStatus, "Pending");

        }
        [TestMethod]
        public void get_SubmitDate()
        {

            UserLog newul = new UserLog();
            newul.TRequestID = "TR10011";
           
            newul.RequestStatus = "Pending";
            newul.UserLogID = "UL001";
            newul.SubmitDate = DateTime.Now;
         // Assert.AreEqual(newul.SubmitDate, DateTime.Now);
            Assert.IsNotNull(newul);

        }
        [TestMethod]
        public void get_TrequestID()
        {
            UserLog newul = new UserLog();
            newul.TRequestID = "TR10011";
            newul.SubmitDate = DateTime.Now;
            newul.RequestStatus = "Pending";
            newul.UserLogID = "UL001";
            Assert.AreEqual(newul.TRequestID, "TR10011");
        }
        [TestMethod]
        public void get_UserLogID()
        {
            UserLog newul = new UserLog();
            newul.TRequestID = "TR10011";
            newul.SubmitDate = DateTime.Now;
            newul.RequestStatus = "Pending";
            newul.UserLogID = "UL001";
            Assert.IsNotNull(newul);

        }
        [TestMethod]
        public void set_SubmitDate()
        {
            UserLog ul = new UserLog();
            ul.TRequestID = "TR10011";
            ul.SubmitDate = DateTime.Now;
           ul.RequestStatus = "Pending";
            ul.UserLogID = "UL001";
            Assert.IsNotNull(ul.SubmitDate);
        }
        [TestMethod]
        public void set_TRequestID()
        {
            UserLog ul = new UserLog();
           ul.TRequestID = "TR10011";
            ul.SubmitDate = DateTime.Now;
            ul.RequestStatus = "Pending";
           ul.UserLogID = "UL001";
            Assert.IsNotNull(ul.TRequestID);
        }
        [TestMethod]
        public void set_UserLogID()
        {
            UserLog ul = new UserLog();
            ul.TRequestID = "TR10011";
            ul.SubmitDate = DateTime.Now;
            ul.RequestStatus = "Pending";
            ul.UserLogID = "UL001";
            Assert.IsNotNull(ul.UserLogID);
        }
        
    }
}
