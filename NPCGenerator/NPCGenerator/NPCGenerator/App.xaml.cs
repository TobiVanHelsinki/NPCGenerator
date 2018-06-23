using NPCGenerator.GUI;
using NPCGenerator.Model;
using NPCGenerator.Services;
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

            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Name", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Race", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Sex", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Age", Typ = PropertyTypes.Int });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Job", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Abiliy", Typ = PropertyTypes.String, Content = "Hunting" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Abiliy", Typ = PropertyTypes.String, Content = "Singing" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Abiliy", Typ = PropertyTypes.String, Content = "Dancing" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Abiliy", Typ = PropertyTypes.String, Content = "Reading" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Special_Placeholder", Typ = PropertyTypes.Boolean, Content = "false" });

            AppModel.Instance.Genres[0].UsedProperties.Add(AppModel.Instance.AllProperties[0]);
            AppModel.Instance.Genres[0].UsedProperties.Add(AppModel.Instance.AllProperties[1]);

            AppModel.Instance.Genres[1].UsedProperties.Add(AppModel.Instance.AllProperties[2]);
            AppModel.Instance.Genres[1].UsedProperties.Add(AppModel.Instance.AllProperties[3]);

            AppModel.Instance.Genres[2].UsedProperties.Add(AppModel.Instance.AllProperties[4]);

            Services.GenerateChar.RandomTraits();
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
