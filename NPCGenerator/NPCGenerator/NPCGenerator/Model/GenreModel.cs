using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NPCGenerator.Model
{
    class GenreModel : INotifyPropertyChanged
	{
        string _GenreName;
        public string GenreName
        {
            get { return _GenreName; }
            set { if (_GenreName != value) { _GenreName = value; NotifyPropertyChanged(); } }
        }
        DateTime _StartTime = DateTime.Now.Date;
        public DateTime StartDate
        {
            get { return _StartTime; }
            set { if (_StartTime != value) { _StartTime = value; NotifyPropertyChanged(); } }
        }

        public string ImagePath { get; set; }

        public ObservableCollection<PropertyModel> UsedProperties { get; set; }

        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public GenreModel(string Name = "Default", string Path = "Xamarin.png")
        {
            GenreName = Name;
            ImagePath = Path;
            UsedProperties = new ObservableCollection<PropertyModel>();
        }

        

        public override string ToString()
        {
            return this._GenreName;
        }
    }
}
