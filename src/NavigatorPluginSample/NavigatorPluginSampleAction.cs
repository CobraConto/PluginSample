using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NavigatorPluginSample
{
    public partial class NavigatorPluginSampleAction : Cobra.Base.ActionBase 
    {
        public NavigatorPluginSampleAction()
        {
            InitializeComponent();
            
            //A design time formra helyezett, vagy form szinten deklarált táblaadaptereknek kiosztja az adatbázis kapcsolatot.
            this.SetConnection();
        }


        protected override void SafeLoad()
        {
			//A beépített hibakezelés miatt itt lehet minden olyat művelni, amit a form_Load()-ban tennénk
            //feltöltjük a lookup adattáblát.
            this.taxYearTableAdapter.Fill(this.navigatorPluginSampleActionDataSet.TaxYear);
        }

        protected override void OnValidate()
        {
			//A start gomb megnyomásakor az OnPerformAction előtt fut le, ezért itt még feldolgozás előtt validálhatunk.
			//Cobra.Base.InvalidValueException dobássával a feldolgozás leáll, az InvalidValueException szövege pedig tájékoztatásként jelenik meg a felhasználó előtt.

            if (!(this.taxYearIdCombo.SelectedValue is int))
            {
                throw new Cobra.Base.InvalidValueException(LocalText.TaxYearNotSet);
            }
        }
        
        protected override void OnPerformAction()
        {
			//A start gomb megnyomása ezt a metódust hívja meg
            //feldolgozás
            int i = (int)this.taxYearIdCombo.SelectedValue;
            //....

            //Üzenhetünk a felhasználónak
            Cobra.Base.CMessageBox.Success();
        }
    }
}
