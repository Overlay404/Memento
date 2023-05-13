using Memento.Model;
using System.Windows;

namespace Memento
{
    public partial class App : Application
    {
        App() => Connection.ConnectionDb();
    }
}
