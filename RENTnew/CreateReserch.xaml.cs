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
    /// Логика взаимодействия для CreateReserch.xaml
    /// </summary>
    public partial class CreateReserch : Window
    {
        public CreateReserch()
        {
            InitializeComponent();
            
        }

        private void ReserchLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ReserchLB.SelectedItem != null)
            {
                string selectedText = ReserchLB.SelectedItem.ToString();
                ReserchTB.Text = selectedText;
            }
        }

        private void ReserchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = ReserchTB.Text;
            // Здесь проводим поиск похожих записей на основе введенного текста и обновляем содержимое ListBox
            ReserchLB.ItemsSource = GetSimilarEntries(searchText);
        }
        private List<string> GetSimilarEntries(string searchText)
        {
            List<string> similarEntries = new List<string>();
            similarEntries = Helper.db.Reserchs.Where(x=>x.NameRerserch.NameRerserch.Contains(searchText)).ToList();
            return similarEntries;
        }
    }
}
