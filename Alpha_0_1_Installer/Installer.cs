using System;
using System.Drawing;
using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using Progile.TRIO.EnvironmentModel;

namespace Alpha_0_1_Installer
{
    [TestCase(1)]
    public class Installer
    {
        ISystemHelpers SystemHelpers { get; set; }

        [SetupTest]
        public bool Prepare(ITester t)
        {
            // Download and unzip the software executable file to the Installer directory (SystemHelpers.InstallerDirectory)
            if (!t.RequestFile(RequestableFileTypeEnum.SoftwareExecutable, out _, true))
            {
                t.Log("Requested SW file could not be downloaded");
                return false;
            }

            SystemHelpers = new SystemHelpers(t);
            return true;
        }

        [PreconditionStep]
        public void PreconditionStep(ITester t)
        {
            SystemHelpers.EnvironmentReady();
            SystemHelpers.SetUpRemoteDirectory();
        }

        [TestStep(1)]
        public void Step1(ITester t)
        {
            t.Report.FailStep("REPLACE_OR_DELETE_ME");
        }
    }
}
