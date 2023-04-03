using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static string DemanderNom(int personalName)
        {
            string name = "";

            while (name == "")
            {
                Console.Write($@"Bonjour Personne ""numéro {personalName}"", quel est votre nom ? ");
                name = Console.ReadLine();
                Console.WriteLine();

                name = name.Trim();

                if (name == "")
                {
                    Console.WriteLine("Erreur : Le nom que vous avez rentré est invalide, veuillez saisir un nom valide\n");
                }
            }
            return name;
        }

        static int DemanderAge(string name)
        {
            int age = 0;

            while (age == 0)
            {
                Console.WriteLine();
                Console.Write("Quel âge avez-vous " + name + " ? ");
                string newage = Console.ReadLine();

                try
                {
                    age = int.Parse(newage);

                    if (age < 1)
                    {
                        Console.WriteLine("Erreur la valeur que vous avez rentrée n'est pas bonne, essayez encore");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur la valeur que vous avez rentrée n'est pas bonne, essayez encore");
                }
            }
            return age;
        }

        static void Main(string[] args)
        {
            string name1 = DemanderNom(1);
            string name2 = DemanderNom(2);

            Console.WriteLine($@"Bonjour ""{name1}"" et ""{name2}"", Bienvenue !");

            int age1 = DemanderAge(name1);
            int age2 = DemanderAge(name2);

            Console.WriteLine();
            Console.WriteLine($"{name1} vous avez donc {age1} ans. Parfait !");
            Console.WriteLine("Cela veut dire que vous aurez bientôt " + (age1 + 1) + " ans !");

            Console.WriteLine();
            Console.WriteLine($"{name2} vous avez donc {age2} ans. Parfait !");
            Console.WriteLine("Cela veut dire que vous aurez bientôt " + (age2 + 1) + " ans !");
        }
    }
}