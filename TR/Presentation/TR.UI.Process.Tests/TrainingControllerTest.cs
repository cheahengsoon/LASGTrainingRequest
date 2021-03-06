using TR.Entities;
// <copyright file="TrainingControllerTest.cs" company="Microsoft">Copyright © Microsoft 2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.UI.Process;

namespace TR.UI.Process.Tests
{
    [TestClass]
    [PexClass(typeof(TrainingController))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TrainingControllerTest
    {

        [PexMethod]
        public void Apply([PexAssumeUnderTest]TrainingController target, TrainingRequest trainingRequest)
        {
            target.Apply(trainingRequest);
            // TODO: add assertions to method TrainingControllerTest.Apply(TrainingController, TrainingRequest)
            Assert.AreSame(trainingRequest, trainingRequest);

        }
    }
}
