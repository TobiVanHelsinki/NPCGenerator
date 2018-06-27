using System;
using System.Collections.Generic;
using System.Text;

namespace NPCGenerator.Model
{
    public class PossiblePropertyContent
    {
        public PossiblePropertyContent(object content, Func<bool> isPossible)
        {
            Content = content;
            IsPossible = isPossible;
        }

        public object Content { get; set; }

        public Func<bool> IsPossible { get; set; }

    }
}
