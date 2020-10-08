using System.Collections;
using System.Collections.Generic;

namespace Homework12
{
    public class MyCollectionEnumerator<T> : IEnumerator<T>
    {
        private MyCollection<T> _myCollection;
        private int position;

        public MyCollectionEnumerator(MyCollection<T> myCollection)
        {
            _myCollection = myCollection;
            position = -1;
        }

        public object Current => _myCollection[position].Value;

        T IEnumerator<T>.Current => _myCollection[position].Value;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (position < _myCollection.Count() - 1)
            {
                position++;

                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
