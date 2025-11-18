using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Dude
{
    public string name;
    public int exp = 0;

    public Dude()
    {
        this.name = "Not assigned";
    }

    public Dude(string name)
    {
        this.name = name;
    }

    public void PrintStatsInfo()
    {
        Console.WriteLine("Dude: " + this.name + " - " + this.exp + " EXP");
    }
}
