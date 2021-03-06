// <copyright file="PexAssemblyInfo.cs" company="Microsoft">Copyright © Microsoft 2016</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("TR.Business")]
[assembly: PexInstrumentAssembly("MK.Framework.ACE")]
[assembly: PexInstrumentAssembly("MK.Framework.ACE.Entities")]
[assembly: PexInstrumentAssembly("MK.Framework.DXE.Entities")]
[assembly: PexInstrumentAssembly("MK.Framework.DXE")]
[assembly: PexInstrumentAssembly("TR.Data")]
[assembly: PexInstrumentAssembly("TR.Entities")]
[assembly: PexInstrumentAssembly("MK.Framework.AE")]
[assembly: PexInstrumentAssembly("MK.Framework.SNE")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "MK.Framework.ACE")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "MK.Framework.ACE.Entities")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "MK.Framework.DXE.Entities")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "MK.Framework.DXE")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "TR.Data")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "TR.Entities")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "MK.Framework.AE")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "MK.Framework.SNE")]

