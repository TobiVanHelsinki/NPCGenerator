using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace NPCGenerator.Model
{
    class PropertyModel: INotifyPropertyChanged
	{

        PropertyTypes _Typ;
        public PropertyTypes Typ
        {
            get { return _Typ; }
            set { if (_Typ != value) { _Typ = value; NotifyPropertyChanged(); } }
        }
        object _Content;
        public object Content
        {
            get { return _Content; }
            set { if (_Content != value) { _Content = value; NotifyPropertyChanged(); } }
        }

        string _PropertyName;
        public string PropertyName
        {
            get { return _PropertyName; }
            set { if (_PropertyName != value) { _PropertyName = value; NotifyPropertyChanged(); } }
        }
        bool _IsUserFixed;
        public bool IsUserFixed
        {
            get { return _IsUserFixed; }
            set { if (_IsUserFixed != value) { _IsUserFixed = value; NotifyPropertyChanged(); } }
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
