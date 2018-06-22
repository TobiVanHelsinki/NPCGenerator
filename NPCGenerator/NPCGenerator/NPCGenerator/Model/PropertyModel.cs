using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NPCGenerator.Model
{
    class PropertyModel: INotifyPropertyChanged
	{

        public PropertyTypes Typ { get; set; }
        public object Content { get; set; }

        string _Name;
        public string Name
        {
            get { return _Name; }
            set { if (_Name != value) { _Name = value; NotifyPropertyChanged(); } }
        }
        #region NotifyPropertyChanged
		public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
