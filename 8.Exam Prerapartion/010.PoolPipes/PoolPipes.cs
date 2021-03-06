﻿using System;

class PoolPipes
{
    static void Main()
    {
        int volume = int.Parse(Console.ReadLine());
        int pipe1 = int.Parse(Console.ReadLine());
        int pipe2 = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());
        double water = pipe1 * hours + pipe2 * hours;

        if (water <= volume)
        {
            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",
                Math.Truncate(water / volume * 100),
                Math.Truncate(pipe1 * hours / water * 100),
                Math.Truncate(pipe2 * hours / water * 100));
        }
        else
        {
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hours, water - volume);
        }


        //int v = int.Parse(Console.ReadLine());
        //int p1 = int.Parse(Console.ReadLine());
        //int p2 = int.Parse(Console.ReadLine());
        //double h = double.Parse(Console.ReadLine());
        //double result = Math.Truncate(((p1 + p2) * h / v) * 100);
        //double sumPipes = p1 + p2;
        //double overflow = Math.Truncate(((p1 + p2) * h) - v);
        //if (result <= 100)
        //{
        //    Console.WriteLine($"The pool is {result}% full. Pipe 1: {(p1 / sumPipes) * 100:00}%. Pipe 2: {(p2 / sumPipes) * 100:00}%.");
        //}
        //else Console.WriteLine($"For {h} hours the pool overflows with {overflow} liters");
    }

}
