using System;

class Complex
{
	public static void Main (){
		Console.WriteLine (new Complex (1, 2) + new Complex (3, 5));
	}

	float real;
	float imaginary;

	public Complex(float real, float imaginary)
	{
		this.real = real;
		this.imaginary = imaginary;
	}
	public override string ToString(){
		return String.Format("({0}, {1}i)", real, imaginary);
	}

	public static bool operator == (Complex a, Complex b){
		return a.real == b.real && a.imaginary == b.imaginary;
	}
	public static bool operator != (Complex a, Complex b){
		return  !(a == b);
	}
	public override bool Equals(object obj){
		return this == (Complex) obj;
	}

	public override int GetHashCode(){
		return(real.GetHashCode() ^ imaginary.GetHashCode());
	}

	public static Complex operator+(Complex a, Complex b){
		return new Complex(a.real + b.real, a.imaginary + b.imaginary);
	}

	public static Complex operator-(Complex a, Complex b){
		return new Complex(a.real - b.real, a.imaginary - b.imaginary);
	}
		
	public static Complex operator * (Complex a, Complex b){
		return new Complex(a.real * b.real - a.imaginary * b.imaginary, a.real * b.imaginary + b.real * a.imaginary);
	}
	public static Complex operator / (Complex a, Complex b){
		if (b.real == 0.0f && b.imaginary == 0.0f)
			throw new DivideByZeroException("Can't divide by zero");

		float real = 
			(a.real * b.real + a.imaginary * b.imaginary) /
			(b.real * b.real + b.imaginary * b.imaginary);
		float imaginary = 
			(b.real * a.imaginary - a.real * b.imaginary) /
			(b.real * b.real + b.imaginary * b.imaginary);

		return new Complex(real, imaginary);
	}

}
