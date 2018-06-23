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
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Fantasy", ImagePath = "fantasy.jpg" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Shadowrun", ImagePath = "shadowrun.png" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "Modern", ImagePath = "modern.jpg" });
            AppModel.Instance.Genres.Add(new GenreModel() {GenreName = "More", ImagePath = "more.jpg" });

            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Name", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Race", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Sex", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Age", Typ = PropertyTypes.Int });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Job", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Abilities", Typ = PropertyTypes.String, Content = "NDY" });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Eyes", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Hair", Typ = PropertyTypes.String });
            AppModel.Instance.AllProperties.Add(new PropertyModel() { PropertyName = "Special_Placeholder", Typ = PropertyTypes.Boolean, Content = false });


            for (int i = 0; i < AppModel.Instance.AllProperties.Count; i++)
            {
                for (int j = 0; j < AppModel.Instance.Genres.Count; j++)
                {
                    AppModel.Instance.Genres[j].UsedProperties.Add(AppModel.Instance.AllProperties[i]);
                }
            }


            
            //AppModel.Instance.Genres[0].UsedProperties.Add(AppModel.Instance.AllProperties[0]);
            //AppModel.Instance.Genres[0].UsedProperties.Add(AppModel.Instance.AllProperties[1]);

            //AppModel.Instance.Genres[1].UsedProperties.Add(AppModel.Instance.AllProperties[2]);
            //AppModel.Instance.Genres[1].UsedProperties.Add(AppModel.Instance.AllProperties[3]);

            //AppModel.Instance.Genres[2].UsedProperties.Add(AppModel.Instance.AllProperties[4]);

            Services.GenerateChar.RandomTraits();

            AppModel.Instance.CurrentGenre = AppModel.Instance.Genres[0];

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
