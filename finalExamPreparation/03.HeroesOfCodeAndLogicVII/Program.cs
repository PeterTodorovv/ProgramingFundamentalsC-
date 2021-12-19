using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeroesOfCodeAndLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> heroesHp = new Dictionary<string, int>();
            Dictionary<string, int> heroesMana = new Dictionary<string, int>();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int hp = int.Parse(input[1]);
                int mana = int.Parse(input[2]);

                heroesHp.Add(name, hp);
                heroesMana.Add(name, mana);
            }

            string[] commands = Console.ReadLine().Split(" - ");

            while(commands[0] != "End")
            {
                string action = commands[0];
                switch (action)
                {
                    case "CastSpell":
                        string heroName = commands[1];
                        int manaNeeded = int.Parse(commands[2]);
                        string spellName = commands[3];

                        if(manaNeeded <= heroesMana[heroName])
                        {
                            heroesMana[heroName] -= manaNeeded;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroesMana[heroName]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        heroName = commands[1];
                        int damage = int.Parse(commands[2]);
                        string attacker = commands[3];
                        heroesHp[heroName] -= damage;

                        if (heroesHp[heroName] > 0)
                        {
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroesHp[heroName]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                            heroesMana.Remove(heroName);
                            heroesHp.Remove(heroName);
                        }
                        break;
                    case "Recharge":
                        heroName = commands[1];
                        int mana = int.Parse(commands[2]);
                        heroesMana[heroName] += mana;
                        if (heroesMana[heroName] > 200)
                        {
                            mana -= heroesMana[heroName] - 200;
                            heroesMana[heroName] = 200;
                        }

                        Console.WriteLine($"{heroName} recharged for {mana} MP!");
                        break;
                    case "Heal":
                        heroName = commands[1];
                        int hp = int.Parse(commands[2]);
                        heroesHp[heroName] += hp;
                        if (heroesHp[heroName] > 100)
                        {
                            hp -= heroesHp[heroName] - 100;
                            heroesHp[heroName] = 100;
                        }

                        Console.WriteLine($"{heroName} healed for {hp} HP!");
                        break;

                }

                commands = Console.ReadLine().Split(" - ");
            }

            foreach(var hero in heroesHp.OrderByDescending(v => v.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroesMana[hero.Key]}");
            }
        }
    }
}
