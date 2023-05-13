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
    /// Логика взаимодействия для TheHostViewCustom.xaml
    /// </summary>
    public partial class TheHostViewCustom : UserControl
    {
        public IEnumerable<Division> Divisions
        {
            get { return (IEnumerable<Division>)GetValue(DivisionsProperty); }
            set { SetValue(DivisionsProperty, value); }
        }

        public static readonly DependencyProperty DivisionsProperty =
            DependencyProperty.Register("Divisions", typeof(IEnumerable<Division>), typeof(TheHostViewCustom));

        public TheHostViewCustom()
        {
            InitializeComponent();
        }
    }
}
