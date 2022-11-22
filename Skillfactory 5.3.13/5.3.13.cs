using System;

static void Main(string[] args)
{
    int[] massiv = new int[6] { 1, 2, 3, 4, 5, 6 };
    int[] sortedmassiv = SortArrayAsc(massiv);
    int[] resortedmassiv = SortArrayDesc(massiv);
    SortArray(massiv, out resortedmassiv, out sortedmassiv);
    Console.ReadLine();
}


static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
{
    //int[] array = new int[6] { 1, 2, 3, 4, 5, 6 };
    sorteddesc = SortArrayDesc(array);
    sortedasc = SortArrayAsc(array);

}

static int[] SortArrayAsc(int[] array)
{ 
    int temp = 0;
    for (int i = 0; i < array.Length; i++)
        for (int j = i + 1; j < array.Length; j++)
            if (array[i] > array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
    return array;
}


static int[] SortArrayDesc(int[] array)
{

    int temp = 0;
    for (int i = 0; i < array.Length; i++)
        for (int j = i + 1; j < array.Length; j++)
            if (array[i] < array[j])
            {
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
    return array;
}
