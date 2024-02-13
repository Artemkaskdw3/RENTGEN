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

            patientDG.DataContext = Helper.db.Patients.Include(x => x.Adress).ToList();




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

        private void CreatePatient_Click(object sender, RoutedEventArgs e)
        {
            new CreatePatient().ShowDialog();
        }
    }      
}