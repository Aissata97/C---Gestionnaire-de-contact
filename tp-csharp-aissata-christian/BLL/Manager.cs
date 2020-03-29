using System;
using System.Collections.Generic;
using Model;

namespace BLL
{
    public class ContactManager
    {
        public static List<ContactEntities> listContacts = new List<ContactEntities>();

        public static void AjouterContact(ContactEntities contact)
        {
            listContacts.Add(contact);
            DAL.Service.AjouterLigne(listContacts);
        }

        public static List<ContactEntities> GetContacts()
        {
            return listContacts;
        }

        public static void SupprimerContact(ContactEntities contact)
        {
            listContacts.Remove(contact);
            string ligneASupprimer = contact.Nom + '/' + contact.Prenom + '/' + contact.Email + '/' + contact.Tel + '/' + contact.Addresse;
            DAL.Service.MiseAjourFichier(ligneASupprimer);
        }


        public static void ModifierContact(ContactEntities ancienContact, ContactEntities contactModifie)
        {
            SupprimerContact(ancienContact);
            AjouterContact(contactModifie);
        }


        public List<ContactEntities> RechercheContact(string value, string info)
        {
            List<ContactEntities> resultRecherche = new List<ContactEntities>();

            switch (value)
            {
                case "Nom":
                    foreach (ContactEntities contact in listContacts)
                    {

                        if (contact.Nom.Contains(info))
                        {
                            resultRecherche.Add(contact);
                        }
                    }
                    break;

                case "Prenom":
                    foreach (ContactEntities contact in listContacts)
                    {

                        if (contact.Nom.Contains(info))
                        {
                            resultRecherche.Add(contact);
                        }
                    }
                    break;
                case "Addresse":
                    foreach (ContactEntities contact in listContacts)
                    {

                        if (contact.Addresse.Contains(info))
                        {
                            resultRecherche.Add(contact);
                        }
                    }
                    break;
                case "Telephone":
                    foreach (ContactEntities contact in listContacts)
                    {

                        if (contact.Tel.ToString().Contains(info))
                        {
                            resultRecherche.Add(contact);
                        }
                    }
                    break;
            }


            return resultRecherche;
        }

    }
}
