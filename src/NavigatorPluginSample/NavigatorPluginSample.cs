using System.Collections.Generic;
using Cobra.Conto.Plugin;

namespace NavigatorPluginSample
{
 	public class NavigatorPluginSample : NavigatorPlugin
	{
		public override string Name 
		{
			get { return "SampleNavigatorPlugin"; } 
		}

		public override System.Guid GUID
		{
			get { return this.mGUID; }
		}
		private System.Guid mGUID = new System.Guid("EB27AB11-97FC-4c70-9D01-7A59052C69A3");

		public NavigatorPluginSample()
		{
			Commands.Add((NavigatorPluginCommand)(new NavigatorPluginCommandSample()));
		}
	}
}
