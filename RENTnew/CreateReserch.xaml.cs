using Microsoft.IdentityModel.Tokens;
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
        Patient _patient;
        public CreateReserch(Patient patient)
        {
            this._patient = patient;
            InitializeComponent();
        }

        //private List<string> GetSimilarEntries(string searchText, string nameCB)
        //{

        //    List<string> similarEntries = new List<string>();
        //    switch (nameCB)
        //    {
        //        case "Reserch":
        //                similarEntries = Helper.db.ReserchsNames.Where(x => x.NameRerserch.Contains(searchText)).Select(x => x.NameRerserch).ToList(); 
        //            break;
        //        case "Departament":
        //                similarEntries = Helper.db.Departaments.Where(x => x.NameDep.Contains(searchText)).Select(x => x.NameDep).ToList();
        //            break;
        //        case "HCF":
        //            similarEntries = Helper.db.HeathCfs.Where(x => x.NameHcf.Contains(searchText)).Select(x => x.NameHcf).ToList();
        //            break;
        //        case "Doctor":
        //            similarEntries = Helper.db.Doctors.Where(x => x.FirstName.Contains(searchText) || x.MiddleName.Contains(searchText) 
        //            || x.Surname.Contains(searchText)).Select(x => x.Surname +" "+ x.FirstName + " " + x.MiddleName).ToList();
        //            break;
        //        case "Assisstants":
        //            similarEntries = Helper.db.Assisstants.Where(x => x.FirstName.Contains(searchText) || x.MiddleName.Contains(searchText)
        //               || x.Surname.Contains(searchText)).Select(x => x.Surname + " " + x.FirstName + " " + x.MiddleName).ToList(); break;
        //        case "Result":
        //            similarEntries = Helper.db.Pathologies.Where(x => x.NamePathologies.Contains(searchText) || x.PartOfBody.PartOfBodyName.Contains(searchText)).Select(x => x.PartOfBody.PartOfBodyName + " "+x.NamePathologies).ToList();
        //            break;
        //    }
        //    return similarEntries;
        //}


        //private void ComboboxTest_KeyUp(object sender, KeyEventArgs e)
        //{
        //    string searchText = ((ComboBox)sender).Text;

        //    string tableName = "";

        //    if (sender == ComboboxRes)
        //    {
        //        tableName = "Reserch";
        //    }
        //    else if (sender == ComboboxDep)
        //    {
        //        tableName = "Departament";
        //    }
        //    else if (sender == ComboboxHCF)
        //    {
        //        tableName = "HCF";
        //    }
        //    else if (sender == ComboboxDoc)
        //    {
        //        tableName = "Doctor";
        //    }
        //    else if (sender == ComboboxLab)
        //    {
        //        tableName = "Assisstants";
        //    }
        //    else if (sender == ComboboxResult)
        //    {
        //        tableName = "Result";
        //    }
        //    ((ComboBox)sender).ItemsSource = GetSimilarEntries(searchText, tableName);
        //    ((ComboBox)sender).IsDropDownOpen = true;
        //}

        private void ReserchTB_TextChanged(object sender, TextChangedEventArgs e)
        {

            var research = Helper.db.ReserchsNames.FirstOrDefault(x => x.Title == ReserchTBox.Text);
            if (research != null && !research.NameReserch.IsNullOrEmpty())
            {
                ReserchTBlock.Text = research.NameReserch;

            }
            else
            {
                ReserchTBlock.Text = "Ничего не найдено";
            }
        }

        private void DepTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var dep = Helper.db.Departaments.FirstOrDefault(x => x.Title == DepTBox.Text);
            if (dep != null && !dep.NameDep.IsNullOrEmpty())
            {
                DepTBlock.Text = dep.NameDep;

            }
            else
            {
                DepTBlock.Text = "Ничего не найдено";
            }
        }

        private void HCFTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var hcf = Helper.db.HeathCfs.FirstOrDefault(x => x.Title == HCFTBox.Text);
            if (hcf != null && !hcf.NameHcf.IsNullOrEmpty())
            {
                HCFTBlock.Text = hcf.NameHcf;

            }
            else
            {
                HCFTBlock.Text = "Ничего не найдено";
            }
        }

        private void DocTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Doc = Helper.db.Doctors.FirstOrDefault(x => x.Title == DocTBox.Text);
            if (Doc != null && !Doc.FirstName.IsNullOrEmpty())
            {
                DocTBlock.Text = Doc.Surname +" "+ Doc.FirstName +" "+ Doc.MiddleName;

            }
            else
            {
                DocTBlock.Text = "Ничего не найдено";
            }
        }

        private void AssistTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Assist = Helper.db.Assisstants.FirstOrDefault(x => x.Title == AssistTBox.Text);
            if (Assist != null && !Assist.FirstName.IsNullOrEmpty())
            {
                AssistTBlock.Text = Assist.Surname + " " + Assist.FirstName + " " + Assist.MiddleName;

            }
            else
            {
                AssistTBlock.Text = "Ничего не найдено";
            }
        }

        private void ResultTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var Result = Helper.db.Pathologies.FirstOrDefault(x => x.Title == ResultTBox.Text);
            if (Result != null && !Result.NamePathologies.IsNullOrEmpty())
            {
                ResultTBlock.Text = Result.NamePathologies;

            }
            else
            {
                ResultTBlock.Text = "Ничего не найдено";
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            // True - Плановая False- Экстр в БАЗЕ ДАННЫХ!!!!!!!
            // True - Амбулатор False- Стационар в БАЗЕ ДАННЫХ!!!!!!!

            bool planOrEmerg = false;
            bool inPatOutPat= false;

            if (Planovaya.IsChecked == true)
            {
                planOrEmerg = true;
            }
            if (Ambulator.IsChecked == true)
            {
                inPatOutPat = true;
            }
            DateTime a = new DateTime();
            DateTime.TryParse(_maskedTextBox.Text, out a);
            Reserch newReserch = new Reserch
            {
                DateReserch = a,
                NameRerserchId = Helper.db.ReserchsNames.FirstOrDefault(x => x.Title == ReserchTBox.Text).Id,
                NumOfPicture = int.Parse(PictureTBox.Text),
                PlanOrEmerg = planOrEmerg,
                InpatientOutpatient = inPatOutPat,
                DepartamentId = Helper.db.Departaments.FirstOrDefault(x => x.Title == DepTBox.Text).Id,
                Hcfid = Helper.db.HeathCfs.FirstOrDefault(x => x.Title == HCFTBox.Text).Id,
                DoctorId = Helper.db.Doctors.FirstOrDefault(x => x.Title == DocTBox.Text).Id,
                PatientId = _patient.Id,
                Assisstant = Helper.db.Assisstants.FirstOrDefault(x => x.Title == AssistTBox.Text).Id,
                ResultId = Helper.db.Pathologies.FirstOrDefault(x => x.Title == ReserchTBox.Text).Id,
                Dose = decimal.Parse(_maskedTextBoxDose.Text)

            };

            Helper.db.Reserchs.Add(newReserch);

            Helper.db.SaveChanges();
            this.Close();
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
