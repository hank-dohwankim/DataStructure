using System;

public class DynamicArray
{
    // length +1 method
    //private object[] arr = new object[0];
    //public void Add(object element)
    //{
    //    var temp = new object[arr.Length + 1];
    //    for(int i=0; i<arr.Length; i++)
    //    {
    //        temp[i] = arr[i];
    //    }
    //    arr = temp;
    //    arr[arr.Length - 1] = element;
    //}

    // expand double
    private object[] arr;
    private const int GROWTH_FACTOR = 2;

    public int Count { get; set; }
    public int Capacity
    {
        get { return arr.Length; }
    }

    public DynamicArray(int capacity = 16)
    {
        arr = new object[capacity];
        Count = 0;
    }

    public void Add(object element)
    {
        // expand array when it's full
        if(Count >= Capacity)
        {
            int newSize = Capacity * GROWTH_FACTOR;
            var temp = new object[newSize];

            for(int i=0; i<arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }

        arr[Count] = element;

        Count++;
    }

    public object Get(int index)
    {
        if(index > Capacity - 1)
        {
            throw new ApplicationException("Element not found");
        }
        return index;
    }
}