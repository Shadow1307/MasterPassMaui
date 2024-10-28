using MasterPassPoc.Service;

namespace MasterPassPoc
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly IMasterPassService _masterPassService;
        public MainPage(IMasterPassService masterPassService)
        {
            InitializeComponent();
            _masterPassService = masterPassService;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void MasterPassClicked(object sender, EventArgs e)
        {
            _masterPassService.DisplayWallet();
        }
    }

}
