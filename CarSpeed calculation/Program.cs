using System;
using System.Collections;
using System.Collections.Generic;
public class Dataset
{
    public List<double>distance = new List<double>();
    public List<double> time = new List<double>(); 
    public List<double>speed = new List<double>();
}
public class UserInput
{
    public void run()
    {
        Dataset obj = new Dataset();
        Console.WriteLine(" Enter the number of userinputs ");
        string inputs = Console.ReadLine();
        int count = Convert.ToInt32(inputs);
        obj .distance = new List<double>();
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(" Enter the distance ");
            string distance = Console.ReadLine();
            obj .distance.Add(Convert.ToDouble(distance));
            Console.WriteLine(" Enter the time ");
            string time = Console.ReadLine();
            obj.time.Add(Convert.ToDouble(time));
        }
        Measure measure = new Measure();
        for( int i = 0; i < count; i++)
        {
            measure.run2(obj.distance[i], obj.time[i], i);
        }
    }
}
public class Measure
{
    public void run2( double a,double b,int i)
    {
        Console.WriteLine(" output of speed " + (i+1));
        Console.WriteLine(a / b);
    }
}
public class MainMethod
{
    public static void Main(string[]args)
    {
        UserInput c = new UserInput();
        c.run();
    }
}
