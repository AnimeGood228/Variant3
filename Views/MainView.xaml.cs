using System.Windows;
using Variant3.Models;
using Variant3.ViewModels;

namespace Variant3.Views
{
    public partial class MainView : Window
    {
        public MainView(User currentUser)
        {
            InitializeComponent();
            DataContext = new MainViewModel(currentUser);
        }
    }
}
