using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TR.Entities;
using TR.UI.Process;
// <copyright file="TrainingControllerTest.Apply.g.cs" company="Microsoft">Copyright © Microsoft 2016</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TR.UI.Process.Tests
{
    public partial class TrainingControllerTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TrainingControllerTest))]
[PexRaisedException(typeof(InvalidProgramException))]
public void ApplyThrowsInvalidProgramException361()
{
    TrainingController s0 = new TrainingController();
    this.Apply(s0, (TrainingRequest)null);
}
    }
}
