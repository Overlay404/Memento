using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
    /// Логика взаимодействия для ComboBoxCustom.xaml
    /// </summary>
    public partial class ComboBoxCustom : UserControl
    {
        public ComboBoxCustom()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty DisplayMemberNameProperty =
            DependencyProperty.Register("DisplayMemberName", typeof(string), typeof(ComboBoxCustom));

        public static DependencyProperty DefaultTextProperty =
         DependencyProperty.Register("DefaultText", typeof(string), typeof(ComboBoxCustom));

        public static DependencyProperty MyItemsSourceProperty =
            DependencyProperty.Register("MyItemsSource", typeof(IEnumerable), typeof(ComboBoxCustom));

        public static DependencyProperty MySelectedItemProperty =
            DependencyProperty.Register("SelectedItem", typeof(object), typeof(ComboBoxCustom));

        public string DisplayMemberName
        {
            get { return (string)GetValue(DisplayMemberNameProperty); }
            set { SetValue(DisplayMemberNameProperty, value); }
        }

        public string DefaultText
        {
            get { return (string)GetValue(DefaultTextProperty); }
            set { SetValue(DefaultTextProperty, value); }
        }

        public IEnumerable MyItemsSource
        {
            get { return (IEnumerable)GetValue(MyItemsSourceProperty); }
            set { SetValue(MyItemsSourceProperty, value); }
        }

        public object MySelectedItem
        {
            get { return GetValue(MySelectedItemProperty); }
            set { SetValue(MySelectedItemProperty, value); }
        }

    }

    public class InverseNullVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
