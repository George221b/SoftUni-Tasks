﻿using System;

public class Startup
{
    public static void Main()
    {
        var spy = new Spy();
        string result = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(result);
    }
}