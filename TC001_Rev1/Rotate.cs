using System;
using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using Alpha_Model;
using static TestImages.TC001_Rev1;

namespace TC001_Rev1
{
    [TestCase(1)]
    public class Rotate
    {
        //  reference the software model
        private AlphaApp App { get; set; }

        [SetupTest]
        public bool Setup(ITester t)
        {
            App = new AlphaApp(t);
            return true;
        }

        [PreconditionStep]
        public void PreconditionStep(ITester t)
        {
            App.SystemHelpers.EnvironmentReady();
            //App.Browser.WaitFor();

            // Example for usage of software model:
            //App.ExampleScreen.WaitFor();
            //App.ExampleScreen.ExampleAction("superuser", "safePW");

            t.Report.FailStep("REPLACE_OR_DELETE_ME");
        }

        [TestStep(1,
            TestInput = "TestInput1",
            ExpectedResults = "Expected1")]
        public void Step1(ITester t)
        {
            App.TestScreen1.Switch();

            t.Report.FailStep("REPLACE_ME");
        }

        [CleanupStep]
        public void CleanupStep(ITester t)
        {
            t.Report.FailStep("REPLACE_OR_DELETE_ME");
        }

        [TearDownTest]
        public bool TearDown(ITester t)
        {
            return true;
        }
    }
}
