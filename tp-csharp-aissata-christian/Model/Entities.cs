using System;
namespace Model
{
    public class ContactEntities
    {
        public static int CptId = 0;
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int Tel { get; set; }
        public string Addresse { get; set; }

        public ContactEntities(string nom, string prenom, string email, int tel, string addresse)
        {
            Id = CptId;
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Tel = tel;
            Addresse = addresse;
            CptId++;
        }

    }
}
