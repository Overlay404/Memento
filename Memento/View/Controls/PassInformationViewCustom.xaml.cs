using Memento.Model;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Memento.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для StackPanelCustom.xaml
    /// </summary>
    public partial class PassInformationViewCustom : UserControl
    {
        public IEnumerable<VisitPurpose> VisitPurposes
        {
            get { return (IEnumerable<VisitPurpose>)GetValue(VisitPurposesProperty); }
            set { SetValue(VisitPurposesProperty, value); }
        }

        public DateTime DesiredStartDateTime
        {
            get { return (DateTime)GetValue(DesiredStartDateTimeProperty); }
            set { SetValue(DesiredStartDateTimeProperty, value); }
        }

        public DateTime DesiredExpirationDateTime
        {
            get { return (DateTime)GetValue(DesiredExpirationDateTimeProperty); }
            set { SetValue(DesiredExpirationDateTimeProperty, value); }
        }

        public static readonly DependencyProperty VisitPurposesProperty =
            DependencyProperty.Register("VisitPurposes", typeof(IEnumerable<VisitPurpose>), typeof(PassInformationViewCustom));

        public static readonly DependencyProperty DesiredStartDateTimeProperty =
            DependencyProperty.Register("DesiredStartDateTime", typeof(DateTime), typeof(PassInformationViewCustom));

        public static readonly DependencyProperty DesiredExpirationDateTimeProperty =
            DependencyProperty.Register("DesiredExpirationDateTime", typeof(DateTime), typeof(PassInformationViewCustom));



        public PassInformationViewCustom()
        {
            InitializeComponent();
        }
    }
}
