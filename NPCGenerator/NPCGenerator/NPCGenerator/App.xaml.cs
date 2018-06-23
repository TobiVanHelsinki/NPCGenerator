using NPCGenerator.GUI;
using NPCGenerator.Model;
using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace NPCGenerator
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
            CreateTestModel();

            MainPage = new NavigationPage(new MainPage());
        }
        void CreateTestModel()
        {
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Fantasy" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Shadowrun" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Modern" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "More" });

            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Name" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Race" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Sex" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Age" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Moral" });

            AppModel.Instance.Genres[0].UsedProperties.Add(AppModel.Instance.AllProperties[0]);
            AppModel.Instance.Genres[0].UsedProperties.Add(AppModel.Instance.AllProperties[1]);

            AppModel.Instance.Genres[1].UsedProperties.Add(AppModel.Instance.AllProperties[2]);
            AppModel.Instance.Genres[1].UsedProperties.Add(AppModel.Instance.AllProperties[3]);

            AppModel.Instance.Genres[2].UsedProperties.Add(AppModel.Instance.AllProperties[4]);
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
