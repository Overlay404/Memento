using Memento.View.Pages;
using System.Windows;

namespace Memento.View.Windows
{
    /// <summary>
    /// Основное окно с элементом Frame
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            Instance = this;
            MainFrame.Navigate(new PersonVisitPage());
        }
    }
}
