using System;

public class MergeSort
{
	public MergeSort()
	{
	}

    public void Merge(E[] array, int left, int middle, int right, Icomparer<E> comp)
    {
        E[] leftArray = new E[middle - left + 1];
        E[] rightArray = new E[right - middle];

        Array.Copy(array, left, leftArray, 0, middle - left + 1);
        Array.Copy(array, middle + 1, rightArray, 0, right - middle);

        int i = 0;
        int j = 0;
        for (int k = left; k < right + 1; k++)
        {
            if (i == leftArray.Length)
            {
                array[k] = rightArray[j];
                j++;
            }
            else if (j == rightArray.Length)
            {
                array[k] = leftArray[i];
                i++;
            }
            else if (comp.compare(leftArray[i], rightArray[j]) <=0)
            {
                array[k] = leftArray[i];
                i++;
            }
            else
            {
                array[k] = rightArray[j];
                j++;
            }
        }
    }

    public void MergeSort(E[] array, int left, int right, Icomparer<E> comp)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(array, left, middle, comp);
            MergeSort(array, middle + 1, right, comp);

            Merge(array, left, middle, right, comp);
        }
    }
}
