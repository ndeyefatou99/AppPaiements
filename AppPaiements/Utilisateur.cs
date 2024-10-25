using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPaiements
{
    internal class Utilisateur
    {
        public string Nom {  get; set; }
        public List <Paiement> Paiements { get; set; }

        public Utilisateur (string nom)
        {
            Nom = nom;
            Paiements = new List <Paiement> ();
        }
        public void AfficherInfos()
        {
            Console.WriteLine($"Utilisateur: {Nom}");

            Console.WriteLine("Liste des paiements:");
            foreach (var paie in Paiements)
            {
                paie.AfficherDetails();
                Console.WriteLine(); //espace
            }
        }
        public void AjouterPaiement(Paiement paiement)
        {
            Paiements.Add (paiement);
        }
    }
}
