using Application = Microsoft.Maui.Controls.Application;

namespace MasterPassPoc
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();

            MainPage = serviceProvider.GetService<AppShell>();
        }
    }


}
