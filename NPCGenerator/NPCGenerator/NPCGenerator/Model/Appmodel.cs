using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NPCGenerator.Model
{
    class AppModel
    {
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
        public GenreModel CurrentGenre { get; set; }
        public ObservableCollection<GenreModel> Genres { get; set; }
        public ObservableCollection<PropertyModel> AllProperties { get; set; }
    }
}
