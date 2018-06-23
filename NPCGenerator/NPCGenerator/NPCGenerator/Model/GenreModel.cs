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
        #region NotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        String _GenreName;

        public GenreModel(string Name = "Default")
        {
            GenreName = Name;
            UsedProperties = new ObservableCollection<PropertyModel>();
        }

        public String GenreName
        {
            get { return _GenreName; }
            set { if (_GenreName != value) { _GenreName = value; NotifyPropertyChanged(); } }
        }

        public ObservableCollection<PropertyModel> UsedProperties { get; set; }
    }
}
