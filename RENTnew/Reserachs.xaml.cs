using Microsoft.EntityFrameworkCore;
using RENTnew.BD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для Reserachs.xaml
    /// </summary>
    public partial class Reserachs : Window
    {
        Patient _patient;
        public Reserachs(Patient patient)
        {
            InitializeComponent();
            this._patient = patient;
            reserchDT.ItemsSource = Helper.db.Reserchs.Include(x => x.NameRerserch).Include(x =>x.Result).Where(x => x.PatientId == patient.Id).ToList();

        }

        private void createResBTN_Click(object sender, RoutedEventArgs e)
        {
            new CreateReserch(_patient).ShowDialog();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
