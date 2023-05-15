using Memento.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memento.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для GroupVisitPage.xaml
    /// </summary>
    public partial class GroupVisitPage : Page
    {
        public string NameFileTry
        {
            get { return (string)GetValue(NameFileProperty); }
            set { SetValue(NameFileProperty, value); }
        }

        public static readonly DependencyProperty NameFileProperty =
            DependencyProperty.Register("NameFileTry", typeof(string), typeof(PersonVisitPage));

        Regex emailRegex = new Regex(@"([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)");
        Regex phoneRegex = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");

        public GroupVisitPage()
        {
            InitializeComponent();

            AttachFile.MouseDown += (sender, e) =>
            {
                AttachFile.Visibility = Visibility.Collapsed;
                NameFileTry = OpenFileDialogSave();
            };
            CreateRequestBtn.Click += (sender, e) =>
            {
                VisitPurpose cbVisit = VisitPurposeCB.SelectedItem as VisitPurpose;
                Division cbDivision = DivisionCB.SelectedItem as Division;
                Employee cbEmpl = EmployeeCB.SelectedItem as Employee;

                if (Validate(emailRegex, phoneRegex, cbVisit, cbDivision, cbEmpl))
                {
                    MessageBox.Show("Не введены или не соответсвуют формату данные");
                }

                VisitPurpose visitPurposeName = Connection.db.VisitPurpose.FirstOrDefault(v => v.Name == (cbVisit).Name);
                int divisionId = Connection.db.Division.FirstOrDefault(d => d.Name == (cbDivision).Name).Id;
                int employeeId = Connection.db.Employee.FirstOrDefault(em => em.LastName == (cbEmpl).LastName).Id;


                Connection.db.Request.Add(new Request
                {
                    RequestTypeId = 1,
                    RequestStatusId = 1,
                    DesiredStartDate = WithDatePicker.SelectedDate ?? DateTime.Today,
                    DesiredExpirationDate = ByDatePicker.SelectedDate ?? DateTime.Today,
                    VisitPurpose = visitPurposeName,
                    DivisionId = divisionId,
                    EmployeeId = employeeId
                });

                Connection.db.Visitor.Add(new Visitor
                {
                    LastName = Surname.TextInTextBox.Trim(),
                    FirstName = Name.TextInTextBox.Trim(),
                    Patronymic = Patronymic.TextInTextBox.Trim(),
                    BirthDate = DateTime.Today,
                });

                try
                {
                    Connection.db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    List<string> mess = new List<string>();

                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            mess.Add("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }

                    MessageBox.Show(string.Join("\n", mess));
                }

                MessageBox.Show($"Заявка на имя {Surname.TextInTextBox} {Name.TextInTextBox} {Patronymic.TextInTextBox} заполнена");
            };
        }

        private bool Validate(Regex emailRegex, Regex phoneRegex, VisitPurpose cbVisit, Division cbDivision, Employee cbEmpl)
        {
            if (cbVisit == null || cbDivision == null || cbEmpl == null || DataPickerBithday.SelectedDate == null) return false;
            if (string.IsNullOrEmpty(Surname.TextInTextBox) || string.IsNullOrEmpty(Name.TextInTextBox) || string.IsNullOrEmpty(Patronymic.TextInTextBox)) return false;
            if (emailRegex.IsMatch(Mail.TextInTextBox.Trim()) || phoneRegex.IsMatch(Phone.TextInTextBox.Trim())) return false;
            return true;
        }

        public static string OpenFileDialogSave()
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "All files| *.txt;*.docx;*.doc;*.pdf*.xls"
            };

            if (openFile.ShowDialog().GetValueOrDefault())
                return openFile.FileName;

            return null;
        }

        private void TheHostViewCustom_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
