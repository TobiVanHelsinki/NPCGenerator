using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using TLIB;

namespace NPCGenerator.Model
{
    class PropertyModel: INotifyPropertyChanged
	{

        PropertyTypes _Typ;
        public PropertyTypes Typ
        {
            get { return _Typ; }
            set { if (_Typ != value) { _Typ = value; Content = PropertyTypeHelper.InitContent(Typ); NotifyPropertyChanged(); } }
        }
        
        object _Content;
        public object Content_Man //TODO hier mal mit dynamic experimentieren
        {
            get { return _Content; }
            set {
                /* why is this code so complex? I will tell you: 
                because Content is a object type, a comparer will do a pointer-compare. 
                if those _Content and value objects contain primitive types like int or double, something like that will happen:
                56 == 56 -> false
                to avoid this, we have to use the right comparer and to do that, we have to check the types
                 */ 
                bool HasChanged = false;
                if (value is int && _Content is int)
                {
                    HasChanged |= (int)_Content != (int)value;
                }
                else if (value is string && _Content is string)
                {
                    HasChanged |= (string)_Content != (string)value;
                }
                else if (value is bool && _Content is bool)
                {
                    HasChanged |= (bool)_Content != (bool)value;
                }
                else if (value is DateTime && _Content is DateTime)
                {
                    HasChanged |= ((DateTime)_Content).Date != ((DateTime)value).Date;
                }
                else
                {
                    HasChanged = true;
                }
                if (HasChanged) { IsUserFixed = true; _Content = value; NotifyPropertyChanged(); NotifyPropertyChanged(nameof(Content)); } }
        }

        internal void Reset()
        {
            Content = PropertyTypeHelper.InitContent(Typ);
        }

        public object Content
        {
            get { return _Content; }
            set { if (_Content != value) { _Content = value; NotifyPropertyChanged();
                    NotifyPropertyChanged(nameof(Content_Man)); } }
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

        public IEnumerable<PossiblePropertyContent> PossibleContents = new List<PossiblePropertyContent>();

        public void SelectNewContent()
        {
            if (IsUserFixed)
            {
                return;
            }
            try
            {
                Content = PossibleContents.Where(x => x.IsPossible() == true).RandomElement().Content;
            }
            catch (Exception)
            {
                Content = PropertyTypeHelper.InitContent(Typ);
            }
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
