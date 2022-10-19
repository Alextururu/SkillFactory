using System;

class SortClass
{
	public static void SortClassMetod()
	{

		int[] array = new int[] {3,5,2,7};
		int[] sorteddesc;
		int[] sortedasc;
		SortArray(in array, out sorteddesc, out sortedasc);
	}
	static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
		sorteddesc = SortArrayDesc( array);
		sortedasc = SortArrayAsc( array);
	}
	static int[] SortArrayDesc(int[]  array)
    {
		int[] sorteddesc = array.ToArray();
		for (int i = 0; i < sorteddesc.Length; i++)
        {
			for (int j = i+1; j < sorteddesc.Length; j++)
            {
				if(sorteddesc[i] > sorteddesc[j])
                {
					int temp = sorteddesc[i];
					sorteddesc[i] = sorteddesc[j];
					sorteddesc[j] = temp;
                }
            }
        }
		return sorteddesc;
	}
	static int[] SortArrayAsc( int[] array)
	{
		int[] sorteddesc = array.ToArray();
		for (int i = 0; i < sorteddesc.Length; i++)
		{
			for (int j = i + 1; j < sorteddesc.Length; j++)
			{
				if (sorteddesc[i] < sorteddesc[j])
				{
					int temp = sorteddesc[i];
					sorteddesc[i] = sorteddesc[j];
					sorteddesc[j] = temp;
				}
			}
		}
		return sorteddesc;
	}
}