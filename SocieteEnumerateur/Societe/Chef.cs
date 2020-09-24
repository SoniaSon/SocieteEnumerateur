using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumerateur.Societe
{ 
        class Chef : Employe
        {
            private string _service;
            public string Service   // salaire proprieté
            {

                get => _service;
                set => _service = value;
            }

            public Chef(string nom, string prenom, int age, float salaire, string service) : base(nom, prenom, age, salaire)
            {
                Nom = nom;
                Prenom = prenom;
                Age = age;
                Salaire = salaire;
                Service = service;
            }



            public override string ToString()
            {
                return "Le nom du chef est : " + Nom + Environment.NewLine + "son prénom est : " + Prenom + Environment.NewLine + "son age est :" + Age + Environment.NewLine +
                        "son salaire est de : " + Salaire + Environment.NewLine + "son service est :" + Service;
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
            }





        }
 }
