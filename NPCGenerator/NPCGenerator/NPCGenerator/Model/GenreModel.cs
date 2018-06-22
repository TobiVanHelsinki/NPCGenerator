using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NPCGenerator.Model
{
    class GenreModel
    {
        public String GenreName { get; set; }
        public ObservableCollection<PropertyModel> UsedProperties { get; set; }
    }
}
