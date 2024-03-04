﻿using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using RENTnew.BD;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;

namespace RENTnew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            patientDG.DataContext = Helper.db.Patients.ToList();

        }

        private void patientDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Patient a = patientDG.SelectedItem as Patient;
            MessageBox.Show(a.FirstName);
        }

        private void OpenBTN_Click(object sender, RoutedEventArgs e)
        {
            Patient a = patientDG.SelectedItem as Patient;
            MessageBox.Show(a.FirstName);
        }
        private void Filter_Click(object sender, RoutedEventArgs e)    //Метод для поиска пациентов 
        //Метод для поиска пациентов 
        {
            //Метод для поиска пациентов 
            SearchDataGrid();
        }

        private void Update_Click(object sender, RoutedEventArgs e)  //Метод для поиска пациентов 
        {
            SearchTB.Text = "";
            _maskedTextBox.Text = "";
            SearchDataGrid();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            new EditPatient(patientDG.SelectedItem as Patient).ShowDialog();
            SearchDataGrid();

        }
        private void CreatePatient_Click(object sender, RoutedEventArgs e)
        {
            new CreatePatient().ShowDialog();
        }

        private object SearchDataGrid()
        {
            if (!SearchTB.Text.IsNullOrEmpty() && _maskedTextBox.Text != "__.__.____")
            {

                DateTime a = new DateTime();
                DateTime.TryParse(_maskedTextBox.Text, out a);
                return patientDG.DataContext = Helper.db.Patients.Where(x => x.Surname.ToUpper().StartsWith(SearchTB.Text) && x.Age == a).ToList();
            }
            else if (SearchTB.Text.IsNullOrEmpty() && _maskedTextBox.Text != "__.__.____")
            {
                DateTime a = new DateTime();
                DateTime.TryParse(_maskedTextBox.Text, out a);
                return patientDG.DataContext = Helper.db.Patients.Where(x => x.Age == a).ToList();
            }
            else
            {
                return patientDG.DataContext = Helper.db.Patients.Where(x => x.Surname.ToUpper().StartsWith(SearchTB.Text)).ToList();

            }
        }
    }      
}