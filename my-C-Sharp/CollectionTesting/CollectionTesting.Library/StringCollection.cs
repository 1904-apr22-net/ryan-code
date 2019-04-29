using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionTesting.Library
{
    public class StringCollection : GenericCollection<string>
    {
        //public StringCollection() : base(new List<string> { "a" })
        public StringCollection() : base() // calls zero-param ctor of parent.
        {
            // 1. constructors are not inherited.
            // 2. every child-class constructor has to call exactly one
            //    parent class constructor. (by default, it tries to call
            //    a zero-parameter constructor first.)
        }

        public StringCollection(IEnumerable<string> coll) : base(coll)
        {
        }

        public void Add(string s)
        {
            List.Add(s);
        }

        public void Remove(string s)
        {
            List.Remove(s);
        }

        //public string GetLongestString()
        //{
        //    if (List.Count == 0)
        //    {
        //        return null;
        //    }

        //    var maxLength = 0;
        //    string max = null;
        //    foreach (var item in List)
        //    {
        //        if (item?.Length > maxLength)
        //        {
        //            maxLength = item.Length;
        //            max = item;
        //        }
        //    }
        //    return max;
        //}

        public string GetLongestString()
        {
            if (List.Count == 0)
            {
                return null;
            }
            var maxLength = List.Max(x => x.Length);
            return List.First(x => x.Length == maxLength);
        }

        public bool AllUppercase()
        {
            return List.All(s => s.All(c => char.IsUpper(c)));
        }

        public void RemoveStartingWithP()
        {
            IEnumerable<string> newList = List.Where(x => x != null && char.ToUpper(x[0]) == 'P');
            List = newList.ToList();
        }
        public string GetMiddleString()
        {
            if (List.Count == 0)
            {
                return null;
            }
            double mid = Math.Floor(List.Count * 0.05);
            return List[(int)mid];
        }

        // we can override most any operator: +, -, +=, ||, &&, ==
        public string this[int index]
        {
            get => List[index];
            set { List[index] = value; }
        }

        public void RemoveShortest()
        {
            if (List.Count > 0)
            {
                var shortest = -1;
                var shortIX = -1;

                for (int i = 0; i < List.Count; i++)
                {
                    if (shortest == -1 || List[i].Length < shortest)
                    {
                        shortIX = i;
                        shortest = List[i].Length;
                    }
                }
                List.Remove(List[shortIX]);
            }


        }
    }
}
