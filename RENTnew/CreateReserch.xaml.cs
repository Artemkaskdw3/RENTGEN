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
using static System.Net.Mime.MediaTypeNames;

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

        private List<string> GetSimilarEntries(string searchText, string nameCB)
        {

            List<string> similarEntries = new List<string>();
            switch (nameCB)
            {
                case "Reserch":
                        similarEntries = Helper.db.ReserchsNames.Where(x => x.NameRerserch.Contains(searchText)).Select(x => x.NameRerserch).ToList(); 
                    break;
                case "Departament":
                        similarEntries = Helper.db.Departaments.Where(x => x.NameDep.Contains(searchText)).Select(x => x.NameDep).ToList();
                    break;
                case "HCF":
                    similarEntries = Helper.db.HeathCfs.Where(x => x.NameHcf.Contains(searchText)).Select(x => x.NameHcf).ToList();
                    break;
                case "Doctor":
                    similarEntries = Helper.db.Doctors.Where(x => x.FirstName.Contains(searchText) || x.MiddleName.Contains(searchText) 
                    || x.Surname.Contains(searchText)).Select(x => x.Surname +" "+ x.FirstName + " " + x.MiddleName).ToList();
                    break;
                case "Assisstants":
                    similarEntries = Helper.db.Assisstants.Where(x => x.FirstName.Contains(searchText) || x.MiddleName.Contains(searchText)
                       || x.Surname.Contains(searchText)).Select(x => x.Surname + " " + x.FirstName + " " + x.MiddleName).ToList(); break;
                case "Result":
                    similarEntries = Helper.db.Pathologies.Where(x => x.NamePathologies.Contains(searchText) || x.PartOfBody.PartOfBodyName.Contains(searchText)).Select(x => x.PartOfBody.PartOfBodyName + " "+x.NamePathologies).ToList();
                    break;
            }
            return similarEntries;
        }


        private void ComboboxTest_KeyUp(object sender, KeyEventArgs e)
        {
            string searchText = ((ComboBox)sender).Text;

            string tableName = "";

            if (sender == ComboboxRes)
            {
                tableName = "Reserch";
            }
            else if (sender == ComboboxDep)
            {
                tableName = "Departament";
            }
            else if (sender == ComboboxHCF)
            {
                tableName = "HCF";
            }
            else if (sender == ComboboxDoc)
            {
                tableName = "Doctor";
            }
            else if (sender == ComboboxLab)
            {
                tableName = "Assisstants";
            }
            else if (sender == ComboboxResult)
            {
                tableName = "Result";
            }
            ((ComboBox)sender).ItemsSource = GetSimilarEntries(searchText, tableName);
            ((ComboBox)sender).IsDropDownOpen = true;
        }

        
    }
}
