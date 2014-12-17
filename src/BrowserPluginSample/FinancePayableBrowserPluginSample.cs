using System;
using Cobra.Conto.Plugin;
using System.Collections.Generic;
using System.Threading;

namespace BrowserPluginSample
{
	public class FinancePayableBrowserPluginSample : Cobra.Conto.Plugin.BrowserPluginBase
	{
		public override string Name
		{
			get { return "Browser Plugin Sample"; }
		}

		public override string DestinationClass
		{
			get { return "Cobra.Conto.Finance.FinancePayableBrowser"; }
		}

		public override System.Guid GUID
		{
			get { return this.mGUID; }
		}
		private System.Guid mGUID = new System.Guid("4F654369-6FB1-4a96-AC1D-56C3CA5BEB08");

		public FinancePayableBrowserPluginSample()
		{
			Commands.Add(new FinancePayableBrowserPluginCommand());
		}
	}

	
}
