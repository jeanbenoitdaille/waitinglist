    using System;
    using System.Collections.Generic;
    using System.Linq;
     
    namespace Coding.Exercise
    {
         public class WaitingList
        {
            public Queue<string> _names;
     
            public WaitingList()
            {
                _names = new Queue<string>();
            }
     
            public void Add(string name)
            {
                this._names.Enqueue(name);
            }
     
            public void AddMultiple(List<string> names)
            {
                foreach(var n in names)
                {
                    Add(n);
                }
            }
     
            public void Remove(string name)
            {
                this._names = new Queue<string>(this._names.Where(x => x != name));
            }
     
            public int Count()
            {
                return this._names.Count();
            }
     
            public string Next()
            {
                return this._names.Dequeue();
            }
     
            public string CheckNext()
            {
                return this._names.Peek();
            }
     
            public void Reset()
            {
                this._names.Clear();
            }
        }
    }