using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NPCGenerator.Model
{
    class AppModel : INotifyPropertyChanged
	{
        #region NotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        protected static AppModel _Instance;
        public static AppModel Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new AppModel();
                }
                return _Instance;
            }
        }
        private AppModel()
        {
            Genres = new ObservableCollection<GenreModel>();
            AllProperties = new ObservableCollection<PropertyModel>();
        }
        GenreModel _CurrentGenre;
        public GenreModel CurrentGenre
        {
            get { return _CurrentGenre; }
            set { if (_CurrentGenre != value) { _CurrentGenre = value; NotifyPropertyChanged(); } }
        }

        public ObservableCollection<GenreModel> Genres { get; set; }
        public ObservableCollection<PropertyModel> AllProperties { get; set; }


    }
}
