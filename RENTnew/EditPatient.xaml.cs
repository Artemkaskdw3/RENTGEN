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
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
