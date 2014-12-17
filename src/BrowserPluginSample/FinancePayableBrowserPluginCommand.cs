using System;
using Cobra.Conto.Plugin;
using System.Collections.Generic;
using System.Threading;

namespace BrowserPluginSample
{
	internal class FinancePayableBrowserPluginCommand : Cobra.Custom.BrowserPluginCommand
	{
		public override string Name
		{
			get { return "FinancePayableBrowserPluginCommand"; }
		}

		public override string Text
		{
			get { return "Browser Plugin Sample"; }
		}

		public override System.Drawing.Image Image
		{
			get { return BrowserPluginSample.Properties.Resources.browserpluginsample; }
		}

		public override void ExecuteCommand(Cobra.Custom.CBrowserGrid browser)
		{
			if (browser.CurrentRow == null)
			{
				System.Windows.Forms.MessageBox.Show("Select a row to view its document Id!");
				return;
			}

			int id = (int)browser.CurrentRow.Cells["IdColumn"].Value;
			string odmaId = GetODMAId(id);
			if (!string.IsNullOrEmpty(odmaId))
			{
				System.Windows.Forms.MessageBox.Show(string.Format("A kiválasztott iktatási azonosító: {}", odmaId));
			}
			else
			{
				System.Windows.Forms.MessageBox.Show("A kiválasztott bizonylathoz nincs megadva külső iktatási azonosító");
			}
		}

		private string GetODMAId(int financePayableId)
		{
			string returnValue = null;
			string sqltext =
							@"SELECT ODMAID FROM FinancePayable WHERE Id = @Id";
			using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(sqltext, Cobra.Db.ConnectionManager.GetSqlConnection()))
			{
				cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int);
				cmd.Parameters["@Id"].Value = financePayableId;
				if (!(cmd.Connection.State == System.Data.ConnectionState.Open))
				{
					cmd.Connection.Open();
				}
				object retval = cmd.ExecuteScalar();
				if (!DBNull.Value.Equals(retval) && retval != null)
				{
					returnValue = (string)retval;
				}
				cmd.Connection.Close();
			}
			return returnValue;
		}
	}
}