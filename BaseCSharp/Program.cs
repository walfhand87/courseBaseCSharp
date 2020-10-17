using System;

namespace BaseCSharp
{
    class Program
    {
        static public void Main(string[] args)
        {

            MethodeSyntax methodeSyntax = new MethodeSyntax();


            methodeSyntax.TestParams(25.0,"sebastien",0);
            //--------------Syntaxe--------------


            //--------------General--------------

            //A chaque fin d'instrucion ne pas oublier le point virgule

            //--------------Declaration de variable-------------

            //Sans initialisation
            //1: Type ex : int, string , double 2: nom de la variable 3 : le point virgule
            int age;


            //Avec initialisation
            //1: Type ex : int, string , double 2: nom de la variable  3: le signe d'affectation '=' 4 : la valeur 5 : le point viurgule
            int ageInit = 25;


            //--------------Instruction If---------------

            //Pour ecrire une condition if --> 1: le mot clef if 2 : parenthese ouvrante 3: la consition 4: parenthese fermante 5: bloc de code ({})
            if(ageInit > 18)
            {
                Console.WriteLine("majeur");
            }


            //Pour ecrite une condition if avec une seule instruction dans le bloc de code celui ci n'est pas obligatoire
            if(ageInit > 18)
                Console.WriteLine("majeur");

            //-------------Switch-----------------

            //Pour ecrire un switch 1: le mot clef switch 2: parenthese ouvrante 3 : la variable a tester 4: ouverture bloc de code 5: fermeture bloc de code 6 le mot clef "case" 7: deux point ':' 8: les différentes instruction 9: le mot clef break suivis du POINT VIRGULE
            switch (ageInit)
            {
                case 10:
                case 9:
                    Console.WriteLine("ecole primaire");
                    break;
                case 14:
                    Console.WriteLine("ecole secondaire");
                    break;
                case 21:
                    Console.WriteLine("Unif");
                    break;
            }

            
        }

    }
}
