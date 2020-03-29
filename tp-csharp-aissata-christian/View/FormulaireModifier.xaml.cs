using System;
using System.Collections.Generic;
using System.Windows;
using Model;

namespace View
{
    /// <summary>
    /// Logique d'interaction pour FormulaireModifier.xaml
    /// </summary>
    public partial class FormulaireModifier : Window
    {
        MainWindow mainWindow = new MainWindow();
        public FormulaireModifier()
        {
            InitializeComponent();
        }

        private void BtnAnnuler_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            Close();
        }

        private void BtnModifier_Click(object sender, RoutedEventArgs e)
        {
            ContactEntities nouveauContact = new ContactEntities(txtboxNom.Text, txtboxPrenom.Text, txtboxEmail.Text, int.Parse(txtboxTelephone.Text), txtboxAddresse.Text);
            ContactEntities ancienContact = MainWindow.contactSelectionne;   
            BLL.ContactManager.ModifierContact(ancienContact, nouveauContact);
            mainWindow.listBox.Items.Clear();
            mainWindow.AjouterItemListbox();
            mainWindow.Show();
            Close();
        }
    }
}
