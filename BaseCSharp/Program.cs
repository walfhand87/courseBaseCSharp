using System;

namespace BaseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bonjour("autre chose");
        }

        static string ConjugaisonSwitch(string genre)
        {
            switch (genre)
            {
                case "Homme":
                    return "é";
                case "Femme":
                    return "ée";
                default:
                    return "";
            }
        }

        static void Bonjour(string prenom)
        {
            if(prenom == "inconnu")
            {
                return;
            }

            Console.WriteLine(prenom);
        }

        static string ConjugaisonIf(string genre)
        {
            if(!string.IsNullOrEmpty(genre))
            {
                if (genre == "Homme")
                {
                    return "é";
                }
                return "ée";
            }

            return "";
        }

        static double LongueurHypotenuseSyntaxUneSeuleInstruction(double a, double b) => Math.Sqrt(a* a + b* b);

        static double LongueurHypotenuseSyntaxBlocDeCode(double a, double b) 
        {
            return Math.Sqrt(a * a + b * b);
        }

        static void DireBonjour(string prenom, int age)
        {
            Console.WriteLine("Bonjour " + prenom);
            Console.WriteLine("Vous avez " + age + " ans");
        }

        static void AfficheBienvenue(string texte)
        {
            Console.WriteLine(texte);
        }
    }
}
