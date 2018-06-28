using NPCGenerator.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TLIB;

namespace NPCGenerator.Data
{
    class ListCollection : IList<PossiblePropertyContent>
    {
        readonly IEnumerable<PossiblePropertyContent> Items;
        const string ItemSeperator = ";";

        public ListCollection(int maxitems, IEnumerable<PossiblePropertyContent> items)
        {
            Count = maxitems;
            Items = items;
        }

        DateTime StartDate => AppModel.Instance.CurrentGenre.StartDate;

        public int Count { get; }

        PossiblePropertyContent CreateList(int count)
        {
            string ret = "";
            foreach (var item in Items.Where(x => x.IsPossible() == true).RandomElements(count))
            {
                if (item.Content != null)
                {
                    ret += item.Content.ToString();
                    ret += ItemSeperator;
                }
            }
            return new PossiblePropertyContent(ret.Remove(ret.Length - ItemSeperator.Length));
        }

        public PossiblePropertyContent this[int index] { get { return CreateList(index); } set { } }


        public IEnumerator<PossiblePropertyContent> GetEnumerator()
        {
            for (int i = 1; i < Count + 1; i++)
            {
                yield return CreateList(i);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 1; i < Count + 1; i++)
            {
                yield return CreateList(i);
            }
        }


        #region NotImportant Properties
        public bool IsReadOnly => true;

        public void Add(PossiblePropertyContent item) { }

        public void Clear() { }

        public bool Contains(PossiblePropertyContent item) => false;

        public void CopyTo(PossiblePropertyContent[] array, int arrayIndex) { }

        public int IndexOf(PossiblePropertyContent item) => 0;

        public void Insert(int index, PossiblePropertyContent item) { }

        public bool Remove(PossiblePropertyContent item) => false;

        public void RemoveAt(int index) { }
        #endregion
    }
}
