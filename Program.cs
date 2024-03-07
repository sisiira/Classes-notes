using System;
using System.Collections.Generic;

namespace clss
{
    class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string NomUtilisateur { get; set; }
        public string MotDePasse { get; set; }
    }

    class Eleve : Personne
    {
        public List<string> Matieres { get; set; }
        public List<int> Notes { get; set; }

        public Eleve(string nom, string prenom, string nomUtilisateur, string motDePasse)
        {
            Nom = nom;
            Prenom = prenom;
            NomUtilisateur = nomUtilisateur;
            MotDePasse = motDePasse;
            Matieres = new List<string>();
            Notes = new List<int>();
        }
    }

    class Professeur : Personne
    {
        public Professeur(string nom, string prenom, string nomUtilisateur, string motDePasse)
        {
            Nom = nom;
            Prenom = prenom;
            NomUtilisateur = nomUtilisateur;
            MotDePasse = motDePasse;
        }
    }

    class Classe
    {
        public string Nom { get; set; }
        public List<Eleve> Eleves { get; set; }

        public Classe(string nom)
        {
            Nom = nom;
            Eleves = new List<Eleve>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Classe classe = new Classe("Classe 3e Enigma");

            Eleve eleve1 = new Eleve("Meski", "Yasser", "Ymeski", "123456");
            eleve1.Matieres.Add("C#");
            eleve1.Notes.Add(90); 
            classe.Eleves.Add(eleve1);

            Eleve eleve2 = new Eleve("chaymae", "mh", "chaymae_mh", "1234567");
            eleve1.Matieres.Add("C#");
            eleve1.Notes.Add(95);
            classe.Eleves.Add(eleve2);

            Eleve eleve3 = new Eleve("Matis", "hugo", "m_hugo", "12345678");
            eleve1.Matieres.Add("C#");
            eleve1.Notes.Add(82);
            classe.Eleves.Add(eleve3);


            Professeur professeur = new Professeur("Prof", "Antoine", "prof_a", "789123");

            while (true)
            {
                Console.Write("Nom d'utilisateur : ");
                string nomUtilisateur = Console.ReadLine();
                Console.Write("Mot de passe : ");
                string motDePasse = Console.ReadLine();

                if (professeur.NomUtilisateur == nomUtilisateur && professeur.MotDePasse == motDePasse)
                {
                    Console.WriteLine($"Bienvenue, {professeur.Prenom} {professeur.Nom} (Professeur)");
                    AfficherListeEleves(classe.Eleves);
                    break;
                }
                else
                {
                    Console.WriteLine("Nom d'utilisateur ou mot de passe incorrect.");
                }
            }
        }

        static void AfficherListeEleves(List<Eleve> eleves)
        {
            Console.WriteLine("Liste des élèves et de leurs notes :");

            foreach (var eleve in eleves) // je l'ai pas su seul j'ai cherché mais j'ai compris la signification
            {
                Console.WriteLine($"{eleve.Prenom} {eleve.Nom}");
                for (int i = 0; i < eleve.Matieres.Count; i++)
                {
                    Console.WriteLine($"- Matière : {eleve.Matieres[i]}, Note : {eleve.Notes[i]}");
                }
                Console.WriteLine();
            }
        }
    }
}
