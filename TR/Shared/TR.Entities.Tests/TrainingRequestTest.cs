using TR.Business;
// <copyright file="TrainingRequestTest.cs" company="Microsoft">Copyright © Microsoft 2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.Entities;

namespace TR.Business.Tests
{
    [TestClass()]
    public class TrainingRequestTest
    {
        
    }
}

namespace TR.Entities.Tests
{
    /// <summary>This class contains parameterized unit tests for TrainingRequest</summary>
    [PexClass(typeof(TrainingRequest))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class TrainingRequestTest
    {
    }
}
