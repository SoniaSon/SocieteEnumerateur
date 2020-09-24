using System;
using System.Collections.Generic;
using System.Text;

namespace SocieteEnumerateur.ListeChainee
{
        public class Element
        {
            private object _objet;
            public object Objet
            {
                get => _objet;
                set => _objet = value;
            }

            private Element _suivant;
            public Element Suivant
            {
                get => _suivant;
                set => _suivant = value;
            }
            public Element(object objet)
            {
                Objet = objet;
            }
        }

        public class Liste
        {
            private Element _debut;
            public Element Debut
            {
                get => _debut;
                set => _debut = value;
            }

            private int _NbElement;
            public int NbElement
            {
                get => _NbElement;
                set => _NbElement = value;
            }

            public Liste()
            {
                Debut = null;
                NbElement = 0;
            }

            public void InsererDebut(object objet)
            {
                Element ajouterElem = new Element(objet);

                ajouterElem.Suivant = Debut;
                Debut = ajouterElem;
                NbElement++;
            }

            public void InsererFin(object objet)
            {
                if (Debut == null)
                {
                    Debut = new Element(objet);
                    Debut.Suivant = null;
                }
                else
                {
                    Element actuel = Debut;
                    while (actuel.Suivant != null)
                    {
                        actuel = actuel.Suivant;
                    }
                    Element ajouterElemFin = new Element(objet);
                    actuel.Suivant = ajouterElemFin;
                    NbElement++;
                }
            }

            public void Lister()
            {
                Element actuel = Debut;
                while (actuel != null)
                {
                    Console.WriteLine(actuel.Objet.ToString());
                    actuel = actuel.Suivant;
                }
            }

            public void Vider()
            {
                Element actuel = Debut;
                if (actuel != null)
                {
                    actuel = null;
                }
                Debut = null;
                NbElement = 0;
                Console.WriteLine("La liste a été vidé Youpiii =) ");
            }

            public object Get(int index)
            {
                if (index < 0)
                {
                    throw new ArgumentOutOfRangeException("Index: " + index);
                }

                if (index >= this.NbElement)
                {
                    index = this.NbElement - 1;
                }

                Element actuel = this.Debut;

                for (int i = 0; i < index; i++)
                {
                    actuel = actuel.Suivant;
                }

                return actuel.Objet;


            }

        } 
}
