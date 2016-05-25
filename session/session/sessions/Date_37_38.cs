using System;
using System.Collections.Generic;
public class MyDate 
{
	public static void Main(){

		MyDate.DateDescription desc = new MyDate.DateDescription {
			year = 1995,
			month = 8,
			day = 5
		};
			
		Console.WriteLine (new MyDate (desc).AddDays (500).getDayOfWeek ());
	}
	DateTime _date;
	public MyDate (DateDescription description){
		this._date = new DateTime( description.year, description.month, description.day );
	}
	public MyDate (int year, int month, int day){
		this._date = new DateTime(year, month, day);
	}
	public MyDate (DateTime date){
		this._date = date;
	}
	public MyDate AddDays (int days){
		return new MyDate (this._date.AddDays(days));
	}
	static Dictionary <DayOfWeek, string> hash = new Dictionary<DayOfWeek,string> {
		{DayOfWeek.Monday, "monday"},
		{DayOfWeek.Tuesday, "tuesday"},
		{DayOfWeek.Wednesday, "wednesday"},
		{DayOfWeek.Thursday, "thursday"},
		{DayOfWeek.Friday, "friday"},
		{DayOfWeek.Saturday, "saturday"},
		{DayOfWeek.Sunday, "sunday"}
	};

	public string getDayOfWeek (){
		return hash [this._date.DayOfWeek];
	}

	public override string ToString (){
		return string.Format ("{0}.{1}.{2}", this._date.Day, this._date.Month, this._date.Year );
	}

	public struct DateDescription {
		public int day;
		public int month;
		public int year;
	}
}

