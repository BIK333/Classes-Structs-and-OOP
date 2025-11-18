using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Adventurer
{
    public string name;
    public int exp = 0;

    public Adventurer()
    {
        this.name = "Not assigned";
    }

    public Adventurer(string name)
    {
        this.name = name;
    }

    public void PrintStatsInfo()
    {
        Console.WriteLine("Adventurer: " + this.name + " - " + this.exp + " EXP");
    }
}
