using Microsoft.IdentityModel.Tokens;
using RENTnew.BD;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;
using static System.Net.Mime.MediaTypeNames;

namespace RENTnew
{
    /// <summary>
    /// Логика взаимодействия для CreateReserch.xaml
    /// </summary>
    public partial class CreateReserch : Window
    {
        Patient _patient;
        public string dateReserchSave;
        public string NameReserchSave;
        public string numOfPictureSave;
        public string DoctorSave;
        public string AssistentSave;
        public string DoseSave;




        public CreateReserch(Patient patient)
        {
            InitializeComponent();
            var docTitle = Helper.db.Reserchs.OrderBy(x => x.Id).Last().DoctorId;
            var assistTitle = Helper.db.Reserchs.OrderBy(x => x.Id).Last().Assisstant;
            var reserchTitle = Helper.db.Reserchs.OrderBy(x => x.Id).Last().NameRerserchId;
            var patologiya = Helper.db.Reserchs.OrderBy(x => x.Id).Last().ResultId;

            DateTime a = new DateTime();
            DateTime.TryParse(Helper.db.Reserchs.OrderBy(x => x.Id).Last().DateReserch.ToString(), out a);

            this._patient = patient;
            _maskedTextBox.Text = a.ToShortDateString();
            ReserchTBox.Text = Helper.db.ReserchsNames.FirstOrDefault(x => x.Id == reserchTitle).Title;
            PictureTBox.Text = Helper.db.Reserchs.OrderBy(x => x.Id).Last().NumOfPicture.ToString();
            DocTBox.Text = Helper.db.Doctors.FirstOrDefault(x => x.Id == docTitle).Title;
            AssistTBox.Text = Helper.db.Assisstants.FirstOrDefault(x => x.Id == assistTitle).Title;
            PartOfBodyTBox.Text = Helper.db.Pathologies.FirstOrDefault(x => x.Id == patologiya).PartOfBodyId.ToString();
            ResultTBox.Text = Helper.db.Pathologies.FirstOrDefault(x => x.Id == patologiya).Title;
            _maskedTextBoxDose.Text = Helper.db.Reserchs.OrderBy(x => x.Id).Last().Dose.ToString();
            Planovaya.IsChecked = true;
            Ambulator.IsChecked = true;

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
                DocTBlock.Text = Doc.Surname + " " + Doc.FirstName + " " + Doc.MiddleName;

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

        private void PartOfBodyTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int NumOrNo;
            int.TryParse(PartOfBodyTBox.Text, out NumOrNo);
            var Result = Helper.db.PartOfBodies.FirstOrDefault(x => x.Id == NumOrNo);
            if (Result != null && !Result.PartOfBodyName.IsNullOrEmpty() && NumOrNo == Result.Id)
            {
                PartOfBodyTBlock.Text = Result.PartOfBodyName;
                ResultTBox.Clear();
            }
            else
            {
                PartOfBodyTBlock.Text = "Ничего не найдено";
            }
        }
        private void ResultTBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int NumOrNo;
            int.TryParse(PartOfBodyTBox.Text, out NumOrNo);
            var Result = Helper.db.Pathologies.FirstOrDefault(x => x.Title == ResultTBox.Text && x.PartOfBodyId == NumOrNo);
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
            // False - Плановая True- Экстр в БАЗЕ ДАННЫХ!!!!!!!
            // True - Амбулатор False- Стационар в БАЗЕ ДАННЫХ!!!!!!!

            decimal treyParcDose;
            decimal.TryParse(_maskedTextBoxDose.Text,out treyParcDose);

            if (!ReserchTBlock.Text.IsNullOrEmpty() && !DocTBlock.Text.IsNullOrEmpty()
                && !AssistTBlock.Text.IsNullOrEmpty()
                && !ReserchTBlock.Text.IsNullOrEmpty() && !_maskedTextBoxDose.Text.IsNullOrEmpty()
                && !PartOfBodyTBox.Text.IsNullOrEmpty()
                && !ResultTBox.Text.IsNullOrEmpty()
                && ResultTBlock.Text != "Ничего не найдено"
                && PartOfBodyTBlock.Text != "Ничего не найдено" && decimal.TryParse(_maskedTextBoxDose.Text, out treyParcDose)

                )
            {

            DateTime a = new DateTime();
            DateTime.TryParse(_maskedTextBox.Text, out a);
                Reserch newReserch = new Reserch
                {
                    DateReserch = a,
                    NameRerserchId = Helper.db.ReserchsNames.FirstOrDefault(x => x.Title == ReserchTBox.Text).Id,
                    NumOfPicture = int.Parse(PictureTBox.Text),
                    PlanOrEmerg = Planovaya.IsChecked.Value ? false: true,
                    InpatientOutpatient = Planovaya.IsChecked.Value ? Ambulator.IsChecked.Value : null ,
                    DepartamentId = Helper.db.Departaments.Any(x => x.Title == DepTBox.Text) ? Helper.db.Departaments.FirstOrDefault(x => x.Title == DepTBox.Text).Id : null,
                    Hcfid = Helper.db.HeathCfs.Any(x => x.Title == HCFTBox.Text) ? Helper.db.HeathCfs.FirstOrDefault(x => x.Title == HCFTBox.Text).Id : null,
                    DoctorId = Helper.db.Doctors.FirstOrDefault(x => x.Title == DocTBox.Text).Id,
                    PatientId = _patient.Id,
                    Assisstant = Helper.db.Assisstants.FirstOrDefault(x => x.Title == AssistTBox.Text).Id,
                    ResultId = Helper.db.Pathologies.FirstOrDefault(x => x.Title == ResultTBox.Text && x.PartOfBodyId == int.Parse(PartOfBodyTBox.Text)).Id,
                    Dose = treyParcDose

                };

            

                Helper.db.Reserchs.Add(newReserch);

                Helper.db.SaveChanges();

                this.Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Не все поля заполнены!");
            }
        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Ambulator_Checked(object sender, RoutedEventArgs e)
        {
            
                HCFTBox.IsEnabled = true;
                DepTBox.IsEnabled = false;
                  DepTBox.Clear();


        }

        private void Stacionar_Checked(object sender, RoutedEventArgs e)
        {
            HCFTBox.IsEnabled = false;
            DepTBox.IsEnabled = true;
            HCFTBox.Clear();


        }

        private void Planovaya_Checked(object sender, RoutedEventArgs e)
        {
            HCFTBox.IsEnabled = true;
            Ambulator.IsEnabled = true;
            Stacionar.IsEnabled = true;
        }

        private void Emergency_Checked(object sender, RoutedEventArgs e)
        {
            HCFTBox.IsEnabled = false;
            DepTBox.IsEnabled = true;
            Ambulator.IsEnabled = false;
            Stacionar.IsEnabled = false;
            Stacionar.IsChecked = false;
            Ambulator.IsChecked = false;
            HCFTBox.Clear();


        }

        private void _maskedTextBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter)
            {
                // Определяем текущий элемент в фокусе
                var focusedElement = FocusManager.GetFocusedElement(this) as FrameworkElement;

                if (focusedElement == null) return; // Если фокус не на элементе управления, выходим

                switch (focusedElement.Name)
                {
                    case "_maskedTextBox":
                        ReserchTBox.Focus();
                        break;
                    case "ReserchTBox":
                        PictureTBox.Focus();
                        break;
                    case "PictureTBox":
                        Planovaya.Focus();  
                        break;
                    case "Planovaya":
                        Emergency.Focus();
                        break;
                    case "Emergency":
                        Ambulator.Focus();
                        break;
                    case "Ambulator":
                        Stacionar.Focus();
                        break;
                    case "Stacionar":
                        DepTBox.Focus();
                        break;
                    case "DepTBox":
                        if (HCFTBox.IsEnabled == true)
                        {
                            HCFTBox.Focus();

                        }
                        else
                        {
                            DocTBox.Focus();
                        }
                        break;
                    case "HCFTBox":
                        DocTBox.Focus();
                        break;
                    case "DocTBox":
                        AssistTBox.Focus();
                        break;
                    case "AssistTBox":
                        PartOfBodyTBox.Focus();
                        break;
                    case "PartOfBodyTBox":
                        ResultTBox.Focus();
                        break;
                    case "ResultTBox":
                        _maskedTextBoxDose.Focus();
                        break;
                    default:
                            // Обработка случая, когда элемент не найден
                        break;
                }
            }

        }

        private void PictureTBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Planovaya.Focus(); 
            }

        }

        private void Stacionar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && Stacionar.IsChecked == true)
            {
                DepTBox.Focus();
            }
        }

        private void Ambulator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && Ambulator.IsChecked == true)
            {
                HCFTBox.Focus();
            }
            else
            {
                Stacionar.Focus();
            }

        }
    }
}
