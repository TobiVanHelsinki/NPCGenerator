using NPCGenerator.Model;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NPCGenerator.GUI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PropertyEntry : ContentView
	{
		public PropertyEntry ()
		{
			InitializeComponent ();
            BindingContextChanged += PropertyEntry_BindingContextChanged;
		}

        PropertyModel CurrentModel;
        private void PropertyEntry_BindingContextChanged(object sender, EventArgs e)
        {
            CurrentModel = ((sender as Element).BindingContext as PropertyModel);
            if (CurrentModel == null)
            {
                return;
            }
            switch (CurrentModel.Typ)
            {
                case PropertyTypes.String:
                    ContentCTRL.ControlTemplate = Resources["String"] as ControlTemplate;
                    break;
                case PropertyTypes.Int:
                    ContentCTRL.ControlTemplate = Resources["Number"] as ControlTemplate;
                    break;
                case PropertyTypes.Color:
                    ContentCTRL.ControlTemplate = Resources["Color"] as ControlTemplate;
                    break;
                case PropertyTypes.Date:
                    ContentCTRL.ControlTemplate = Resources["Date"] as ControlTemplate;
                    break;
                case PropertyTypes.Boolean:
                    ContentCTRL.ControlTemplate = Resources["Boolean"] as ControlTemplate;
                    break;
                default:
                    break;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((sender as Element).BindingContext as PropertyModel).SelectNewContent();
        }
    }
}