using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Paladin : Character
{
    public Weapon weapon;

    public Paladin(string name, Weapon weapon) : base(name)
    {
        this.weapon = weapon;
    }

    public override void PrintStatsInfo()
    {
        Console.WriteLine("Hail " + this.name + "! Take up your " + this.weapon.name + "!");
    }
}
