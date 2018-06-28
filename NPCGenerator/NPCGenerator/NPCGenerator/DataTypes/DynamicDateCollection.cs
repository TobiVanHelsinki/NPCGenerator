using NPCGenerator.Data;
using NPCGenerator.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NPCGenerator.DataTypes
{
    class DynamicDateCollection : IList<PossiblePropertyContent>
    {
        const int DaysInYear = 365;
        DateTime StartDate => AppModel.Instance.CurrentGenre.StartDate;

        public int Count => DaysInYear;

        PossiblePropertyContent DateFromInt(int index)
        {
            return new PossiblePropertyContent(StartDate.AddDays(index).AddYears((int)AppModel.Instance.AllProperties[HardCoded.Age].Content));
        }

        public PossiblePropertyContent this[int index] { get { return DateFromInt(index); } set { } }


        public IEnumerator<PossiblePropertyContent> GetEnumerator()
        {
            for (int i = 1; i < Count + 1; i++)
            {
                yield return DateFromInt(i);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 1; i < Count + 1; i++)
            {
                yield return DateFromInt(i);
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
