using NPCGenerator.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NPCGenerator.Data
{
    class DynamicAgeCollection : IList<PossiblePropertyContent>
    {
        public DynamicAgeCollection(int count)
        {
            Count = count;
        }

        // hier könnten jetzt auch so sachen wie alters-offset oder normalverteilung etc implementiert werden.

        public PossiblePropertyContent this[int index] { get { return new PossiblePropertyContent(index); } set {  } }

        public int Count { get; set; }

        public IEnumerator<PossiblePropertyContent> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return new PossiblePropertyContent(i);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return new PossiblePropertyContent(i);
            }
        }

        #region NotImportant Properties
        public bool IsReadOnly => true;

        public void Add(PossiblePropertyContent item) { }

        public void Clear() { }

        public bool Contains(PossiblePropertyContent item) => false;

        public void CopyTo(PossiblePropertyContent[] array, int arrayIndex){}

        public int IndexOf(PossiblePropertyContent item) => 0;

        public void Insert(int index, PossiblePropertyContent item) { }

        public bool Remove(PossiblePropertyContent item) => false;

        public void RemoveAt(int index) { }
        #endregion

    }
}
