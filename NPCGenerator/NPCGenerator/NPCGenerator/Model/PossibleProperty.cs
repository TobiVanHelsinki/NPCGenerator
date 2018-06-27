using System;

namespace NPCGenerator.Model
{
    public class PossiblePropertyContent
    {
        public PossiblePropertyContent(object content, Func<bool> isPossible = null)
        {
            Content = content;
            IsPossible = isPossible == null ? () => true : isPossible;
        }

        public object Content { get; set; }

        public Func<bool> IsPossible { get; set; }

    }
}
