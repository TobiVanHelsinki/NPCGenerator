using NPCGenerator.GUI;
using NPCGenerator.Model;
using System;
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
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Name1" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Name2" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Name3" });
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
