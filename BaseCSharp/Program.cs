using System;

namespace BaseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------Les boucles --------------
            //for
            //foreach
            //while
            //do while

            //--------------boucle for ---------------

            //--------------Syntaxe ----------------

            //1: mot clef for 2: parenthese ouvrante 3: variable  + initialisation ex: int compteur = 1; 4 : condition de sortie a lire 'tant que --> alors' ex (compteur < 50) 5: incrementation de la variable ex : compteur ++

            int index = 1;

            for (int compteur = 1; compteur <= 80; compteur += 1)
            {
                Console.WriteLine($"{index} Bonjour c#");
                //il est possible de rajouter des condition à l'incrementation de la variable qui se trouve dans la condition ex : compteur
                if(index > 30)
                {
                    compteur += 5;
                }

                index += 1;
            }


            int[] ages = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[,] agesMatrix = new int[,] { { 1,2},{ 3,4},{ 5,6}};


            //boucle for imbriquée
            for (int x = 0; x < agesMatrix.GetLength(0); x++)
            {
                for (int y = 0; y < agesMatrix.GetLength(1); y++)
                {
                    Console.WriteLine(agesMatrix[x, y]);
                }
            }


            Console.WriteLine(ages.Length);
            //parcours du tableau grace à l'index
            for (int indexDuTableau = ages.Length -1; indexDuTableau > -1; indexDuTableau--)
            {
                Console.WriteLine(ages[indexDuTableau]);
            }

            //boucle foreach ne sert qu'a parcourir des listes ou des tableau
            //Attention ne pas modifier la liste en cours de parcours
            foreach (int age in ages)
            {
                Console.WriteLine(age);
            }

            int i = 0;
            while(i < 50)
            {
                Console.WriteLine(i++);

                if(i == 32)
                {
                    break;
                }
            }


            int i2 = 60;
            do
            {
                Console.WriteLine(i2++);
            }
            while (i2 < 50);


            for (int test = 0; test < 20; test++)
            {
                if(test % 2 != 0)
                {
                    Console.WriteLine(test);
                }

                //A NE JAMAIS FAIRE !!!
                //if(test % 2 == 0)
                //{
                //    continue;
                //}

                //Console.WriteLine(test);
            }

        }
    }
}
