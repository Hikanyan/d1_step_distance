using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine().Split(' ');
        var d = int.Parse(line[0]);
        var s = int.Parse(line[1]);
        
        var ans = 0;

        ans = (d * 100000) / s;
        Console.WriteLine(ans);
        if (ans >= 10000)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}