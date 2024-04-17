using Microsoft.VisualBasic;
using RENTnew.BD;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Логика взаимодействия для CreatePatient.xaml
    /// </summary>
    public partial class CreatePatient : Window
    {
        public CreatePatient()
        {
            InitializeComponent();
            
        }
        static bool TextIsDate(string text)
        {
            var dateFormat = "dd.MM.yyyy";
            DateTime scheduleDate = new DateTime();

            if (DateTime.TryParseExact(text, dateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out scheduleDate))
            {
                return true;
            }
            return false;
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            bool sex = false;
            DateTime a = new DateTime();
            DateTime.TryParse(_maskedTextBox.Text, out a);
            if (sexCB.Text == "Женский")
            {
                sex = true;
            }

            Patient newPatients = new Patient {
                Surname = surname.Text,
                FirstName = firstNameTB.Text,
                MiddleName = middleNameTB.Text,
                Age = a,
                Sex = sex,
                City = cityTextBox.Text,
                Street = streetTextBox.Text,
                Building = houseTextBox.Text,
                Letter = letterTextBox.Text,
                Appartaments = apartmentTextBox.Text,
                CreateDate = DateTime.Today
                
            };

            Helper.db.Patients.Add(newPatients);

            Helper.db.SaveChanges();
            this.Close();

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
