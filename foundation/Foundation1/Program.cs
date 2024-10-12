using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video instance = new Video();
        List<Action> series = new List<Action>();
        series.Add(instance.video01);
        series.Add(instance.video02);
        series.Add(instance.video03);

        foreach(var i in series)
        {
            i();
        }
    }
}