namespace NavigatorPluginSample
{
    partial class NavigatorPluginSampleAction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.taxYearIdCombo = new Cobra.Custom.CComboBox();
			this.cLabel1 = new Cobra.Custom.CLabel();
			this.navigatorPluginSampleActionDataSet = new NavigatorPluginSampleActionDataSet();
			this.taxYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.taxYearTableAdapter = new NavigatorPluginSampleActionDataSetTableAdapters.TaxYearTableAdapter();
			this.FunctionPanel.SuspendLayout();
			this.DataPanel.SuspendLayout();
			this.ButtonsPanel.SuspendLayout();
			this.MainPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.navigatorPluginSampleActionDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.taxYearBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// FunctionPanel
			// 
			this.FunctionPanel.Location = new System.Drawing.Point(0, 90);
			this.FunctionPanel.Size = new System.Drawing.Size(288, 39);
			// 
			// DataPanel
			// 
			this.DataPanel.Controls.Add(this.cLabel1);
			this.DataPanel.Controls.Add(this.taxYearIdCombo);
			this.DataPanel.Size = new System.Drawing.Size(288, 90);
			// 
			// ButtonsPanel
			// 
			this.ButtonsPanel.Location = new System.Drawing.Point(195, 1);
			// 
			// FunctionSeparatorPanel
			// 
			this.FunctionSeparatorPanel.Size = new System.Drawing.Size(288, 1);
			// 
			// MainPanel
			// 
			this.MainPanel.Size = new System.Drawing.Size(288, 129);
			// 
			// taxYearIdCombo
			// 
			this.taxYearIdCombo.DataSource = this.taxYearBindingSource;
			this.taxYearIdCombo.DisplayMember = "Name";
			this.taxYearIdCombo.FormattingEnabled = true;
			this.taxYearIdCombo.Location = new System.Drawing.Point(71, 22);
			this.taxYearIdCombo.Name = "taxYearIdCombo";
			this.taxYearIdCombo.Size = new System.Drawing.Size(149, 21);
			this.taxYearIdCombo.TabIndex = 0;
			this.taxYearIdCombo.ValueMember = "Id";
			// 
			// cLabel1
			// 
			this.cLabel1.Location = new System.Drawing.Point(12, 23);
			this.cLabel1.Name = "cLabel1";
			this.cLabel1.Size = new System.Drawing.Size(38, 13);
			this.cLabel1.TabIndex = 1;
			this.cLabel1.Text = "Adóév";
			// 
			// navigatorPluginSampleActionDataSet
			// 
			this.navigatorPluginSampleActionDataSet.DataSetName = "NavigatorPluginSampleActionDataSet";
			this.navigatorPluginSampleActionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// taxYearBindingSource
			// 
			this.taxYearBindingSource.DataMember = "TaxYear";
			this.taxYearBindingSource.DataSource = this.navigatorPluginSampleActionDataSet;
			// 
			// taxYearTableAdapter
			// 
			this.taxYearTableAdapter.ClearBeforeFill = true;
			// 
			// NavigatorPluginSampleAction
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 184);
			this.MinimumSize = new System.Drawing.Size(263, 132);
			this.Name = "NavigatorPluginSampleAction";
			this.Text = "Navigátor Plugin Példa";
			this.Load += new System.EventHandler(this.NavigatorPluginSampleAction_Load);
			this.FunctionPanel.ResumeLayout(false);
			this.DataPanel.ResumeLayout(false);
			this.DataPanel.PerformLayout();
			this.ButtonsPanel.ResumeLayout(false);
			this.MainPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.navigatorPluginSampleActionDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.taxYearBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Cobra.Custom.CLabel cLabel1;
		private Cobra.Custom.CComboBox taxYearIdCombo;
		private NavigatorPluginSampleActionDataSet navigatorPluginSampleActionDataSet;
		private System.Windows.Forms.BindingSource taxYearBindingSource;
		private NavigatorPluginSampleActionDataSetTableAdapters.TaxYearTableAdapter taxYearTableAdapter;
    }
}