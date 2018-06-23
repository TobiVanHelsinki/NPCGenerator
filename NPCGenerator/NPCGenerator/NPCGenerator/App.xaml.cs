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
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Name1" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Name2" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Name3" });
            AppModel.Instance.CurrentGenre = AppModel.Instance.Genres.FirstOrDefault();
            AppModel.Instance.AllProperties.Add(new PropertyModel() { Name = "Prop1" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { Name = "Prop2" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { Name = "Prop3" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { Name = "Prop4" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { Name = "Prop5" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { Name = "Prop6" });

            AppModel.Instance.Genres[0].UsedProperties.Add(AppModel.Instance.AllProperties[0]);
            AppModel.Instance.Genres[0].UsedProperties.Add(AppModel.Instance.AllProperties[1]);

            AppModel.Instance.Genres[1].UsedProperties.Add(AppModel.Instance.AllProperties[2]);
            AppModel.Instance.Genres[1].UsedProperties.Add(AppModel.Instance.AllProperties[3]);

            AppModel.Instance.Genres[2].UsedProperties.Add(AppModel.Instance.AllProperties[4]);
            AppModel.Instance.Genres[2].UsedProperties.Add(AppModel.Instance.AllProperties[5]);

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
