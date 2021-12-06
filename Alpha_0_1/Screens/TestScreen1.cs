using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using Progile.ATE.Common;
using Progile.ATE.TestFramework;
using Progile.TRIO.BaseModel;
using Progile.TRIO.EnvironmentModel;

using static TestImages.Alpha;


namespace Alpha_Model.Screens
{
    public partial class TestScreen1
    {
        public void Switch()
        {
            SwitchButton.Click(SwitchButton.WaitForDisappear);
        }
    }
}