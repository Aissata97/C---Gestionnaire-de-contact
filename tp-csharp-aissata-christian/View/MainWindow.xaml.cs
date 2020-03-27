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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

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
                listBox.Items.Add(contact.Prenom + " " + contact.Nom + " " + contact.Email + " " + contact.Tel + " " + contact.Addresse);
            }
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            //string text = listBox.Items.Con;
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            //BLL.ContactManager.SupprimerContact(listBox.SelectedIndex);
        }
    }
}
