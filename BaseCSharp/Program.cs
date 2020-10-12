using System;

namespace BaseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // les variables

            //declaration de variable
            int nombreEntier;
            double nombreReel;
            string chaine;
            bool estVrai;

            //affectation de variables
            nombreEntier = 1;
            nombreReel = 2.5;
            chaine = "Mon texte";
            estVrai = true;
            //opérations

            int resultat = nombreEntier * 2; //le resultat = 4
            resultat = 10 / 2; // le resultat = 5

            // les operateurs sont '+' '-' '/' '*' '()'



            //Les instructions conditionelles

            decimal compteEnBanque = 300;

            //L'instruction 'if'

            if (compteEnBanque >= 0)
            {
                Console.WriteLine("Votre compte est créditeur");
            }    
            if (compteEnBanque < 0)
            {
                Console.WriteLine("Votre compte est débiteur");
            }

            //L'instruction 'if else'
            if (compteEnBanque >= 0)
            {
                Console.WriteLine("Votre compte est créditeur");
            }
            else
            {
                Console.WriteLine("Votre compte est débiteur");
            }


            //les operateus de conditions

            string login = "Nicolas";
            string motDePasse = "test";

            //si login egal 'nicolas' et que motDePasse égal 'test' alors
            if (login == "Nicolas" && motDePasse == "test")
                Console.WriteLine("Bienvenue Nicolas");
            else
                Console.WriteLine("Login incorrect");



            string civilite = "Mme";

            //si civilite egal 'Mme' ou que civilite = 'Mlle' alors
            if (civilite == "Mme" || civilite == "Mlle")
                Console.WriteLine("Vous êtes une femme");
            else
                Console.WriteLine("Vous êtes un homme");


            //negation --> si c'est pas vrai alors c'est faux
            if (!estVrai)
                Console.WriteLine("C'est faux !");
            else
                Console.WriteLine("C'est vrai !");


            //l'instruction switch

            //If classique
            if (civilite == "M.")
                Console.WriteLine("Bonjour monsieur");
            if (civilite == "Mme")
                Console.WriteLine("Bonjour madame");
            if (civilite == "Mlle")
                Console.WriteLine("Bonjour mademoiselle");

            //equivalent en switch
            switch (civilite)
            {
                case "M.":
                    Console.WriteLine("Bonjour monsieur");
                    break;
                case "Mme":
                    Console.WriteLine("Bonjour madame");
                    break;
                case "Mlle":
                    Console.WriteLine("Bonjour mademoiselle");
                    break;
            }

            // enchainer plusieur cas

            //maniere avec if
            string mois = "Janvier";
            if (mois == "Mars" || mois == "Avril" || mois == "Mai")
                Console.WriteLine("C'est le printemps");
            if (mois == "Juin" || mois == "Juillet" || mois == "Aout")
                Console.WriteLine("C'est l'été");
            if (mois == "Septembre" || mois == "Octobre" || mois == "Novembre")
                Console.WriteLine("C'est l'automne");
            if (mois == "Decembre" || mois == "Janvier" || mois == "Février")
                Console.WriteLine("C'est l'hiver");



            //avec switch

            switch (mois)
            {
                case "Mars":
                case "Avril":
                case "Mai":
                    Console.WriteLine("C'est le printemps");
                    break;
                case "Juin":
                case "Juillet":
                case "Aout":
                    Console.WriteLine("C'est l'été");
                    break;
                case "Septembre":
                case "Octobre":
                case "Novembre":
                    Console.WriteLine("C'est l'automne");
                    break;
                case "Décembre":
                case "Janvier":
                case "Février":
                    Console.WriteLine("C'est l'hiver");
                    break;
            }
        }

    }
}
