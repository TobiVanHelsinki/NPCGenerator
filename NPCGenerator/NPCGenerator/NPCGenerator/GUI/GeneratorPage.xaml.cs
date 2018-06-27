using NPCGenerator.Model;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NPCGenerator.GUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneratorPage : ContentPage, INotifyPropertyChanged
	{
        AppModel AppModel => AppModel.Instance;

		public GeneratorPage ()
		{
            InitializeComponent ();

            CurrentGenrePanel.BindingContext = AppModel.CurrentGenre;
            AppModel.PropertyChanged += AppModel_PropertyChanged;
        }

        private void AppModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(AppModel.CurrentGenre):
                    CurrentGenrePanel.BindingContext = AppModel.CurrentGenre;
                    break;
                default:
                    break;
            }
        }

        private void Reset_Clicked(object sender, EventArgs e)
        {
            foreach (var item in AppModel.Instance.AllProperties)
            {
                item.Reset();
            }
        }

        private void Generate_Clicked(object sender, EventArgs e)
        {
            foreach (var item in AppModel.Instance.AllProperties)
            {
                item.SelectNewContent();
            }
        }

        private void Impressum_Clicked(object sender, EventArgs e)
        {

        }
    }
}