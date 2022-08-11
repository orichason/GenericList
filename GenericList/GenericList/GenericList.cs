using System;
namespace GenericList
{
    public class GenericList<T>
    {
        //make function called insert
        //make function called delete
        //make contains function

        T[] List = new T[5];
        int count = 0;

        public GenericList()
        {

        }

        public void InsertItem(T item)
        {
            T[] NewList = new T[List.Length + 1];

            for (int i = 0; i < NewList.Length; i++)
            {
                if (i.Equals(NewList.Length))
                {
                    NewList[i] = item;
                }

                else
                {
                    NewList[i] = List[i];
                }

            }

            List = NewList;
        }

        public void DeleteItem(T item)
        {

        }

        //public bool Contains(T item)
        //{

        //}
    }
}
