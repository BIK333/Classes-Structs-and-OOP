using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Character tests
        Character hero = new Character();
        hero.PrintStatsInfo();

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        // Struct test
        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();

        // Reference type test
        Character villain = hero;
        hero.PrintStatsInfo();
        villain.PrintStatsInfo();

        villain.name = "Sir Kane the Brave";
        hero.PrintStatsInfo();
        villain.PrintStatsInfo();

        // Value type test
        Weapon warBow = huntingBow;
        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        warBow.name = "War Bow";
        warBow.damage = 155;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        // Inheritance test
        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();

        // External file test (these classes would be in separate .cs files)
        Adventurer mike = new Adventurer("Mike");
        mike.PrintStatsInfo();

        Dude dave = new Dude("Dave");
        dave.PrintStatsInfo();
    }
}
