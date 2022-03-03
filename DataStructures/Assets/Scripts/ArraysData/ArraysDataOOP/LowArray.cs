using UnityEngine;

public class LowArray 
{
    readonly int[] _array;
    int NElements { get; set; }

    public LowArray(int size)
    {
        NElements = size;
        _array = new int[NElements];
    }

    public void SetElement(int index, int value)
    {
        _array[index] = value;
    }

    public int GetElement(int index) => _array[index];

    public int GetLength() => NElements;

    public void SearchForElement(int valueToSearch)
    {
        foreach (var currentElement in _array)
        {
            if (currentElement == valueToSearch)
                Debug.Log(currentElement);
        }
    }

    public void DeleteElement(int valueToDelete, int counter)
    {
        for (counter = 0; counter < NElements; counter++)
        {
            if (GetElement(counter) == valueToDelete)
            {
               break; 
            }
        }

        for (int deleteCounter = counter; deleteCounter < NElements; deleteCounter++)
        {
           SetElement(deleteCounter, GetElement(deleteCounter + 1)); 
        }

        NElements--;
        
    }
}
