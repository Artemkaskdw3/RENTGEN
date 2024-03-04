using RENTnew.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RENTnew
{
    /// <summary>
    /// Логика взаимодействия для EditPatient.xaml
    /// </summary>
    public partial class EditPatient : Window
    {
        Patient _patient;
        public EditPatient(Patient patient)
        {
            InitializeComponent();
            this._patient = patient;
            surname.Text = patient.Surname;
            firstNameTB.Text = patient.FirstName;
            middleNameTB.Text = patient.MiddleName;
            _maskedTextBox.Text = patient.Age.ToShortDateString();
            sexCB.SelectedIndex = 1;
            cityTextBox.Text = patient.Adress.City;
            streetTextBox.Text = patient.Adress.Street;
            houseTextBox.Text = patient.Adress.Building;
            letterTextBox.Text = patient.Adress.Letter;
            apartmentTextBox.Text = patient.Adress.Appartaments;
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            DateTime a = new DateTime();
            DateTime.TryParse(_maskedTextBox.Text, out a);
            bool SelectedSex = false;
            if (sexCB.SelectedIndex == 1)
            {
                SelectedSex = true;
            }
            _patient.Surname = surname.Text;
            _patient.FirstName = firstNameTB.Text;
            _patient.MiddleName = middleNameTB.Text;
            _patient.Age = a;
            _patient.Sex = SelectedSex;
            _patient.Adress.City = cityTextBox.Text;
            _patient.Adress.Street = streetTextBox.Text;
            _patient.Adress.Building = houseTextBox.Text;
            _patient.Adress.Letter = letterTextBox.Text;
            _patient.Adress.Appartaments = apartmentTextBox.Text;
        }
    }
}
