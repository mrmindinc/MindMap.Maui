using MindMap.Views;

namespace MindMap
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Home());
        }
    }
}