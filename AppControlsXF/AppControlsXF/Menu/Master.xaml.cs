using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppControlsXF.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
		}

        private void GoActivityIndicatorPage(object sender, EventArgs args)
        {
            Detail = new Controls.ActivityIndicatorPage();
        }

        private void GoProgressBarPage(object sender, EventArgs args)
        {
            Detail = new Controls.ProgressBarPage();
        }

        private void GoBoxViewPage(object sender, EventArgs args)
        {
            Detail = new Controls.BoxViewpage();
        }

        private void GoLabelPage(object sender, EventArgs args)
        {
            Detail = new Controls.LabelPage();
        }

    }
}