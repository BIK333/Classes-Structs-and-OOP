using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Character
{
    public string name;
    public int exp = 0;

    public Character()
    {
        this.name = "Not assigned";
    }

    public Character(string name)
    {
        this.name = name;
    }

    public virtual void PrintStatsInfo()
    {
        Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
    }

    // Example of encapsulation
    private void Reset()
    {
        this.name = "Not assigned";
        this.exp = 0;
    }
}
