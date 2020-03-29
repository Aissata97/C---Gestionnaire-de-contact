using System;
using System.Collections.Generic;
using System.Windows;
using Model;
using BLL;


namespace View
{
    /// <summary>
    /// Logique d'interaction pour formulaire.xaml
    /// </summary>
    public partial class formulaire : Window
    {
        public formulaire()
        {
            InitializeComponent();

        }

        private void BtnAnnuler(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void BtnAjouterContact(object sender, RoutedEventArgs e)
        {
            List<ContactEntities> listContact = BLL.ContactManager.GetContacts();

            if (txtboxNom.Text == "" | txtboxPrenom.Text == "")
            {
                lblErreur.Content = " Attention, le nom et le prénom ne peuvent pas etre vide !!";
            }
            else
            {
                BLL.ContactManager.AjouterContact(new ContactEntities(txtboxNom.Text, txtboxPrenom.Text, txtboxEmail.Text, int.Parse(txtboxTelephone.Text), txtboxAddresse.Text));
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();

            }
        }
    }
}
