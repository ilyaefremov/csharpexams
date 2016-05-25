using System;

public class BMI
{

	public static void Main (){
		int weight = 60;
		int height = 180;

		double bmi = BMI.EvalBMI (height, weight);

		Console.WriteLine (bmi, BMI.DescribeBMI (bmi));

	}

	public static double EvalBMI(double height, double weigh)
	{
		return (weigh / Math.Pow(height, 2)); 	
	}
	public static string DescribeBMI(double bmi){
		if (bmi < 16.5)
			return "těžká podvýživa";
		if (bmi < 18.5)
			return "podváha";
		if (bmi < 25)
			return "nadváha";
		if (bmi < 30)
			return "optimální váha";
		if (bmi < 35)
			return "obezita prvního stupně";
		if (bmi < 40)
			return "obezita druhého stupně";

		return "obezita třetího stupně ";
	}

}

