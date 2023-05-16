using Memento.Model;
using Memento.View.Windows;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private Organization firstOrganization = new Organization() { Name = "Добавить организацию" };

        #region Свойства для DatePickers
        public DateTime variableMinDatePickerStart { get; set; }
        public DateTime variableMinDatePickerEnd { get; set; }
        public DateTime variableMaxDatePickerStart { get; set; }
        public DateTime variableMaxDatePickerEnd { get; set; }
        #endregion

        Regex emailRegex = new Regex(@"([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)");
        Regex phoneRegex = new Regex(@"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$");

        public GroupVisitPage()
        {
            variableMinDatePickerStart = new DateTime (DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);
            variableMinDatePickerEnd = new DateTime (DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1);

            variableMaxDatePickerStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 15);
            variableMaxDatePickerEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 15);

            Divisions = Connection.db.Division.Local;
            Employee = Connection.db.Employee.Local;
            VisitPurposes = Connection.db.VisitPurpose.Local;

            Visitors = new List<Visitor>();

            FillingOrganization();

            InitializeComponent();

            Series.KeyDown += (sender, e) => 
            {
                if (new KeyConverter().ConvertToString(e.Key).All(letter => char.IsLetter(letter)))
                    e.Handled = true;
            };

            Number.KeyDown += (sender, e) =>
            {
                if (new KeyConverter().ConvertToString(e.Key).All(letter => char.IsLetter(letter)))
                    e.Handled = true;
            };

            Phone.KeyDown += (sender, e) =>
            {
                if (new KeyConverter().ConvertToString(e.Key).All(letter => char.IsLetter(letter)))
                    e.Handled = true;
            };

            ClearForm.Click += (sender, e) =>
            {
                MainWindow.Instance.MainFrame.Navigate(new GroupVisitPage());
            };

            AttachFile.MouseDown += (sender, e) =>
            {
                AttachFile.Visibility = Visibility.Collapsed;
                NameFileTry = OpenFileDialogSave();
            };

            Org.SelectionChanged += (sender, e) =>
            {
                if (Org.SelectedValue == firstOrganization)
                {
                    Org.Visibility = Visibility.Collapsed;
                    NewOrg.Visibility = Visibility.Visible;
                }
            };

            AddingVisitor.MouseDown += (sender, e) =>
            {
                try
                {
                    if (Mail.TextInTextBox != null || Phone.TextInTextBoxForPhone != null)
                        if (Validate(emailRegex, phoneRegex))
                            throw new Exception("Не введены или не соответсвуют формату данные в поле mail и телефон");

                    if (ByDatePicker.SelectedDate == null || WithDatePicker.SelectedDate == null)
                        throw new Exception("Дата везита не должна быть пустой");

                    ValiadteDataPickerBithday();
                    ValiadteDatePickers();

                    VisitPurpose visitPurposeName;
                    int divisionId, employeeId;

                    CreatingVariables(out visitPurposeName, out divisionId, out employeeId);

                    Organization orgValue = ValidateOrganization();

                    Visitor visitor = CreationNewVisitor(orgValue);

                    Request request = CreationNewRequest(visitPurposeName, divisionId, employeeId);

                    request.Visitor.Add(visitor);

                    Connection.db.Request.Add(request);

                    Connection.db.Visitor.Add(visitor);

                    Visitors.Add(visitor);
                    ListVisitor.ItemsSource = Visitors;
                    ListVisitor.Items.Refresh();

                    if (!Validate(emailRegex, phoneRegex))
                         throw new Exception("Не введены или не соответсвуют формату данные");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            };

            CreateRequestBtn.Click += (sender, e) =>
            {
                try
                {
                    ValiadteDataPickerBithday();
                    ValiadteDatePickers();

                    Connection.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Проверьте все введенные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                MessageBox.Show($"Заявка на имя {Surname.TextInTextBox} {Name.TextInTextBox} {Patronymic.TextInTextBox} заполнена");
            };
        }

        #region Заполнение нужный полей

        private void FillingOrganization()
        {
            Organizations = Connection.db.Organization.Local;
            Organizations = Organizations.Append(firstOrganization);
        }
        #endregion

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

        #region Проверки полей

        private void ValiadteDatePickers()
        {
            if (ByDatePicker.SelectedDate.Value.Day < WithDatePicker.SelectedDate.Value.Day)
                throw new Exception("Дата окончания заявки не может быть больше чем дата начала заявки");
        }

        private void ValiadteDataPickerBithday()
        {
            if (DataPickerBithday.SelectedDate != null)
                if (DateTime.Now.Year - DataPickerBithday.SelectedDate.Value.Year < 16)
                    throw new Exception("Заявку могут додавать только люди достигшие 16 лет");
        }

        private Organization ValidateOrganization()
        {
            if (NewOrg.TextInTextBox != null)
            {
                Organization newOrganization = NewOrg.TextInTextBox == null
                                                ? throw new Exception("Поле орагнизация заполнено не корректно")
                                                : new Organization() { Name = NewOrg.TextInTextBox.Trim() };

                Connection.db.Organization.Local.Add(newOrganization);

                return newOrganization;
            }
            else
                return Org.SelectedItem as Organization ?? throw new Exception("Проверьте введенные данные");
        }

        private bool Validate(Regex emailRegex, Regex phoneRegex)
        {
            if (Mail.TextInTextBox != null || Phone.TextInTextBoxForPhone != null)
                if (phoneRegex.IsMatch(Phone.TextInTextBoxForPhone) || emailRegex.IsMatch(Mail.TextInTextBox))
                    return false;

            return true;
        }
        #endregion

        #region Методы создания

        private void CreatingVariables(out VisitPurpose visitPurposeName, out int divisionId, out int employeeId)
        {
            VisitPurpose cbVisit = VisitPurposeCB.SelectedItem as VisitPurpose;
            Division cbDivision = DivisionCB.SelectedItem as Division;
            Employee cbEmpl = EmployeeCB.SelectedItem as Employee;

            visitPurposeName = Connection.db.VisitPurpose.FirstOrDefault(v => v.Name == (cbVisit).Name);
            divisionId = Connection.db.Division.FirstOrDefault(d => d.Name == (cbDivision).Name).Id;
            employeeId = Connection.db.Employee.FirstOrDefault(em => em.LastName == (cbEmpl).LastName).Id;
        }

        private Visitor CreationNewVisitor(Organization orgValue) =>
            new Visitor
            {
                LastName = Surname.TextInTextBox.Trim(),
                FirstName = Name.TextInTextBox.Trim(),
                Patronymic = Patronymic.TextInTextBox.Trim(),
                Email = Mail.TextInTextBox?.Trim(),
                Phone = Phone.TextInTextBoxForPhone?.Trim(),
                Organization = orgValue,
                Note = Note.TextInTextBox?.Trim(),
                PassportNumber = Number.TextInTextBox?.Trim(),
                PassportSeries = Series.TextInTextBox?.Trim(),
                BirthDate = DateTime.Today
            };

        private Request CreationNewRequest(VisitPurpose visitPurposeName, int divisionId, int employeeId) =>
            new Request
            {
                RequestTypeId = 1,
                RequestStatusId = 1,
                DesiredStartDate = WithDatePicker.SelectedDate ?? DateTime.Today,
                DesiredExpirationDate = ByDatePicker.SelectedDate ?? DateTime.Today,
                VisitPurpose = visitPurposeName,
                DivisionId = divisionId,
                EmployeeId = employeeId
            };
        #endregion

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new SelectionPage());
        }
    }
}
