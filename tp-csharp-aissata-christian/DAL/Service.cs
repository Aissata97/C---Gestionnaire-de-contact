using System;
using System.IO;
using Model;
using System.Collections.Generic;

namespace DAL
{
    public class Service
    {
        //private const string fileName = "data-contact.txt";
        private const string path = "../../data-contact.txt";

        public static void LireFichier()
        {
            File.ReadAllLines(path);
        }

        public static List<ContactEntities> LireData()
        {
            List<ContactEntities> contacts = new List<ContactEntities>();
            string[] lignes = File.ReadAllLines(path);
            string[] tabLineElement;
            foreach (string ligne in lignes)
            {
                tabLineElement = ligne.Split('/');
                contacts.Add(new ContactEntities(tabLineElement[0], tabLineElement[1], tabLineElement[2], int.Parse(tabLineElement[3]), tabLineElement[4]));
            }
            return contacts;
        }

        //Sauvegarde le contact dans le fichier texte
        public static void AjouterLigne(List<ContactEntities> listContacts)
        {
            foreach (ContactEntities contact in listContacts)
            {
                string ligne = contact.Nom + '/' + contact.Prenom + '/' + contact.Email + '/' + contact.Tel + '/' + contact.Addresse + '\n';
                File.AppendAllText(path, ligne);
            }
        }
    }
}
