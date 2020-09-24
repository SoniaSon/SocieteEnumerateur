using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumerateur.Societe
{
        class Directeur : Chef
        {
            private string _societe;
            public string Societe   // salaire proprieté
            {

                get => _societe;
                set => _societe = value;
            }

            public Directeur(string nom, string prenom, int age, float salaire, string service, string societe) : base(nom, prenom, age, salaire, service)
            {
                Nom = nom;
                Prenom = prenom;
                Age = age;
                Salaire = salaire;
                Service = service;
                Societe = societe;
            }



            public override string ToString()
            {
                return "Le nom du chef est : " + Nom + Environment.NewLine + "son prénom est : " + Prenom + Environment.NewLine +
                        "son age est :" + Age + Environment.NewLine + "son salaire est de : " + Salaire + Environment.NewLine +
                        "son service est :" + Service + Environment.NewLine + "sa société est :" + Societe;
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
                Console.WriteLine("Service :" + Service);
                Console.WriteLine("Société : " + Societe);
            }





        }
}
