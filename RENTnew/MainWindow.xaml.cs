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

namespace RENTnew
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int pageNumber = 1;
        private int pageSize = 20;
        public MainWindow()
        {
            InitializeComponent();
            //Метод PageDG Если принимает значение 0 - значит идет переход на след. страницу Если 1 - то переход на предыдущию, а если 2 - ничего не происходит
            PageDG(2);
        }

        private void patientDG_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (patientDG.SelectedItem == null)
            {
                return;
            }
            Patient a = patientDG.SelectedItem as Patient;
            MessageBox.Show(a.FirstName);
        }

        private void OpenBTN_Click(object sender, RoutedEventArgs e)
        {
            if (patientDG.SelectedItem == null)
            {
                return;
            }
            Patient a = patientDG.SelectedItem as Patient;
            MessageBox.Show(a.FirstName);
        }
        private void Filter_Click(object sender, RoutedEventArgs e)    //Метод для поиска пациентов 
        //Метод для поиска пациентов 
        {
            //Метод для поиска пациентов 
            SearchDataGrid();
            pageNumber = 1;
            numOfPageTB.Text = pageNumber.ToString();
        }

        private void Update_Click(object sender, RoutedEventArgs e)  //Метод для поиска пациентов 
        {
            SearchTB.Text = "";
            _maskedTextBox.Text = "";
            SearchDataGrid();
            pageNumber = 1;
            numOfPageTB.Text = pageNumber.ToString();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            new EditPatient(patientDG.SelectedItem as Patient).ShowDialog();
            PageDG(2);

        }
        private void CreatePatient_Click(object sender, RoutedEventArgs e)
        {
            new CreatePatient().ShowDialog();
            PageDG(2);
        }

        private void PageDG(int a)
        {
            if (a == 1)
            {
                pageNumber++;
            }
            else if (pageNumber >= 1 && a == 0)
            {
                pageNumber--;
            }
            patientDG.DataContext = Helper.db.Patients.OrderByDescending(x => x.CreateDate).Skip((pageNumber) * pageSize).Take(pageSize).ToList();
            numOfPageTB.Text = pageNumber.ToString();

        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            PageDG(1);
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PageDG(0);
        }
        private object SearchDataGrid()
        {
            if (!SearchTB.Text.IsNullOrEmpty() && _maskedTextBox.Text != "__.__.____")
            {

                DateTime a = new DateTime();
                DateTime.TryParse(_maskedTextBox.Text, out a);
                return patientDG.DataContext = Helper.db.Patients.Where(x => x.Surname.ToUpper().StartsWith(SearchTB.Text) && x.Age == a).Take(pageSize).OrderByDescending(x => x.CreateDate).ToList();
            }
            else if (SearchTB.Text.IsNullOrEmpty() && _maskedTextBox.Text != "__.__.____")
            {
                DateTime a = new DateTime();
                DateTime.TryParse(_maskedTextBox.Text, out a);
                return patientDG.DataContext = Helper.db.Patients.Where(x => x.Age == a).Take(pageSize).OrderByDescending(x => x.CreateDate).ToList();
            }
            else
            {
                return patientDG.DataContext = Helper.db.Patients.Where(x => x.Surname.ToUpper().StartsWith(SearchTB.Text)).Take(pageSize).OrderByDescending(x => x.CreateDate).ToList();

            }
        }

        private void patientDG_Sorting(object sender, DataGridSortingEventArgs e)
        {

        }
    }      
}