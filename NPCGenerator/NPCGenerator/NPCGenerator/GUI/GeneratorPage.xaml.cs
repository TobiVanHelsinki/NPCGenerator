using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NPCGenerator.GUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneratorPage : ContentPage
    {
        
        ObservableCollection<string> Liste { get; set; } = new ObservableCollection<string>() { "hallo", "Tobi" };
		public GeneratorPage ()
		{
			InitializeComponent ();
		}
	}
}