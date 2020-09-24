using SocieteEnumerateur.Societe;
using System;
using SocieteEnumerateur.Societe;
using SocieteEnumerateur.ListeChainee;


namespace SocieteEnumerateur
{
    class GererSocieteEnumeration
    {
        static void Main(string[] args)
        {
            var employe1 = new Employe("LAIB", "LAIB", 18, 1000);
            var employe2 = new Employe("KACED ", "Yasmine", 19, 1100);
            var employe3 = new Employe("ATHMANI ", "Darine", 20, 1200);
            var employe4 = new Employe("AYAD ", "Ishak", 21, 1300);
            var employe5 = new Employe("IGHIT ", "Yanis", 22, 1400);

            var chef1 = new Chef("BEAUCHAMP", "David", 48, 4000, "Informatique");
            var chef2 = new Chef("PRECIGOUT", "Pascal", 50, 3000, "Medecine");

            var directeur = new Directeur("JOLIE", "Femme", 45, 3000, "MEDECINE", "Medecin");


            //Inserer au debut de la liste 
            var Liste = new Liste();
            Liste.InsererDebut(employe1);
            Liste.InsererDebut(employe2);
            Liste.InsererDebut(employe3);
            Liste.InsererDebut(employe4);
            Liste.InsererDebut(employe5);
            Liste.InsererDebut(chef1);
            Liste.InsererDebut(chef2);
            Liste.InsererDebut(directeur);

            var ListeEnumeration = new ListeEnumeration(Liste);

            while (ListeEnumeration.MoveNext())
            {
                Console.WriteLine(ListeEnumeration.Current().ToString());
                Console.WriteLine(Environment.NewLine);

            }

        }
    }
}
