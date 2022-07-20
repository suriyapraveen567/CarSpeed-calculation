// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;

public class Dataset
{
	public List<double> distance = new List<double>();
	public List<double> time = new List<double>();
}

public class UserInput
{
	public void run()
	{
		Dataset obj = new Dataset();
		Console.WriteLine("Enter Number of Inputs");
		string input = Console.ReadLine();
		int count = Convert.ToInt32(input);
		obj.distance = new List<double>(count);
		for (int i = 0; i < count; i++)
		{
			Console.WriteLine("Enter the distance");
			string distance = Console.ReadLine();
			obj.distance.Add(Convert.ToDouble(distance));
			Console.WriteLine("Enter the time");
			string time = Console.ReadLine();
			obj.time.Add(Convert.ToDouble(time));
		}
		Measure measure = new Measure();
		for (int i = 0; i < count; i++)
		{
			measure.run2(obj.distance[i], obj.time[i], i);
		}
	}
}

public class Measure
{
	public void run2(double a, double b, int i)
	{
		Console.WriteLine("Output of user: " + (i + 1));
		Console.WriteLine(a / b);
	}
}

public class first
{
	public static void Main(string[] args)
	{
		UserInput c = new UserInput();
		c.run();
	}
}