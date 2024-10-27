using Application = Microsoft.Maui.Controls.Application;

namespace MasterPassPoc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
