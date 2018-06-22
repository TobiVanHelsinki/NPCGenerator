using System;
using System.Collections.Generic;
using System.Text;

namespace NPCGenerator.Model
{
    class PropertyModel
    {
        public string Name { get; set; }
        public PropertyTypes Typ { get; set; }
        public object Content { get; set; }
    }
}
