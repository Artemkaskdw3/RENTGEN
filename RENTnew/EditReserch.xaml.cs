using Microsoft.EntityFrameworkCore;
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

namespace RENTnew
{
    /// <summary>
    /// Логика взаимодействия для EditReserch.xaml
    /// </summary>
    public partial class EditReserch : Window
    {
        Reserch _reserch;
     


        public EditReserch(Reserch reserch)
        {
            InitializeComponent();
            

          
           
            DateTime a = new DateTime();
            DateTime.TryParse(reserch.DateReserch.ToString(), out a);   

            this._reserch = reserch;
            _maskedTextBox.Text = a.ToShortDateString();
            ReserchTBox.Text = reserch.NameRerserch.Title;
            PictureTBox.Text = reserch.NumOfPicture.ToString();
            if (reserch.PlanOrEmerg == true)
            {
                Planovaya.IsChecked = false;
                Emergency.IsChecked = true;
                DepTBox.Text = reserch.Departament.Title; 

            }
            else
            {
                Emergency.IsChecked = false;
                Planovaya.IsChecked = true;
            }
            if (reserch.InpatientOutpatient == true)
            {
                Stacionar.IsChecked = false;
                Ambulator.IsChecked = true;
                HCFTBox.Text = reserch.Hcf.Title; 

            }
            else
            {
                Ambulator.IsChecked = false;
                Stacionar.IsChecked = true;

                DepTBox.Text = reserch.Departament.Title; 

            }

            DocTBox.Text = Helper.db.Doctors.FirstOrDefault(x =>x.Id == reserch.DoctorId).Title;
            AssistTBox.Text = Helper.db.Assisstants.FirstOrDefault(x => x.Id == reserch.Assisstant).Title;
            PartOfBodyTBox.Text = Helper.db.Pathologies.FirstOrDefault(x=>x.Id == reserch.ResultId).PartOfBodyId.ToString();
            ResultTBox.Text = Helper.db.Pathologies.FirstOrDefault(x=>x.Id == reserch.ResultId).Title;
            _maskedTextBoxDose.Text = reserch.Dose.ToString();
        }

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
            decimal.TryParse(_maskedTextBoxDose.Text, out treyParcDose);

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

                    _reserch.DateReserch = a;
                    _reserch.NameRerserchId = Helper.db.ReserchsNames.FirstOrDefault(x => x.Title == ReserchTBox.Text).Id;
                    _reserch.NumOfPicture = int.Parse(PictureTBox.Text);
                    _reserch.PlanOrEmerg = Planovaya.IsChecked.Value ? false : true;
                    _reserch.InpatientOutpatient = Planovaya.IsChecked.Value ? Ambulator.IsChecked.Value : null;
                    _reserch.DepartamentId = Helper.db.Departaments.Any(x => x.Title == DepTBox.Text) ? Helper.db.Departaments.FirstOrDefault(x => x.Title == DepTBox.Text).Id : null;
                    _reserch.Hcfid = Helper.db.HeathCfs.Any(x => x.Title == HCFTBox.Text) ? Helper.db.HeathCfs.FirstOrDefault(x => x.Title == HCFTBox.Text).Id : null;
                    _reserch.DoctorId = Helper.db.Doctors.FirstOrDefault(x => x.Title == DocTBox.Text).Id;
                    _reserch.Assisstant = Helper.db.Assisstants.FirstOrDefault(x => x.Title == AssistTBox.Text).Id;
                    _reserch.ResultId = Helper.db.Pathologies.FirstOrDefault(x => x.Title == ResultTBox.Text && x.PartOfBodyId == int.Parse(PartOfBodyTBox.Text)).Id;
                    _reserch.Dose = treyParcDose;

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

