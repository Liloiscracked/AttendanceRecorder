// See https://aka.ms/new-console-template for more information
#pragma warning disable IDE0005 // Using directive is unnecessary.
using System;
#pragma warning restore IDE0005 // Using directive is unnecessary.
using Attendance_System;

public class Program
{
    static public void Main(string[] args)
    {
        HashSet<Employee> s = new HashSet<Employee>();
        s.Add(new Employee(12));
        s.Add(new Employee(12));
        s.Add(new Employee(123));
        s.Add(new Employee(12));
        s.Add(new Employee(125));
        s.ElementAt(0).AddAtt("1", "2", "3");


        Console.WriteLine(new TimeSpan().Hours);
    }
}

