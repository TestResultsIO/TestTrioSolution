﻿using Alpha_Model;
using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using System;
using static TestImages.TC004_Rev1;

namespace TC004_Rev1
{
    [TestCase(1)]
    public class TurnAround
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

            // Example for usage of software model:
            //App.ExampleScreen.Activate();
            //App.ExampleScreen.ExampleAction("superuser", "safePW");

            t.Report.FailStep("REPLACE_OR_DELETE_ME");
        }

        [TestStep(1,
            TestInput = "TestInput1",
            ExpectedResults = "Expected1")]
        public void Step1(ITester t)
        {
            t.Report.FailStep("REPLACE_ME");
        }

        [CleanupStep]
        public void Step2(ITester t)
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
