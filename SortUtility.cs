using System;

public class SortUtility
{
	public static void Sort(int[] array)
    {
        if (ArrayExist(array))
        {
            while (!IsSorted(array))
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
        }
    }

    private static bool IsSorted(int[] array)
    {
        bool isSorted = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            int a = array[i];
            int b = array[i + 1];
            if (a > b)
            {
                isSorted = false;
                break;
            }
        }
        return isSorted;
    }

    private static bool InArrayIndex(int index, int length)
    {
        return index >= 0 && index < length;
    }

    private static bool ArrayExist(int[] array)
    {
        bool arrayExist = false;
        if (array != null && array.Length > 0)
        {
            arrayExist = true;
        }
        return arrayExist;
    }	
}
