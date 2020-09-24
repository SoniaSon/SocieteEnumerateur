using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumerateur.Societe
{
        class Personne
        {
            private string _nom;
            public string Nom    // proprieté du nom
            {
                get => _nom;
                set => _nom = value;

            }
            private string _prenom;
            public string Prenom    // proprieté du prenom
            {
                get => _prenom;
                set => _prenom = value;

            }
            private int _age;
            public int Age   // age proprieté
            {
                get => _age;
                set => _age = value;
            }
            public Personne(string Nom, string Prenom)
            {
                Nom = _nom;
                Prenom = _prenom;
            }
            public Personne(string Nom, string Prenom, int Age)
            {
                Nom = _nom;
                Prenom = _prenom;
                Age = _age;
            }
            public override string ToString() => "Le est de la personne est : " + Nom + " son prénom est  " + Prenom + "son age est : " + Age;
            public void Afficher()
            {
                Console.WriteLine("Nom :" + Nom);
                Console.WriteLine("Prenom :" + Prenom);
                if (Age != 0)
                {
                    Console.WriteLine("Age : " + Age);
                }
                else
                {
                    Console.WriteLine("Erreur, l'age n'existe pas");
                }
            }
        }

}
