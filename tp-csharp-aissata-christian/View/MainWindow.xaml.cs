using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Model;

namespace View
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ContactEntities contactSelectionne { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            AjouterItemListbox();
        }

        //Ouvrir le formulaire de contact
        private void BtnFormulaireContact(object sender, RoutedEventArgs e)
        {
            new formulaire().Show();
            DAL.Service.LireData();
            this.Close();
        }

        public void AjouterItemListbox()
        {
            List<ContactEntities> listContact = DAL.Service.LireData();
            foreach (ContactEntities contact in listContact)
            {
                listBox.Items.Add(contact);
            }
        }

        //**
        private void SupprimerItemListox(ContactEntities contact)
        {
            listBox.Items.Remove(contact);
            BLL.ContactManager.SupprimerContact(contact);
        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            SupprimerItemListox((ContactEntities)listBox.SelectedItem);
        }

        //Ouvre le formulaire permettant de faire la modification
        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            contactSelectionne = (ContactEntities)listBox.SelectedItem;
            FormulaireModifier formulaire = new FormulaireModifier();
            formulaire.txtboxNom.Text = contactSelectionne.Nom;
            formulaire.txtboxPrenom.Text = contactSelectionne.Prenom;
            formulaire.txtboxAddresse.Text = contactSelectionne.Addresse;
            formulaire.txtboxTelephone.Text = contactSelectionne.Tel.ToString();
            formulaire.txtboxEmail.Text = contactSelectionne.Email;

            formulaire.Show();
            Close();
        }

    }
}
