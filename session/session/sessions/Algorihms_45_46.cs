using System;
using System.Linq;
using System.Collections;

public class Algoritms {
	public static void Main()
	{

		foreach (int i in Algoritms.GetThreeMaxnumbers (new int[]{ 1, 2, 34, 5, 6, 67, 7 })) {
			Console.WriteLine (i);
		};
		Console.WriteLine (Algoritms.MostOccuredNumber (new int[]{ 3, 4, 2, 65, 6, 6, 6, 6, 7, 7, 7, 7 }));

	}

	public static int[] GetThreeMaxnumbers(int[] numbers )
	{
		return numbers.OrderByDescending (s => s).Take (3).ToArray ();
	}

	public static int MostOccuredNumber(int[] array)
	{
		return array.GroupBy (x => x).OrderByDescending (x => x.Count ()).First ().Key;
	}
}

