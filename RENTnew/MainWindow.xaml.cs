using Microsoft.Data.SqlClient;
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
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using System.Collections.ObjectModel;

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
            Helper.db.Patients.Load();
            SearchDataGrid();
        }

        private void patientDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (patientDG.SelectedItem is Patient selectedPatient)
            {
                new Reserachs(selectedPatient).Show();
                this.Close();
            }
        }
        private void OpenBTN_Click(object sender, RoutedEventArgs e)
        {
            if (patientDG.SelectedItem is Patient selectedPatient)
            {
                new Reserachs(selectedPatient).Show();
                this.Close();
            }
        }

        private void Filter_Click(object sender, RoutedEventArgs e)    //Метод для поиска пациентов 
        //Метод для поиска пациентов 
        {
            //Метод для поиска пациентов 
            if (SearchTB.Text.IsNullOrEmpty() && _maskedTextBox.Text == "__.__.____")
            {
                MessageBox.Show("Поля пустые");
            }
            else { 
                SearchDataGrid();
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)  //Метод для поиска пациентов 
        {
            SearchTB.Text = "";
            _maskedTextBox.Text = "";
            SearchDataGrid();

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (patientDG.SelectedItem is Patient selectedPatient)
            {
                new EditPatient(patientDG.SelectedItem as Patient).ShowDialog();
                SearchDataGrid();

            }
            else
            {
                MessageBox.Show("Не выбран пациент");
            }

        }
        private void CreatePatient_Click(object sender, RoutedEventArgs e)
        {
            new CreatePatient().ShowDialog();
            SearchDataGrid();

        }

        private object SearchDataGrid()
        {
            var patientsQuery = (IQueryable<Patient>)Helper.db.Patients;

            if (_maskedTextBox.Text != "__.__.____")
            {
                DateTime a = new DateTime();
                DateTime.TryParse(_maskedTextBox.Text, out a);

                
                if (!SearchTB.Text.IsNullOrEmpty())
                {
                    patientsQuery = patientsQuery
                        .Where(x => x.Surname.ToUpper().StartsWith(SearchTB.Text) && x.Age == a);
                }
                else
                {
                    patientsQuery = patientsQuery
                        .Where(x => x.Age == a);
                }
            }
            else
            {
                patientsQuery = patientsQuery
                    .Where(x => x.Surname.ToUpper().StartsWith(SearchTB.Text));
            }

            return patientDG.ItemsSource = patientsQuery
                .OrderByDescending(x => x.CreateDate)
                .ToList();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Patient patient = (Patient)patientDG.SelectedItem;
            if (patientDG.SelectedItem is Patient selectedRes)
            {
                var resultMB = MessageBox.Show("Вы уверены что хотите удалить", "Сообщение", MessageBoxButton.YesNo);
                if (resultMB == MessageBoxResult.Yes && !Helper.db.Reserchs.Any(x=>x.PatientId == patient.Id))
                {
                    Helper.db.Patients.Remove(selectedRes);
                    Helper.db.SaveChanges();
                    SearchDataGrid();
                    MessageBox.Show("Пациент успешно удален");

                }
                else
                {
                    

                }
            }
            else
            {
                MessageBox.Show("Исследование для удаления не выбрано или необходимо удалить все исследования у пациента!");
            }

        }

        private void RentWork_Click(object sender, RoutedEventArgs e)
        {
            new Report().ShowDialog();
        }

        private void SearchTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SearchDataGrid();
            }
        }
    }      
}