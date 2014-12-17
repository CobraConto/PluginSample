using System.Collections.Generic;
using Cobra.Conto.Plugin;

namespace NavigatorPluginSample
{
	internal class NavigatorPluginCommandSample : NavigatorPluginCommand
	{
		public override NavigatorPlugin.PluggableMenu Menu
		{
			get { return NavigatorPlugin.PluggableMenu.Main; }
		}

		public override string Path
		{
            get { return "Invoice.Maintenance"; }
		}

		public override string Name
		{
			get { return "NavigatorPluginSampleForm"; }
		}

		public override string Text
		{
			get { return "Navigátor Plugin Példa"; }
		}

		public override void ExecuteCommand()
		{
			NavigatorPluginSampleAction form = new NavigatorPluginSampleAction();
			form.SafeShow();
		}
	}
}
