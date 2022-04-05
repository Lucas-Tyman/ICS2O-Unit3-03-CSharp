// Created by: Lucas Tyman
// Created on: Mar 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double radiusSphere;
        double volume;
        

        // input
        Console.WriteLine("This program finds the volume of a sphere. ");
        Console.WriteLine("");
        Console.WriteLine("the formula is: v = 4/3 x π x r³");
        Console.WriteLine("");
        Console.WriteLine("please enter the measurements (cm)");
        Console.WriteLine("");

        Console.Write("Input the measurement for the radius :");
        radiusSphere = Convert.ToDouble(Console.ReadLine());

        // process
        volume = 4.0 / 3.0 * Math.PI * Math.Pow(radiusSphere, 3);

        // output
        Console.WriteLine("");
        Console.WriteLine("The volume of the sphere is, " + volume.ToString("0.00") + " cm");
        Console.WriteLine("\nDone.");
    }
}