using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
  public class MyDictionary<TKey,TValue>
    {
        TKey[]tkeys;
        TValue[] tvalues;
       
        public MyDictionary()
        {
            tkeys = new TKey[0];
            tvalues = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] TkeyArray = tkeys;
            TValue[] TvalueArray = tvalues;
            tkeys = new TKey[tkeys.Length+1];
            tvalues = new TValue[tvalues.Length + 1];
            for (int i = 0; i < TkeyArray.Length; i++)
            {
                tkeys[i] = TkeyArray[i];
            }

            for (int i = 0; i < TvalueArray.Length; i++)
            {
                tvalues[i] = TvalueArray[i];
            }
            tkeys[tkeys.Length-1]= key;
            tvalues[tvalues.Length - 1] = value;
        }
    }
}
