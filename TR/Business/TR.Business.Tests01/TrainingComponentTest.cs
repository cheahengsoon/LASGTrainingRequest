// <copyright file="TrainingComponentTest.cs" company="Microsoft">Copyright © Microsoft 2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.Business;
using TR.Entities;

namespace TR.Business.Tests
{
    /// <summary>This class contains parameterized unit tests for TrainingComponent</summary>
    [PexClass(typeof(TrainingComponent))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class TrainingComponentTest
    {
        /// <summary>Test stub for GetTraining(String)</summary>
        [PexMethod]
        public TrainingRequest GetTrainingTest([PexAssumeUnderTest]TrainingComponent target, string tRequestID)
        {
            TrainingRequest result = target.GetTraining(tRequestID);
            return result;
            // TODO: add assertions to method TrainingComponentTest.GetTrainingTest(TrainingComponent, String)
        }
    }
}
