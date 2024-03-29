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

        private List<string> GetSimilarEntries(string searchText)
        {
            List<string> similarEntries = new List<string>();
            similarEntries = Helper.db.ReserchsNames.Where(x => x.NameRerserch.Contains(searchText)).Select(x => x.NameRerserch).ToList(); 
            return similarEntries;
        }


        private void ComboboxTest_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = ComboboxTest.Text;
            ComboboxTest.ItemsSource = GetSimilarEntries(searchText);
            ComboboxTest.IsDropDownOpen = true;
        }

        
    }
}
