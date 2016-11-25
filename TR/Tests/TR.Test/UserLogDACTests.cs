using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TR.Entities;
using System.Collections.ObjectModel;
using TR.Services;
using TR.UI.Process;
using TR.Business;

namespace TR.Data.Tests
{
    [TestClass()]
    public class UserLogDACTests
    {
        //[TestMethod()]
        //public void Select()
        //{
        //    UserLogDAC tr = new UserLogDAC();

        //    Assert.AreSame(tr, tr);
        //}

      [TestMethod]
      public void Select()
        {
          
            UserLogDAC tr = new UserLogDAC();
      
            Assert.IsNotNull(tr);

        }


    
    }
}