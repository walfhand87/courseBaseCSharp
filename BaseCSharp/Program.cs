using System;
using System.Collections.Generic;

namespace BaseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[] { 5, 10, 25, 47, 98, 44, 78, 94 };
            Jours[] jours = new Jours[] {Jours.Lundi,Jours.Mardi,Jours.Mercredi};
            
            
            string[] joursUnParUn = new string[3];
            joursUnParUn[0] = "Lundi";
            joursUnParUn[1] = "Mardi";
            joursUnParUn[2] = "Mercredi";

            Array.Sort(jours);


            for (int indexDuTableau = 0; indexDuTableau < jours.Length; indexDuTableau++)
            {
                if(jours[indexDuTableau] == Jours.Dimanche || jours[indexDuTableau] == Jours.Samedi)
                {
                    Console.WriteLine("Bon week-end");
                }

                Console.WriteLine(jours[indexDuTableau]);
            }

            Console.WriteLine();
            List<int> chiffres = new List<int>();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int numberRandom = random.Next(1, 50);
                chiffres.Add(numberRandom);
            }

            foreach (int chiffre in chiffres)
            {
                Console.WriteLine(chiffre);
            }
        }
    }
}
