using Memento.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для PersonVisitPage.xaml
    /// </summary>
    public partial class PersonVisitPage : Page, INotifyPropertyChanged
    {
        public IEnumerable<Visitor> employees { get; set; }
        public PersonVisitPage()
        {
            employees = Connection.Db.Visitor.Local;

            InitializeComponent();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(employees)));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
