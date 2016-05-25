using System;

namespace session
{
	public class Sorts
	{
		public static void Main (){

			foreach (int i in Sorts.InsertionSort (new int[]{ 1, 2, 34, 5, 6, 67, 7 })) {
				Console.WriteLine (i);
			};
			foreach (int i in Sorts.BubbleSort (new int[]{ 1, 2, 34, 5, 6, 67, 7 })) {
				Console.WriteLine (i);
			};
			foreach (int i in Sorts.SelectSort (new int[]{ 1, 2, 34, 5, 6, 67, 7 })) {
				Console.WriteLine (i);
			};
		}
		static int[] InsertionSort(int [] array)
		{

			for(int i = 1; i < array.Length; i++)
			{
				int j = i;
				while(j > 0)
				{
					if(array[j-1] > array[j])
					{
						int temp = array[j - 1];
						array[j - 1] = array[j];
						array[j] = temp;
						j--;
					}
					else
						break;
				}
			}
			return array;
		}
		public static int[] SelectSort(int [] array)
		{
			int posiotinMin, temp;

			for (int i = 0; i < array.Length - 1; i++) {
				posiotinMin = i;
				for (int j = i + 1; j < array.Length; j++) {
					if (array [j] < array [posiotinMin]) {
						posiotinMin = j;
					}                                          
				}
				if (posiotinMin != i) {
					temp = array [i];
					array [i] = array [posiotinMin];
					array [posiotinMin] = temp;
				}
			}
			return array;
		}
		public static int[] BubbleSort(int[] array)
		{
			for (int i = array.Length - 1; i > 0; i--) {
				for (int j = 0; j <= i - 1; j++) {
					if (array [j] > array [j + 1]) {
						int highValue = array [j];

						array [j] = array [j + 1];
						array [j + 1] = highValue;
					}
				}
			}
			return array;
		}

	}
}

