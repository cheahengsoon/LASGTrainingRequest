using TR.Entities;
// <copyright file="TrainingRequestDACTest.cs" company="Microsoft">Copyright © Microsoft 2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.Data;

namespace TR.Data.Tests
{
    [TestClass]
    [PexClass(typeof(TrainingRequestDAC))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TrainingRequestDACTest
    {

        [PexMethod]
        public TrainingRequest Create([PexAssumeUnderTest]TrainingRequestDAC target, TrainingRequest trainingRequest)
        {
            TrainingRequest result = target.Create(trainingRequest);
            return result;
            // TODO: add assertions to method TrainingRequestDACTest.Create(TrainingRequestDAC, TrainingRequest)
        }
    }
}
