using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumerateur.Societe
{
        class Employe : Personne
        {
            private float _salaire;
            public float Salaire   // salaire proprieté
            {

                get => _salaire;
                set => _salaire = value;
            }

            public Employe(string nom, string prenom, int age, float salaire) : base(nom, prenom, age)
            {
                Nom = nom;
                Prenom = prenom;
                Age = age;
                Salaire = salaire;
            }



            public override string ToString()
            {
                return "Le nom de l'empolyé est : " + Nom + Environment.NewLine + "Le prénom est : " + Prenom + Environment.NewLine +
                        "son age est :" + Age + Environment.NewLine + "son salaire est de : " + Salaire;
            }

            public void Afficher()
            {
                Console.WriteLine("Nom : " + Nom);
                Console.WriteLine("Prenom : " + Prenom);
                if (Age != 0)
                {
                    Console.WriteLine("Age : " + Age);
                }
                Console.WriteLine("Salaire : " + Salaire);
            }

        }
}
