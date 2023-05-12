using System.Windows;
using System.Windows.Controls;

namespace Memento.View.Controls
{
    /// <summary>
    /// Логика взаимодействия для TextBoxCustom.xaml
    /// </summary>
    public partial class TextBoxCustom : UserControl
    {
        public static readonly DependencyProperty MyTextProperty = DependencyProperty.Register(
            "NameTextBox",
            typeof(string),
            typeof(TextBoxCustom));

        public string NameTextBox
        {
            get { return (string)GetValue(MyTextProperty); }
            set { SetValue(MyTextProperty, value); }
        }

        public TextBoxCustom()
        {
            InitializeComponent();
        }
    }
}
