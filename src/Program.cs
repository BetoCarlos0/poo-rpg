// See https://aka.ms/new-console-template for more information
using System;
using poo_rpg.src.Entities;

namespace poo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 10, "Guerreiro");
            Wizzard wizzard = new Wizzard("maguinha", 23, "Mage");
            
            Console.WriteLine(wizzard.Attack(20));
            Console.WriteLine(arus.Attack());
        }
    }
}