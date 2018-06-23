using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using NPCGenerator.Model;

namespace NPCGenerator.GUI
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeneratorPage : ContentPage, INotifyPropertyChanged
	{
        #region NotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        AppModel AppModel => AppModel.Instance;


        List<string> _TestList;
        public List<string> TestList
        {
            get { return _TestList; }
            set { if (_TestList != value) { _TestList = value; NotifyPropertyChanged(); } }
        }

		public GeneratorPage ()
		{
            TestList = new List<string>() { "hallo", "Tobi" };
            InitializeComponent ();
            BindingContext = this;
        }
	}
}