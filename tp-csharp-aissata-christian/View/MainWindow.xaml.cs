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

        private void AjouterItemListbox()
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

    }
}
