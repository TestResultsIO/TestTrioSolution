//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by the TestResults.io Designer.
// Designer Version: 4.1.0.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Progile.TRIO.BaseModel;
using Alpha_Model.Screens;
 
namespace Alpha_Model
{
	public partial class AlphaApp : IAppBasics
    {
        partial void InitScreens()
        {
			TestScreen1 = new TestScreen1(this);
        }

		  
		public TestScreen1 TestScreen1 { get; set; }
		
    }
}