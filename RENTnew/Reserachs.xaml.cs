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
using System.Windows.Media.TextFormatting;
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
         

            reserchDT.ItemsSource = Helper.db.Reserchs.Include(x => x.NameRerserch).Include(x => x.Result).Include(x => x.Hcf).Include(x => x.Departament).Where(x => x.PatientId == patient.Id).ToList(); ;

        }

        private void createResBTN_Click(object sender, RoutedEventArgs e)
        {
            new CreateReserch(_patient).ShowDialog();
            reserchDT.ItemsSource = Helper.db.Reserchs.Include(x => x.NameRerserch).Include(x => x.Result).Include(x => x.Hcf).Include(x => x.Departament).Where(x => x.PatientId == _patient.Id).ToList();

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (reserchDT.SelectedItem is Reserch selectedRes)
            {
                var resultMB = MessageBox.Show("Вы уверены что хотите удалить","Сообщение", MessageBoxButton.YesNo);
                if (resultMB == MessageBoxResult.Yes)
                {
                    Helper.db.Reserchs.Remove(selectedRes);
                    Helper.db.SaveChanges();
                    MessageBox.Show("Исследование успешно удалено");
                    reserchDT.ItemsSource = Helper.db.Reserchs.Include(x => x.NameRerserch).Include(x => x.Result).Include(x => x.Hcf).Include(x => x.Departament).Where(x => x.PatientId == _patient.Id).ToList();
                }
            }
            else {
                MessageBox.Show("Исследование для удаления не выбрано");
            }


          
        }

        private void reserchDT_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (reserchDT.SelectedItem is Reserch selectedReserch)
            {
                new EditReserch(selectedReserch).ShowDialog();
            }
            reserchDT.ItemsSource = Helper.db.Reserchs.Include(x => x.NameRerserch).Include(x => x.Result).Include(x => x.Hcf).Include(x => x.Departament).Where(x => x.PatientId == _patient.Id).ToList();

        }
    }
}
