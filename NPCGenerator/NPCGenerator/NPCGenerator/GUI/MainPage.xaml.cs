using NPCGenerator.Model;
using System;
using Xamarin.Forms;

namespace NPCGenerator.GUI
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
		{
            InitializeComponent();
            BindingContext = AppModel.Instance;
        }

        async void GenreSelected(object sender, EventArgs e)
        {
            AppModel.Instance.CurrentGenre = (e as SelectedItemChangedEventArgs).SelectedItem as GenreModel;
            await Navigation.PushAsync(new GeneratorPage());
        }
    }
}
