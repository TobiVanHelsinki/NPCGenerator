using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NPCGenerator.Model
{
    class AppModel
    {
        public GenreModel CurrentGenre { get; set; }
        public ObservableCollection<GenreModel> Genres { get; set; }
        public ObservableCollection<PropertyModel> AllProperties { get; set; }
    }
}
