// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Collections;
using System.Collections.Generic;

public class Dataset
{
	public List<double> distance = new List<double>();
	public List<double> time = new List<double>();
	public List<double> speed = new List<double>();
	public int value;
}

public class UserInput
{
	public void run()
	{
		Dataset obj = new Dataset();
		Console.WriteLine("Enter Number of Inputs");
		string input = Console.ReadLine();
		int count = Convert.ToInt32(input);
		obj.value = count;
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
			double temp = measure.run2(obj.distance[i], obj.time[i]);
			obj.speed.Add(temp);
		}
	}
}

public class Measure
{
	public double run2(double a, double b)
	{
		return a / b;
	}
}

public class show_result
{
	public void run3()
	{
		Dataset obj = new Dataset();
		for (int i = 0; i < obj.value; i++)
		{
			Console.WriteLine(obj.speed[i]);
		}
	}
}

public class first
{
	public static void Main(string[] args)
	{
		UserInput c = new UserInput();
		show_result obj = new show_result();
		c.run();
		obj.run3();
	}
}
