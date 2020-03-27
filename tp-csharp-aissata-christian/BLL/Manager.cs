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
            /*int compteur = 0;
            bool trouver = false;
            while (!trouver & compteur < listContacts.Count)
            {
                if (listContacts[compteur].Id == id)
                {
                    listContacts.RemoveAt(compteur);
                    trouver = true;
                }
                compteur++;
            }*/
        }

    }
}
