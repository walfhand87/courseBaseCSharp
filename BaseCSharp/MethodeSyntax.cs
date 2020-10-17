using System;
using System.Collections.Generic;
using System.Text;

namespace BaseCSharp
{
    class MethodeSyntax
    {
        //-------------Declarer une methode sans parametres------------

        //1 accessibilité ex : (private, public, protected) 2 : type de retour ex : (void,string,int,double) 3: parenthese ouvrante 4 : parenthese fermante

        public void Test()
        {

        }


        //-------------Declarer une methode avec parametres------------
        //1 accessibilité ex : (private, public, protected) 2 : type de retour ex : (void,string,int,double) 3: parenthese ouvrante 4 : type du parametre d'entrée ex (int,string) 5: le nom du parametre 6 : fermer parenthese 7: bloc de code

        public void TestParams(double fortunePersonelle, string prenom ,double fortuneDeMaFemme)
        {
            //De preference utiliser l'interpolation de chaine de caractere
            Console.WriteLine($"fortune perso : {fortunePersonelle}");

            //A eviter
            Console.WriteLine("Fortune perso : " + fortunePersonelle);

            Console.WriteLine($"Prenom : {prenom}");

            Console.WriteLine($"Fortune de ma femme : {fortuneDeMaFemme}");
        }
    }
}
