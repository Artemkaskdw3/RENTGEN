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
           
            {
                DateTime a = new DateTime();
                DateTime.TryParse(_maskedTextBox.Text, out a);
                if (!Helper.db.Patients.Any(x => x.Surname == surname.Text && x.FirstName == firstNameTB.Text && x.MiddleName == middleNameTB.Text && x.Age == a))
                {

                    bool sex = false;
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
                        CreateDate = DateTime.Now
                
                    };

                    Helper.db.Patients.Add(newPatients);

                    Helper.db.SaveChanges();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Человек с таким ФИО и датой рождения уже существует в базе данных");
                }
            }

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      

        private void surname_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = char.ToUpper(textBox.Text[0]) + textBox.Text.Substring(1).ToLower();
            }

        }

        private void surname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                // Определяем текущий элемент в фокусе
                var focusedElement = FocusManager.GetFocusedElement(this) as FrameworkElement;

                if (focusedElement == null) return; // Если фокус не на элементе управления, выходим

                switch (focusedElement.Name)
                {
                    case "surname":
                        firstNameTB.Focus();
                        break;
                    case "firstNameTB":
                        middleNameTB.Focus();
                        break;
                    case "middleNameTB":
                        _maskedTextBox.Focus();
                        break;
                    case "_maskedTextBox":
                        sexCB.Focus();
                        break;
                    case "sexCB":
                        cityTextBox.Focus();
                        break;
                    case "cityTextBox":
                        streetTextBox.Focus();
                        break;
                    case "streetTextBox":
                        houseTextBox.Focus();
                        break;
                    case "houseTextBox":
                        letterTextBox.Focus();
                        break;
                    case "letterTextBox":
                        apartmentTextBox.Focus();
                        break;
                    case "apartmentTextBox":
                        Create.Focus();
                        break;
                    default:
                        // Обработка случая, когда элемент не найден
                        break;
                }
            }
        }
    }
}
